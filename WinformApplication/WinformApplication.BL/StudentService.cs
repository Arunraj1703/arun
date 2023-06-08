using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using WinformApplication.DAL;
using WinformApplication.Entities;

namespace WinformApplication.BL
{
    public class StudentService
    {
        StudentRepository repository = new StudentRepository();
        public void InsertStudentDetail(Student se)
        {
            repository.InsertStudent(se);
        }
        public void UpdateStudentDetail(Student pass)
        {
           
            repository.UpdateStudent(pass);
        }
       /* public int SearchReg(Student s)
        {
            int a = r;
            return r;
            repository.SearchRegisterNumber(s);
        }*/
        public void DeleteStudentDetail(Student object1)
        {
            repository.DeleteStudent(object1);
        }
        public List<Student> DisplayStudentDetail()
        {
            List<Student> lists = StudentRepository.DisplayStudent();
            return lists;
        }

    }
}