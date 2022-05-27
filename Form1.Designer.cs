namespace Soulsborne_Save_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.srcLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bakTextbox = new System.Windows.Forms.TextBox();
            this.srcTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quickTextbox = new System.Windows.Forms.TextBox();
            this.saveTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            this.bakFolderDialogBtn = new System.Windows.Forms.Button();
            this.quickFolderDialogBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.srcFolderDialogBtn = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.quickLimitTextbox = new System.Windows.Forms.NumericUpDown();
            this.quicksaveToggle = new MetroFramework.Controls.MetroToggle();
            this.backupButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.intervalCombobox = new System.Windows.Forms.ComboBox();
            this.backupRadio = new System.Windows.Forms.RadioButton();
            this.quickRadio = new System.Windows.Forms.RadioButton();
            this.quicksaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quickLimitTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // srcLabel
            // 
            this.srcLabel.AutoSize = true;
            this.srcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcLabel.Location = new System.Drawing.Point(12, 10);
            this.srcLabel.Name = "srcLabel";
            this.srcLabel.Size = new System.Drawing.Size(64, 20);
            this.srcLabel.TabIndex = 1;
            this.srcLabel.Text = "Source:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backup folder:";
            // 
            // bakTextbox
            // 
            this.bakTextbox.Location = new System.Drawing.Point(159, 38);
            this.bakTextbox.Name = "bakTextbox";
            this.bakTextbox.ReadOnly = true;
            this.bakTextbox.Size = new System.Drawing.Size(333, 20);
            this.bakTextbox.TabIndex = 3;
            // 
            // srcTextbox
            // 
            this.srcTextbox.Location = new System.Drawing.Point(159, 12);
            this.srcTextbox.Name = "srcTextbox";
            this.srcTextbox.ReadOnly = true;
            this.srcTextbox.Size = new System.Drawing.Size(333, 20);
            this.srcTextbox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(285, 432);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Option";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quicksave folder:";
            // 
            // quickTextbox
            // 
            this.quickTextbox.Location = new System.Drawing.Point(159, 68);
            this.quickTextbox.Name = "quickTextbox";
            this.quickTextbox.ReadOnly = true;
            this.quickTextbox.Size = new System.Drawing.Size(333, 20);
            this.quickTextbox.TabIndex = 8;
            // 
            // saveTextbox
            // 
            this.saveTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTextbox.Location = new System.Drawing.Point(159, 98);
            this.saveTextbox.Name = "saveTextbox";
            this.saveTextbox.Size = new System.Drawing.Size(333, 21);
            this.saveTextbox.TabIndex = 10;
            this.saveTextbox.Text = "filename.sl2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Save filename:";
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(366, 432);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(75, 23);
            this.helpBtn.TabIndex = 11;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // bakFolderDialogBtn
            // 
            this.bakFolderDialogBtn.Location = new System.Drawing.Point(498, 38);
            this.bakFolderDialogBtn.Name = "bakFolderDialogBtn";
            this.bakFolderDialogBtn.Size = new System.Drawing.Size(25, 20);
            this.bakFolderDialogBtn.TabIndex = 13;
            this.bakFolderDialogBtn.Text = "...";
            this.bakFolderDialogBtn.UseVisualStyleBackColor = true;
            this.bakFolderDialogBtn.Click += new System.EventHandler(this.bakFolderDialogBtn_Click);
            // 
            // quickFolderDialogBtn
            // 
            this.quickFolderDialogBtn.Location = new System.Drawing.Point(498, 68);
            this.quickFolderDialogBtn.Name = "quickFolderDialogBtn";
            this.quickFolderDialogBtn.Size = new System.Drawing.Size(25, 20);
            this.quickFolderDialogBtn.TabIndex = 14;
            this.quickFolderDialogBtn.Text = "...";
            this.quickFolderDialogBtn.UseVisualStyleBackColor = true;
            this.quickFolderDialogBtn.Click += new System.EventHandler(this.quickFolderDialogBtn_Click);
            // 
            // srcFolderDialogBtn
            // 
            this.srcFolderDialogBtn.Location = new System.Drawing.Point(498, 12);
            this.srcFolderDialogBtn.Name = "srcFolderDialogBtn";
            this.srcFolderDialogBtn.Size = new System.Drawing.Size(25, 20);
            this.srcFolderDialogBtn.TabIndex = 15;
            this.srcFolderDialogBtn.Text = "...";
            this.srcFolderDialogBtn.UseVisualStyleBackColor = true;
            this.srcFolderDialogBtn.Click += new System.EventHandler(this.srcFolderDialogBtn_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(451, 432);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 16;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quicksave Limit:";
            // 
            // quickLimitTextbox
            // 
            this.quickLimitTextbox.Location = new System.Drawing.Point(159, 159);
            this.quickLimitTextbox.Name = "quickLimitTextbox";
            this.quickLimitTextbox.Size = new System.Drawing.Size(58, 20);
            this.quickLimitTextbox.TabIndex = 18;
            this.quickLimitTextbox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // quicksaveToggle
            // 
            this.quicksaveToggle.AutoSize = true;
            this.quicksaveToggle.Location = new System.Drawing.Point(16, 229);
            this.quicksaveToggle.Name = "quicksaveToggle";
            this.quicksaveToggle.Size = new System.Drawing.Size(80, 17);
            this.quicksaveToggle.TabIndex = 19;
            this.quicksaveToggle.Text = "Off";
            this.quicksaveToggle.UseVisualStyleBackColor = true;
            this.quicksaveToggle.CheckedChanged += new System.EventHandler(this.quicksaveToggle_CheckedChanged);
            // 
            // backupButton
            // 
            this.backupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupButton.Location = new System.Drawing.Point(43, 297);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(204, 108);
            this.backupButton.TabIndex = 20;
            this.backupButton.Text = "Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(288, 297);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(204, 108);
            this.loadButton.TabIndex = 21;
            this.loadButton.Text = "Load Backup";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quicksave interval:";
            // 
            // intervalCombobox
            // 
            this.intervalCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalCombobox.FormattingEnabled = true;
            this.intervalCombobox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "30",
            "60"});
            this.intervalCombobox.Location = new System.Drawing.Point(159, 189);
            this.intervalCombobox.Name = "intervalCombobox";
            this.intervalCombobox.Size = new System.Drawing.Size(58, 21);
            this.intervalCombobox.TabIndex = 23;
            // 
            // backupRadio
            // 
            this.backupRadio.AutoSize = true;
            this.backupRadio.Checked = true;
            this.backupRadio.Location = new System.Drawing.Point(321, 274);
            this.backupRadio.Name = "backupRadio";
            this.backupRadio.Size = new System.Drawing.Size(62, 17);
            this.backupRadio.TabIndex = 24;
            this.backupRadio.TabStop = true;
            this.backupRadio.Text = "Backup";
            this.backupRadio.UseVisualStyleBackColor = true;
            // 
            // quickRadio
            // 
            this.quickRadio.AutoSize = true;
            this.quickRadio.Location = new System.Drawing.Point(403, 274);
            this.quickRadio.Name = "quickRadio";
            this.quickRadio.Size = new System.Drawing.Size(53, 17);
            this.quickRadio.TabIndex = 25;
            this.quickRadio.Text = "Quick";
            this.quickRadio.UseVisualStyleBackColor = true;
            // 
            // quicksaveButton
            // 
            this.quicksaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quicksaveButton.Location = new System.Drawing.Point(288, 145);
            this.quicksaveButton.Name = "quicksaveButton";
            this.quicksaveButton.Size = new System.Drawing.Size(204, 108);
            this.quicksaveButton.TabIndex = 26;
            this.quicksaveButton.Text = "Quicksave now";
            this.quicksaveButton.UseVisualStyleBackColor = true;
            this.quicksaveButton.Click += new System.EventHandler(this.quicksaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(538, 469);
            this.Controls.Add(this.quicksaveButton);
            this.Controls.Add(this.quickRadio);
            this.Controls.Add(this.backupRadio);
            this.Controls.Add(this.intervalCombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.quicksaveToggle);
            this.Controls.Add(this.quickLimitTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.srcFolderDialogBtn);
            this.Controls.Add(this.quickFolderDialogBtn);
            this.Controls.Add(this.bakFolderDialogBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.saveTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quickTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.srcTextbox);
            this.Controls.Add(this.bakTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srcLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Soulsborne Save Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quickLimitTextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label srcLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bakTextbox;
        private System.Windows.Forms.TextBox srcTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quickTextbox;
        private System.Windows.Forms.TextBox saveTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button bakFolderDialogBtn;
        private System.Windows.Forms.Button quickFolderDialogBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button srcFolderDialogBtn;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown quickLimitTextbox;
        private MetroFramework.Controls.MetroToggle quicksaveToggle;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox intervalCombobox;
        private System.Windows.Forms.RadioButton backupRadio;
        private System.Windows.Forms.RadioButton quickRadio;
        private System.Windows.Forms.Button quicksaveButton;
    }
}

