using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TotalCommander
{
    public partial class FormPrompt : Form
    {
        public FormPrompt(string title, string message="")
        {
            InitializeComponent();
            this.Text = title;
            this.labelMessage.Text = message;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
          
            if (!validFolderName(textBoxInput.Text))
            { 
                errorProvider1.SetError(textBoxInput, "Nazwa jest pusta lub zawiera nieodpowiednie znaki");
               // buttonOK.DialogResult = DialogResult.None;
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private bool validFolderName(string text)
        {
            return (text != "" && text.IndexOfAny(Path.GetInvalidPathChars()) <= 0 && !text.Contains('\\') && !text.Contains('/'));       
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                buttonOK.PerformClick();
            if (e.KeyChar == (char)Keys.Escape)
                buttonCancel.PerformClick();
        }
    }
}
