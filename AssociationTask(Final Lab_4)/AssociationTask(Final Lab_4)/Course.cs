using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationTask_Final_Lab_4_
{
    class Course
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

        public Course() { }
        public Course(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public void showInfo()
        {
            Console.WriteLine("Course Name: " + name);
            Console.WriteLine("ID: " + id);
        }


    }
}
