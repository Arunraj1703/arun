namespace UpdateForm
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            registernumber = new TextBox();
            firstname = new TextBox();
            lastname = new TextBox();
            address1 = new TextBox();
            phonenumber = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(253, 28);
            label1.Name = "label1";
            label1.Size = new Size(213, 17);
            label1.TabIndex = 0;
            label1.Text = "UPDATE STUDENT DETAILS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 110);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Register Number";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 173);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 158);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 3;
            label4.Text = "Enter First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 212);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 4;
            label5.Text = "Enter Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 267);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 5;
            label6.Text = "Enter Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 309);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 6;
            label7.Text = "Enter Phone Number";
            // 
            // registernumber
            // 
            registernumber.Location = new Point(239, 110);
            registernumber.Name = "registernumber";
            registernumber.Size = new Size(100, 21);
            registernumber.TabIndex = 7;
            registernumber.TextChanged += registernumber_TextChanged;
            // 
            // firstname
            // 
            firstname.Location = new Point(239, 167);
            firstname.Name = "firstname";
            firstname.Size = new Size(100, 21);
            firstname.TabIndex = 8;
            // 
            // lastname
            // 
            lastname.Location = new Point(239, 212);
            lastname.Name = "lastname";
            lastname.Size = new Size(100, 21);
            lastname.TabIndex = 9;
            // 
            // address1
            // 
            address1.Location = new Point(239, 261);
            address1.Name = "address1";
            address1.Size = new Size(100, 21);
            address1.TabIndex = 10;
            // 
            // phonenumber
            // 
            phonenumber.Location = new Point(239, 309);
            phonenumber.Name = "phonenumber";
            phonenumber.Size = new Size(100, 21);
            phonenumber.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(162, 376);
            button1.Name = "button1";
            button1.Size = new Size(93, 35);
            button1.TabIndex = 12;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(phonenumber);
            Controls.Add(address1);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(registernumber);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "UpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox registernumber;
        private TextBox firstname;
        private TextBox lastname;
        private TextBox address1;
        private TextBox phonenumber;
        private Button button1;
    }
}