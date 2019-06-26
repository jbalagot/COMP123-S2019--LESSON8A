using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019__LESSON8A
{
    public partial class Lab08Form : Form
    {
        public  string UserName { get; set; }
        public float UserAge { get; set; }
        public Lab08Form()
        {
            InitializeComponent();
        }

        private void InfoGroupBox_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this is the event handler for the nametextbox textchanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length >= 2) ? true : false;
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is the Event Handler for the submitButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;

            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearForm();

        }
        /// <summary>
        /// This method clears the Textboxes and resets other properties
        /// </summary>
        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// this is the event handler for the agetextbox textchanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch 
            {
                SubmitButton.Enabled = false;

            }
            
        }
    }
}
