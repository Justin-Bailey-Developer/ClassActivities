using System;

namespace PROG7311_ICE1
{

/*
    --Open Closed Principle--
    This Student class can be extended from to make 
    the Fulltime and Parttime Student classes - without 
    needing to modify this parent class

    --Liskov Substituion Principle--
    All attributes and methods in this abstract/parent class are relevant
    to both types of students (Full time and part time students)
*/

    public abstract class Student
    {
        
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ContactNo { get; set; }
        public string Course { get; set; }
        public bool Enrolled { get; set; }

        public Student(string studentId, string name, string surname, string contactNo, string course, bool enrolled)
        {
            this.StudentId = studentId;
            this.Name = name;
            this.Surname = surname;
            this.ContactNo = contactNo;
            this.Course= course;
            this.Enrolled = enrolled;
        }
                
        public override string ToString()
        {
            string output = StudentId+",\t"+ Name + " " + Surname + ",\t" + Course;

            return output;
        }
    }
}
