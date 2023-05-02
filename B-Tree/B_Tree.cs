using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Tree
{
    public class B_Tree
    {
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

        private B_Tree_Node root;
        public B_Tree_Node Root
        {
            get
            {
                return this.root;
            }
            set
            {
                this.root = value;
            }
        }

        public B_Tree()
        {
            M = 1;
            Root = new B_Tree_Node();
        }

        public B_Tree(int _M)
        {
            M = _M;
            Root = new B_Tree_Node(M);
        }

        public bool IsCreate()
        {
            if (this.Root == null)
                return false;
            return true;
        }

        public int Calculate_Depth_Of_B_Tree()
        {
            B_Tree_Node temp = new B_Tree_Node(M);
            temp = this.Root;

            int i = 0;
            while (temp.Link[0] != null)
            {
                i++;
                temp = temp.Link[0];
            }
            return i + 1;
        }

        public int Calculate_Number_Of_Nodes()
        {
            Queue<B_Tree_Node> Queue_Nodes = new Queue<B_Tree_Node>();
            B_Tree_Node temp = new B_Tree_Node(M);
            int N = 0;

            temp = Root;
            Queue_Nodes.Enqueue(temp);

            while (Queue_Nodes.Count != 0)
            {
                temp = Queue_Nodes.Dequeue();

                for (int j = 0; j < temp.Number_Of_Child + 1; j++)
                    if (temp.Link[j] != null)
                        Queue_Nodes.Enqueue(temp.Link[j]);

                N++;
            }
            return N;
        }

        public void Calculate_Level_Of_nodes()
        {
            int k = 1;
            int level = 0;
  
            Queue<B_Tree_Node> Queue_Nodes = new Queue<B_Tree_Node>();
            B_Tree_Node temp = new B_Tree_Node(M);

            temp = Root;
            temp.Level = 0;
            Queue_Nodes.Enqueue(temp);

            while (Queue_Nodes.Count != 0)
            {
                int i = k;
                k=0;
                for (; i > 0; i--)
                {
                    temp = Queue_Nodes.Dequeue();
                    temp.Level = level;
                    for (int j = 0; j < temp.Number_Of_Child + 1; j++)
                        if (temp.Link[j] != null)
                        {
                            Queue_Nodes.Enqueue(temp.Link[j]);
                            k++;
                        }
                }
                level++;
            }
        }

        public void Set_All_Boolian_False()
        {
            Queue<B_Tree_Node> Queue_Nodes = new Queue<B_Tree_Node>();
            B_Tree_Node temp = new B_Tree_Node(M);

            temp = Root;
            Queue_Nodes.Enqueue(temp);

            while (Queue_Nodes.Count != 0)
            {
                temp = Queue_Nodes.Dequeue();
                temp.IsDivide = false;
                temp.IsOrginal = false;
                temp.IsCopy = false;
                for (int j = 0; j < temp.Number_Of_Child + 1; j++)
                    if (temp.Link[j] != null)
                        Queue_Nodes.Enqueue(temp.Link[j]);
            }
        }

        public void Set_True_Parents()
        {
            Queue<B_Tree_Node> Queue_Nodes = new Queue<B_Tree_Node>();
            B_Tree_Node temp = new B_Tree_Node(M);

            temp = Root;
            Queue_Nodes.Enqueue(temp);

            while (Queue_Nodes.Count != 0)
            {
                temp = Queue_Nodes.Dequeue();
                for (int j = 0; j < temp.Number_Of_Child + 1; j++)
                    if (temp.Link[j] != null)
                    {
                        temp.Link[j].Parent = temp;
                        Queue_Nodes.Enqueue(temp.Link[j]);
                    }
            }
        }

        public List<string> Write_Nodes_To_String_List()
        {
            Calculate_Level_Of_nodes();

            string output = "";

            List<string> String_List = new List<string>();
            Queue<B_Tree_Node> Queue_Nodes = new Queue<B_Tree_Node>();
            B_Tree_Node temp = new B_Tree_Node(M);
            temp = Root;

            Queue_Nodes.Enqueue(temp);

            while (Queue_Nodes.Count != 0)
            {
                output = "";
                temp = Queue_Nodes.Dequeue();

                output = temp.Print();

                if (String_List.Count <= temp.Level)
                    String_List.Add(output);
                else
                    String_List[temp.Level] += output;

                for (int j = 0; j < temp.Number_Of_Child + 1; j++)
                    if (temp.Link[j] != null)
                        Queue_Nodes.Enqueue(temp.Link[j]);
            }
            return String_List;
        }

        public List<List<B_Tree_Node>> Write_Nodes_To_B_Tree_Node_List()
        {
            Calculate_Level_Of_nodes();

            List<List<B_Tree_Node>> Nodes_List = new List<List<B_Tree_Node>>();
            List<B_Tree_Node> List_Temp = new List<B_Tree_Node>();

            Queue<B_Tree_Node> Queue_Nodes = new Queue<B_Tree_Node>();
            B_Tree_Node Node_Temp = new B_Tree_Node(M);

            Node_Temp = Root;
            Queue_Nodes.Enqueue(Node_Temp);

            while (Queue_Nodes.Count != 0)
            {
                Node_Temp = Queue_Nodes.Dequeue();

                if (Nodes_List.Count <= Node_Temp.Level)
                {
                    List_Temp = new List<B_Tree_Node>();
                    List_Temp.Add(Node_Temp);
                    Nodes_List.Add(List_Temp); //Nodes_List[temp.Level + 1].Add(temp); //list.Insert(0, i); // SLOW
                }
                else
                    Nodes_List[Node_Temp.Level].Add(Node_Temp);

                for (int j = 0; j < Node_Temp.Number_Of_Child + 1; j++)
                    if (Node_Temp.Link[j] != null)
                        Queue_Nodes.Enqueue(Node_Temp.Link[j]);

            }
            return Nodes_List;
        }

        public List<List<int>> Write_Number_Of_Child_Of_Nodes_To_Int_List()
        {
            Calculate_Level_Of_nodes();

            List<List<int>> Nodes_Number_Of_Child_List = new List<List<int>>();
            List<int> List_Temp = new List<int>();

            Queue<B_Tree_Node> Queue_Nodes = new Queue<B_Tree_Node>();
            B_Tree_Node Node_Temp = new B_Tree_Node(M);

            Node_Temp = Root;
            Queue_Nodes.Enqueue(Node_Temp);

            while (Queue_Nodes.Count != 0)
            {
                Node_Temp = Queue_Nodes.Dequeue();

                if (Nodes_Number_Of_Child_List.Count <= Node_Temp.Level)
                {
                    List_Temp = new List<int>();
                    List_Temp.Add(Node_Temp.Number_Of_Child + 1);
                    Nodes_Number_Of_Child_List.Add(List_Temp); //Nodes_List[temp.Level + 1].Add(temp); //list.Insert(0, i); // SLOW
                }
                else
                    Nodes_Number_Of_Child_List[Node_Temp.Level].Add(Node_Temp.Number_Of_Child + 1);

                for (int j = 0; j < Node_Temp.Number_Of_Child + 1; j++)
                    if (Node_Temp.Link[j] != null)
                        Queue_Nodes.Enqueue(Node_Temp.Link[j]);

            }
            return Nodes_Number_Of_Child_List;
        }

        public Stack<B_Tree_Node> Adapt_Node_To_Show_Graphical(int D)
        {
            Calculate_Level_Of_nodes();

            Stack<B_Tree_Node> Stack_Nodes = new Stack<B_Tree_Node>();

            Queue<B_Tree_Node> Queue_Nodes = new Queue<B_Tree_Node>();
            B_Tree_Node temp = new B_Tree_Node(M);
            B_Tree_Node N;

            temp = Root;
            Queue_Nodes.Enqueue(temp);

            int level = 0;
            while (Queue_Nodes.Count != 0)
            {
                temp = Queue_Nodes.Dequeue();

                

                Stack_Nodes.Push(temp);

                if (temp != null)
                {
                    if (level == temp.Level)
                        level = temp.Level + 1;
                    for (int j = 0; j < 2 * M + 1; j++)
                        if(level <= D)
                            Queue_Nodes.Enqueue(temp.Link[j]);
                }
                else
                {
                    if(level <= D)
                        Queue_Nodes.Enqueue(temp);
                //    Stack_Nodes.Push(temp);
                }
            }

            return Stack_Nodes;
        }

        public void Write_B_Tree_In_Text_File(string TextFileName)
        {
            List<string> String_List = Write_Nodes_To_String_List();

            FileStream myFile = new FileStream(TextFileName, FileMode.Create, FileAccess.Write);
            StreamWriter Writer_myFile = new StreamWriter(myFile);

            for (int i = 0; i < String_List.Count; i++)
                Writer_myFile.WriteLine(String_List[i]);

            Writer_myFile.Close();
        }

        public void Go_Up_Then_Divide_To_Down(B_Tree_Node temp , int k)
        {    
            int Index_Of_Own_Link, Index_Of_Orginal, Index_Of_Copy, Index_Of_K_Link;
            B_Tree_Node temp1 = new B_Tree_Node(M);
            B_Tree_Node copy_of_temp = new B_Tree_Node(M);
            B_Tree_Node Compare1 = new B_Tree_Node(M);
            B_Tree_Node Compare2 = new B_Tree_Node(M);
            B_Tree_Node Orginal_Of_Compare2 = new B_Tree_Node(M);
            ArrayList d;
            bool Orginal_Copy = false;
            bool Copy_Orginal = false;
            bool Flag = false;

            //Go_Up_Then_Divide_To_Down;
            while (temp != null)
            {
                //if temp is full
                if (temp.IsFull(M))
                {
                    //if temp is not root
                    if (temp.Parent != null)
                    {
                        d = new ArrayList();

                        for (int i = 0; i < temp.Number_Of_Child; i++)
                            d.Add(temp.Data[i]);
                        d.Add(k);

                        d.Sort();

                        for (int i = 0; i < temp.Number_Of_Child / 2; i++)
                            temp.Data[i] = (int)d[i];

                        for (int i = (temp.Number_Of_Child / 2) + 1, j = i - 1; i <= temp.Number_Of_Child; i++, j++)
                            temp.Data[j] = (int)d[i];

                        k = (int)d[temp.Number_Of_Child / 2];

                        temp.IsDivide = true;

                        Index_Of_Own_Link = temp.Found_Index_Of_Own_Link();

                        if (Index_Of_Own_Link < M)
                            temp.Location = "L";
                        else if (Index_Of_Own_Link > M)
                            temp.Location = "R";
                        else
                            temp.Location = "M";

                        if (temp.Link[0] == null)
                            temp.Child_Location = "-";
                        else
                            for (int i = 0; i < 2 * M + 1; i++)
                            {
                                if (temp.Link[i].IsDivide == true)

                                    if (i < M)
                                        temp.Child_Location = "L";
                                    else if (i > M)
                                        temp.Child_Location = "R";
                                    else
                                        temp.Child_Location = "M";
                            }
                    }
                    else//if temp is full and is root
                    {
                        d = new ArrayList();

                        for (int i = 0; i < temp.Number_Of_Child; i++)
                            d.Add(temp.Data[i]);
                        d.Add(k);

                        d.Sort();

                        for (int i = 0; i < temp.Number_Of_Child / 2; i++)
                            temp.Data[i] = (int)d[i];

                        for (int i = (temp.Number_Of_Child / 2) + 1, j = i - 1; i <= temp.Number_Of_Child; i++, j++)
                            temp.Data[j] = (int)d[i];

                        k = (int)d[temp.Number_Of_Child / 2];

                        temp.IsDivide = true;

                        if (temp.Link[0] == null)
                            temp.Child_Location = "-";
                        else
                            for (int i = 0; i < 2 * M + 1; i++)
                                if (temp.Link[i].IsDivide == true)

                                    if (i < M)
                                        temp.Child_Location = "L";
                                    else if (i > M)
                                        temp.Child_Location = "R";
                                    else
                                        temp.Child_Location = "M";

                        //create new root
                        temp1.Data[0] = k;
                        temp1.Number_Of_Child = 1;

                        if (temp.Child_Location.CompareTo("R") == 0) //barabar bashe
                        {
                            temp1.Link[1] = temp;
                            temp1.Child_Location = "R";
                            temp.Location = "R";
                            temp.IsOrginal = true;
                        }
                        else
                        {
                            temp1.Link[0] = temp;
                            temp1.Child_Location = "L";
                            temp.Location = "L";
                            temp.IsOrginal = true;
                        }

                        temp.Parent = temp1;
                        Root = temp1;
                        temp = temp1;
                    }
                }
                else//if temp is not full 
                {
                    //be pedare khali beresim
                    d = new ArrayList();

                    for (int i = 0; i < temp.Number_Of_Child; i++)
                        d.Add(temp.Data[i]);
                    d.Add(k);

                    d.Sort();

                    for (int i = 0; i <= temp.Number_Of_Child; i++)
                        temp.Data[i] = (int)d[i];

                    temp.Number_Of_Child++;

                    Index_Of_K_Link = temp.Found_Index_Of_K_Link(k);

                    temp.Link[Index_Of_K_Link].IsDivide = true;

                    //for (int j = temp.Number_Of_Child - 1; j >= temp.Found_Index_Of_IsDivide_Link(); j--)
                    //    temp.Link[j + 1] = temp.Link[j];
                    temp.Right_Shift();

                    temp.Link[temp.Found_Index_Of_IsDivide_Link() + 1] = temp.Link[temp.Found_Index_Of_IsDivide_Link()].Return_Copy_Of_Node(temp.Found_Index_Of_IsDivide_Link() + 1);
                    int wwwww = temp.Found_Index_Of_IsDivide_Link();
                    //B_Tree_Node t = new B_Tree_Node();
                    //t = temp.Link[temp.Found_Index_Of_IsDivide_Link()];
                    //temp.Link[temp.Found_Index_Of_IsDivide_Link() + 1] = t;

                    temp.Child_Location = "L";
                    Flag = true;

                    goto GOTO_WHILE;
                }//end of else

                copy_of_temp = temp;
                temp = temp.Parent;
            }//end of while

           
            temp = copy_of_temp;

        GOTO_WHILE:
            int ffff = 9;
            while (temp.Child_Location.CompareTo("-") != 0)//barabar nabashe
            {
                switch (temp.Child_Location)
                {
                    case "R":
                        if (temp.Link[temp.Number_Of_Child] != null)
                            temp.Link[0] = null;

                        //shift data to left 
                        temp.Left_Shift();

                        Index_Of_Orginal = temp.Found_Index_Of_IsDivide_Link();
                        Index_Of_Copy = temp.Found_Index_Of_IsDivide_Link() - 1;

                        if (temp.Link[Index_Of_Orginal].Child_Location.CompareTo("R") == 0)
                        {
                            temp.Link[Index_Of_Orginal].IsOrginal = true;

                            temp.Link[Index_Of_Copy] = temp.Link[Index_Of_Orginal].Return_Copy_Of_Node(Index_Of_Copy);
                            temp.Link[Index_Of_Copy].IsCopy = true;

                            // dadehaye akhare copy hazf shavad
                            for (int i = temp.Link[Index_Of_Copy].Number_Of_Child; i > temp.Link[Index_Of_Copy].Number_Of_Child / 2; i--)
                                temp.Link[Index_Of_Copy].Link[i] = null;

                            temp.Link[Index_Of_Copy].Number_Of_Child /= 2;

                            // dadehaye avvale orginal hazf va shift anjam shavad
                            int j = temp.Link[Index_Of_Orginal].Number_Of_Child / 2;
                            for (int i = temp.Link[Index_Of_Orginal].Number_Of_Child / 2; i < temp.Link[Index_Of_Orginal].Number_Of_Child; i++)
                            {
                                temp.Link[Index_Of_Orginal].Data[i - j] = temp.Link[Index_Of_Orginal].Data[i];
                                temp.Link[Index_Of_Orginal].Link[i - j] = temp.Link[Index_Of_Orginal].Link[i];
                                temp.Link[Index_Of_Orginal].Link[i] = null;
                            }
                            temp.Link[Index_Of_Orginal].Link[j] = temp.Link[Index_Of_Orginal].Link[temp.Link[Index_Of_Orginal].Number_Of_Child]; 
                            //temp.Link[Index_Of_Orginal].Link[temp.Link[Index_Of_Orginal].Number_Of_Child / 2] = temp.Link[Index_Of_Orginal].Link[temp.Link[Index_Of_Orginal].Number_Of_Child];
                            temp.Link[Index_Of_Orginal].Link[temp.Link[Index_Of_Orginal].Number_Of_Child] = null;

                            temp.Link[Index_Of_Orginal].Number_Of_Child /= 2;
                          //  temp.Link[Index_Of_Copy].Number_Of_Child /= 2;

                            temp = temp.Link[Index_Of_Orginal];
                        }
                        else
                        {
                            Index_Of_Copy = temp.Found_Index_Of_IsDivide_Link();
                            Index_Of_Orginal = temp.Found_Index_Of_IsDivide_Link() - 1;

                            temp.Link[Index_Of_Copy].IsCopy = true;

                            temp.Link[Index_Of_Orginal] = temp.Link[temp.Found_Index_Of_IsDivide_Link()].Return_Copy_Of_Node(Index_Of_Orginal);
                            temp.Link[Index_Of_Orginal].IsOrginal = true;

                            // dadehaye akhare orginal hazf shavad
                            for (int i = temp.Link[Index_Of_Orginal].Number_Of_Child; i > temp.Link[Index_Of_Orginal].Number_Of_Child / 2; i--)
                                temp.Link[Index_Of_Orginal].Link[i] = null;

                            temp.Link[Index_Of_Orginal].Number_Of_Child /= 2;

                            // dadehaye avvale copy hazf shavad va shift dade shavand
                            int j = temp.Link[Index_Of_Copy].Number_Of_Child / 2;
                            for (int i = temp.Link[Index_Of_Copy].Number_Of_Child / 2; i < temp.Link[Index_Of_Copy].Number_Of_Child; i++)
                            {
                                temp.Link[Index_Of_Copy].Data[i - j] = temp.Link[Index_Of_Copy].Data[i];
                                temp.Link[Index_Of_Copy].Link[i - j] = temp.Link[Index_Of_Copy].Link[i];
                                temp.Link[Index_Of_Copy].Link[i] = null;
                            }
                            temp.Link[Index_Of_Copy].Link[j] = temp.Link[Index_Of_Copy].Link[temp.Link[Index_Of_Copy].Number_Of_Child];
                            temp.Link[Index_Of_Copy].Link[temp.Link[Index_Of_Copy].Number_Of_Child] = null;

                            //temp.Link[Index_Of_Orginal].Number_Of_Child /= 2;
                            temp.Link[Index_Of_Copy].Number_Of_Child /= 2;

                            temp = temp.Link[Index_Of_Orginal];
                        }

                        break;
                    case "L":

                        if(Flag == false)
                        {
                            temp.Link[temp.Number_Of_Child] = null;
                            temp.Right_Shift();
                        }
                        Flag = false;

                        Index_Of_Orginal = temp.Found_Index_Of_IsDivide_Link() + 1;
                        Index_Of_Copy = temp.Found_Index_Of_IsDivide_Link();

                        temp.Link[Index_Of_Orginal] = temp.Link[temp.Found_Index_Of_IsDivide_Link()].Return_Copy_Of_Node(Index_Of_Orginal);

                        if (temp.Link[Index_Of_Orginal].Child_Location.CompareTo("R") == 0)
                        {
                            temp.Link[Index_Of_Orginal].IsOrginal = true;

                            temp.Link[Index_Of_Copy] = temp.Link[Index_Of_Orginal].Return_Copy_Of_Node(Index_Of_Copy);
                            temp.Link[Index_Of_Copy].IsCopy = true;

                            // dadehaye akhare copy hazf shavad
                            for (int i = temp.Link[Index_Of_Copy].Number_Of_Child; i > temp.Link[Index_Of_Copy].Number_Of_Child / 2; i--)
                                temp.Link[Index_Of_Copy].Link[i] = null;

                            temp.Link[Index_Of_Copy].Number_Of_Child /= 2;

                            // dadehaye avvale orginal hazf va shift anjam shavad
                            int j = temp.Link[Index_Of_Orginal].Number_Of_Child / 2;
                            for (int i = temp.Link[Index_Of_Orginal].Number_Of_Child / 2; i < temp.Link[Index_Of_Orginal].Number_Of_Child; i++)
                            {
                                temp.Link[Index_Of_Orginal].Data[i - j] = temp.Link[Index_Of_Orginal].Data[i];
                                temp.Link[Index_Of_Orginal].Link[i - j] = temp.Link[Index_Of_Orginal].Link[i];
                                temp.Link[Index_Of_Orginal].Link[i] = null;
                            }
                            temp.Link[Index_Of_Orginal].Link[temp.Link[Index_Of_Orginal].Number_Of_Child / 2] = temp.Link[Index_Of_Orginal].Link[temp.Link[Index_Of_Orginal].Number_Of_Child];
                            temp.Link[Index_Of_Orginal].Link[temp.Link[Index_Of_Orginal].Number_Of_Child] = null;

                            temp.Link[Index_Of_Orginal].Number_Of_Child /= 2;
                           // temp.Link[Index_Of_Copy].Number_Of_Child /= 2;

                            temp = temp.Link[Index_Of_Orginal];
                        }
                        else
                        {
                            Index_Of_Copy = temp.Found_Index_Of_IsDivide_Link() + 1;
                            Index_Of_Orginal = temp.Found_Index_Of_IsDivide_Link();


                            temp.Link[Index_Of_Copy].IsCopy = true;

                            temp.Link[Index_Of_Orginal] = temp.Link[temp.Found_Index_Of_IsDivide_Link()];
                            temp.Link[Index_Of_Orginal].IsOrginal = true;

                            // dadehaye akhare orginal hazf shavad
                            for (int i = temp.Link[Index_Of_Orginal].Number_Of_Child; i > temp.Link[Index_Of_Orginal].Number_Of_Child / 2; i--)
                                temp.Link[Index_Of_Orginal].Link[i] = null;

                            temp.Link[Index_Of_Orginal].Number_Of_Child /= 2;
                            int eee = 9;
                            // dadehaye avvale copy hazf shavad va shift dade shavand
                            int j = temp.Link[Index_Of_Copy].Number_Of_Child / 2;
                            for (int i = temp.Link[Index_Of_Copy].Number_Of_Child / 2; i < temp.Link[Index_Of_Copy].Number_Of_Child; i++)
                            {
                                temp.Link[Index_Of_Copy].Data[i - j] = temp.Link[Index_Of_Copy].Data[i];
                                temp.Link[Index_Of_Copy].Link[i - j] = temp.Link[Index_Of_Copy].Link[i];
                                temp.Link[Index_Of_Copy].Link[i] = null;
                            }
                            temp.Link[Index_Of_Copy].Link[temp.Link[Index_Of_Copy].Number_Of_Child / 2] = temp.Link[Index_Of_Copy].Link[temp.Link[Index_Of_Copy].Number_Of_Child];
                            temp.Link[Index_Of_Copy].Link[temp.Link[Index_Of_Copy].Number_Of_Child] = null;

                     //       temp.Link[Index_Of_Orginal].Number_Of_Child /= 2;
                            temp.Link[Index_Of_Copy].Number_Of_Child /= 2;

                            temp = temp.Link[Index_Of_Orginal];
                        }
                        break;
                    case "M":

                        Orginal_Copy = false;
                        Copy_Orginal = false;

                        Compare1 = temp.Link[temp.Found_Index_Of_IsDivide_Link()];
                        Compare2 = temp;

                        while (Compare2.Child_Location.CompareTo("M") == 0)
                        {
                            Compare2 = Compare2.Parent;
                        }//end of while

                        int c = 0;
                        if (Compare2.Link[Compare2.Found_Index_Of_IsDivide_Link()].IsOrginal == true)
                        {
                            Orginal_Copy = true;
                            c = Compare2.Found_Index_Of_IsDivide_Link() + 1;
                        }
                        else
                        {
                            Copy_Orginal = true;
                            c = Compare2.Found_Index_Of_IsDivide_Link();
                        }
                        //it is not true for ever
                        if (Compare2.Link[c].Compare(Compare1) == true)
                        {
                            if (Orginal_Copy == true)
                            {
                                //dadehaye avvale copy hazf shavad
                                int j = Compare2.Link[c].Number_Of_Child / 2;
                                for (int i = Compare2.Link[c].Number_Of_Child / 2; i < Compare2.Link[c].Number_Of_Child; i++)
                                {
                                    Compare2.Link[c].Data[i - j] = Compare2.Link[c].Data[i];
                                    Compare2.Link[c].Link[i - j] = Compare2.Link[c].Link[i];
                                    Compare2.Link[c].Link[i] = null;
                                }
                                Compare2.Link[c].Link[j] = Compare2.Link[c].Link[Compare2.Link[c].Number_Of_Child];
                                Compare2.Link[c].Link[Compare2.Link[c].Number_Of_Child] = null;
                                Compare2.Link[c].Number_Of_Child /= 2;

                                // dadehaye akhare orginal hazf shavad
                                for (int i = Compare1.Number_Of_Child; i > Compare1.Number_Of_Child / 2; i--)
                                    Compare1.Link[i] = null;

                                Compare1.Number_Of_Child /= 2;
                            }

                            if (Copy_Orginal == true)
                            {
                                // dadehaye akhare copy hazf shavad
                                for (int i = Compare2.Link[c].Number_Of_Child; i > Compare2.Link[c].Number_Of_Child / 2; i--)
                                    Compare2.Link[c].Link[i] = null;

                                Compare2.Link[c].Number_Of_Child /= 2;


                                //dadehaye avvale orginal hazf shavad
                                int j = Compare1.Number_Of_Child / 2;
                                for (int i = Compare1.Number_Of_Child / 2; i < Compare1.Number_Of_Child; i++)
                                {
                                    Compare1.Data[i - j] = Compare1.Data[i];
                                    Compare1.Link[i - j] = Compare1.Link[i];
                                    Compare1.Link[i] = null;
                                }
                                Compare1.Link[Compare1.Number_Of_Child / 2] = Compare1.Link[Compare1.Number_Of_Child];
                                Compare1.Link[Compare1.Number_Of_Child] = null;
                                Compare1.Number_Of_Child /= 2;
                            }
                        }//end of if
                        else
                        {
                            Orginal_Of_Compare2 = Compare2.Link[c];   ////////////////////////////compare2 ro taghir midim badan mirizim sare jash
                            Compare2 = Compare2.Link[c].Return_Copy_Of_Node();
                            while (Compare2.Link[Compare2.Found_Index_Of_IsDivide_Link()].Compare(Compare1) == false)
                            {
                                Orginal_Of_Compare2 = Orginal_Of_Compare2.Link[Orginal_Of_Compare2.Found_Index_Of_IsDivide_Link()];
                                Compare2 = Compare2.Link[Compare2.Found_Index_Of_IsDivide_Link()];
                            }
                          //  Orginal_Of_Compare2 = Orginal_Of_Compare2.Link[Orginal_Of_Compare2.Found_Index_Of_IsDivide_Link()];
                            Compare2 = Compare2.Link[Compare2.Found_Index_Of_IsDivide_Link()].Return_Copy_Of_Node();

                            if (Orginal_Copy == true)
                            {
                                //dadehaye avvale copy hazf shavad
                                int j = Compare2.Number_Of_Child / 2;
                                for (int i = Compare2.Number_Of_Child / 2; i < Compare2.Number_Of_Child; i++)
                                {
                                    Compare2.Data[i - j] = Compare2.Data[i];
                                    Compare2.Link[i - j] = Compare2.Link[i];
                                    Compare2.Link[i] = null;
                                }
                                Compare2.Link[Compare2.Number_Of_Child / 2] = Compare2.Link[Compare2.Number_Of_Child];
                                Compare2.Link[Compare2.Number_Of_Child] = null;
                                Compare2.Number_Of_Child /= 2;

                                // dadehaye akhare orginal hazf shavad
                                for (int i = Compare1.Number_Of_Child; i > Compare1.Number_Of_Child / 2; i--)
                                    Compare1.Link[i] = null;

                                Compare1.Number_Of_Child /= 2;
                            }

                            if (Copy_Orginal == true)
                            {
                                // dadehaye akhare copy hazf shavad
                                for (int i = Compare2.Number_Of_Child; i > Compare2.Number_Of_Child / 2; i--)
                                    Compare2.Link[i] = null;

                                Compare2.Number_Of_Child /= 2;

                              

                                //dadehaye avvale orginal hazf shavad
                                int j = Compare1.Number_Of_Child / 2;
                                for (int i = Compare1.Number_Of_Child / 2; i < Compare1.Number_Of_Child; i++)
                                {
                                    Compare1.Data[i - j] = Compare1.Data[i];
                                    Compare1.Link[i - j] = Compare1.Link[i];
                                    Compare1.Link[i] = null;
                                }
                                Compare1.Link[Compare1.Number_Of_Child / 2] = Compare1.Link[Compare1.Number_Of_Child];
                                Compare1.Link[Compare1.Number_Of_Child] = null;
                                Compare1.Number_Of_Child /= 2;
                            }

                        }
                          Orginal_Of_Compare2.Link[Orginal_Of_Compare2.Found_Index_Of_IsDivide_Link()] = Compare2; /////////////////////////////////////////////
                        temp = temp.Link[temp.Found_Index_Of_IsDivide_Link()];
                        break;
                    default:
                        break;
                }
            }//end of while
        }

        public void Insert(List<int> keys)
        {
            #region data for insert function

            int k, Index_Of_Suitable_Link, Index_Of_Own_Link, First, Last;
            B_Tree_Node temp = new B_Tree_Node(M);
            B_Tree_Node temp1 = new B_Tree_Node(M);
            B_Tree_Node copy_of_temp = new B_Tree_Node(M);
            B_Tree_Node Compare1 = new B_Tree_Node(M);
            B_Tree_Node Compare2 = new B_Tree_Node(M);

            #endregion
            keys.Sort();
            for (int numberOfKeys = 0; numberOfKeys < keys.Count; numberOfKeys++)
            {
                k = keys[numberOfKeys];
                temp = this.Root;
                Set_All_Boolian_False();
                Set_True_Parents();
            First:
                //if temp is not full
                if (temp.IsFull(this.M) == false)
                {
                    //if temp don't have any child
                    if (temp.Link[0] == null)
                    {
                        temp.InsertNonFull(k);
                        temp.Number_Of_Child++;
                    }
                    else//if temp have any child
                    {
                        Index_Of_Suitable_Link = temp.Found_Index_Of_Suitable_Link(k);
                        temp = temp.Link[Index_Of_Suitable_Link];
                        goto First;
                    }
                }
                else//if temp is full
                {
                    //if have any child
                    if (temp.Link[0] != null)
                    {
                        Index_Of_Suitable_Link = temp.Found_Index_Of_Suitable_Link(k);
                        temp = temp.Link[Index_Of_Suitable_Link];
                        goto First;
                    }
                    else //if don't have any child
                    {
                        //if temp have father (is not root)
                        if (temp.Parent != null)
                        {
                            Index_Of_Own_Link = temp.Found_Index_Of_Own_Link();
                            //if temp is last child in children of it's father
                            if (Index_Of_Own_Link == temp.Parent.Number_Of_Child)
                            {
                                //if previous child in children of temp's father is not full 
                                if (temp.Parent.Link[Index_Of_Own_Link - 1].IsFull(M) == false)
                                {
                                    First = temp.Found_First_Of_Datas(k);
                                    temp.Insert_In_Left_Neighbour(First);
                                }
                                else
                                {
                                    Go_Up_Then_Divide_To_Down(temp,k);
                                }
                            }
                            else//if temp is not last child in children of it's father
                            {    //if temp is first child in children of it's father
                                if (Index_Of_Own_Link == 0)
                                {
                                    //if next child in children of temp's father is not full 
                                    if (temp.Parent.Link[Index_Of_Own_Link + 1].IsFull(M) == false)
                                    {
                                        Last = temp.Found_Last_Of_Datas(k);
                                        temp.Insert_In_Right_Neighbour(Last);
                                    }
                                    else
                                    {
                                        Go_Up_Then_Divide_To_Down(temp,k);
                                    }
                                }
                                else//if temp is not last child or first child in children of it's father
                                {
                                    //if previous child in children of temp's father is not full 
                                    if (temp.Parent.Link[Index_Of_Own_Link - 1].IsFull(M) == false)
                                    {
                                        First = temp.Found_First_Of_Datas(k);
                                        temp.Insert_In_Left_Neighbour(First);
                                    }
                                    else//if next child in children of temp's father is full
                                    {
                                        if (temp.Parent.Link[Index_Of_Own_Link + 1].IsFull(M) == false)
                                        {
                                            Last = temp.Found_Last_Of_Datas(k);
                                            temp.Insert_In_Right_Neighbour(Last);
                                        }
                                        else//if next child and previous child in children of temp's father is full 
                                        {
                                            Go_Up_Then_Divide_To_Down(temp,k);
                                        }
                                    }
                                }
                            }
                        }//end of if
                        else //is root and full and don't have any child
                        {
                            temp.Divide(k);
                        }
                    }
                }
            }//end of while
        }
    }
}
