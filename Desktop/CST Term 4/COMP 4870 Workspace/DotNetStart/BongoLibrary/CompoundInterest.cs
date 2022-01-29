namespace COMP4870.Models {
    //A = Amount
    //P = Principal Investment Amount
    //r = Annual interest Rate
    //n = number of times the interest is compounded per yr
    //t = number of years the money is invested or borrowed for
    public class CompoundInterest {
        public double A {get; set; }
        public double P { get; set; }
        public double R { get; set; }
        public double N { get; set; }
        public double T { get; set; }

        public double calculate() {
            this.R = R / 100;
            this.A = Math.Round(P * Math.Pow(1 + R / N, N * T), 2);
            return this.A;
        }
    }
}