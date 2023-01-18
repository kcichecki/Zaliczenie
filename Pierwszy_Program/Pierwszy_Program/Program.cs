using System;

namespace Pierwszy_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            int result = 5 + 9;
            */


            //Zadanie 1

            /*
            int number = 6;
            double money = 4.5;
            string text = "test";
            bool isLogged = true;
            string myChar = "4";
            double price = 4.6;

            Console.WriteLine(number);
            Console.WriteLine(money);
            Console.WriteLine(text);
            Console.WriteLine(isLogged);
            Console.WriteLine(myChar);
            Console.WriteLine(price);
            */

            //zadanie 2
            /*
            string myAge = "Age:";
            int wifeAge = 18;
            string result = myAge + wifeAge;
            */


            //Zadanie 3
            /*
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;

            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine("and: "+and );
            Console.WriteLine("or: "+or);
            Console.WriteLine("negative "+negative);
            */
            //Zadanie 4

            /*
             
            int a = 5;
            int b = 12;

            int add = a + b;
            int sub = a - b;
            int div = a / b;
            int mul = a * b;
            int mod = a % b;

            Console.WriteLine("add: " + add);
            console.WriteLine("sub: " + sub);
            console.WriteLine("div: " + div);
            console.WriteLine("mul: " + mul);
            console.WriteLine("mod: " + mod);

                         */

            //Zadanie 5

            /*
             string a = "Ala";
            string b = " ma";
            string c = " kota.";

            string result = a + b + c;

            // Wynik operacji to "Ala ma kota."
            console.WriteLine(result);

             
             */



            //Zadanie 1

            /*
             
           int n1 = 10;
            int n2 = 20;

            if (n1 > n2)
            {
                Console.WriteLine("n1 jest większe od n2");
            }
            else if (n1 < n2)
            {
               Console.WriteLine("n1 jest mniejsze od n2");
            }
            else
            {
               Console.WriteLine("n1 jest równe n2");
            }  

             */


            //zadanie 2

            /*

            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine("C#");
            }


            int i = 0;
            while (i < 10)
            {
               Console.WriteLine("C#");
               i++;
            }

                         */


            //zadanie 3


            /*
             int n = 10;

            for (int i = 0; i <= n; i++)
            {
               if (i % 2 == 0)
               {
                   Console.WriteLine(i + " - Parzysta");
               }
               else
               {
                   Console.WriteLine(i + " - Nieparzysta");
               }
            }
             
             */



            //zadanie 4


            /*
             int n = 5;

            for (int i = 1; i <= n; i++)
            {
               for (int j = 1; j <= i; j++)
               {
                   Console.Write("* ");
               }
               Console.WriteLine();
            }
             
             */


            //zadanie 5

            /*
            
            int exam = 57;

            if (exam >= 0 && exam <= 39)
            {
               Console.WriteLine("Ocena Niedostateczna");
            }
            else if (exam >= 40 && exam <= 54)
            {
               Console.WriteLine("Ocena Dopuszczająca");
            }
            else if (exam >= 55 && exam <= 69)
            {
               Console.WriteLine("Ocena Dostateczna");
            }
            else if (exam >= 70 && exam <= 84)
            {
               Console.WriteLine("Ocena Dobra");
            }
            else if (exam >= 85 && exam <= 98)
            {
               Console.WriteLine("Ocena Bardzo Dobra");
            }
            else if (exam >= 99 && exam <= 100)
            {
               Console.WriteLine("Ocena Celująca");
            }
            else
            {
               Console.WriteLine("Wartość poza zakresem");
            } 

             */


            //zadanie 1


            /*
             string[] colors = { "niebieski", "zielony", "żółty", "czerwony" };

            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            console.WriteLine("Mój ostatni kolor to: " + colors[colors.Length - 1]);
             
             */

            //zadanie 2


            /*
             
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Liczba: " + numbers[i]);
}



            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

foreach (int number in numbers)
{
   Console.WriteLine("Liczba: " + number);
}
        
             
             int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int i = 0;

while (i < 10)
{
   Console.WriteLine("Liczba: " + numbers[i]);
   i++;
}

             
             
             */



            //zadanie 3

            /*
             List<string> fruits = new List<string> { "Pomidor", "Jabłko", "Marchewka" };

fruits.Remove("Pomidor");
fruits.Remove("Marchewka");

Console.WriteLine(string.Join(", ", fruits));
             
             */


        }
    }
}
