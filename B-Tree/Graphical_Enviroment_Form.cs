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
    public partial class Graphical_Enviroment_Form : Form
    {
        public Graphical_Enviroment_Form()
        {
            InitializeComponent();
        }

        public void Show_Graphical_B_Tree(B_Tree B_Tree)
        {
            Label[] Label = new Label[1000];

            int Number_Of_Nodes = B_Tree.Calculate_Number_Of_Nodes();
            int Depth_Of_B_Tree = B_Tree.Calculate_Depth_Of_B_Tree();
            int Number_Of_Nodes_In_Rows = (int)Math.Pow((2 * B_Tree.M + 1), (Depth_Of_B_Tree - 1));

            List<List<B_Tree_Node>> Nodes_List = B_Tree.Write_Nodes_To_B_Tree_Node_List();

            List<List<int>> Nodes_Number_Of_Child_List = B_Tree.Write_Number_Of_Child_Of_Nodes_To_Int_List();

            for (int i = 0; i < 1000; i++)
            {
                Label[i] = new Label();
                Label[i].Visible = false;
                Label[i].Font = new Font("Hobo Std", 16.0f);
                Graphical_Enviroment_Panel.Controls.Add(Label[i]);
            }

            Label l1 = new Label();
            l1.Font = new Font("Hobo Std", 16.0f);
            for (int i = 0; i < 2 * B_Tree.M; i++)
                l1.Text += ".999";
            l1.Text += ".";

            int Width_Of_Labels = l1.Width;
            int Height_Of_Labels = l1.Height + 5;

            int x = 10;
            int xx = 0;
            int y = (Depth_Of_B_Tree - 1) * (Height_Of_Labels + 10);
            int s = 0;
            int m = 0;
            int n = 0;
           // int Index_Of_Own_Link = 0;

            for (int i = 0; i < Depth_Of_B_Tree; i++)
            {
                List<B_Tree_Node> Nodes_Of_Each_Row = Nodes_List[Depth_Of_B_Tree - 1 - i];

                List<int> Nodes_Number_Of_Child_Of_Each_Row = new List<int>();

                if ((Depth_Of_B_Tree - 2 - i) >= 0)
                    Nodes_Number_Of_Child_Of_Each_Row = Nodes_Number_Of_Child_List[Depth_Of_B_Tree - 2 - i];
                else
                    Nodes_Number_Of_Child_Of_Each_Row.Add(1);

                if (n == 0)
                    n = (Width_Of_Labels + 10);
                    //n = 10;
                else
                    n = (2 * (x - 10)) + (Width_Of_Labels + 10);

                xx = x;

                int count = 0;
                for (int j = 0; j < Nodes_Number_Of_Child_Of_Each_Row.Count; j++)
                {                    
                    int Nodes_Number_Of_Child = Nodes_Number_Of_Child_Of_Each_Row[j];
                    
                    for (int g = 0; g < Nodes_Number_Of_Child; g++,s++)
                    {
                        B_Tree_Node Node = new B_Tree_Node();
                        Node = Nodes_Of_Each_Row[g + count];

                        Label[s].Text = Node.Print_For_Graphical_Enviroment();
                        Label[s].Location = new Point(x, y);
                        Label[s].Visible = true;

                        x += n;
                    }

                    count += Nodes_Number_Of_Child;

                    if (Nodes_Number_Of_Child < 2 * B_Tree.M + 1)
                        for (int a = Nodes_Number_Of_Child; a < 2 * B_Tree.M + 1; a++,s++)
                        {
                            string ss = "";
                            for (int k = 0; k < 2 * B_Tree.M; k++)
                                ss += ".   ";
                            ss += ".";

                            Label[s].Text = ss;
                            Label[s].Location = new Point(x, y);
                            Label[s].Visible = false;
                            x += n;
                        }

                    //        if (j < Nodes_Of_Each_Row.Count)
                    //            Node = Nodes_Of_Each_Row[j];
                    //        else
                    //            break;

                    

                    //if (!Node.IsRoot())
                    //    Index_Of_Own_Link = Node.Found_Index_Of_Own_Link();
                    //else
                    //    Index_Of_Own_Link = 0;

                    ////for(int sss=0;sss<2 * B_Tree.M;sss++)
                    //{
                    //if (Index_Of_Own_Link < )
                    //{
                    //    Label[s].Text = Node.Print_For_Graphical_Enviroment();
                    //    Label[s].Location = new Point(x, y);
                    //    Label[s].Visible = true;
                    //} 
                    //}
                    //if (Index_Of_Own_Link < 2 * B_Tree.M)
                    //{
                    //    Label[s].Text = Node.Print_For_Graphical_Enviroment();
                    //    Label[s].Location = new Point(x, y);
                    //    Label[s].Visible = true;
                    //}

                    //x += n;
                }

                y -= (Height_Of_Labels + 10);

                //m = (int)Math.Pow((2), i);
                //x = (m + 1) * (Width_Of_Labels + 10);
                m = (int)Math.Pow((2 * B_Tree.M + 1), i);//*******
                x = xx + ( m * (Width_Of_Labels + 10));//*****
                //m = (int)Math.Pow((2 * B_Tree.M + 1), i + 1);
                //x = ((m / 2) * (Width_Of_Labels + 10)) + 10;

                //Number_Of_Nodes_In_Rows /= (2 * B_Tree.M);
            }
            //Label[] Label = new Label[1000];

            //int Depth_Of_B_Tree = B_Tree.Calculate_Depth_Of_B_Tree();
            //int Number_Of_Nodes_In_Rows = (int)Math.Pow((2 * B_Tree.M + 1), (Depth_Of_B_Tree));

            //Stack<B_Tree_Node> Stack_Nodes = new Stack<B_Tree_Node>();
            //Stack_Nodes = B_Tree.Adapt_Node_To_Show_Graphical(Depth_Of_B_Tree);

            //List<string> String_List = B_Tree.Write_Nodes_To_String_List();


            ////int Number_Of_Nodes = Stack_Nodes.Count;
            //int Number_Of_Nodes = B_Tree.Calculate_Number_Of_Nodes();

            //for (int i = 0; i < Number_Of_Nodes; i++)
            //{
            //    Label[i] = new Label();
            //    Label[i].Visible = false;
            //    Label[i].Font = new Font("Hobo Std", 16.0f);
            //    Graphical_Enviroment_Panel.Controls.Add(Label[i]);
            //}

            //Label l1 = new Label();
            //l1.Font = new Font("Hobo Std", 16.0f);
            //for (int i = 0; i < 2 * B_Tree.M; i++)
            //    l1.Text += ".111";
            //l1.Text += ".";

            //int Width_Of_Labels = l1.Width;
            //int Height_Of_Labels = l1.Height + 5;

            //int x = ((Number_Of_Nodes_In_Rows - 1) * (Width + 10)) + 10 ;
            //int y = (Depth_Of_B_Tree - 1) * (Height_Of_Labels + 10);
            //int s = 0;
            //int m = 0;
            //int n = 0;
            //int Index_Of_Own_Link = 0;

            //for (int i = 0; i < Depth_Of_B_Tree; i++)
            //{
            //    string Nodes_Of_Each_Row =  String_List[Depth_Of_B_Tree - 1 - i];

            //    if (n == 0)
            //        n = (Width_Of_Labels + 10);
            //    else
            //        n = (2 * (x - 10)) + (Width_Of_Labels + 10);

            //    for (int j = 0; j < Number_Of_Nodes_In_Rows; j++, s++)
            //    {
            //        B_Tree_Node Node = Nodes_Of_Each_Row[j];

            //        for (int g = 0; g < 10; g++) ;

            //        if (Node.IsRoot())
            //            Index_Of_Own_Link = Node.Found_Index_Of_Own_Link();
            //        else
            //            Index_Of_Own_Link = 0;


            //        if (Index_Of_Own_Link < 2 * B_Tree.M)
            //        {
            //            Label[s].Text = Node.Print_For_Graphical_Enviroment();
            //            Label[s].Location = new Point(x, y);
            //            Label[s].Visible = true;
            //        }

            //        x += n;
            //    }

            //    y -= (Height_Of_Labels + 10);

            //    m = (int)Math.Pow((2 * B_Tree.M - 1), i + 1);
            //    x = ((m / 2) * (Width_Of_Labels + 10)) + 10;

            //    Number_Of_Nodes_In_Rows /= (2 * B_Tree.M);
            //}

            //for (int i = 0; i < Depth_Of_B_Tree; i++)
            //{
            //    if (n == 0)
            //        n = (Width_Of_Labels + 10);
            //    else
            //        n = (2 * (h - 10)) + (Width_Of_Labels + 10);

            //    int xx = x;

            //    for (int j = 0; j < Number_Of_Nodes_In_Rows; j++, s++)
            //    {
            //        B_Tree_Node Node = Stack_Nodes.Pop();
            //       ;

            //       if (Node == null)
            //       {
            //           string ss = "";
            //           for (int k = 0; k < 2 * B_Tree.M; k++)
            //               ss += ".   ";
            //           ss += ".";

            //           Label[s].Text = ss;
            //           Label[s].Location = new Point(x, y);
            //           Label[s].Visible = true;
            //       }
            //       else
            //       {
            //           Label[s].Text = Node.Print_For_Graphical_Enviroment();
            //           Label[s].Location = new Point(x, y);
            //           Label[s].Visible = true;
            //       }

            //        x -= n;
            //    }

            //    y -= (Height_Of_Labels + 10);

            //    m = (int)Math.Pow((2 * B_Tree.M - 1), i + 1);
            //    x = xx - ((m / 2) * (Width_Of_Labels + 10)) + 10;
            //    h = ((m / 2) * (Width_Of_Labels + 10)) + 10;

            //    Number_Of_Nodes_In_Rows /= (2 * B_Tree.M);
            //}
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
