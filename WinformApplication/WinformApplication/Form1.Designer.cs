namespace WinformApplication
{
    partial class Form1
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
            registerNumber = new TextBox();
            firstName = new TextBox();
            lastName = new TextBox();
            address = new TextBox();
            phoneNumber = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            male = new RadioButton();
            female = new RadioButton();
            others = new RadioButton();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            errorRegisterNumber = new Label();
            errorFirstName = new Label();
            errorLastName = new Label();
            errorAddress = new Label();
            errorPhoneNumber = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(241, 21);
            label1.Name = "label1";
            label1.Size = new Size(247, 22);
            label1.TabIndex = 0;
            label1.Text = "Student Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.ImageAlign = ContentAlignment.BottomRight;
            label2.Location = new Point(161, 102);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 1;
            label2.Text = "Register Number";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(162, 177);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(161, 244);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(162, 314);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(161, 387);
            label6.Name = "label6";
            label6.Size = new Size(108, 19);
            label6.TabIndex = 5;
            label6.Text = "Phone Number";
            // 
            // registerNumber
            // 
            registerNumber.Location = new Point(378, 102);
            registerNumber.Name = "registerNumber";
            registerNumber.Size = new Size(100, 22);
            registerNumber.TabIndex = 6;
            registerNumber.TextChanged += textBox1_TextChanged;
            // 
            // firstName
            // 
            firstName.Location = new Point(378, 174);
            firstName.Name = "firstName";
            firstName.Size = new Size(100, 22);
            firstName.TabIndex = 7;
            firstName.TextChanged += firstName_TextChanged;
            // 
            // lastName
            // 
            lastName.Location = new Point(378, 241);
            lastName.Name = "lastName";
            lastName.Size = new Size(100, 22);
            lastName.TabIndex = 8;
            lastName.TextChanged += lastName_TextChanged;
            // 
            // address
            // 
            address.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            address.Location = new Point(378, 314);
            address.Name = "address";
            address.Size = new Size(100, 22);
            address.TabIndex = 9;
            // 
            // phoneNumber
            // 
            phoneNumber.Location = new Point(378, 387);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(100, 22);
            phoneNumber.TabIndex = 10;
            phoneNumber.TextChanged += phoneNumber_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Fuchsia;
            button1.Location = new Point(107, 581);
            button1.Name = "button1";
            button1.Size = new Size(83, 30);
            button1.TabIndex = 11;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.AntiqueWhite;
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Fuchsia;
            button2.Location = new Point(257, 581);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 12;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.AntiqueWhite;
            button3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Fuchsia;
            button3.Location = new Point(426, 581);
            button3.Name = "button3";
            button3.Size = new Size(88, 30);
            button3.TabIndex = 13;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.AntiqueWhite;
            button4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Magenta;
            button4.Location = new Point(586, 581);
            button4.Name = "button4";
            button4.Size = new Size(93, 30);
            button4.TabIndex = 14;
            button4.Text = "SELECT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(161, 465);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 15;
            label7.Text = "Gender";
            // 
            // male
            // 
            male.AutoSize = true;
            male.ForeColor = Color.Blue;
            male.Location = new Point(378, 466);
            male.Name = "male";
            male.Size = new Size(52, 19);
            male.TabIndex = 16;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.ForeColor = Color.Blue;
            female.Location = new Point(465, 467);
            female.Name = "female";
            female.Size = new Size(64, 19);
            female.TabIndex = 17;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // others
            // 
            others.AutoSize = true;
            others.ForeColor = Color.Blue;
            others.Location = new Point(567, 467);
            others.Name = "others";
            others.Size = new Size(64, 19);
            others.TabIndex = 18;
            others.TabStop = true;
            others.Text = "Others";
            others.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(161, 520);
            label8.Name = "label8";
            label8.Size = new Size(101, 19);
            label8.TabIndex = 19;
            label8.Text = "Date Of Birth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(378, 517);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 22);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // errorRegisterNumber
            // 
            errorRegisterNumber.AutoSize = true;
            errorRegisterNumber.BackColor = Color.Transparent;
            errorRegisterNumber.ForeColor = Color.Black;
            errorRegisterNumber.Location = new Point(378, 138);
            errorRegisterNumber.Name = "errorRegisterNumber";
            errorRegisterNumber.Size = new Size(10, 15);
            errorRegisterNumber.TabIndex = 21;
            errorRegisterNumber.Text = ".";
            // 
            // errorFirstName
            // 
            errorFirstName.AutoSize = true;
            errorFirstName.ForeColor = Color.Black;
            errorFirstName.Location = new Point(378, 213);
            errorFirstName.Name = "errorFirstName";
            errorFirstName.Size = new Size(10, 15);
            errorFirstName.TabIndex = 22;
            errorFirstName.Text = ".";
            // 
            // errorLastName
            // 
            errorLastName.AutoSize = true;
            errorLastName.ForeColor = Color.Black;
            errorLastName.Location = new Point(378, 279);
            errorLastName.Name = "errorLastName";
            errorLastName.Size = new Size(10, 15);
            errorLastName.TabIndex = 23;
            errorLastName.Text = ".";
            // 
            // errorAddress
            // 
            errorAddress.AutoSize = true;
            errorAddress.ForeColor = Color.Black;
            errorAddress.Location = new Point(383, 348);
            errorAddress.Name = "errorAddress";
            errorAddress.Size = new Size(10, 15);
            errorAddress.TabIndex = 24;
            errorAddress.Text = ".";
            // 
            // errorPhoneNumber
            // 
            errorPhoneNumber.AutoSize = true;
            errorPhoneNumber.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            errorPhoneNumber.ForeColor = Color.Black;
            errorPhoneNumber.Location = new Point(388, 423);
            errorPhoneNumber.Name = "errorPhoneNumber";
            errorPhoneNumber.Size = new Size(10, 15);
            errorPhoneNumber.TabIndex = 25;
            errorPhoneNumber.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 647);
            Controls.Add(errorPhoneNumber);
            Controls.Add(errorAddress);
            Controls.Add(errorLastName);
            Controls.Add(errorFirstName);
            Controls.Add(errorRegisterNumber);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(others);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(phoneNumber);
            Controls.Add(address);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(registerNumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.SlateBlue;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private TextBox registerNumber;
        private TextBox firstName;
        private TextBox lastName;
        private TextBox address;
        private TextBox phoneNumber;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private RadioButton male;
        private RadioButton female;
        private RadioButton others;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label errorRegisterNumber;
        private Label errorFirstName;
        private Label errorLastName;
        private Label errorAddress;
        private Label errorPhoneNumber;
    }
}