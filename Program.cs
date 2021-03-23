using System;

namespace Exercitiu2_Calcule
{ 
    /* Exercise 2:  Citiți două numere reale de la tastatură și apoi, utilizând operatorii binari +, -, *, /, să se execute
câteva calcule. Sa se creeze o clasă care să conțină metode pentru operațiile matematice cât și
o metodă pentru afișare.*/

    class Calcule : Calculator
    {
        static void Main(string[] args)
        {
            float nr1 = 0F; float nr2 = 0F;
            
            string operation = " ";

            while (3>2)
            {
                                
                Console.Write("The first number [nr1] is = ");
                nr1 = Convert.ToSingle(Console.ReadLine());

                Console.Write("The second number [nr2] is = ");
                nr2 = Convert.ToSingle(Console.ReadLine());

                Console.Write("\nChoose the operation [+, -, *, /] = ");
                operation = Console.ReadLine();

                /* switch (operation)
                 {
                     case "+": Calculator.Addition(nr1, nr2); 
                     case "-": Calculator.Difference(nr1, nr2); 
                     case "*": Calculator.Multiplication(nr1, nr2); 
                     case "/": Calculator.Division(nr1, nr2); 
                     default: Console.WriteLine("Error! Please choose one of them [+, -, *, /]"); 
                 }*/

                    if (operation == "+")
                    {
                        Calculator.Addition(nr1, nr2);
                    }

                    if (operation == "-")
                    {
                        Calculator.Difference(nr1, nr2);
                    }

                    if (operation == "*")
                    {
                        Calculator.Multiplication(nr1, nr2);
                    }

                    if (operation == "/")
                    {
                        Calculator.Division(nr1, nr2);
                    }
               
                Console.Read();
                Console.Clear();
                Console.Read();
            }
        }
    }

    public class Calculator
    {
        public static void Addition(float nr1, float nr2)
        {
            DisplayResult(nr1 + nr2);
        }

        public static void Difference(float nr1, float nr2)
        {
            DisplayResult(nr1 - nr2);
        }

        public static void Multiplication(float nr1, float nr2)
        {
            DisplayResult(nr1 * nr2);
        }

        public static void Division(float nr1, float nr2)
        {
            DisplayResult(nr1 / nr2);
        }

        public static void DisplayResult(float result) {

            Console.WriteLine("The result is = " + result);
        }
    }
}
