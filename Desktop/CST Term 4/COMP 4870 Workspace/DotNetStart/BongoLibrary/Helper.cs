namespace COMP4870.Models {
    public class Helper {
        public static String Reverse(string s) {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}