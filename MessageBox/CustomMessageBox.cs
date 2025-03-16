using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollageManagement
{
    public partial class Message: Form
    {
        public Message()
        {
            InitializeComponent();
        }

        static Message M;
        static String Button_id;

        public static String Show(String Message, String Title, String Btn, String Image)
        {

            M = new Message();
            M.Text.Text = Message;
            M.Title.Text = Title;
            if (Btn == "YesNo")
            {
                M.Btn1.Text = "Yes";
                M.Btn1.Location = new Point(65, 141);
                M.Btn2.Text = "No";
                M.Btn2.Location = new Point(239, 141);
                M.Btn3.Visible = false;

            }
            else if (Btn == "Ok")
            {
                M.Btn1.Text = "Ok";
                M.Btn1.Location = new Point(160, 141);
                M.Btn2.Visible = false;
                M.Btn3.Visible = false;
            }
            else if (Btn == "AbortRetryCancel")
            {
                M.Btn1.Text = "Abort";
                M.Btn1.Location = new Point(29, 141);
                M.Btn2.Text = "Retry";
                M.Btn2.Location = new Point(160, 141);
                M.Btn3.Text = "Cancel";
                M.Btn3.Location = new Point(291, 141);
            }
            else if (Btn == "RetryCancel")
            {
                M.Btn1.Text = "Retry";
                M.Btn1.Location = new Point(65, 141);
                M.Btn2.Text = "Cancel";
                M.Btn1.Location = new Point(239, 141);
                M.Btn3.Visible = false;
            }
            else if (Btn == "YesNoCancel")
            {
                M.Btn1.Text = "Yes";
                M.Btn1.Location = new Point(29, 141);
                M.Btn2.Text = "No";
                M.Btn2.Location = new Point(160, 141);
                M.Btn3.Text = "Cancel";
                M.Btn3.Location = new Point(291, 141);
            }
            else if (Btn == "OkCancel")
            {
                M.Btn1.Text = "Ok";
                M.Btn1.Location = new Point(88, 152);
                M.Btn2.Text = "Cancel";
                M.Btn1.Location = new Point(224, 152);
                M.Btn3.Visible = false;
            }
            M.Image.Image = new Bitmap("C:\\Users\\dell\\source\\repos\\CollageManagement\\CollageManagement\\Resources\\" + Image + ".png");
            M.ShowDialog();
            return Button_id;
        }
        
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Btn1.Text == "Yes")
            {
                Button_id = "1";
                M.Dispose();
            }
            else if (Btn1.Text == "Ok")
            {
                Button_id = "4";
                M.Dispose();
            }
            else if (Btn2.Text == "Abort")
            {
                Button_id = "5";
                M.Dispose();
            }
            else if (Btn2.Text == "Retry")
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

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Btn1.Text == "No")
            {
                Button_id = "2";
                M.Dispose();
            }
            else if (Btn1.Text == "Cancel")
            {
                Button_id = "3";
                M.Dispose();
            }
            else if (Btn2.Text == "Retry")
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

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (Btn1.Text == "Cancel")
            {
                Button_id = "3";
                M.Dispose();
            }
            else if (Btn2.Text == "Ignore")
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
    }
}
