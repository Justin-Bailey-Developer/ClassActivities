

namespace PROG7311_ICE1
{

    /*
        
    */

    public class FulltimeStudent : Student
    {
        
        //public string Attendance { get; set; }
        public int GroupNo { get; set; }
        public FulltimeStudent(string studentId, string name, string surname, 
                                    string contactNo, string course,
                                        bool enrolled, int groupNo)
                                        : base(studentId, name, surname, contactNo, course, enrolled){ 
            
            GroupNo = groupNo;
        }
    }
}