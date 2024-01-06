namespace JournalingApp
{
    partial class PastEntriesForm
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
            PastEntriesTextBox = new TextBox();
            PastEntriesLabel = new Label();
            SuspendLayout();
            // 
            // PastEntriesTextBox
            // 
            PastEntriesTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PastEntriesTextBox.Font = new Font("Segoe UI", 12F);
            PastEntriesTextBox.Location = new Point(335, 285);
            PastEntriesTextBox.Multiline = true;
            PastEntriesTextBox.Name = "PastEntriesTextBox";
            PastEntriesTextBox.ReadOnly = true;
            PastEntriesTextBox.ScrollBars = ScrollBars.Vertical;
            PastEntriesTextBox.Size = new Size(1225, 580);
            PastEntriesTextBox.TabIndex = 0;
            PastEntriesTextBox.TextChanged += PastEntriesTextBox_TextChanged;
            // 
            // PastEntriesLabel
            // 
            PastEntriesLabel.AutoSize = true;
            PastEntriesLabel.Font = new Font("Segoe UI", 24F);
            PastEntriesLabel.Location = new Point(768, 137);
            PastEntriesLabel.Name = "PastEntriesLabel";
            PastEntriesLabel.Size = new Size(359, 86);
            PastEntriesLabel.TabIndex = 1;
            PastEntriesLabel.Text = "Past Entries";
            PastEntriesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // PastEntriesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(PastEntriesLabel);
            Controls.Add(PastEntriesTextBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PastEntriesForm";
            Text = "Daily Journal";
            Load += PastEntriesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PastEntriesTextBox;
        private Label PastEntriesLabel;
    }
}