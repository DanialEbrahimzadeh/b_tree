using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Tree
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public MessageForm(string s)
        {
            InitializeComponent();
            Message = s;
            this.Message_Label2.Text = Message;
        }

        private string message;
        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }

        private void OK_Button_MouseHover(object sender, EventArgs e)
        {
            OK_Button.ForeColor = Color.White;
        }

        private void OK_Button_MouseLeave(object sender, EventArgs e)
        {
            OK_Button.ForeColor = Color.Black;
        }

        private void OK_Button_MouseDown(object sender, MouseEventArgs e)
        {
            OK_Button.ForeColor = Color.Gold;
        }

        private void OK_Button_MouseUp(object sender, MouseEventArgs e)
        {
            OK_Button.ForeColor = Color.White;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
