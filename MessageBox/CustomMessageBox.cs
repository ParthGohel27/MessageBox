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
    public partial class CustomMessageBox: Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        static CustomMessageBox M;
        static String Button_id;

        public static String View(String Message, String Title, String Btn, String Image)
        {
            //Difine Object of This Form
            M = new CustomMessageBox();
            //Set Message Text Pass From Calling Method
            //LMessage is Name of Label
            M.LMessage.Text = Message;
            //Set Title Text Pass From Calling Method
            //LTitle is Name of Label
            M.LTitle.Text = Title;
            //Set Button Text Pass From Calling Method
            if (Btn == "YesNo")
            {
                //button1,button2,button3 is Name of Button
                M.button1.Text = "Yes";
                //Set Button Location As X and Y
                M.button1.Location = new Point(105, 149);
                M.button2.Text = "No";
                M.button2.Location = new Point(224, 149);
                M.button3.Visible = false;

            }
            else if (Btn == "Ok")
            {
                M.button1.Text = "Ok";
                M.button1.Location = new Point(167, 149);
                M.button2.Visible = false;
                M.button3.Visible = false;
            }
            else if (Btn == "AbortRetryCancel")
            {
                M.button1.Text = "Abort";
                M.button2.Text = "Retry";
                M.button3.Text = "Cancel";
            }
            else if (Btn == "RetryCancel")
            {
                M.button1.Text = "Retry";
                M.button1.Location = new Point(105, 149);
                M.button2.Text = "Cancel";
                M.button1.Location = new Point(224, 149);
                M.button3.Visible = false;
            }
            else if (Btn == "YesNoCancel")
            {
                M.button1.Text = "Yes";
                M.button2.Text = "No";
                M.button2.Text = "Cancel";
            }
            else if (Btn == "OkCancel")
            {
                M.button1.Text = "Ok";
                M.button1.Location = new Point(105, 149);
                M.button2.Text = "Cancel";
                M.button1.Location = new Point(224, 149);
                M.button2.Visible = false;
            }
            //Image is PictureBox Name
            //Set Image Path And Take Image Name as a String For Show Image
            M.Image.Image = new Bitmap("C:\\Users\\dell\\source\\repos\\MessageBox\\MessageBox\\Resources\\" + Image + ".png");
            M.ShowDialog();
            return Button_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Yes")
            {
                Button_id = "1";
                M.Dispose();
            }
            else if (button1.Text == "Ok")
            {
                Button_id = "4";
                M.Dispose();
            }
            else if (button2.Text == "Abort")
            {
                Button_id = "5";
                M.Dispose();
            }
            else if (button2.Text == "Retry")
            {
                Button_id = "6";
                M.Dispose();
            }
            else
            {
                Button_id = "8";
                M.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "No")
            {
                Button_id = "2";
                M.Dispose();
            }
            else if (button1.Text == "Cancel")
            {
                Button_id = "3";
                M.Dispose();
            }
            else if (button2.Text == "Retry")
            {
                Button_id = "6";
                M.Dispose();
            }
            else
            {
                Button_id = "8";
                M.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Cancel")
            {
                Button_id = "3";
                M.Dispose();
            }
            else if (button2.Text == "Ignore")
            {
                Button_id = "7";
                M.Dispose();
            }
            else
            {
                Button_id = "8";
                M.Dispose();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
