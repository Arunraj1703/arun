using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformApplication.BL;
using WinformApplication.Entities;
using System.Data.SqlClient;

namespace WinformApplication
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        StudentService service = new StudentService();
        private void button1_Click(object sender, EventArgs e)
        {
            Student object1 = new Student();

            object1.RegisterNumber = register_number.Text;
            try
            {
                service.DeleteStudentDetail(object1);
                MessageBox.Show("delete student details Successfully");
            }
            catch (SqlException x)
            {
                MessageBox.Show("Error :" + x.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
