using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// If this variable is true, some processes will stop in order not to intersect.
        /// </summary>
        private bool _switching = false;
        /// <summary>
        /// Amount of new files created.
        /// </summary>
        public int newFileCount = 1;
        /// <summary>
        /// A list of open files.
        /// </summary>
        public List<OpenFile> openFiles = new List<OpenFile>();
        public Form1()
        {
            InitializeComponent();
            selectAllStrip.Click += SelectAllStrip_Click;
            cutSelectedStrip.Click += CutSelectedStrip_Click;
            copySelectedStrip.Click += CopySelectedStrip_Click;
            pasteStrip.Click += PasteStrip_Click;
            selectedFontStrip.Click += SelectedFontStrip_Click;
        }
        /// <summary>
        /// Loads the correct text into the textbox when the user switches tabs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textTabs.TabCount != 0)
            {
                //_switching is made true so that when the textbox loads the file and therefore changes it's text 
                //the event for changed text will not initiate and loading the text and switching tabs will not intersect.
                _switching = true;
                    MainTextLoadFile(openFiles[textTabs.SelectedIndex].Path);
                _switching = false;
            }
        }
        /// <summary>
        /// Loads text into the textbox.
        /// </summary>
        /// <param name="path">path of the file with the text.</param>
        private void MainTextLoadFile(string path)
        {
            try 
            { 
                if (path.Split('.')[path.Split('.').Length - 1] == "rtf")
                    mainText.LoadFile(path);
                else
                    mainText.LoadFile(path, RichTextBoxStreamType.PlainText);
            }
            catch
            {
                _switching = true;
                mainText.Text = "THIS FILE HAS BEEN DELETED";
                _switching = false;
            }
        }
        /// <summary>
        /// Saves the text once it's changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainText_TextChanged(object sender, EventArgs e)
        {
            if (!_switching)
                SaveFile(openFiles[textTabs.SelectedIndex].Path);
        }
        private void SaveFile(string path)
        {
            if (path.Split('.')[path.Split('.').Length - 1] == "rtf")
                mainText.SaveFile(path);
            else
                mainText.SaveFile(path, RichTextBoxStreamType.PlainText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\saves");
            if (File.Exists(Directory.GetCurrentDirectory() + @"\openFiles"))
            {
                string[] filePaths = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\openFiles");
                for (int i = 1; i < filePaths.Length; i++)
                {
                    string path = filePaths[i];
                    if (File.Exists(path))
                    {
                        openFiles.Add(new OpenFile(path.Split(@"\")[path.Split(@"\").Length - 1]));
                        openFiles[openFiles.Count - 1].Path = path;
                        openFiles[openFiles.Count - 1].IsSaved = true;
                        textTabs.TabPages.Add(openFiles[openFiles.Count - 1].Name);
                    }
                }
                //Loading the saved settings.
                numericUpDown1.Value = int.Parse(filePaths[0].Split(' ')[0]);
                comboBox1.SelectedIndex = int.Parse(filePaths[0].Split(' ')[1]);
            }
            if (openFiles.Count == 0)
            {
                textTabs.TabPages.Add(new TabPage("New text file"));
                openFiles.Add(new OpenFile("New text file"));
                SaveFile(openFiles[textTabs.SelectedIndex].Path);
            }
            if (openFiles.Count == 1)
                closeTab.Visible = false;
            tabPage1.Text = "File";
            tabPage2.Text = "Edit";
            tabPage3.Text = "Format";
            tabPage4.Text = "Settings";
            controlTabs.SelectedIndex = 0;
        }
        /// <summary>
        /// Initiates when a button is pressed in order to create shortcuts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && (e.Control))
            {
                NewTextFile();
            }
            if (e.KeyCode == Keys.W && (e.Control))
            {
                new Form1().Show();
            }
            if (e.KeyCode == Keys.S && (e.Control) && !e.Shift)
            {
                SaveThisFile();
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                for (int i = 0; i < textTabs.TabCount; i++)
                {
                    if (openFiles[i].IsSaved)
                        SaveFile(openFiles[i].Path);
                    else
                    {
                        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf*)|*.rtf|c# code files (*.cs*)|*.cs";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.Title = "Saving " + openFiles[i].Name;
                        saveFileDialog1.ShowDialog();
                        saveFileDialog1.DefaultExt = ".rtf";
                        if (saveFileDialog1.FileName != "")
                        {
                            SaveFile(saveFileDialog1.FileName);
                            textTabs.TabPages[i].Text = saveFileDialog1.FileName.Split(@"\")[saveFileDialog1.FileName.Split(@"\").Length - 1];
                            openFiles[i].IsSaved = true;
                            openFiles[i].Path = saveFileDialog1.FileName;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Initiates when the new button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewButton_Click(object sender, EventArgs e)
        {
            NewTextFile();
        }
        /// <summary>
        /// Creates a new text file in a new tab.
        /// </summary>
        private void NewTextFile()
        {
            closeTab.Visible = true;
            openFiles.Add(new OpenFile("New text file" + newFileCount));
            textTabs.TabPages.Add(new TabPage("New text file" + newFileCount));
            newFileCount += 1;
            _switching = true;
            mainText.Text = "";
            _switching = false;
            SaveFile(openFiles[openFiles.Count - 1].Path);
            textTabs.SelectedIndex = textTabs.TabCount - 1;

        }
        /// <summary>
        /// Initiates when the close tab button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseTab_Click(object sender, EventArgs e)
        {
            CurrentTabClose();
        }
        /// <summary>
        /// Closes the currently selected tab after warning the user about saving it.
        /// </summary>
        public void CurrentTabClose()
        {
            SaveOrExit sOr = new SaveOrExit($"Are you sure you would like to close this tab?");
            sOr.Show();
            sOr.TopMost = true;
        }
        /// <summary>
        /// Simply closes the selected tab.
        /// </summary>
        public void CloseTabMessage()
        {
            if (textTabs.TabCount == 2)
                closeTab.Visible = false;
            openFiles.RemoveAt(textTabs.SelectedIndex);
            textTabs.TabPages.RemoveAt(textTabs.SelectedIndex);
            if (textTabs.TabCount == 0)
            {
                Close();
                Dispose();
            }
            else
            {
                textTabs.SelectedIndex = textTabs.TabCount - 1;
                _switching = true;
                MainTextLoadFile(openFiles[textTabs.SelectedIndex].Path);
                _switching = false;
            }
        }
        /// <summary>
        /// Initiates when the save as button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            SaveThisFileAs();
        }
        /// <summary>
        /// Saves the currently selected file.
        /// </summary>
        public void SaveThisFile()
        {
            if (openFiles[textTabs.SelectedIndex].IsSaved)
                SaveFile(openFiles[textTabs.SelectedIndex].Path);
            else
                SaveThisFileAs();
        }
        /// <summary>
        /// Initiates when the save button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveThisFile();
        }
        /// <summary>
        /// Save the selected file at a specified location.
        /// </summary>
        public void SaveThisFileAs()
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf*)|*.rtf|c# code files (*.cs*)|*.cs";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.ShowDialog();
            saveFileDialog1.DefaultExt = ".rtf";
            if (saveFileDialog1.FileName != "")
            {
                SaveFile(saveFileDialog1.FileName);
                textTabs.SelectedTab.Text = saveFileDialog1.FileName.Split(@"\")[saveFileDialog1.FileName.Split(@"\").Length - 1];
                openFiles[textTabs.SelectedIndex].IsSaved = true;
                openFiles[textTabs.SelectedIndex].Path = saveFileDialog1.FileName;
            }
        }
        /// <summary>
        /// Opens a file in a new tab and reads it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            closeTab.Visible = true;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                textTabs.TabPages.Add(new TabPage(openFileDialog1.FileName.Split(@"\")[openFileDialog1.FileName.Split(@"\").Length - 1]));
                openFiles.Add(new OpenFile(openFileDialog1.FileName.Split(@"\")[openFileDialog1.FileName.Split(@"\").Length - 1]));
                openFiles[openFiles.Count - 1].Path = openFileDialog1.FileName;
                newFileCount += 1;
                textTabs.SelectedIndex = textTabs.TabCount - 1;
                _switching = true;
                MainTextLoadFile(openFiles[textTabs.SelectedIndex].Path);
                _switching = false;
                openFiles[openFiles.Count - 1].IsSaved = true;
            }
        }
        /// <summary>
        /// Initiates when the font button is pressed and allows the user to change fonts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            mainText.SelectionFont = fontDialog1.Font;
        }
        /// <summary>
        /// Initiates when the font reset button is pressed and resets all fonts of the whole text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            mainText.SelectAll();
            mainText.SelectionFont = new Font("Sergoe UI", 9);
            mainText.DeselectAll();
        }
        /// <summary>
        /// Initiates when the form is about to close and asks the user whether he would like to save his files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\openFiles", numericUpDown1.Value + " " + comboBox1.SelectedIndex);
            foreach (OpenFile openfile in openFiles)
            {
                if (openfile.IsSaved)
                {
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\openFiles", openfile.Path);
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\openFiles", Environment.NewLine);
                }
            }
            for (int i = 0; i < textTabs.TabCount; i++)
            {
                CurrentTabClose();
            }
            e.Cancel = true;
        }
        /// <summary>
        /// Initiates when the right click is pressed and opens the context menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(Cursor.Position);
        }
        /// <summary>
        /// Initiates when the user selects the select all option in the context menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllStrip_Click(object sender, EventArgs e)
        {
            mainText.SelectAll();
        }
        /// <summary>
        /// Initiates when the user selects the cut option in the context menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutSelectedStrip_Click(object sender, EventArgs e)
        {
            mainText.Cut();
        }
        /// <summary>
        /// Initiates when the user selects the copy option in the context menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopySelectedStrip_Click(object sender, EventArgs e)
        {
            mainText.Copy();
        }
        /// <summary>
        /// Initiates when the user selects the paste option in the context menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteStrip_Click(object sender, EventArgs e)
        {
            mainText.Paste();
        }
        /// <summary>
        /// Initiates when the user selects the font selection option in the context menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedFontStrip_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            mainText.SelectionFont = fontDialog1.Font;
        }
        /// <summary>
        /// Creates a new file in a new window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewWindowButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
        /// <summary>
        /// Initiates when the user presses the undo button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoButton_Click(object sender, EventArgs e)
        {
            mainText.Undo();
        }
        /// <summary>
        /// Initiates when the user presses the redo button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RedoButton_Click(object sender, EventArgs e)
        {
            mainText.Redo();
        }
        /// <summary>
        /// Initiates when the user presses the clear button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            mainText.Text = "";
        }

        /// <summary>
        /// Initiates when the user presses the select all button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            mainText.Focus();
            mainText.SelectAll();
        }

        /// <summary>
        /// Initiates when the user changes the theme of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                BackColor = Color.WhiteSmoke;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                BackColor = Color.FromArgb(255,50,50,50);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                BackColor = Color.Gray;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                BackColor = Color.Maroon;
            }
        }
        /// <summary>
        /// Initiates when the user presses the code formating button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormatButton_Click(object sender, EventArgs e)
        {
            string newText = "";
            for (int i = 0; i < mainText.Text.Length; i++)
            {
                if (mainText.Text[i] == '{' || mainText.Text[i] == '}')
                {
                    newText += "\n";
                    newText += mainText.Text[i];
                    newText += "\n";
                }
                else
                    newText += mainText.Text[i];
            }
            int skip = -1;
            string[] lines = newText.Split("\n");
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace("\t","");
                foreach (char sym in lines[i])
                {
                    if (sym != ' ')
                        break;
                    else
                        lines[i] = lines[i].TrimStart();
                }
            }
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "{")
                {
                    lines = ScanText(i + 1, lines, ref skip);
                }
            }
            string text = "";
            for (int i = 0; i < lines.Length; i++)
            {
                text += lines[i];
                if (i != lines.Length)
                    text += Environment.NewLine;
            }
            mainText.Text = text;

        }
        /// <summary>
        /// Scans the text and looks for '{' and '}'.
        /// </summary>
        /// <param name="start">Starting line.</param>
        /// <param name="lines">lines of the text.</param>
        /// <param name="skip">lines it needs to skip.</param>
        /// <returns></returns>
        private string[] ScanText(int start, string[] lines, ref int skip)
        {
            for (int i = start; i < lines.Length; i++)
            {
                if (i > skip)
                {
                    if (lines[i] == "{")
                    {
                        lines = ScanText(i + 1, lines, ref skip);
                    }
                    if (lines[i] == "}")
                    {
                        for (int j = start; j < i; j++)
                        {
                            lines[j] = "\t" + lines[j];
                        }
                        skip = i;
                        return lines;
                    }
                }
            }
            return lines;
        }
        /// <summary>
        /// Shows the help form when the help button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpButton_Click(object sender, EventArgs e)
        {
            new HelpWindow().Show();
        }

        private void compileButton_Click(object sender, EventArgs e)
        {
            try
            {
                Errors errors = new Errors(RunTimeCompiler.ErrorDisplay(mainText.Text));
                errors.Show();
            }
            catch
            { }
        }
    }
    /// <summary>
    /// This is a class each object of which contains information about a file currently open in the text editor.
    /// </summary>
    public class OpenFile
    {
        public string Name;
        public string Path;
        public bool IsSaved = false;
        public OpenFile(string name)
        {
            Name = name;
            Path = Directory.GetCurrentDirectory() + @"\saves" + @"\" + Name + ".rtf";
        }
    }
}
