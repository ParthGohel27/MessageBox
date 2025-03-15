using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class ShowMessageBox: Form
    {
        public ShowMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Call CustomMessageBox Class And View Method
            //Pass Message,Title,Button Type,Image Name as a Parameter
            CustomMessageBox.View("Text What You Enter", "Title What You Enter", "Ok", "Information");
            CustomMessageBox.View("Text What You Enter", "Title What You Enter", "YesNo", "Asterisk");
            CustomMessageBox.View("Text What You Enter", "Title What You Enter", "AbortRetryCancel", "Question");
            CustomMessageBox.View("Text What You Enter", "Title What You Enter", "RetryCancel", "Error");
            CustomMessageBox.View("Text What You Enter", "Title What You Enter", "YesNoCancel", "Stop");
            CustomMessageBox.View("Text What You Enter", "Title What You Enter", "OkCancel", "Exclamation");
            CustomMessageBox.View("Text What You Enter", "Title What You Enter", "YesNo", "Warning");
        }
    }
}
