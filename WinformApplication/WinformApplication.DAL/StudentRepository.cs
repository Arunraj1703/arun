using System.Net;
using System.Data.SqlClient;

using WinformApplication.Entities;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WinformApplication.DAL
{
    public class StudentRepository
    {
      static List<Student> lists = new List<Student>();
        public  void InsertStudent(Student sr)
        {
            string str = "StudentConnection";
            SqlConnection con = new SqlConnection("Data Source=TRNE13-ARUN;Initial Catalog=studentinfo;user id=sa;password=LEB0@d34d0Je");
            con.Open();
            string statement = "Insert into StudentManagements(RegisterNumber, FirstName, LastName, Address,PhoneNumber,gender,DateOfBirth) values(@RegisterNumber,@FirstName,@LastName,@Address,@PhoneNumber,@gender,@DateOfBirth)";
            SqlCommand command = new SqlCommand(statement, con);
            command.Parameters.AddWithValue("@RegisterNumber", sr.RegisterNumber);
            command.Parameters.AddWithValue("@FirstName", sr.FirstName);
            command.Parameters.AddWithValue("@LastName", sr.LastName);
            command.Parameters.AddWithValue("@Address", sr.Address);
            command.Parameters.AddWithValue("@PhoneNumber", sr.PhoneNumber);
            command.Parameters.AddWithValue("@gender", sr.gender);
            command.Parameters.AddWithValue("@DateOfBirth", sr.DateOfBirth);
            command.ExecuteNonQuery();
            con.Close();

        }
        //int r;
       /* public int SearchRegisterNumber(Student se)
        {
            string str = "StudentConnection";
            SqlConnection con = new SqlConnection("Data Source=TRNE13-ARUN;Initial Catalog=studentinfo;user id=sa;password=LEB0@d34d0Je");
            con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string statement = "select RegisterNumber from StudentManagements  where RegisterNumber='" + se.RegisterNumber + "'";
            command = new SqlCommand(statement, con);
            

             r = command.ExecuteNonQuery();
         
            command.Dispose();
            con.Close();

            return r;
        }*/
        public static List<Student> DisplayStudent()
        {
            string str = "StudentConnection";
            SqlConnection con = new SqlConnection("Data Source=TRNE13-ARUN;Initial Catalog=studentinfo;user id=sa;password=LEB0@d34d0Je");
            con.Open();
            SqlDataReader dataReader;
            String Statement = "select * from StudentManagements";
            SqlCommand command = new SqlCommand(Statement, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
               
                Student info = new Student();
                info.RegisterNumber = (string)dataReader[0];
                info.FirstName = (string)dataReader[1];
                info.LastName = (string)dataReader[2];
                info.Address = (string)dataReader[3];
                info.PhoneNumber = (string)dataReader[4];
                info.gender =(Gender)dataReader[5];
                info.DateOfBirth =(DateTime)dataReader[6];
                lists.Add(info); 
            }
   
            dataReader.Close();
            command.Dispose();
            con.Close();
            return lists;
        }

            //
            public  void UpdateStudent(Student pass)
            {
                string str = "StudentConnection";
                SqlConnection con = new SqlConnection("Data Source=TRNE13-ARUN;Initial Catalog=studentinfo;user id=sa;password=LEB0@d34d0Je");
                con.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
            
                string statement = "Update StudentManagements set FirstName='" + pass.FirstName + "',LastName='" + pass.LastName + "',Address='" + pass.Address + "',PhoneNumber='" + pass.PhoneNumber + "' where RegisterNumber='" + pass.RegisterNumber + "'";
                command = new SqlCommand(statement, con);
                adapter.UpdateCommand = new SqlCommand(statement, con);
                command.ExecuteNonQuery();
                command.Dispose();
                con.Close();
            
             
               
            }
            public  void DeleteStudent(Student object1)
            {
                string str = "StudentConnection";
                SqlConnection con = new SqlConnection("Data Source=TRNE13-ARUN;Initial Catalog=studentinfo;user id=sa;password=LEB0@d34d0Je");
                con.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string statement = "delete from StudentManagements  where RegisterNumber='" + object1.RegisterNumber+"'";
                command = new SqlCommand(statement, con);
                adapter.DeleteCommand = new SqlCommand(statement, con);
                command.ExecuteNonQuery();
                command.Dispose();
                con.Close();
               
            }
        }
    }
