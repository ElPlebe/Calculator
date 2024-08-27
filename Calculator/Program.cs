namespace Calculator
{
    public class Calc
    {
        public static void Main(string[] args)
        {
            int a, b;
            Console.Write("\n" + "Introduce el 1er número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\n" + "Introduce el 2do número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("\n" + "Seleccione una opción: " + "\n" + "\n");
            Console.Write("\n" + "     1º) Sum" + "\n" + "     2º) Substraction" + "\n" + "     3º) Multiplication" + "\n" + "     4º) Division" + "\n" + "     5º) Salir del Programa" + "\n" + "\n");

            switch (Console.Read())
            {
                case '1':
                    Console.Write("\n" + "    Sum = " + Calcs.Sum(a, b));
                break;

                case '2':
                    Console.Write("\n" + "    Substraction = " + Calcs.Substraction(a, b));
                break;

                case '3':
                    Console.Write("\n" + "   Multiplication = " + Calcs.Multiplication(a, b));
                break;

                case '4':
                    Console.Write("\n" + "    Division = " + Calcs.Division(a, b));
                break;

                case '5':
                    Console.Write("\n" + "     ( Good Luck!!)");
                break;
            }
            Console.ReadKey();
        }
    }
}