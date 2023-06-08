namespace WinformApplication
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            registernumber = new TextBox();
            firstname = new TextBox();
            lastname = new TextBox();
            address1 = new TextBox();
            phonenumber = new TextBox();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            male = new RadioButton();
            female = new RadioButton();
            others = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            errorregisterNumber = new Label();
            errorfirstName = new Label();
            errorlastName = new Label();
            Erroraddress = new Label();
            errorphoneNumber = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(249, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 19);
            label1.TabIndex = 0;
            label1.Text = "UPDATE STUDENT FORM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(126, 98);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Register Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(126, 170);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(127, 253);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 3;
            label4.Text = "Enter Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(126, 337);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 4;
            label5.Text = "Enter Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(126, 416);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 5;
            label6.Text = "Enter Phone Number";
            // 
            // registernumber
            // 
            registernumber.Location = new Point(304, 95);
            registernumber.Name = "registernumber";
            registernumber.Size = new Size(100, 23);
            registernumber.TabIndex = 6;
            registernumber.TextChanged += textBox1_TextChanged;
            // 
            // firstname
            // 
            firstname.Location = new Point(304, 170);
            firstname.Name = "firstname";
            firstname.Size = new Size(100, 23);
            firstname.TabIndex = 7;
            // 
            // lastname
            // 
            lastname.Location = new Point(304, 253);
            lastname.Name = "lastname";
            lastname.Size = new Size(100, 23);
            lastname.TabIndex = 8;
            // 
            // address1
            // 
            address1.Location = new Point(304, 334);
            address1.Name = "address1";
            address1.Size = new Size(100, 23);
            address1.TabIndex = 9;
            // 
            // phonenumber
            // 
            phonenumber.Location = new Point(304, 408);
            phonenumber.Name = "phonenumber";
            phonenumber.Size = new Size(100, 23);
            phonenumber.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(249, 625);
            button1.Name = "button1";
            button1.Size = new Size(135, 39);
            button1.TabIndex = 11;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(200, 51);
            label7.Name = "label7";
            label7.Size = new Size(309, 17);
            label7.TabIndex = 12;
            label7.Text = "Using Register Number Your Details can be Edit";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(127, 486);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 13;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(126, 559);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 14;
            label9.Text = "Date Of Birth";
            // 
            // male
            // 
            male.AutoSize = true;
            male.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            male.ForeColor = Color.Blue;
            male.Location = new Point(304, 482);
            male.Name = "male";
            male.Size = new Size(52, 19);
            male.TabIndex = 15;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            female.ForeColor = Color.Blue;
            female.Location = new Point(389, 482);
            female.Name = "female";
            female.Size = new Size(62, 19);
            female.TabIndex = 16;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // others
            // 
            others.AutoSize = true;
            others.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            others.ForeColor = Color.Blue;
            others.Location = new Point(494, 482);
            others.Name = "others";
            others.Size = new Size(61, 19);
            others.TabIndex = 17;
            others.TabStop = true;
            others.Text = "Others";
            others.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(294, 559);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 22);
            dateTimePicker1.TabIndex = 18;
            // 
            // errorregisterNumber
            // 
            errorregisterNumber.AutoSize = true;
            errorregisterNumber.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            errorregisterNumber.ForeColor = Color.Black;
            errorregisterNumber.Location = new Point(304, 130);
            errorregisterNumber.Name = "errorregisterNumber";
            errorregisterNumber.Size = new Size(10, 15);
            errorregisterNumber.TabIndex = 19;
            errorregisterNumber.Text = ".";
            // 
            // errorfirstName
            // 
            errorfirstName.AutoSize = true;
            errorfirstName.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            errorfirstName.ForeColor = Color.Black;
            errorfirstName.Location = new Point(304, 207);
            errorfirstName.Name = "errorfirstName";
            errorfirstName.Size = new Size(10, 15);
            errorfirstName.TabIndex = 20;
            errorfirstName.Text = ".";
            // 
            // errorlastName
            // 
            errorlastName.AutoSize = true;
            errorlastName.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            errorlastName.ForeColor = Color.Black;
            errorlastName.Location = new Point(304, 296);
            errorlastName.Name = "errorlastName";
            errorlastName.Size = new Size(10, 15);
            errorlastName.TabIndex = 21;
            errorlastName.Text = ".";
            // 
            // Erroraddress
            // 
            Erroraddress.AutoSize = true;
            Erroraddress.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Erroraddress.ForeColor = Color.Black;
            Erroraddress.Location = new Point(304, 370);
            Erroraddress.Name = "Erroraddress";
            Erroraddress.Size = new Size(10, 15);
            Erroraddress.TabIndex = 22;
            Erroraddress.Text = ".";
            // 
            // errorphoneNumber
            // 
            errorphoneNumber.AutoSize = true;
            errorphoneNumber.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            errorphoneNumber.ForeColor = Color.Black;
            errorphoneNumber.Location = new Point(304, 449);
            errorphoneNumber.Name = "errorphoneNumber";
            errorphoneNumber.Size = new Size(10, 15);
            errorphoneNumber.TabIndex = 23;
            errorphoneNumber.Text = ".";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(800, 699);
            Controls.Add(errorphoneNumber);
            Controls.Add(Erroraddress);
            Controls.Add(errorlastName);
            Controls.Add(errorfirstName);
            Controls.Add(errorregisterNumber);
            Controls.Add(dateTimePicker1);
            Controls.Add(others);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(phonenumber);
            Controls.Add(address1);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(registernumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Magenta;
            Name = "Form2";
            Text = "Form2";
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
        private TextBox registernumber;
        private TextBox firstname;
        private TextBox lastname;
        private TextBox address1;
        private TextBox phonenumber;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private RadioButton male;
        private RadioButton female;
        private RadioButton others;
        private DateTimePicker dateTimePicker1;
        private Label errorregisterNumber;
        private Label errorfirstName;
        private Label errorlastName;
        private Label Erroraddress;
        private Label errorphoneNumber;
    }
}