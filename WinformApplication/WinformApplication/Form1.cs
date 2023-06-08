using WinformApplication.BL;
using System.Data.SqlClient;
using WinformApplication.Entities;

using System.Net;

using static WinformApplication.Entities.Student;

namespace WinformApplication
{


    public partial class Form1 : Form
    {
        StudentService service = new StudentService();
        ValidationService service1 = new ValidationService();
        public Form1()
        {
            InitializeComponent();
        }
        StudentService object3 = new StudentService();
        ValidationService validation = new ValidationService();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*bool a = service1.ToValidateRegisterNumber(registerNumber.Text);

            if (a == false)
            {
                registerNumber.BackColor = Color.Red;
                MessageBox.Show("please enter 4 digit number");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b, c, d, f, g;
            b = service1.ToValidateRegisterNumber(registerNumber.Text);
            if (b == false)
            {
                errorRegisterNumber.Text = "please enter 4 digit register Number";
            }
            c = service1.ToValidateFirstName(firstName.Text);
            if (c == false)
            {
                errorFirstName.Text = "please enter your correct first name";
            }
            d = service1.ToValidateLastName(lastName.Text);

            if (d == false)
            {
                errorLastName.Text = "please enter your correct last name";
            }
            f = service1.ToValidateAddress(address.Text);
            if (f == false)
            {
                errorAddress.Text = "please enter your correct Address";
            }
            g = service1.ToValidatePhoneNumber(phoneNumber.Text);
            if (g == false)
            {
                errorPhoneNumber.Text = "please enter your correct phone number";
            }
            if (b == true && c == true && d == true && f == true && g == true)
            {
                Student student = new Student();
                student.RegisterNumber = registerNumber.Text;
                student.FirstName = firstName.Text;
                student.LastName = lastName.Text;
                student.Address = address.Text;
                student.PhoneNumber = phoneNumber.Text;
                if (male.Checked)
                    student.gender = Gender.Male;
                else if (female.Checked)
                    student.gender = Gender.Female;
                else if (others.Checked)
                    student.gender = Gender.Others;
                student.DateOfBirth = DateTime.Parse(dateTimePicker1.Text);
                try
                {
                    service.InsertStudentDetail(student);
                    MessageBox.Show("INSERT student details Successfully");
                    registerNumber.Text = string.Empty;
                    firstName.Text = string.Empty;
                    lastName.Text = string.Empty;
                    address.Text = string.Empty;
                    phoneNumber.Text = string.Empty;
                    if (male.Checked == true)
                        male.Checked = false;
                    else if (female.Checked)
                        male.Checked = false;
                    else if (others.Checked == true)
                        male.Checked = false;
                }
                catch (SqlException x)
                {
                    MessageBox.Show("Error :" + x.Message);
                }

            }
            else
            {
                MessageBox.Show("Please enter the correct details then click on insert");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 updateForm = new Form2();
            updateForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 deleteForm = new Form3();
            deleteForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                List<Student> lists = service.DisplayStudentDetail();
                foreach (Student j in lists)
                {
                    string a = (j.RegisterNumber + " " + j.FirstName + " " + j.LastName + j.Address + " " + j.PhoneNumber);
                    MessageBox.Show(a);
                }

            }
            catch (SqlException x)
            {
                MessageBox.Show("Error :" + x.Message);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        bool a;

        private void firstName_TextChanged(object sender, EventArgs e)
        {

            /*a = validation.ToValidateRegisterNumber(registerNumber.Text);
            if (a == true)
            {

            }
            else
            {
                MessageBox.Show("please enter a correct register Number");
            }*/

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            /*a = validation.ToValidateFirstName(registerNumber.Text);
            if (a == true)
            {

            }
            else
            {
                MessageBox.Show("please enter a correct FirstName");
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Text);
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


