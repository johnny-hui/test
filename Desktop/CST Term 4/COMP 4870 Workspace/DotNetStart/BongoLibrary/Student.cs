namespace COMP4870.Models {
    //a) Demonstrates Inheritance for Classes and Implementation of Interface
    public class Student : Person, IStudentAble {
        public string school { get; set; }
        public int graduatingYear { get; set; }

        public int GraduatingYear() {
            return graduatingYear;
        }
    }
}