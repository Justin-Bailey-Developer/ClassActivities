using System;

namespace PROG7311_ICE1
{

    /*
        Single Responisiblity Principle:
        This class only deals with Parttime students
    */

    public class ParttimeStudent : Student
    {
        
        public ParttimeStudent(string studentId, string name, string surname, 
                                    string contactNo, string course,
                                        bool enrolled) : base(studentId, name, surname,contactNo, course, enrolled)
        { 
            //constructor    
        }
    }
}
