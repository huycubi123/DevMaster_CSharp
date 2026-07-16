using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_3
{

    internal class StudentModel
    {
        List<Student> liststudent;
        //  Student[] students = new Student[5];
        public StudentModel()
        {
            //this.students[0] = new Student(1, "Nguyen Van A", "Hoc sinh gioi");
            //this.students[1] = new Student(2, "Nguyen Van B", "Hoc sinh kha");
            //this.students[2] = new Student(3, "Nguyen Van C", "Hoc sinh trung binh");
            //this.students[3]= new Student(4, "Nguyen Van D", "Hoc sinh yeu");
            //this.students[4] = new Student(5, "Nguyen Van E", "Hoc sinh kem");
            liststudent = new List<Student>();
            new Student(1, "Nguyen Van A", 20);
            new Student(2, "Nguyen Van B", 18);
            new Student(3, "Nguyen Van C", 19);
            new Student(4, "Nguyen Van D", 23);
            new Student(5, "Nguyen Van E", 21);

        }

        // Xử lý overloading (đa hình)
        #region
        public List<Student> GetStudents()
        {
            return liststudent;
        }
        // Lấy theo id 
        public Student GetStudents(int id)
        {
            Student st = null;
            foreach (var item in liststudent)
            {
                if (item.Id == id)
                {
                    st = item;
                    break;
                }
            }
            return st;
        }


        // trả về sinh viên có tuổi từ x to y
        public List<Student> GetStudents(int x, int y)
        {
            List<Student> list = new List<Student>();
            foreach (var item in liststudent)
            {
                if (item.Age >= x && item.Age <= y)
                {
                    list.Add(item);
                }
            }
            return list;
            #endregion
        }
    }
}

