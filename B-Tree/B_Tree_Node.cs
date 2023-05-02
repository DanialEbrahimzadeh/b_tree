using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Tree
{
    public class B_Tree_Node
    {
        private int[] data;
        public int[] Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        private B_Tree_Node[] link;
        public B_Tree_Node[] Link
        {
            get
            {
                return this.link;
            }
            set
            {
                this.link = value;
            }
        }

        private B_Tree_Node parent;
        public B_Tree_Node Parent
        {
            get
            {
                return this.parent;
            }
            set
            {
                this.parent = value;
            }
        }

        private int level;
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }

        private int size;
        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        private int number_of_child;
        public int Number_Of_Child
        {
            get
            {
                return this.number_of_child;
            }
            set
            {
                this.number_of_child = value;
            }
        }

        private string location;
        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        private string child_location;
        public string Child_Location
        {
            get
            {
                return this.child_location;
            }
            set
            {
                this.child_location = value;
            }
        }

        private bool isdivide;
        public bool IsDivide
        {
            get
            {
                return this.isdivide;
            }
            set
            {
                this.isdivide = value;
            }
        }

        private bool iscopy;
        public bool IsCopy
        {
            get
            {
                return this.iscopy;
            }
            set
            {
                this.iscopy = value;
            }
        }

        private bool isorginal;
        public bool IsOrginal
        {
            get
            {
                return this.isorginal;
            }
            set
            {
                this.isorginal = value;
            }
        }

        //constructor of class node
        public B_Tree_Node()
        {
            Data = new int[2];
            Link = new B_Tree_Node[3];
            Level = 0;
            Number_Of_Child = 0;
            Location = "";
            Size = 2;
            IsDivide = false;
            IsCopy = false;
            IsOrginal = false;
        }

        //constructor of class node that give argument
        public B_Tree_Node(int M)
        {
            Data = new int[2 * M];
            Link = new B_Tree_Node[2 * M + 1];
            Level = 0;
            Number_Of_Child = 0;
            Location = "";
            Size = 2 * M;
            IsDivide = false;
            IsCopy = false;
            IsOrginal = false;
        }

        //this function specify that node is root or is not root 
        public bool IsFull(int M)
        {
            if (Number_Of_Child == 2 * M)
                return true;
            return false;
        }

        public bool IsRoot()
        {
            if(this.Parent == null)
                return true;
            return false;
        }

        public void InsertNonFull(int k)
        {
            Data[Number_Of_Child] = k;

            long j = 0;
            int temp = 0;
            for (int index = 1; index <= Number_Of_Child; index++)
            {
                j = index;
                temp = Data[index];
                while ((j > 0) && (Data[j - 1] > temp))
                {
                    Data[j] = Data[j - 1];
                    j = j - 1;
                }
                Data[j] = temp;
            }
        }

        public int Found_Index_Of_Suitable_Link(int k)
        {
            int i;
            for (i = 0; i < Number_Of_Child; i++)
            {
                if (k < Data[i])
                    return i;
            }
            return i;
        }

        //this function return the number of index of node  
        public int Found_Index_Of_Own_Link()
        {
            int i = 0;
            for (i = 0; i < this.parent.Number_Of_Child; i++)
            {
                if (this.Parent.Link[i] == this)
                    return i;
            }
            return i;
        }

        public int Found_Index_Of_K_Link(int k)
        {
            int i = 0;
            for (i = 0; i < Number_Of_Child; i++)
            {
                if (this.Data[i] == k)
                    return i;
            }
            return i;
        }

        //this function return the datas[mid]  
        public int Found_Mid_Of_Datas(int k)
        {
            int mid = 0;
            ArrayList d = new ArrayList();

            for (int i = 0; i < Number_Of_Child; i++)
            {
                d.Add(this.Data[i]);
            }
            d.Add(k);

            d.Sort();

            for (int i = 0, j = 0; i < Number_Of_Child + 1; i++, j++)
            {
                if (i == (Number_Of_Child / 2) + 1)
                {
                    mid = (int)d[i];
                    j--;
                }
                else
                    this.Data[j] = (int)d[i];
            }

            return mid;
        }

        //this function return the datas[first]  
        public int Found_First_Of_Datas(int k)
        {
            int first = 0;
            ArrayList d = new ArrayList();

            for (int i = 0; i < Number_Of_Child; i++)
            {
                d.Add(this.Data[i]);
            }
            d.Add(k);

            d.Sort();

            first = (int)d[0];
            for (int i = 1; i <= Number_Of_Child; i++)
            {
                this.Data[i - 1] = (int)d[i];
            }

            return first;
        }

        //this function return the datas[last]
        public int Found_Last_Of_Datas(int k)
        {
            int last = 0;
            ArrayList d = new ArrayList();

            for (int i = 0; i < Number_Of_Child; i++)
            {
                d.Add(this.Data[i]);
            }
            d.Add(k);

            d.Sort();

            last = (int)d[Number_Of_Child];

            for (int i = 0; i < Number_Of_Child; i++)
                this.Data[i] = (int)d[i];

            return last;
        }

        public int Found_Index_Of_IsDivide_Link()
        {
            int i = 0;
            //for (i = 0; this.Link[i].IsDivide != true; i++) ;
            for (i = 0; i < this.Number_Of_Child; i++)
            {
                if (this.Link[i] != null)
                    if (this.Link[i].IsDivide == true)
                        return i;
            }
            return i;
        }

        public void Insert_In_Left_Neighbour(int First)
        {
            B_Tree_Node p = this.Parent;
            ArrayList d = new ArrayList();
            int index = 0;

            for (int i = 0; i < p.Number_Of_Child; i++)
                d.Add(p.Data[i]);

            d.Add(First);

            d.Sort();

            for (int i = 0; i < p.Number_Of_Child + 1; i++)
                if ((int)d[i] == First)
                    index = i;

            p.Link[index - 1].Data[p.Link[index - 1].Number_Of_Child] = p.Data[index - 1];
            p.Link[index - 1].Number_Of_Child++;

            p.Data[index - 1] = First;
        }

        public void Insert_In_Right_Neighbour(int Last)
        {
            B_Tree_Node p = this.Parent;
            ArrayList d = new ArrayList();
            int index = 0;

            for (int i = 0; i < p.Number_Of_Child; i++)
                d.Add(p.Data[i]);

            d.Add(Last);

            d.Sort();

            for (int i = 0; i < p.Number_Of_Child + 1; i++)
                if ((int)d[i] == Last)
                    index = i;

            d.Clear();
            for (int i = 0; i < p.Link[index + 1].Number_Of_Child; i++)
                d.Add(p.Link[index + 1].Data[i]);

            d.Add(p.Data[index]);

            d.Sort();

            for (int i = 0; i <= p.Link[index + 1].Number_Of_Child; i++)
                p.Link[index + 1].Data[i] = (int)d[i];

            p.Link[index + 1].Number_Of_Child++;

            p.Data[index] = Last;
        }

        public void Divide(int k)
        {
            B_Tree_Node child1 = new B_Tree_Node(Size/2);
            B_Tree_Node child2 = new B_Tree_Node(Size/2);
            ArrayList d = new ArrayList();

            for (int i = 0; i < Number_Of_Child; i++)
                d.Add(Data[i]);

            d.Add(k);

            d.Sort();

            for (int i = 0; i < Number_Of_Child / 2; i++)
                child1.Data[i] = (int)d[i];

            for (int i = (Number_Of_Child / 2) + 1, j = 0; i <= Number_Of_Child; i++, j++)
                child2.Data[j] = (int)d[i];

            child1.Number_Of_Child = Number_Of_Child / 2;
            child2.Number_Of_Child = Number_Of_Child / 2;

            Data[0] = (int)d[Number_Of_Child / 2];
            Number_Of_Child = 1;

            child1.Parent = this;
            child2.Parent = this;

            Link[0] = child1;
            Link[1] = child2;
        }

        public void Left_Shift()
        {
            for (int j = 1; j < this.Found_Index_Of_IsDivide_Link(); j++)
                this.Link[j - 1] = this.Link[j];
        }

        public void Right_Shift()
        {
            for (int j = Number_Of_Child - 1; j > this.Found_Index_Of_IsDivide_Link(); j--)
                this.Link[j + 1] = this.Link[j];
        }

        public bool Compare(B_Tree_Node c)
        {
            if (this.Number_Of_Child == c.Number_Of_Child)
            {
                for (int i = 0; i < Number_Of_Child; i++)
                    if (this.Data[i] != c.Data[i])
                        return false;
            }
            else
                return false; ;
            return true;
        }

        private string PrintData(int a)
        {
            string s = "";
            s += a.ToString();
            if (a < 10)
                s += "  ";
            else if (a < 100)
                s += " ";
            return s;
        }

        public B_Tree_Node Return_Copy_Of_Node(int Index_Of_This_For_Its_Parent)
        {
            B_Tree_Node result = new B_Tree_Node(Size / 2);

            for (int i = 0; i < this.number_of_child; i++)
                result.Data[i] = this.Data[i];

            for (int i = 0; i <= this.number_of_child; i++)
                result.Link[i] = this.Link[i];

            result.Parent = this.Parent;
            result.Level = this.Level;
            result.Number_Of_Child = this.Number_Of_Child;
            result.Location = this.Location;
            result.Child_Location = this.Child_Location;
            result.Size = this.Size;
            result.IsDivide = false;
            result.IsCopy = false;
            result.IsOrginal = false;
            this.parent.link[Index_Of_This_For_Its_Parent] = result;
            return result;
        }

        public B_Tree_Node Return_Copy_Of_Node()
        {
            B_Tree_Node result = new B_Tree_Node(Size / 2);

            for (int i = 0; i < this.number_of_child; i++)
                result.Data[i] = this.Data[i];

            for (int i = 0; i <= this.number_of_child; i++)
                result.Link[i] = this.Link[i];

            result.Parent = this.Parent;
            result.Level = this.Level;
            result.Number_Of_Child = this.Number_Of_Child;
            result.Location = this.Location;
            result.Child_Location = this.Child_Location;
            result.Size = this.Size;
            result.IsDivide = false;
            result.IsCopy = false;
            result.IsOrginal = false;
         
            return result;
        }
        public string Print()
        {
            string s = "";
            for (int i = 0; i < Size; i++)
            {
                s += ".";
                if (i < Number_Of_Child)
                    s += PrintData(data[i]);
                else
                    s += "   ";
            }
            s += ".;";
            return s;
        }

        public string Print_For_Graphical_Enviroment()
        {
            string s = "";
            for (int i = 0; i < Size; i++)
            {
                s += ".";
                if (i < Number_Of_Child)
                    s += PrintData(data[i]);
                else
                    s += "   ";
            }
            s += ".";
            return s;
        }
    }
}
