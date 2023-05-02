namespace B_Tree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.B_Tree_Panel = new System.Windows.Forms.Panel();
            this.Output_Label = new System.Windows.Forms.Label();
            this.Input_Label = new System.Windows.Forms.Label();
            this.Create_B_Tree_Button = new System.Windows.Forms.Button();
            this.Show_B_Tree_Button = new System.Windows.Forms.Button();
            this.About_B_Tree_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Create_B_Tree_Panel = new System.Windows.Forms.Panel();
            this.Create_Button = new System.Windows.Forms.Button();
            this.Browse_Button = new System.Windows.Forms.Button();
            this.Create_B_Tree_Label5 = new System.Windows.Forms.Label();
            this.Create_B_Tree_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Create_B_Tree_Label4 = new System.Windows.Forms.Label();
            this.M_TextBox = new System.Windows.Forms.TextBox();
            this.Create_B_Tree_Label3 = new System.Windows.Forms.Label();
            this.Create_B_Tree_RadioButton2 = new System.Windows.Forms.RadioButton();
            this.Create_B_Tree_RadioButton1 = new System.Windows.Forms.RadioButton();
            this.Create_B_Tree_Label1 = new System.Windows.Forms.Label();
            this.Create_B_Tree_Label2 = new System.Windows.Forms.Label();
            this.Show_B_Tree_Panel = new System.Windows.Forms.Panel();
            this.Show_Graphical_Enviroment_Button = new System.Windows.Forms.Button();
            this.Show_B_Tree_Label5 = new System.Windows.Forms.Label();
            this.Show_B_Tree_Label3 = new System.Windows.Forms.Label();
            this.Show_Text_File_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Show_B_Tree_Label4 = new System.Windows.Forms.Label();
            this.Show_B_Tree_Label2 = new System.Windows.Forms.Label();
            this.Show_B_Tree_Label1 = new System.Windows.Forms.Label();
            this.About_B_Tree_Panel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.About_B_Tree_Label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.B_Tree_Panel.SuspendLayout();
            this.Create_B_Tree_Panel.SuspendLayout();
            this.Show_B_Tree_Panel.SuspendLayout();
            this.About_B_Tree_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Tree_Panel
            // 
            this.B_Tree_Panel.BackColor = System.Drawing.Color.White;
            this.B_Tree_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Tree_Panel.BackgroundImage")));
            this.B_Tree_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Tree_Panel.Controls.Add(this.Output_Label);
            this.B_Tree_Panel.Controls.Add(this.Input_Label);
            this.B_Tree_Panel.Controls.Add(this.Create_B_Tree_Button);
            this.B_Tree_Panel.Controls.Add(this.Show_B_Tree_Button);
            this.B_Tree_Panel.Controls.Add(this.About_B_Tree_Button);
            this.B_Tree_Panel.Controls.Add(this.Exit_Button);
            this.B_Tree_Panel.Location = new System.Drawing.Point(36, 34);
            this.B_Tree_Panel.Name = "B_Tree_Panel";
            this.B_Tree_Panel.Size = new System.Drawing.Size(717, 179);
            this.B_Tree_Panel.TabIndex = 0;
            // 
            // Output_Label
            // 
            this.Output_Label.BackColor = System.Drawing.Color.Transparent;
            this.Output_Label.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_Label.Location = new System.Drawing.Point(363, 16);
            this.Output_Label.Name = "Output_Label";
            this.Output_Label.Size = new System.Drawing.Size(110, 38);
            this.Output_Label.TabIndex = 5;
            this.Output_Label.Text = "Output";
            // 
            // Input_Label
            // 
            this.Input_Label.BackColor = System.Drawing.Color.Transparent;
            this.Input_Label.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Label.Location = new System.Drawing.Point(275, 16);
            this.Input_Label.Name = "Input_Label";
            this.Input_Label.Size = new System.Drawing.Size(94, 38);
            this.Input_Label.TabIndex = 4;
            this.Input_Label.Text = "Input";
            // 
            // Create_B_Tree_Button
            // 
            this.Create_B_Tree_Button.BackColor = System.Drawing.Color.Transparent;
            this.Create_B_Tree_Button.FlatAppearance.BorderSize = 0;
            this.Create_B_Tree_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Create_B_Tree_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Create_B_Tree_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_B_Tree_Button.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_B_Tree_Button.Location = new System.Drawing.Point(60, 121);
            this.Create_B_Tree_Button.Name = "Create_B_Tree_Button";
            this.Create_B_Tree_Button.Size = new System.Drawing.Size(70, 60);
            this.Create_B_Tree_Button.TabIndex = 3;
            this.Create_B_Tree_Button.Text = "Create B-Tree";
            this.Create_B_Tree_Button.UseVisualStyleBackColor = false;
            this.Create_B_Tree_Button.Click += new System.EventHandler(this.Create_B_Tree_Button_Click);
            this.Create_B_Tree_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Create_B_Tree_Button_MouseDown);
            this.Create_B_Tree_Button.MouseLeave += new System.EventHandler(this.Create_B_Tree_Button_MouseLeave);
            this.Create_B_Tree_Button.MouseHover += new System.EventHandler(this.Create_B_Tree_Button_MouseHover);
            this.Create_B_Tree_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Create_B_Tree_Button_MouseUp);
            // 
            // Show_B_Tree_Button
            // 
            this.Show_B_Tree_Button.BackColor = System.Drawing.Color.Transparent;
            this.Show_B_Tree_Button.FlatAppearance.BorderSize = 0;
            this.Show_B_Tree_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Show_B_Tree_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Show_B_Tree_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_B_Tree_Button.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_B_Tree_Button.Location = new System.Drawing.Point(267, 123);
            this.Show_B_Tree_Button.Name = "Show_B_Tree_Button";
            this.Show_B_Tree_Button.Size = new System.Drawing.Size(90, 56);
            this.Show_B_Tree_Button.TabIndex = 2;
            this.Show_B_Tree_Button.Text = "Show B-Tree";
            this.Show_B_Tree_Button.UseVisualStyleBackColor = false;
            this.Show_B_Tree_Button.Click += new System.EventHandler(this.Show_B_Tree_Button_Click);
            this.Show_B_Tree_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Show_B_Tree_Button_MouseDown);
            this.Show_B_Tree_Button.MouseLeave += new System.EventHandler(this.Show_B_Tree_Button_MouseLeave);
            this.Show_B_Tree_Button.MouseHover += new System.EventHandler(this.Show_B_Tree_Button_MouseHover);
            this.Show_B_Tree_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Show_B_Tree_Button_MouseUp);
            // 
            // About_B_Tree_Button
            // 
            this.About_B_Tree_Button.BackColor = System.Drawing.Color.Transparent;
            this.About_B_Tree_Button.FlatAppearance.BorderSize = 0;
            this.About_B_Tree_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.About_B_Tree_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.About_B_Tree_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_B_Tree_Button.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_B_Tree_Button.Location = new System.Drawing.Point(493, 125);
            this.About_B_Tree_Button.Name = "About_B_Tree_Button";
            this.About_B_Tree_Button.Size = new System.Drawing.Size(71, 55);
            this.About_B_Tree_Button.TabIndex = 1;
            this.About_B_Tree_Button.Text = "About B-Tree";
            this.About_B_Tree_Button.UseVisualStyleBackColor = false;
            this.About_B_Tree_Button.Click += new System.EventHandler(this.About_B_Tree_Button_Click);
            this.About_B_Tree_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.About_B_Tree_Button_MouseDown);
            this.About_B_Tree_Button.MouseLeave += new System.EventHandler(this.About_B_Tree_Button_MouseLeave);
            this.About_B_Tree_Button.MouseHover += new System.EventHandler(this.About_B_Tree_Button_MouseHover);
            this.About_B_Tree_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.About_B_Tree_Button_MouseUp);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Location = new System.Drawing.Point(598, 131);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(61, 43);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            this.Exit_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_Button_MouseDown);
            this.Exit_Button.MouseLeave += new System.EventHandler(this.Exit_Button_MouseLeave);
            this.Exit_Button.MouseHover += new System.EventHandler(this.Exit_Button_MouseHover);
            this.Exit_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Exit_Button_MouseUp);
            // 
            // Create_B_Tree_Panel
            // 
            this.Create_B_Tree_Panel.AutoScroll = true;
            this.Create_B_Tree_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Create_B_Tree_Panel.Controls.Add(this.Create_Button);
            this.Create_B_Tree_Panel.Controls.Add(this.Browse_Button);
            this.Create_B_Tree_Panel.Controls.Add(this.Create_B_Tree_Label5);
            this.Create_B_Tree_Panel.Controls.Add(this.Create_B_Tree_RichTextBox);
            this.Create_B_Tree_Panel.Controls.Add(this.Create_B_Tree_Label4);
            this.Create_B_Tree_Panel.Controls.Add(this.M_TextBox);
            this.Create_B_Tree_Panel.Controls.Add(this.Create_B_Tree_Label3);
            this.Create_B_Tree_Panel.Controls.Add(this.Create_B_Tree_RadioButton2);
            this.Create_B_Tree_Panel.Controls.Add(this.Create_B_Tree_RadioButton1);
            this.Create_B_Tree_Panel.Controls.Add(this.Create_B_Tree_Label1);
            this.Create_B_Tree_Panel.Controls.Add(this.Create_B_Tree_Label2);
            this.Create_B_Tree_Panel.Location = new System.Drawing.Point(36, 286);
            this.Create_B_Tree_Panel.Name = "Create_B_Tree_Panel";
            this.Create_B_Tree_Panel.Size = new System.Drawing.Size(741, 469);
            this.Create_B_Tree_Panel.TabIndex = 1;
            this.Create_B_Tree_Panel.Visible = false;
            // 
            // Create_Button
            // 
            this.Create_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Create_Button.BackgroundImage")));
            this.Create_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Create_Button.FlatAppearance.BorderSize = 0;
            this.Create_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Button.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Button.Location = new System.Drawing.Point(599, 418);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(98, 34);
            this.Create_Button.TabIndex = 10;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            this.Create_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Create_Button_MouseDown);
            this.Create_Button.MouseLeave += new System.EventHandler(this.Create_Button_MouseLeave);
            this.Create_Button.MouseHover += new System.EventHandler(this.Create_Button_MouseHover);
            this.Create_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Create_Button_MouseUp);
            // 
            // Browse_Button
            // 
            this.Browse_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Browse_Button.BackgroundImage")));
            this.Browse_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Browse_Button.FlatAppearance.BorderSize = 0;
            this.Browse_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse_Button.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse_Button.Location = new System.Drawing.Point(57, 200);
            this.Browse_Button.Name = "Browse_Button";
            this.Browse_Button.Size = new System.Drawing.Size(98, 34);
            this.Browse_Button.TabIndex = 9;
            this.Browse_Button.Text = "Browse";
            this.Browse_Button.UseVisualStyleBackColor = true;
            this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
            this.Browse_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Browse_Button_MouseDown);
            this.Browse_Button.MouseLeave += new System.EventHandler(this.Browse_Button_MouseLeave);
            this.Browse_Button.MouseHover += new System.EventHandler(this.Browse_Button_MouseHover);
            this.Browse_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Browse_Button_MouseUp);
            // 
            // Create_B_Tree_Label5
            // 
            this.Create_B_Tree_Label5.BackColor = System.Drawing.Color.White;
            this.Create_B_Tree_Label5.Font = new System.Drawing.Font("Binary ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_B_Tree_Label5.ForeColor = System.Drawing.Color.DarkGray;
            this.Create_B_Tree_Label5.Location = new System.Drawing.Point(161, 202);
            this.Create_B_Tree_Label5.Name = "Create_B_Tree_Label5";
            this.Create_B_Tree_Label5.Size = new System.Drawing.Size(566, 72);
            this.Create_B_Tree_Label5.TabIndex = 8;
            this.Create_B_Tree_Label5.Text = "URL :";
            // 
            // Create_B_Tree_RichTextBox
            // 
            this.Create_B_Tree_RichTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.Create_B_Tree_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Create_B_Tree_RichTextBox.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_B_Tree_RichTextBox.Location = new System.Drawing.Point(54, 309);
            this.Create_B_Tree_RichTextBox.Name = "Create_B_Tree_RichTextBox";
            this.Create_B_Tree_RichTextBox.Size = new System.Drawing.Size(265, 120);
            this.Create_B_Tree_RichTextBox.TabIndex = 7;
            this.Create_B_Tree_RichTextBox.Text = "";
            // 
            // Create_B_Tree_Label4
            // 
            this.Create_B_Tree_Label4.AutoSize = true;
            this.Create_B_Tree_Label4.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_B_Tree_Label4.Location = new System.Drawing.Point(5, 120);
            this.Create_B_Tree_Label4.Name = "Create_B_Tree_Label4";
            this.Create_B_Tree_Label4.Size = new System.Drawing.Size(494, 30);
            this.Create_B_Tree_Label4.TabIndex = 6;
            this.Create_B_Tree_Label4.Text = "You can use two ways for enter your input datas :";
            // 
            // M_TextBox
            // 
            this.M_TextBox.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_TextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.M_TextBox.Location = new System.Drawing.Point(625, 84);
            this.M_TextBox.Name = "M_TextBox";
            this.M_TextBox.Size = new System.Drawing.Size(72, 36);
            this.M_TextBox.TabIndex = 5;
            this.M_TextBox.Text = "1";
            // 
            // Create_B_Tree_Label3
            // 
            this.Create_B_Tree_Label3.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_B_Tree_Label3.Location = new System.Drawing.Point(5, 85);
            this.Create_B_Tree_Label3.Name = "Create_B_Tree_Label3";
            this.Create_B_Tree_Label3.Size = new System.Drawing.Size(614, 30);
            this.Create_B_Tree_Label3.TabIndex = 4;
            this.Create_B_Tree_Label3.Text = "Set a value between 1 to 4 for M to create  a M order B-Tree :";
            // 
            // Create_B_Tree_RadioButton2
            // 
            this.Create_B_Tree_RadioButton2.AutoSize = true;
            this.Create_B_Tree_RadioButton2.Font = new System.Drawing.Font("Binary ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_B_Tree_RadioButton2.Location = new System.Drawing.Point(31, 273);
            this.Create_B_Tree_RadioButton2.Name = "Create_B_Tree_RadioButton2";
            this.Create_B_Tree_RadioButton2.Size = new System.Drawing.Size(288, 30);
            this.Create_B_Tree_RadioButton2.TabIndex = 3;
            this.Create_B_Tree_RadioButton2.TabStop = true;
            this.Create_B_Tree_RadioButton2.Text = "Enter your datas in below box.";
            this.Create_B_Tree_RadioButton2.UseVisualStyleBackColor = true;
            this.Create_B_Tree_RadioButton2.CheckedChanged += new System.EventHandler(this.Create_B_Tree_RadioButton2_CheckedChanged);
            // 
            // Create_B_Tree_RadioButton1
            // 
            this.Create_B_Tree_RadioButton1.AutoSize = true;
            this.Create_B_Tree_RadioButton1.Font = new System.Drawing.Font("Binary ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_B_Tree_RadioButton1.Location = new System.Drawing.Point(31, 166);
            this.Create_B_Tree_RadioButton1.Name = "Create_B_Tree_RadioButton1";
            this.Create_B_Tree_RadioButton1.Size = new System.Drawing.Size(256, 30);
            this.Create_B_Tree_RadioButton1.TabIndex = 2;
            this.Create_B_Tree_RadioButton1.TabStop = true;
            this.Create_B_Tree_RadioButton1.Text = "Upload the input text file .";
            this.Create_B_Tree_RadioButton1.UseVisualStyleBackColor = true;
            this.Create_B_Tree_RadioButton1.CheckedChanged += new System.EventHandler(this.Create_B_Tree_RadioButton1_CheckedChanged);
            // 
            // Create_B_Tree_Label1
            // 
            this.Create_B_Tree_Label1.Font = new System.Drawing.Font("Hobo Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_B_Tree_Label1.Location = new System.Drawing.Point(3, 12);
            this.Create_B_Tree_Label1.Name = "Create_B_Tree_Label1";
            this.Create_B_Tree_Label1.Size = new System.Drawing.Size(220, 36);
            this.Create_B_Tree_Label1.TabIndex = 0;
            this.Create_B_Tree_Label1.Text = "Create B-Tree :";
            // 
            // Create_B_Tree_Label2
            // 
            this.Create_B_Tree_Label2.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_B_Tree_Label2.Location = new System.Drawing.Point(5, 50);
            this.Create_B_Tree_Label2.Name = "Create_B_Tree_Label2";
            this.Create_B_Tree_Label2.Size = new System.Drawing.Size(663, 30);
            this.Create_B_Tree_Label2.TabIndex = 1;
            this.Create_B_Tree_Label2.Text = "Your input datas should be a list from integers between 0 to 255.";
            // 
            // Show_B_Tree_Panel
            // 
            this.Show_B_Tree_Panel.AutoScroll = true;
            this.Show_B_Tree_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Show_B_Tree_Panel.Controls.Add(this.Show_Graphical_Enviroment_Button);
            this.Show_B_Tree_Panel.Controls.Add(this.Show_B_Tree_Label5);
            this.Show_B_Tree_Panel.Controls.Add(this.Show_B_Tree_Label3);
            this.Show_B_Tree_Panel.Controls.Add(this.Show_Text_File_Button);
            this.Show_B_Tree_Panel.Controls.Add(this.Save_Button);
            this.Show_B_Tree_Panel.Controls.Add(this.Show_B_Tree_Label4);
            this.Show_B_Tree_Panel.Controls.Add(this.Show_B_Tree_Label2);
            this.Show_B_Tree_Panel.Controls.Add(this.Show_B_Tree_Label1);
            this.Show_B_Tree_Panel.Location = new System.Drawing.Point(36, 286);
            this.Show_B_Tree_Panel.Name = "Show_B_Tree_Panel";
            this.Show_B_Tree_Panel.Size = new System.Drawing.Size(741, 469);
            this.Show_B_Tree_Panel.TabIndex = 2;
            this.Show_B_Tree_Panel.Visible = false;
            // 
            // Show_Graphical_Enviroment_Button
            // 
            this.Show_Graphical_Enviroment_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_Graphical_Enviroment_Button.BackgroundImage")));
            this.Show_Graphical_Enviroment_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Show_Graphical_Enviroment_Button.FlatAppearance.BorderSize = 0;
            this.Show_Graphical_Enviroment_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Graphical_Enviroment_Button.Font = new System.Drawing.Font("Binary ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Graphical_Enviroment_Button.Location = new System.Drawing.Point(60, 277);
            this.Show_Graphical_Enviroment_Button.Name = "Show_Graphical_Enviroment_Button";
            this.Show_Graphical_Enviroment_Button.Size = new System.Drawing.Size(272, 40);
            this.Show_Graphical_Enviroment_Button.TabIndex = 13;
            this.Show_Graphical_Enviroment_Button.Text = "Show graphical enviroment";
            this.Show_Graphical_Enviroment_Button.UseVisualStyleBackColor = true;
            this.Show_Graphical_Enviroment_Button.Click += new System.EventHandler(this.Show_Graphical_Enviroment_Button_Click);
            this.Show_Graphical_Enviroment_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Show_Graphical_Enviroment_Button_MouseDown);
            this.Show_Graphical_Enviroment_Button.MouseLeave += new System.EventHandler(this.Show_Graphical_Enviroment_Button_MouseLeave);
            this.Show_Graphical_Enviroment_Button.MouseHover += new System.EventHandler(this.Show_Graphical_Enviroment_Button_MouseHover);
            this.Show_Graphical_Enviroment_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Show_Graphical_Enviroment_Button_MouseUp);
            // 
            // Show_B_Tree_Label5
            // 
            this.Show_B_Tree_Label5.AutoSize = true;
            this.Show_B_Tree_Label5.Font = new System.Drawing.Font("Binary ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_B_Tree_Label5.Location = new System.Drawing.Point(30, 242);
            this.Show_B_Tree_Label5.Name = "Show_B_Tree_Label5";
            this.Show_B_Tree_Label5.Size = new System.Drawing.Size(363, 26);
            this.Show_B_Tree_Label5.TabIndex = 12;
            this.Show_B_Tree_Label5.Text = "Show result in a graphical environment :";
            // 
            // Show_B_Tree_Label3
            // 
            this.Show_B_Tree_Label3.AutoSize = true;
            this.Show_B_Tree_Label3.Font = new System.Drawing.Font("Binary ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_B_Tree_Label3.Location = new System.Drawing.Point(30, 94);
            this.Show_B_Tree_Label3.Name = "Show_B_Tree_Label3";
            this.Show_B_Tree_Label3.Size = new System.Drawing.Size(229, 26);
            this.Show_B_Tree_Label3.TabIndex = 11;
            this.Show_B_Tree_Label3.Text = "Show result in a text file :";
            // 
            // Show_Text_File_Button
            // 
            this.Show_Text_File_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show_Text_File_Button.BackgroundImage")));
            this.Show_Text_File_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Show_Text_File_Button.Enabled = false;
            this.Show_Text_File_Button.FlatAppearance.BorderSize = 0;
            this.Show_Text_File_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Text_File_Button.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Text_File_Button.Location = new System.Drawing.Point(162, 129);
            this.Show_Text_File_Button.Name = "Show_Text_File_Button";
            this.Show_Text_File_Button.Size = new System.Drawing.Size(170, 34);
            this.Show_Text_File_Button.TabIndex = 10;
            this.Show_Text_File_Button.Text = "Show text file";
            this.Show_Text_File_Button.UseVisualStyleBackColor = true;
            this.Show_Text_File_Button.Click += new System.EventHandler(this.Show_Text_File_Button_Click);
            this.Show_Text_File_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Show_Text_File_Button_MouseDown);
            this.Show_Text_File_Button.MouseLeave += new System.EventHandler(this.Show_Text_File_Button_MouseLeave);
            this.Show_Text_File_Button.MouseHover += new System.EventHandler(this.Show_Text_File_Button_MouseHover);
            this.Show_Text_File_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Show_Text_File_Button_MouseUp);
            // 
            // Save_Button
            // 
            this.Save_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_Button.BackgroundImage")));
            this.Save_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_Button.FlatAppearance.BorderSize = 0;
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Button.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Button.Location = new System.Drawing.Point(60, 129);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(98, 34);
            this.Save_Button.TabIndex = 9;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            this.Save_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Save_Button_MouseDown);
            this.Save_Button.MouseLeave += new System.EventHandler(this.Save_Button_MouseLeave);
            this.Save_Button.MouseHover += new System.EventHandler(this.Save_Button_MouseHover);
            this.Save_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Save_Button_MouseUp);
            // 
            // Show_B_Tree_Label4
            // 
            this.Show_B_Tree_Label4.BackColor = System.Drawing.Color.White;
            this.Show_B_Tree_Label4.Font = new System.Drawing.Font("Binary ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_B_Tree_Label4.ForeColor = System.Drawing.Color.DarkGray;
            this.Show_B_Tree_Label4.Location = new System.Drawing.Point(58, 166);
            this.Show_B_Tree_Label4.Name = "Show_B_Tree_Label4";
            this.Show_B_Tree_Label4.Size = new System.Drawing.Size(619, 68);
            this.Show_B_Tree_Label4.TabIndex = 8;
            this.Show_B_Tree_Label4.Text = "URL :";
            // 
            // Show_B_Tree_Label2
            // 
            this.Show_B_Tree_Label2.AutoSize = true;
            this.Show_B_Tree_Label2.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_B_Tree_Label2.Location = new System.Drawing.Point(5, 50);
            this.Show_B_Tree_Label2.Name = "Show_B_Tree_Label2";
            this.Show_B_Tree_Label2.Size = new System.Drawing.Size(521, 30);
            this.Show_B_Tree_Label2.TabIndex = 6;
            this.Show_B_Tree_Label2.Text = "You can see result of create B-Tree from two ways :";
            // 
            // Show_B_Tree_Label1
            // 
            this.Show_B_Tree_Label1.Font = new System.Drawing.Font("Hobo Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_B_Tree_Label1.Location = new System.Drawing.Point(3, 12);
            this.Show_B_Tree_Label1.Name = "Show_B_Tree_Label1";
            this.Show_B_Tree_Label1.Size = new System.Drawing.Size(220, 36);
            this.Show_B_Tree_Label1.TabIndex = 0;
            this.Show_B_Tree_Label1.Text = "Show B-Tree :";
            // 
            // About_B_Tree_Panel
            // 
            this.About_B_Tree_Panel.AutoScroll = true;
            this.About_B_Tree_Panel.BackColor = System.Drawing.Color.Transparent;
            this.About_B_Tree_Panel.Controls.Add(this.richTextBox1);
            this.About_B_Tree_Panel.Controls.Add(this.About_B_Tree_Label1);
            this.About_B_Tree_Panel.Location = new System.Drawing.Point(36, 286);
            this.About_B_Tree_Panel.Name = "About_B_Tree_Panel";
            this.About_B_Tree_Panel.Size = new System.Drawing.Size(741, 469);
            this.About_B_Tree_Panel.TabIndex = 3;
            this.About_B_Tree_Panel.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(31, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(677, 382);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // About_B_Tree_Label1
            // 
            this.About_B_Tree_Label1.Font = new System.Drawing.Font("Hobo Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_B_Tree_Label1.Location = new System.Drawing.Point(3, 12);
            this.About_B_Tree_Label1.Name = "About_B_Tree_Label1";
            this.About_B_Tree_Label1.Size = new System.Drawing.Size(220, 36);
            this.About_B_Tree_Label1.TabIndex = 0;
            this.About_B_Tree_Label1.Text = "About B-Tree :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.B_Tree_Panel);
            this.Controls.Add(this.Create_B_Tree_Panel);
            this.Controls.Add(this.About_B_Tree_Panel);
            this.Controls.Add(this.Show_B_Tree_Panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.B_Tree_Panel.ResumeLayout(false);
            this.Create_B_Tree_Panel.ResumeLayout(false);
            this.Create_B_Tree_Panel.PerformLayout();
            this.Show_B_Tree_Panel.ResumeLayout(false);
            this.Show_B_Tree_Panel.PerformLayout();
            this.About_B_Tree_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel B_Tree_Panel;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button About_B_Tree_Button;
        private System.Windows.Forms.Button Create_B_Tree_Button;
        private System.Windows.Forms.Button Show_B_Tree_Button;
        private System.Windows.Forms.Label Output_Label;
        private System.Windows.Forms.Label Input_Label;
        private System.Windows.Forms.Panel Create_B_Tree_Panel;
        private System.Windows.Forms.RadioButton Create_B_Tree_RadioButton2;
        private System.Windows.Forms.RadioButton Create_B_Tree_RadioButton1;
        private System.Windows.Forms.Label Create_B_Tree_Label2;
        private System.Windows.Forms.Label Create_B_Tree_Label1;
        private System.Windows.Forms.RichTextBox Create_B_Tree_RichTextBox;
        private System.Windows.Forms.Label Create_B_Tree_Label4;
        private System.Windows.Forms.TextBox M_TextBox;
        private System.Windows.Forms.Label Create_B_Tree_Label3;
        private System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.Label Create_B_Tree_Label5;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.Panel Show_B_Tree_Panel;
        private System.Windows.Forms.Button Show_Graphical_Enviroment_Button;
        private System.Windows.Forms.Label Show_B_Tree_Label5;
        private System.Windows.Forms.Label Show_B_Tree_Label3;
        private System.Windows.Forms.Button Show_Text_File_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label Show_B_Tree_Label4;
        private System.Windows.Forms.Label Show_B_Tree_Label2;
        private System.Windows.Forms.Label Show_B_Tree_Label1;
        private System.Windows.Forms.Panel About_B_Tree_Panel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label About_B_Tree_Label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

