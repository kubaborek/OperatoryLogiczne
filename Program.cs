using System;

namespace OperatoryLogiczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1) Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
               one równe czy nie.
               Dane testowe:
               a : 5
               b : 5
               Rezultat w terminalu :
               5 i 5 są równe */

            Console.WriteLine("Ex. 1:\r\n");

            int a = 5;
            int b = 5;
            int result;

            if (a == b)
            {
                Console.WriteLine("Variables \"a\" and \"b\" are equal.");
            }
            else
            {
                Console.WriteLine("Variables \"a\" and \"b\" are different.");
            }

            /* 2) Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
               jest parzysta czy nieparzysta.
               Dane testowe : 15
               Rezultat w terminalu :
               15 jest liczbą nieparzystą.*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 2:\r\n");

            Console.WriteLine("Enter a number to check if is even or odd:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine($"Number {userInput} is even.");
            }
            else
            {
                Console.WriteLine($"Number {userInput} is odd.");
            }

            /* 3) Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
               jest dodatnia czy ujemna.
               Dane testowe : 14
               Rezultat w terminalu :
               14 jest liczbą dodatnią.*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 3:\r\n");

            Console.WriteLine("Enter a number to check if is positive or negative:");
            int userInput2 = int.Parse(Console.ReadLine());

            if (userInput2 > 0)
            {
                Console.WriteLine($"Number {userInput2} is positive");
            }
            else if (userInput2 < 0)
            {
                Console.WriteLine($"Number {userInput2} is negative");
            }
            else
            {
                Console.WriteLine($"It's zero, null, nic!!!! :)");
            }

            /* 4) Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
               jest rokiem przestępnym.
               Dane testowe : 2016
               Rezultat w terminalu :
               2016 jest rokiem przestępnym*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 4:\r\n");

            Console.WriteLine("Enter year to check if is it a leap year:");
            int userInput3 = int.Parse(Console.ReadLine());

            if (userInput3 % 4 == 0)
            {

                if (userInput3 % 100 == 0 && userInput3 % 400 == 0)
                {
                    Console.WriteLine($"{userInput3} is not a leap year.");
                }
                else
                {
                    Console.WriteLine($"{userInput3} is a leap year.");
                }
            }
            else
            {
                Console.WriteLine($"{userInput3} is not a leap year.");
            }

            /* 5) Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
               uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
               prezydenta.
               Dane testowe : 21
               Rezultat w terminalu :
               Możesz zostać posłem. */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 5:\r\n");

            
            Console.WriteLine("Do you have Polish citizenship? (type \"true\" or \"false\")");
            bool nationality = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter your age:");
            int userAge = int.Parse(Console.ReadLine());

            if (!nationality)
            {
                Console.WriteLine("You cannot serve any state function in Poland.");
            }
            else
            {
                if (userAge >= 35)
                {
                    Console.WriteLine("You can run for president, senator and parliament representative in Poland.");
                }
                else if (userAge >= 25)
                {
                    Console.WriteLine("At this age you can become senator and parliament representative but not president of Poland.");
                }
                else if (userAge >= 21)
                {
                    Console.WriteLine("At the moment you can run as parliament representative but you have to wait to become senator or president od Poland.");
                }
                else
                {
                    Console.WriteLine("You are too young to serve any public function.");
                }
            }

            /* 6) Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
               wymyśloną kategorię wzrostu.
               Dane testowe : 140
               Rezultat w terminalu :
               Jesteś krasnoludem */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 6:\r\n");

            Console.WriteLine("Enter your height (in cm):");
            int userHeight = int.Parse(Console.ReadLine());

            if (userHeight >= 300)
            {
                Console.WriteLine("I-M-P-O-S-I-B-L-E");
            }
            else if (userHeight >= 250)
            {
                Console.WriteLine("OMG!");
            }
            else if (userHeight >= 200)
            {
                Console.WriteLine("Are you a basketball player?");
            }
            else if (userHeight >= 190)
            {
                Console.WriteLine("You are skyscraping ;)");
            }
            else if (userHeight >= 180)
            {
                Console.WriteLine("You are pretty high.");
            }
            else if (userHeight >= 160)
            {
                Console.WriteLine("You are not so high.");
            }
            else if (userHeight >= 141)
            {
                Console.WriteLine("You are low.");
            }
            else if (userHeight >= 100)
            {
                Console.WriteLine("You are a midget :)");
            }
            else if (userHeight >= 1)
            {
                Console.WriteLine("You're probably a child.");
            }
            else
            {
                Console.WriteLine("You made a mistake - height cannot be negative numbber.");
            }

            /* 7) Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
               która jest największa
               Dane testowe:
               25
               63
               79
               Rezultat w terminalu :
               79 jest największa z podanych
             */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 7:\r\n");

            Console.WriteLine("Enter three numbers to check highest.");

            Console.WriteLine("Enter 1st number:");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number:");
            int input3 = int.Parse(Console.ReadLine());

            int max = Math.Max(input1, Math.Max(input2, input3));

            Console.WriteLine($"Highest of these three is number {max}");

            /* 8) Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
               na studiach wg. Następujących kryteriów:
               Wynik z Matury z matematyki powyżej 70
               Wynik z fizyki powyżej 55
               Wynik z chemii powyżej 45
               Łączny wynik z 3 przedmiotów powyżej 180
               Albo
               Wynik z matematyki i jednego przedmiotu powyżej 150
               Dane testowe:
               Matematyka 80
               Fizyka 71
               Chemia 0
               Rezultat w terminalu :
               Kandydat dopuszczony do rekrutacji. */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 8:\r\n");

            Console.WriteLine("Let's check if you can join in recruitment:");
            Console.WriteLine("Enter your Math exam score:");
            int mathScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Physics exam score:");
            int physicsScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Chemistry exam score:");
            int chemistryScore = int.Parse(Console.ReadLine());

            if ((mathScore > 70 && physicsScore > 55 && chemistryScore > 45) &&
               ((mathScore + physicsScore + chemistryScore > 180) || (mathScore + physicsScore > 150) || (mathScore + chemistryScore > 150)))
            {
                Console.WriteLine("Congratulation! You can be qualified :)");
            }
            else
            {
                Console.WriteLine("Unfortunately, you cannot be qualified... :(");
            }

            /* 9) Napisz program, który odczyta temperaturę I zwróci nazwę jak w
               poniższych kryteriach
               Temp < 0 – cholernie piździ
               Temp 0 – 10 – zimno
               Temp 10 – 20 – chłodno
               Temp 20 – 30 – w sam raz
               Temp 30 – 40 – zaczyna być słabo, bo gorąco
               Temp >= 40 – a weź wyprowadzam się na Alaskę.
               Dane testowe : 41
               Rezultat w terminalu :
               a weź wyprowadzam się na Alaskę. */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 9:\r\n");

            Console.WriteLine("Enter the temparature today (°C):");
            double temperature = double.Parse(Console.ReadLine());
            if (temperature < 0)
            {
                Console.WriteLine("It's bloody cold!");
            }
            else if (temperature <= 10)
            {
                Console.WriteLine("It's cold.");
            }
            else if (temperature <= 20)
            {
                Console.WriteLine("It's pretty cold.");
            }
            else if (temperature <= 30)
            {
                Console.WriteLine("It's OK!");
            }
            else if (temperature <= 40)
            {
                Console.WriteLine("It goes bad, because of hot.");
            }
            else
            {
                Console.WriteLine("Give me a break! I'm moving to Alaska...");
            }

            /* 10) Napisz program, który sprawdzi, czy z 3 podanych długości można
               stworzyć trójkąt
               Dane testowe : 40 55 65
               Rezultat w terminalu :
               Można zbudować trójkąt */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 10:\r\n");

            Console.WriteLine("Let's check if we can build a triangle with below side lenghts:");
            Console.WriteLine("Enter length of the side \"a\":");
            double aTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of the side \"b\":");
            double bTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of the side \"c\":");
            double cTriangle = double.Parse(Console.ReadLine());

            double sum = aTriangle + bTriangle + cTriangle;
            double longest = Math.Max(aTriangle, Math.Max(bTriangle, cTriangle));

            if (aTriangle <= 0 || bTriangle <= 0 || cTriangle <= 0)
            {
                Console.WriteLine("You cannot build such triangle, because the side cannot be 0 or negative.");
            }
            else if (longest < sum - longest)
            {
                Console.WriteLine($"You can build such triangle and its perimeter equals {sum}.");
            }
            else
            {
                Console.WriteLine("You cannot build such triangle, because the longest side is equal or higher than the sum of the others.");
            }

            /* 11) Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
               Ocena Opis
               6 Celujący
               5 Bardzo dobry
               4 Dobry
               3 Dostateczny
               2 Dopuszczający
               1 Niedostateczny
               Dane testowe : 3
               Rezultat w terminalu :
               Dostateczny*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 11:\r\n");

            Console.WriteLine("Enter a grade (1-6) to find out its name in Polish:");
            int grade = int.Parse(Console.ReadLine());

            switch (grade)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzop dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Grade is out of range.");
                    break;
            }

            /* 12) Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
               nazwę
               Dane testowe: 4
               Rezultat w terminalu :
               Czwartek */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 12:\r\n");

            Console.WriteLine("Enter weekday number - I will return its name:");
            int weekday = int.Parse(Console.ReadLine());

            switch (weekday)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Weekday is out of range.");
                    break;
            }

            /* 13) Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I
               będzie prostym kalkulatorem
               Podaj pierwszą liczbę:
               …
               Podaj drugą liczbę:
               …
               Podaj numer operacji do wykonania:
               1. Dodawanie
               2. Odejmowanie
               3. Mnożenie
               4. Dzielenie
               …
               Twój wynik to:*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 13:\r\n");

            Console.WriteLine("Welcome to (very) SIMPLE CALCULATOR!");
            Console.WriteLine("Enter first number:");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\nWhat do you want to do with these numbers?");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Choose an option...");
            int choice = int.Parse(Console.ReadLine());
            double choiceResult = 0;

            switch (choice)
            {
                case 1:
                    choiceResult = firstNum + secondNum;
                    Console.WriteLine($"Your result equals: {choiceResult}");
                    break;
                case 2:
                    choiceResult = firstNum - secondNum;
                    Console.WriteLine($"Your result equals: {choiceResult}");
                    break;
                case 3:
                    choiceResult = firstNum * secondNum;
                    Console.WriteLine($"Your result equals: {choiceResult}");
                    break;
                case 4:
                    if (secondNum == 0)
                    {
                        Console.WriteLine("You cannot divide by 0!");
                    }
                    else
                    {
                        choiceResult = firstNum / secondNum;
                        Console.WriteLine($"Your result equals: {choiceResult}");
                    }
                    break;
                default:
                    Console.WriteLine("Unknown choice.");
                    break;
            }
        }
    }
}