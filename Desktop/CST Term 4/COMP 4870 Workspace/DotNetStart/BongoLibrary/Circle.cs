//Partial Class provides a special ability to implement the functionality of a single class 
              //into multiple files and all these files are combined into a single class file 
              //when the application is compiled. 
            
//NOTE: A partial class is created by using the "partial" keyword
namespace Lecture_1.Models
{
    public partial class Circle
    {
        public double Radius { get; set;}
        public double Area () {
            return Math.PI * (Radius * Radius);
        }
    }
}