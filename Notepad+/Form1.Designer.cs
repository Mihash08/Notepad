namespace Notepad_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textTabs = new System.Windows.Forms.TabControl();
            this.controlTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.newWindowButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.compileButton = new System.Windows.Forms.Button();
            this.formatTestButton = new System.Windows.Forms.Button();
            this.fontResetButton = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.closeTab = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mainText = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cutSelectedStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedFontStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpButton = new System.Windows.Forms.Button();
            this.controlTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textTabs
            // 
            this.textTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTabs.Location = new System.Drawing.Point(5, 107);
            this.textTabs.Name = "textTabs";
            this.textTabs.SelectedIndex = 0;
            this.textTabs.Size = new System.Drawing.Size(1020, 562);
            this.textTabs.TabIndex = 1;
            this.textTabs.SelectedIndexChanged += new System.EventHandler(this.TextTabs_SelectedIndexChanged);
            // 
            // controlTabs
            // 
            this.controlTabs.Controls.Add(this.tabPage1);
            this.controlTabs.Controls.Add(this.tabPage2);
            this.controlTabs.Controls.Add(this.tabPage3);
            this.controlTabs.Controls.Add(this.tabPage4);
            this.controlTabs.Location = new System.Drawing.Point(5, 13);
            this.controlTabs.Name = "controlTabs";
            this.controlTabs.SelectedIndex = 3;
            this.controlTabs.Size = new System.Drawing.Size(267, 96);
            this.controlTabs.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.newWindowButton);
            this.tabPage1.Controls.Add(this.openButton);
            this.tabPage1.Controls.Add(this.saveAsButton);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.newButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(259, 68);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // newWindowButton
            // 
            this.newWindowButton.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newWindowButton.Location = new System.Drawing.Point(4, 32);
            this.newWindowButton.Name = "newWindowButton";
            this.newWindowButton.Size = new System.Drawing.Size(121, 25);
            this.newWindowButton.TabIndex = 5;
            this.newWindowButton.Text = "New window (ctrl + w)";
            this.newWindowButton.UseVisualStyleBackColor = true;
            this.newWindowButton.Click += new System.EventHandler(this.NewWindowButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(131, 4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(125, 24);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Open a text file";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(197, 32);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(59, 25);
            this.saveAsButton.TabIndex = 6;
            this.saveAsButton.Text = "Save as";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(131, 32);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(60, 25);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton.Location = new System.Drawing.Point(3, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(121, 25);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New file (ctrl + n)";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.selectAllButton);
            this.tabPage2.Controls.Add(this.redoButton);
            this.tabPage2.Controls.Add(this.clearButton);
            this.tabPage2.Controls.Add(this.undoButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(259, 68);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(129, 33);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(127, 23);
            this.selectAllButton.TabIndex = 3;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.Location = new System.Drawing.Point(3, 33);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(120, 23);
            this.redoButton.TabIndex = 1;
            this.redoButton.Text = "Redo";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(129, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(127, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear page";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(3, 4);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(120, 23);
            this.undoButton.TabIndex = 0;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.compileButton);
            this.tabPage3.Controls.Add(this.formatTestButton);
            this.tabPage3.Controls.Add(this.fontResetButton);
            this.tabPage3.Controls.Add(this.fontButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(259, 68);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // compileButton
            // 
            this.compileButton.Location = new System.Drawing.Point(131, 34);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(125, 23);
            this.compileButton.TabIndex = 3;
            this.compileButton.Text = "Compile code";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // formatTestButton
            // 
            this.formatTestButton.Location = new System.Drawing.Point(130, 3);
            this.formatTestButton.Name = "formatTestButton";
            this.formatTestButton.Size = new System.Drawing.Size(126, 25);
            this.formatTestButton.TabIndex = 2;
            this.formatTestButton.Text = "Code formating";
            this.formatTestButton.UseVisualStyleBackColor = true;
            this.formatTestButton.Click += new System.EventHandler(this.FormatButton_Click);
            // 
            // fontResetButton
            // 
            this.fontResetButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fontResetButton.Location = new System.Drawing.Point(3, 34);
            this.fontResetButton.Name = "fontResetButton";
            this.fontResetButton.Size = new System.Drawing.Size(121, 23);
            this.fontResetButton.TabIndex = 1;
            this.fontResetButton.Text = "Reset all fonts";
            this.fontResetButton.UseVisualStyleBackColor = true;
            this.fontResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(3, 3);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(121, 25);
            this.fontButton.TabIndex = 0;
            this.fontButton.Text = "Choose font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.numericUpDown1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(259, 68);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Theme";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Light",
            "Dark",
            "Grey",
            "Dark red"});
            this.comboBox1.Location = new System.Drawing.Point(47, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "symbol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Save every";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(65, 3);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 23);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // closeTab
            // 
            this.closeTab.BackColor = System.Drawing.Color.Maroon;
            this.closeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeTab.ForeColor = System.Drawing.Color.White;
            this.closeTab.Location = new System.Drawing.Point(907, 37);
            this.closeTab.Name = "closeTab";
            this.closeTab.Size = new System.Drawing.Size(118, 40);
            this.closeTab.TabIndex = 4;
            this.closeTab.Text = "Close current tab";
            this.closeTab.UseVisualStyleBackColor = false;
            this.closeTab.Click += new System.EventHandler(this.CloseTab_Click);
            // 
            // mainText
            // 
            this.mainText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainText.BackColor = System.Drawing.Color.White;
            this.mainText.Location = new System.Drawing.Point(5, 133);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(1020, 536);
            this.mainText.TabIndex = 4;
            this.mainText.Text = "";
            this.mainText.TextChanged += new System.EventHandler(this.MainText_TextChanged);
            this.mainText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainText_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllStrip,
            this.cutSelectedStrip,
            this.copySelectedStrip,
            this.pasteStrip,
            this.selectedFontStrip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 114);
            // 
            // selectAllStrip
            // 
            this.selectAllStrip.Name = "selectAllStrip";
            this.selectAllStrip.Size = new System.Drawing.Size(168, 22);
            this.selectAllStrip.Text = "Select all (ctrl + a)";
            // 
            // cutSelectedStrip
            // 
            this.cutSelectedStrip.Name = "cutSelectedStrip";
            this.cutSelectedStrip.Size = new System.Drawing.Size(168, 22);
            this.cutSelectedStrip.Text = "Cut (ctrl + x)";
            // 
            // copySelectedStrip
            // 
            this.copySelectedStrip.Name = "copySelectedStrip";
            this.copySelectedStrip.Size = new System.Drawing.Size(168, 22);
            this.copySelectedStrip.Text = "Copy (crtl + c)";
            // 
            // pasteStrip
            // 
            this.pasteStrip.Name = "pasteStrip";
            this.pasteStrip.Size = new System.Drawing.Size(168, 22);
            this.pasteStrip.Text = "Paste (ctrl + v)";
            // 
            // selectedFontStrip
            // 
            this.selectedFontStrip.Name = "selectedFontStrip";
            this.selectedFontStrip.Size = new System.Drawing.Size(168, 22);
            this.selectedFontStrip.Text = "Edit font";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(278, 37);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(104, 28);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1029, 674);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.controlTabs);
            this.Controls.Add(this.textTabs);
            this.Controls.Add(this.closeTab);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1045, 713);
            this.Name = "Form1";
            this.Text = "Useless Text Editor (use Word instead)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.controlTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl textTabs;
        private System.Windows.Forms.TabControl controlTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button closeTab;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox mainText;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button fontResetButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAllStrip;
        private System.Windows.Forms.ToolStripMenuItem cutSelectedStrip;
        private System.Windows.Forms.ToolStripMenuItem copySelectedStrip;
        private System.Windows.Forms.ToolStripMenuItem pasteStrip;
        private System.Windows.Forms.ToolStripMenuItem selectedFontStrip;
        private System.Windows.Forms.Button newWindowButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button formatTestButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button compileButton;
    }
}

