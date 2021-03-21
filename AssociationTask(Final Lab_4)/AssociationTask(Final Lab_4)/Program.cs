using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationTask_Final_Lab_4_
{
    class Program
    {
        static void Main(string[] args)
        {

                Student s1 = new Student("Ali", "18-38901-3", 3.0f);
                Student s2 = new Student("Antoraj", "18-38901-2", 3.5f);
                Department d1 = new Department("Computer Science", "SE");
                s1.Department = d1;
                s2.Department = d1;
                d1.AddStudent(s1);
                d1.AddStudent(s2);
                d1.AllStudents();
            
        }
    }
}
