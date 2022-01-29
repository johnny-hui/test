//Partial Class allows a single class to be sub-divded into multiple files. This includes its
              //functionalities, methods, getters + setters.
            
              //- At compile time, the files denoted as partial for one class 
              //  will be combined into one class.
            
//NOTE: A partial class is created by using the "partial" keyword

//We can use partial keyword to divide functionalities into different files.
namespace Lecture_1.Models
{
    public partial class Circle 
    {
        public double Perimeter() {
            return 2 * Math.PI * Radius;
        }
    }
}