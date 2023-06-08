namespace WinformApplication
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            register_number = new TextBox();
            button1 = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(251, 23);
            label1.Name = "label1";
            label1.Size = new Size(220, 19);
            label1.TabIndex = 0;
            label1.Text = "DELETE STUDENT DETAILS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(165, 83);
            label2.Name = "label2";
            label2.Size = new Size(435, 17);
            label2.TabIndex = 1;
            label2.Text = "Using Register Number Delete the entire student Details successfully";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(70, 176);
            label3.Name = "label3";
            label3.Size = new Size(145, 17);
            label3.TabIndex = 2;
            label3.Text = "Enter Register Number";
            // 
            // register_number
            // 
            register_number.Location = new Point(278, 174);
            register_number.Name = "register_number";
            register_number.Size = new Size(142, 23);
            register_number.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.OliveDrab;
            button1.Location = new Point(209, 249);
            button1.Name = "button1";
            button1.Size = new Size(106, 53);
            button1.TabIndex = 4;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(register_number);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox register_number;
        private Button button1;
        private ImageList imageList1;
    }
}