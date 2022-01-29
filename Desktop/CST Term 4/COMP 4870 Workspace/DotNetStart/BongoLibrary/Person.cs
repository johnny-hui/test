//Creating Java Bean (C# Equivalent)
namespace COMP4870.Models {
    public class Person {
        // private int _Id;
        
        // public int Id {
        //     get {
        //         return _Id;
        //     }
        //     set {
        //         _Id = value;
        //     }
        // }

        //a) Better way to create Getters + Setters (type "prop" -> Hit Tab)
        public int Id { get; set; } //Question Mark ? to ignore the nulls
        public string firstName { get; set; }

        public string lastName { get; set; }
        public string gender { get; set; }
        
    }
}