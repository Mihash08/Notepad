namespace Notepad_
{
    partial class SaveOrExit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveAndExit = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you would like to exit?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "You still have some unsaved progress";
            // 
            // saveAndExit
            // 
            this.saveAndExit.Location = new System.Drawing.Point(4, 115);
            this.saveAndExit.Name = "saveAndExit";
            this.saveAndExit.Size = new System.Drawing.Size(98, 23);
            this.saveAndExit.TabIndex = 2;
            this.saveAndExit.Text = "Save and close";
            this.saveAndExit.UseVisualStyleBackColor = true;
            this.saveAndExit.Click += new System.EventHandler(this.saveAndExit_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(109, 115);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(137, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Close without saving";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(252, 115);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveOrExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 150);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveAndExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaveOrExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Are you sure?";
            this.Load += new System.EventHandler(this.SaveOrExit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveAndExit;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button cancelButton;
    }
}