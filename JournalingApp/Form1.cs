namespace JournalingApp
{

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    public partial class StartForm : Form
    {
        // Create a list to store journal entries
        private List<string> journalEntries = new List<string>();
        private string filePath = "journal_entries.txt"; // Specify the path for your text 

        public StartForm()
        {
            InitializeComponent();

            if (File.Exists(filePath))
            {
                journalEntries.AddRange(File.ReadAllLines(filePath));
            }
        }

        private void JournalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            // Get the text from the journal entry text box
            string entry = $"{DateTime.Now}: {JournalTextBox.Text}";

            // Add the entry to the list
            journalEntries.Add(entry);

            // Save the entries to the text file
            File.WriteAllLines(filePath, journalEntries);

            // Optionally, you can clear the text box after submitting
            JournalTextBox.Clear();
        }

        private void PastLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the PastEntriesForm and pass the entries
            PastEntriesForm pastEntriesForm = new PastEntriesForm(journalEntries);
            pastEntriesForm.ShowDialog();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            
        }
    }
    public partial class PastEntriesForm: Form
        {
            private List<string> pastEntries;

            public PastEntriesForm(List<string> pastEntries)
            {
                InitializeComponent();
                this.pastEntries = pastEntries;

                // Display past entries in a TextBox or any other control on this form
                PastEntriesTextBox.Text = string.Join(Environment.NewLine, pastEntries);
            }
        }
}
