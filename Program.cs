namespace Kondital_opgave {
    class Program {
        static void Main() {
            Console.Write("Weight in kg: ");
            int Weight = Convert.ToInt16(Console.ReadLine());

            Console.Write("Hvilepuls: ");
            double Hvilepuls= Convert.ToInt16(Console.ReadLine());

            Console.Write("Maxpuls: ");
            double Maxpuls = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nKondital (ml/kg/min): {0}", Kondital.CalculateKondital(Hvilepuls, Maxpuls));
        }
    }

    class Kondital {
        public static double CalculateKondital(double Hvilepuls, double Maxpuls) {
            return Math.Round((Maxpuls / Hvilepuls) * 15.3, 0);
        }
    }
}