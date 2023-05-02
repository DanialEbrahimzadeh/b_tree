namespace B_Tree
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.OK_Button = new System.Windows.Forms.Button();
            this.Message_Label2 = new System.Windows.Forms.Label();
            this.Message_Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK_Button
            // 
            this.OK_Button.BackColor = System.Drawing.Color.Transparent;
            this.OK_Button.FlatAppearance.BorderSize = 0;
            this.OK_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OK_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_Button.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_Button.Location = new System.Drawing.Point(186, 169);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(61, 43);
            this.OK_Button.TabIndex = 1;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = false;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.OK_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OK_Button_MouseDown);
            this.OK_Button.MouseLeave += new System.EventHandler(this.OK_Button_MouseLeave);
            this.OK_Button.MouseHover += new System.EventHandler(this.OK_Button_MouseHover);
            this.OK_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OK_Button_MouseUp);
            // 
            // Message_Label2
            // 
            this.Message_Label2.BackColor = System.Drawing.Color.Transparent;
            this.Message_Label2.Font = new System.Drawing.Font("Binary ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_Label2.Location = new System.Drawing.Point(12, 54);
            this.Message_Label2.Name = "Message_Label2";
            this.Message_Label2.Size = new System.Drawing.Size(411, 109);
            this.Message_Label2.TabIndex = 2;
            // 
            // Message_Label1
            // 
            this.Message_Label1.BackColor = System.Drawing.Color.Transparent;
            this.Message_Label1.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_Label1.Location = new System.Drawing.Point(12, 19);
            this.Message_Label1.Name = "Message_Label1";
            this.Message_Label1.Size = new System.Drawing.Size(135, 30);
            this.Message_Label1.TabIndex = 3;
            this.Message_Label1.Text = "Message :";
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 224);
            this.Controls.Add(this.Message_Label1);
            this.Controls.Add(this.Message_Label2);
            this.Controls.Add(this.OK_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Label Message_Label2;
        private System.Windows.Forms.Label Message_Label1;
    }
}