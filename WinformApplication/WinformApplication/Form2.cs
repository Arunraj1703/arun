using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformApplication.BL;
using WinformApplication.Entities;
using System.Data.SqlClient;


namespace WinformApplication
{
    public partial class Form2 : Form
    {
        ValidationService service1 = new ValidationService();
        public Form2()
        {
            InitializeComponent();
        }
        StudentService service = new StudentService();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            bool b, c, d, f, g;
            b = service1.ToValidateRegisterNumber(registernumber.Text);
            if (b == false)
            {
                errorregisterNumber.Text = "please enter 4 digit register Number";
            }
            c = service1.ToValidateFirstName(firstname.Text);
            if (c == false)
            {
                errorfirstName.Text = "please enter your correct first name";
            }
            d = service1.ToValidateLastName(lastname.Text);

            if (d == false)
            {
                errorlastName.Text = "please enter your correct last name";
            }
            f = service1.ToValidateAddress(address1.Text);
            if (f == false)
            {
                Erroraddress.Text = "please enter your correct Address";
            }
            g = service1.ToValidatePhoneNumber(phonenumber.Text);
            if (g == false)
            {
                errorphoneNumber.Text = "please enter your correct phone number";
            }
            if (b == true && c == true && d == true && f == true && g == true)
            {
                Student student1 = new Student();
                student1.RegisterNumber = registernumber.Text;

                student1.FirstName = firstname.Text;
                student1.LastName = lastname.Text;
                student1.Address = address1.Text;
                student.PhoneNumber = phonenumber.Text;
                if (male.Checked)
                    student.gender = Gender.Male;
                else if (female.Checked)
                    student.gender = Gender.Female;
                else if (others.Checked)
                    student.gender = Gender.Others;
                student.DateOfBirth = DateTime.Parse(dateTimePicker1.Text);
                try
                {
                    //service.SearchReg(student1);
                    //MessageBox.Show(r);
                    service.UpdateStudentDetail(student1);

                    MessageBox.Show("Update Student Details Successfully");
                    registernumber.Text = string.Empty;
                    firstname.Text = string.Empty;
                    lastname.Text = string.Empty;
                    address1.Text = string.Empty;
                    phonenumber.Text = string.Empty;
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
                MessageBox.Show("Please enter the correct details then click on Update");
            }
        }

    }
}
