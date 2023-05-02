namespace B_Tree
{
    partial class Graphical_Enviroment_Form
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
            this.Show_Graphical_B_Tree_Label1 = new System.Windows.Forms.Label();
            this.Graphical_Enviroment_Panel = new System.Windows.Forms.Panel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Show_Graphical_B_Tree_Label1
            // 
            this.Show_Graphical_B_Tree_Label1.Font = new System.Drawing.Font("Hobo Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Graphical_B_Tree_Label1.Location = new System.Drawing.Point(25, 25);
            this.Show_Graphical_B_Tree_Label1.Name = "Show_Graphical_B_Tree_Label1";
            this.Show_Graphical_B_Tree_Label1.Size = new System.Drawing.Size(342, 36);
            this.Show_Graphical_B_Tree_Label1.TabIndex = 1;
            this.Show_Graphical_B_Tree_Label1.Text = "Show Graphical B-Tree :";
            // 
            // Graphical_Enviroment_Panel
            // 
            this.Graphical_Enviroment_Panel.AutoScroll = true;
            this.Graphical_Enviroment_Panel.Location = new System.Drawing.Point(48, 80);
            this.Graphical_Enviroment_Panel.Name = "Graphical_Enviroment_Panel";
            this.Graphical_Enviroment_Panel.Size = new System.Drawing.Size(892, 346);
            this.Graphical_Enviroment_Panel.TabIndex = 2;
            // 
            // OK_Button
            // 
            this.OK_Button.BackgroundImage = global::B_Tree.Properties.Resources.Message;
            this.OK_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OK_Button.FlatAppearance.BorderSize = 0;
            this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_Button.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_Button.Location = new System.Drawing.Point(878, 452);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(98, 34);
            this.OK_Button.TabIndex = 10;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Graphical_Enviroment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(988, 498);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Graphical_Enviroment_Panel);
            this.Controls.Add(this.Show_Graphical_B_Tree_Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Graphical_Enviroment_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphical_Enviroment_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Show_Graphical_B_Tree_Label1;
        private System.Windows.Forms.Panel Graphical_Enviroment_Panel;
        private System.Windows.Forms.Button OK_Button;
    }
}