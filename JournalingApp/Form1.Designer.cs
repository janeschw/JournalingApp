namespace JournalingApp
{
    partial class StartForm
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
            JournalTextBox = new TextBox();
            SubmitButton = new Button();
            StartText = new Label();
            PastLink = new LinkLabel();
            SuspendLayout();
            // 
            // JournalTextBox
            // 
            JournalTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            JournalTextBox.Font = new Font("Segoe UI", 12F);
            JournalTextBox.Location = new Point(457, 349);
            JournalTextBox.Multiline = true;
            JournalTextBox.Name = "JournalTextBox";
            JournalTextBox.Size = new Size(980, 436);
            JournalTextBox.TabIndex = 0;
            JournalTextBox.TextChanged += JournalTextBox_TextChanged;
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubmitButton.Font = new Font("Segoe UI", 12F);
            SubmitButton.Location = new Point(764, 840);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(366, 87);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // StartText
            // 
            StartText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StartText.AutoSize = true;
            StartText.Font = new Font("Segoe UI", 24F);
            StartText.Location = new Point(495, 195);
            StartText.Name = "StartText";
            StartText.Size = new Size(904, 86);
            StartText.TabIndex = 2;
            StartText.Text = "Welcome to your Daily Journal";
            StartText.TextAlign = ContentAlignment.TopCenter;
            // 
            // PastLink
            // 
            PastLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PastLink.AutoSize = true;
            PastLink.Font = new Font("Segoe UI", 12F);
            PastLink.ForeColor = SystemColors.ControlText;
            PastLink.ImageAlign = ContentAlignment.TopLeft;
            PastLink.Location = new Point(18, 14);
            PastLink.Name = "PastLink";
            PastLink.Size = new Size(182, 45);
            PastLink.TabIndex = 3;
            PastLink.TabStop = true;
            PastLink.Text = "Past Entries";
            PastLink.LinkClicked += PastLink_LinkClicked;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(PastLink);
            Controls.Add(StartText);
            Controls.Add(SubmitButton);
            Controls.Add(JournalTextBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartForm";
            Text = "Daily Journal";
            Load += StartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox JournalTextBox;
        private Button SubmitButton;
        private Label StartText;
        private LinkLabel PastLink;
    }
}
