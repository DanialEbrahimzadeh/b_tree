using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                           
        private string opentextfilename;
        public string OpenTextFileName
        {
            get
            {
                return this.opentextfilename;
            }
            set
            {
                this.opentextfilename = value;
            }
        }

        private string savetextfilename;
        public string SaveTextFileName
        {
            get
            {
                return this.savetextfilename;
            }
            set
            {
                this.savetextfilename = value;
            }
        }

        private static List<int> inputlist;
        public static List<int> InputList
        {
            get { return inputlist; }
            set { inputlist = value; }
        }

        private int m;
        public int M
        {
            get
            {
                return this.m;
            }
            set
            {
                this.m = value;
            }
        }

        public B_Tree _B_Tree = new B_Tree();

        private void Exit_Button_MouseHover(object sender, EventArgs e)
        {
            Exit_Button.ForeColor = Color.White;
        }

        private void Exit_Button_MouseLeave(object sender, EventArgs e)
        {
            Exit_Button.ForeColor = Color.Black;
        }

        private void Exit_Button_MouseDown(object sender, MouseEventArgs e)
        {
            Exit_Button.ForeColor = Color.Gold;
        }

        private void Exit_Button_MouseUp(object sender, MouseEventArgs e)
        {
            Exit_Button.ForeColor = Color.Black;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void About_B_Tree_Button_MouseHover(object sender, EventArgs e)
        {
            About_B_Tree_Button.ForeColor = Color.White;
        }

        private void About_B_Tree_Button_MouseLeave(object sender, EventArgs e)
        {
            About_B_Tree_Button.ForeColor = Color.Black;
        }

        private void About_B_Tree_Button_MouseDown(object sender, MouseEventArgs e)
        {
            About_B_Tree_Button.ForeColor = Color.Gold;
        }

        private void About_B_Tree_Button_MouseUp(object sender, MouseEventArgs e)
        {
            About_B_Tree_Button.ForeColor = Color.Black;
        }

        private void About_B_Tree_Button_Click(object sender, EventArgs e)
        {
            Show_Suiitable_Panel("About_B_Tree_Panel");
        }



        private void Show_B_Tree_Button_MouseHover(object sender, EventArgs e)
        {
            Show_B_Tree_Button.ForeColor = Color.White;
        }

        private void Show_B_Tree_Button_MouseLeave(object sender, EventArgs e)
        {
            Show_B_Tree_Button.ForeColor = Color.Black;
        }

        private void Show_B_Tree_Button_MouseDown(object sender, MouseEventArgs e)
        {
            Show_B_Tree_Button.ForeColor = Color.Gold;
        }

        private void Show_B_Tree_Button_MouseUp(object sender, MouseEventArgs e)
        {
            Show_B_Tree_Button.ForeColor = Color.Black;
        }

        private void Show_B_Tree_Button_Click(object sender, EventArgs e)
        {
            Show_Suiitable_Panel("Show_B_Tree_Panel");
        }




        private void Create_B_Tree_Button_MouseHover(object sender, EventArgs e)
        {
            Create_B_Tree_Button.ForeColor = Color.White;
        }

        private void Create_B_Tree_Button_MouseLeave(object sender, EventArgs e)
        {
            Create_B_Tree_Button.ForeColor = Color.Black;
        }

        private void Create_B_Tree_Button_MouseDown(object sender, MouseEventArgs e)
        {
            Create_B_Tree_Button.ForeColor = Color.Gold;
        }

        private void Create_B_Tree_Button_MouseUp(object sender, MouseEventArgs e)
        {
            Create_B_Tree_Button.ForeColor = Color.Black;
        }

        private void Create_B_Tree_Button_Click(object sender, EventArgs e)
        {
            Show_Suiitable_Panel("Create_B_Tree_Panel");
        }



        private void Browse_Button_MouseHover(object sender, EventArgs e)
        {
            Browse_Button.ForeColor = Color.White;
        }

        private void Browse_Button_MouseLeave(object sender, EventArgs e)
        {
            Browse_Button.ForeColor = Color.Black;
        }

        private void Browse_Button_MouseDown(object sender, MouseEventArgs e)
        {
            Browse_Button.ForeColor = Color.Gold;
        }

        private void Browse_Button_MouseUp(object sender, MouseEventArgs e)
        {
            Browse_Button.ForeColor = Color.Black;
        }

        private void Browse_Button_Click(object sender, EventArgs e)
        {
            OpenTextFileName = "";
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt;";
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Open Input Text File";

            DialogResult OpenFileDialogResult = openFileDialog1.ShowDialog();

            if (OpenFileDialogResult == DialogResult.OK)
            {
                OpenTextFileName = openFileDialog1.FileName;
                Create_B_Tree_Label5.Text ="\" " + OpenTextFileName + " \"";
            }
        }



        private void Create_Button_MouseHover(object sender, EventArgs e)
        {
            Create_Button.ForeColor = Color.White;
        }

        private void Create_Button_MouseLeave(object sender, EventArgs e)
        {
            Create_Button.ForeColor = Color.Black;
        }

        private void Create_Button_MouseDown(object sender, MouseEventArgs e)
        {
            Create_Button.ForeColor = Color.Gold;
        }

        private void Create_Button_MouseUp(object sender, MouseEventArgs e)
        {
            Create_Button.ForeColor = Color.Black;
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            if (Surveillance_Create_B_Tree())
            {
                _B_Tree = new B_Tree(M);
                _B_Tree.Insert(InputList);

                Clean_Show_B_Tree_Enviroment();

                MessageForm Message_Form = new MessageForm("Create the B_Tree is Completed Successfully.");
                Message_Form.ShowDialog();
            }
        }



        private void Save_Button_MouseHover(object sender, EventArgs e)
        {
            Save_Button.ForeColor = Color.White;
        }

        private void Save_Button_MouseLeave(object sender, EventArgs e)
        {
            Save_Button.ForeColor = Color.Black;
        }

        private void Save_Button_MouseDown(object sender, MouseEventArgs e)
        {
            Save_Button.ForeColor = Color.Gold;
        }

        private void Save_Button_MouseUp(object sender, MouseEventArgs e)
        {
            Save_Button.ForeColor = Color.Black;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (_B_Tree.IsCreate())
            {
                SaveTextFileName = "";

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text Files|*.txt;";
                saveFileDialog1.FileName = "Output.txt";
                saveFileDialog1.Title = "Save Output Text File";

                DialogResult SaveFileDialogResult = saveFileDialog1.ShowDialog();

                if (SaveFileDialogResult == DialogResult.OK)
                {
                    SaveTextFileName = saveFileDialog1.FileName;
                    Show_B_Tree_Label4.Text ="URL : " + "\" " + SaveTextFileName + " \"";

                    _B_Tree.Write_B_Tree_In_Text_File(SaveTextFileName);

                    Show_Text_File_Button.Enabled = true;
                }
            }
            else
            {
                MessageForm Message_Form = new MessageForm("You should create a B_Tree.");
                Message_Form.ShowDialog();
            }
        }



        private void Show_Text_File_Button_MouseHover(object sender, EventArgs e)
        {
            Show_Text_File_Button.ForeColor = Color.White;
        }

        private void Show_Text_File_Button_MouseLeave(object sender, EventArgs e)
        {
            Show_Text_File_Button.ForeColor = Color.Black;
        }

        private void Show_Text_File_Button_MouseDown(object sender, MouseEventArgs e)
        {
            Show_Text_File_Button.ForeColor = Color.Gold;
        }

        private void Show_Text_File_Button_MouseUp(object sender, MouseEventArgs e)
        {
            Show_Text_File_Button.ForeColor = Color.Black;
        }

        private void Show_Text_File_Button_Click(object sender, EventArgs e)
        {
            if (SaveTextFileName != String.Empty)
            {
                if (File.Exists(SaveTextFileName))
                {
                    Process.Start(SaveTextFileName);
                }
                else
                {
                    MessageForm Message_Form = new MessageForm("This file is not exist.");
                    Message_Form.ShowDialog();
                }
            }
            else
            {
                MessageForm Message_Form = new MessageForm("You should save your result text file.");
                Message_Form.ShowDialog();
            }
        }



        private void Show_Graphical_Enviroment_Button_MouseHover(object sender, EventArgs e)
        {
            Show_Graphical_Enviroment_Button.ForeColor = Color.White;
        }

        private void Show_Graphical_Enviroment_Button_MouseLeave(object sender, EventArgs e)
        {
            Show_Graphical_Enviroment_Button.ForeColor = Color.Black;
        }

        private void Show_Graphical_Enviroment_Button_MouseDown(object sender, MouseEventArgs e)
        {
            Show_Graphical_Enviroment_Button.ForeColor = Color.Gold;
        }

        private void Show_Graphical_Enviroment_Button_MouseUp(object sender, MouseEventArgs e)
        {
            Show_Graphical_Enviroment_Button.ForeColor = Color.Black;
        }

        private void Show_Graphical_Enviroment_Button_Click(object sender, EventArgs e)
        {
            if (_B_Tree.IsCreate())
            {
                Graphical_Enviroment_Form Graphical_Form = new Graphical_Enviroment_Form();
                Graphical_Form.Show_Graphical_B_Tree(_B_Tree);
                Graphical_Form.ShowDialog();
            }
            else
            {
                MessageForm Message_Form = new MessageForm("You should create a B_Tree.");
                Message_Form.ShowDialog();
            }
        }



        private void Create_B_Tree_RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Create_B_Tree_RadioButton1.Checked == true)
            {
                Create_B_Tree_RichTextBox.Enabled = false;
            }
            else
            {
                Create_B_Tree_RichTextBox.Enabled = true;
            }
        }

        private void Create_B_Tree_RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Create_B_Tree_RadioButton2.Checked == true)
            {
                Browse_Button.Enabled = false;
            }
            else
            {
                Browse_Button.Enabled = true;
            }
        }



        private void Show_Suiitable_Panel(string s)
        {
            switch (s)
            { 
                case "Create_B_Tree_Panel":
                    Show_B_Tree_Panel.Visible = false;
                    About_B_Tree_Panel.Visible = false;
                    Create_B_Tree_Panel.Visible = true;
                    break;

                case "Show_B_Tree_Panel":
                    Show_B_Tree_Panel.Visible = true;
                    About_B_Tree_Panel.Visible = false;
                    Create_B_Tree_Panel.Visible = false;
                    break;

                case "About_B_Tree_Panel":
                    Show_B_Tree_Panel.Visible = false;
                    About_B_Tree_Panel.Visible = true;
                    Create_B_Tree_Panel.Visible = false;
                    break;
            }
        }

        private bool Surveillance_Create_B_Tree()
        {
            if (M_TextBox.Text == "")
            {
                MessageForm Message_Form = new MessageForm("You should enter a value for M.");
                Message_Form.ShowDialog();

                return false;
            }
            else
            {
                string Str1 = M_TextBox.Text.Trim();
                int Num1;
                bool isNum1 = int.TryParse(Str1, out Num1);
                if (!isNum1)
                {
                    MessageForm Message_Form = new MessageForm("Your input value for M should be an integer.");
                    Message_Form.ShowDialog();

                    return false;
                }
                else
                {
                    int N = int.Parse(M_TextBox.Text);
                    if (N > 4 || N < 1)
                    {
                        MessageForm Message_Form = new MessageForm("Your input value for M should be between 1 to 4.");
                        Message_Form.ShowDialog();

                        return false;
                    }
                    else
                    {
                        if (!Create_B_Tree_RadioButton1.Checked && !Create_B_Tree_RadioButton2.Checked)
                        {
                            MessageForm Message_Form = new MessageForm("You should choose one of ways to enter your input datas.");
                            Message_Form.ShowDialog();

                            return false;
                        }
                        else
                        {
                            if (Create_B_Tree_RadioButton1.Checked)
                            {
                                if (!Surveillance_Text_File())
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                if (Create_B_Tree_RadioButton2.Checked)
                                {
                                    if (!Surveillance_RichTextBox())
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            M = int.Parse(M_TextBox.Text);
            return true;
        }

        private bool Surveillance_Text_File()
        {
            if (OpenTextFileName == null)
            {
                MessageForm Message_Form = new MessageForm("You should select a text file.");
                Message_Form.ShowDialog();

                return false;
            }
            else
            {
                if (new FileInfo(OpenTextFileName).Length == 0)
                {
                    MessageForm Message_Form = new MessageForm("You should select a text file that is not empty.");
                    Message_Form.ShowDialog();

                    return false;
                }
                else
                {
                    FileStream Text_File = new FileStream(OpenTextFileName, FileMode.Open, FileAccess.Read);
                    StreamReader Reader_Text_File = new StreamReader(Text_File);
                    List<int> list = new List<int>();
                    InputList = new List<int>();

                    while (Reader_Text_File.Peek() != -1)
                    {
                        string line = Reader_Text_File.ReadLine();
                        int Num1;
                        if (!int.TryParse(line, out Num1))
                        {
                            MessageForm Message_Form = new MessageForm("Your input datas should be integers.\n" + "Please refine : " + line);
                            Message_Form.ShowDialog();

                            return false;
                        }
                        else
                        {
                            int N = int.Parse(line);
                            if (N < 0 || N > 255)
                            {
                                MessageForm Message_Form = new MessageForm("Your input datas should be between 0 t0 255.\n" + "Please refine : " + line);
                                Message_Form.ShowDialog();

                                return false;
                            }
                            else
                            {
                                list.Add(N);
                            }
                        }
                    }
                    Reader_Text_File.Close();

                    InputList = list.Distinct().ToList();

                    if (InputList.Count < list.Count)
                    {
                        MessageForm Message_Form = new MessageForm("Your input datas have Duplicates.\n" + "We use them for one time.");
                        Message_Form.ShowDialog();
                    }
                }
            }
            return true;
        }

        private bool Surveillance_RichTextBox()
        {
            if (Create_B_Tree_RichTextBox.TextLength == 0)
            {
                MessageForm Message_Form = new MessageForm("You should enter your input datas in the box.");
                Message_Form.ShowDialog();

                return false;
            }
            else
            {
                List<int> list = new List<int>();
                InputList = new List<int>();

                for (int i = 0; i <= Create_B_Tree_RichTextBox.Lines.Length - 1; i++)
                {
                    string line = Create_B_Tree_RichTextBox.Lines[i];
                    int Num1;
                    if (!int.TryParse(line, out Num1))
                    {
                        MessageForm Message_Form = new MessageForm("Your input datas should be integers.\n" + "Please refine : " + line);
                        Message_Form.ShowDialog();

                        return false;
                    }
                    else
                    {
                        int N = int.Parse(line);
                        if (N > 255 || N < 0)
                        {
                            MessageForm Message_Form = new MessageForm("Your input datas should be between 0 t0 255.\n" + "Please refine : " + line);
                            Message_Form.ShowDialog();

                            return false;
                        }
                        else
                        {
                            list.Add(N);
                        }
                    }
                }

                InputList = list.Distinct().ToList();

                if (InputList.Count < list.Count)
                {
                    MessageForm Message_Form = new MessageForm("Your input datas have Duplicates.\n" + "We use them for one time.");
                    Message_Form.ShowDialog();
                }
            }
            return true;
        }

        private void Clean_Show_B_Tree_Enviroment()
        {
            Create_B_Tree_Label5.Text = "URL :";
            Show_Text_File_Button.Enabled = false;
        }
    }
}
