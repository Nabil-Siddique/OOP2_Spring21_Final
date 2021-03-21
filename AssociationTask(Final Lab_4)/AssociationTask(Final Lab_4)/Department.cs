using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationTask_Final_Lab_4_
{
    class Department
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private Student[] students;
        private int studentCount;
        public int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }

        public void AddStudent(Student student)
        {
            students[studentCount++] = student;
        }

        public void AllStudents()
        {
            for (int i = 0; i < studentCount; i++)
            {
                students[i].showInfo();
            }
        }

        public Student SearchStudent(Student student)
        {
            return null;
        }

        public Department()
        {
            students = new Student[60];
        }
        public Department(string name, string id)
        {
            this.name = name;
            this.id = id;
            students = new Student[60];
        }

        public void showInfo()
        {
            Console.WriteLine("Department Name: " + name);
            Console.WriteLine("Id: " + id);
        }


    }
}
