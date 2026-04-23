using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace AdirEf10th
{
    internal class Program
    {
        static void Main()
        {
            //Program.Targil5_2_1();
            //Program.Hello();
            //Program.Targil4_1_1();
            //Program.Targil5_1_2();
            //Program.Targil5_2_2();
            //Program.Targil5_345_2();
            //Program.Loops();
            //Program.Loops1();
            //Program.Loops2();
            //Program.Loops3();
            //Program.Loops4();
            //Program.Loops5();
            //Program.Loops6();
            //Program.Loops7();
            //Program.Loops8();
            //Program.Loops9();
            //Program.Loops10();
            //Program.Loops11();
            //Program.Loops12();
            //Program.Loops13();
            //Program.Loops14();
            //Program.Loops15();
            //Program.Loops16();
            //Program.Loops17();
            //Program.Loops18A();
            //Program.Loops18B();
            //Program.UsdToIls();
            //Program.MoreWhile1();
            //Program.MoreWhile2();
            //Program.MoreWhile3();
            //Program.MoreWhile4();
            //Program.MoreWhile5();
            //Program.MoreWhile6();
            //Program.MoreWhile8();
            //Program.Songs();
            //Program.For7_4();
            //Program.For7_5();
            //Program.For7_9();
            //Program.For7_10();
            //Program.For7_12();
            //Program.For7_13();
            //Program.For7_14();
            //Program.For7_15();
            //Program.For7_17();
            //Program.For7_18();
            //Program.For7_20();
            //Program.For32();
            //Program.For33();
            //Program.For34();
            //Program.For40();
            //Program.For44();
            //Program.For45();
            //Program.Loops7_24();
            //Program.Loops7_25();
            //Program.Loops7_28();
            //Program.Loops7_29();
            //Program.Loops7_30();
            //Program.Loops7_31();
            //Program.Loops7_32();
            //Program.Loops7_39();
            //Program.Loops7_41();
            //Program.Loops7_42();
            //Program.Loops7_43();
            //Program.Loops7_45();
            //StaticFuncs1A_ut();
            //StaticFuncs1B_t();
            //StaticFuncs2A_ut();
            //StaticFuncs2B_t();
            //StaticFuncs3A_ut();
            //StaticFuncs3B_t();
            //StaticFuncs4A_ut();
            //StaticFuncs4B_t();
            //StaticFuncs5A_ut();
            //StaticFuncs5B_t();
            //StaticFuncs6A_ut();
            //StaticFuncs6A_t();
            //StaticFuncs8A_ut();
            //StaticFuncs8B_t();
            //StaticFuncs10A_ut();
            //StaticFuncs10B_t();
            //StaticFuncs12A_ut();
            //StaticFuncs12AB_ut();
            //StaticFuncs12B_ut();
            //StaticFuncs12C_t();
            //StaticFuncs14A_ut();
            //StaticFuncs14B_ut();
            //StaticFuncs14C_t();
            //Nested_Loops();
            //NestedLoops7_67_A();
            //NestedLoops7_67_B();
            //NestedLoops7_67_C();
            //NestedLoops7_67_D();
            //NestedLoops7_67_E();
            //NestedLoops7_67_F();
            //NestedLoops7_67_G();
            //NestedLoops7_67_H();
            //NestedLoops7_69();
            //NestedLoops7_70();
            //NestedLoops47();
            //NestedLoops48();
            //WordNum();
            //StaticString.StaticString_UT();
            //Cypher.CypherUT();
            //LapTime();
            //ArrayPractice.ArrayPracticeUT();
            //FinalGradeCalc.UnitTest();
            //ClassPractice.UnitTests();
            //Point.PointUT();
            //PokeCatch.PokeUT();
            //Date.DateUT();
            //Rational.RationalUT();
            //Rectangle.RectangleUT();
            //Passport.PassportUT();
            //Traveler.TravelerUT();
            //ArraySort.Sort_UnitTest();
            //Line.LineUT();
            Parabola.ParabolaUT();
            //TEST
        }

        static void Targil5_2_1()
        {
            Console.WriteLine("Enter the driver's speed.");
            double spd = double.Parse(Console.ReadLine());
            if (spd < 55 || spd > 100)
            {
                Console.WriteLine("The driver's speed exceeds the limit.");
            }
            else
            {
                Console.WriteLine("The driver's speed is okay.");
            }
        }

        static void Hello()
        {
            Console.WriteLine("Hello World!");
        }

        static void Targil4_1_1()
        {
            double a, b, c, d, x1, x2;
            Console.WriteLine("Enter the parameters a, b and c.");
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            d = Math.Pow(b, 2) - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine("Linear function.");
            }
            else
            {
                if (d < 0)
                {
                    Console.WriteLine("There is no answer.");
                }
                else if (d == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine("x1 = " + x1);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
        }

        static void Targil5_1_2()
        {
            double consumption, payment, average;
            Console.WriteLine("Enter the amount of gas in liters.");
            consumption = double.Parse(Console.ReadLine());
            if (consumption <= 5)
            {
                payment = consumption * 10;
            }
            else
            {
                payment = 5 * 10 + (consumption - 5) * 7;
            }
            average = payment / consumption;
            Console.WriteLine("Your payment is " + payment + ".");
            Console.WriteLine("The average is " + average + ".");
        }

        static void Targil5_2_2()
        {
            Console.WriteLine("Enter a number between 1-99.");
            int num = int.Parse(Console.ReadLine());
            if (0 < num && num < 100)
            {
                if (num / 10 == 7 || num % 10 == 7 || num % 7 == 0)
                {
                    Console.WriteLine("BOOM!");
                }
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }

        static void Targil5_345_2()
        {
            Console.WriteLine("Enter your rank.");
            int rank = int.Parse(Console.ReadLine());//THIS IS TRASH, ADD TRY AND CATCH METHOD.(CHAT GPT)
            if (rank >= 1 && rank <= 10)
            {
                if (rank <= 2)
                {
                    Console.WriteLine("Student.");
                }
                else if (rank <= 4)
                {
                    Console.WriteLine("Worker.");
                }
                else if (rank <= 7)
                {
                    Console.WriteLine("Crew leader.");
                }
                else
                {
                    Console.WriteLine("Manager.");
                }
            }
            else
            {
                Console.WriteLine("Invalid rank.");
            }
        }

        /*
        Targil5_1:
        
        A:

        if (x > 9)
        {
            x = x + 1;
        }
        else
        {
            x = x - 1;
        }

        B:

        if (x >= 5)
        {
            x = x * 4;
            x = x / 2;
        }

        C:

        if (x > 0)
        {
            x = -x;
        }

        D:

        if (x > 1)
        {
            x = -x;
        }
        */

        /*
        Targil5_2:

        A:

        if (((rookRow + rookCol) % 2) == 1)
            //Checks if the rook in on a white square.

        B:

        ((rookRow == bishopRow) || (rookCol == bishopCol))

        C:

        ((bishopRow – rookRow) == (bishopCol – rookCol) || (bishopRow – rookRow) == (rookCol - bishopCol))
        */

        static void Loops()
        {
            int num;
            num = 17;
            while (num > 0)
            {
                num = num - 1;
                Console.WriteLine(num);
            }
            Console.WriteLine("Bye!");
        }

        static void Loops1()
        {
            int num;
            num = 3;
            while (num > 0)
            {
                num = num - 1;
            }
            Console.WriteLine("last num = " + num);

            //A: last num = 2

            //B: last num = 0
            //:כל זמן שהתנאי מתקיים, בצע את ההוראה
            // num = num - 1;
        }

        static void Loops2()
        {
            double num;
            Console.WriteLine("Enter first number.");
            num = double.Parse(Console.ReadLine());
            while (num != 9.9)
            {
                Console.WriteLine("Enter other number.");
                num = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Finish.");

            //B:
            //גם בהוראת החזרה
            //while,
            //.כאשר רוצים לחזור על ביצוע של מספר הוראות, צריך להכניס את ההוראות לתוך הבלוק
            //.} כלומר, בין הסימן } לבין הסימן 
        }

        static void Loops3()
        {
            int num;
            num = 5;
            while (num < 10)
            {
                Console.WriteLine("Num = " + num);
                num = num - 1;
            }
            Console.WriteLine("Last num = " + num);

            //A:
            //num > 0:
            //1: 5, 4, 3, 2, 1.
            //2: 0.
            //3: 5, 4, 3, 2, 1.
            //4: 0.
            //num != 2:
            //1: 5, 4, 3.
            //2: 2.
            //3: 5, 4, 3.
            //4: 2.
            //num == 5:
            //1: 5.
            //2: 4.
            //3: 5.
            //4: 4.
            //num > 10:
            //1: X.
            //2: 5.
            //3: X.
            //4: 5.
            //B:
            //.הפעולה נכנסה ללולאה אינסופית כי התנאי המשיך להתקיים
            //!ההוראות שבגוף הלולאה צריכות לגרום לכך שלאחר מספר סופי של פעמים בהם מתבצעת הלולאה, התנאי לבדיקה לא יתקיים
        }

        static void Loops4()
        {
            Console.WriteLine("I love you.");
            Console.WriteLine("Continue? (Type 1 to continue.)");
            int num = int.Parse(Console.ReadLine());
            while (num == 1)
            {
                Console.WriteLine("I love you.");
                Console.WriteLine("Continue? (Type 1 to continue.)");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Finish.");
        }

        static void Loops5()
        {
            int num, count;
            Console.WriteLine("Enter natural number.");
            num = int.Parse(Console.ReadLine());
            count = 1;
            while (count <= num)
            {
                Console.WriteLine(count);
                count++;
            }
        }

        static void Loops6()
        {
            int sum, flat, count;
            Console.WriteLine("Enter number of flats.");
            flat = int.Parse(Console.ReadLine());
            sum = 0;
            count = 0;
            while (flat >= 0)
            {
                sum = sum + flat;
                count++;
                Console.WriteLine("Enter number of flats.");
                flat = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum + " flats were sold.");
            Console.WriteLine("The average amount of flats sold per area is " + (double)sum / count + ".");
        }

        static void Loops7()
        {
            Console.WriteLine("Enter the amount of hours the student does homework in a week.");
            double hours = double.Parse(Console.ReadLine());
            int students = 0;
            while (hours <= 70)
            {
                if (hours >= 15)
                {
                    students++;
                }
                Console.WriteLine("Enter the amount of hours the student does homework in a week.");
                hours = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The amount of students that do homework for 15 hours or more in a week is " + students + ".");
        }

        static void Loops8()
        {
            int fams = 0;
            int sum = 0;
            int fam6 = 0;
            Console.WriteLine("Enter the amount of family members in the family.");
            int famems = int.Parse(Console.ReadLine());
            while (famems > 0)
            {
                fams++;
                sum = sum + famems;
                if (famems >= 6)
                {
                    fam6++;
                }
                Console.WriteLine("Enter the amount of family members in the family.");
                famems = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The average amount of family members per family is " + (double)sum / fams + ".");
            Console.WriteLine("The amount of families with 6 or more family members is " + fam6 + ".");
        }

        static void Loops9()
        {
            double expensive, cheap;
            Console.WriteLine("Enter the hummus' price.");
            double hummusprice = double.Parse(Console.ReadLine());
            cheap = hummusprice;
            expensive = hummusprice;
            while (hummusprice >= 0)
            {
                if (cheap > hummusprice)
                {
                    cheap = hummusprice;
                }
                else if (expensive < hummusprice)
                {
                    expensive = hummusprice;
                }
                Console.WriteLine("Enter the hummus' price.");
                hummusprice = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The most expensive price for hummus is " + expensive + ".");
            Console.WriteLine("The cheapest price for hummus is " + cheap + ".");
        }

        static void Loops10()
        {
            double most, secondmost;
            Console.WriteLine("Enter the amount of Kilograms of apples the child collected.");
            double applekg1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of Kilograms of apples the child collected.");
            double applekg2 = double.Parse(Console.ReadLine());
            most = Math.Max(applekg1, applekg2);
            secondmost = Math.Min(applekg1, applekg2);
            Console.WriteLine("Enter the amount of Kilograms of apples the child collected.");
            applekg1 = double.Parse(Console.ReadLine());
            while (applekg1 >= 0)
            {
                if (applekg1 > most)
                {
                    secondmost = most;
                    most = applekg1;
                }
                else if (applekg1 > secondmost && applekg1 < most)
                {
                    secondmost = applekg1;
                }
                Console.WriteLine("Enter the amount of Kilograms of apples the child collected.");
                applekg1 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("First = " + most);
            Console.WriteLine("Second = " + secondmost);
        }

        static void Loops11()
        {
            double a, b, dif = 0;
            int count = 0;
            Console.WriteLine("Enter a number.");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number.");
            b = double.Parse(Console.ReadLine());
            while (count < 20 && a >= 0 && b >= 0 && dif != 1)
            {
                count ++;
                Console.WriteLine("Enter a number.");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number.");
                b = double.Parse(Console.ReadLine());
                if (a > b)
                {
                    dif = a - b;
                }
                else
                {
                    dif = b - a;
                }
                Console.WriteLine("The difference is " + dif + ".");
                Console.WriteLine("There are " + count + "number pairs.");
            }
            Console.WriteLine("Finish.");
        }

        static void Loops12()
        {
            int num, sum, digits;
            Console.WriteLine("Enter number.");
            num = int.Parse(Console.ReadLine());
            sum = 0;
            digits = 0;
            while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
                digits ++;
            }
            Console.WriteLine("Sum digits = " + sum);
            Console.WriteLine("Number of digits = " + digits);
        }

        static void Loops13()
        {
            int countA, countB;
            double weight;
            countA = 0;
            countB = 0;
            while (countA < 50 && countB < 70)
            {
                Console.WriteLine("Enter weight.");
                weight = double.Parse(Console.ReadLine());
                if (weight >= 150 && weight <= 250)
                {
                    countA = countA + 1;
                }
                else
                {
                    countB = countB + 1;
                }
            }
            if (countA == 50)
            {
                Console.WriteLine("Box A is full.");
            }
            else
            {
                Console.WriteLine("Box B is full.");
            }
            //No, no.
        }

        static void Loops14()
        {
            double num1, num2;
            int count = 1;
            Console.WriteLine("Enter number.");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number.");
            num2 = double.Parse(Console.ReadLine());
            while (num1 < num2)
            {
                num1 = num2;
                count ++;
                Console.WriteLine("Enter number.");
                num2 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(count + " good numbers were entered.");
        }

        static void Loops15()
        {
            int studentnum, count1 = 0, count2 = 0, count0 = 0;
            bool t1, t2;
            Console.WriteLine("Enter the student's number.");
            studentnum = int.Parse(Console.ReadLine());
            while (studentnum > 0)
            {
                Console.WriteLine("Did the student finish the first task? (Enter true / false)");
                t1 = bool.Parse(Console.ReadLine());
                Console.WriteLine("Did the student finish the second task? (Enter true / false)");
                t2 = bool.Parse(Console.ReadLine());
                if (t1)
                {
                    count1 ++;
                }
                if (t2)
                {
                    count2 ++;
                }
                else if (!t1)
                {
                    count0 ++;
                }
                Console.WriteLine("Enter the student's number.");
                studentnum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The amount of students who finished the first task is " + count1);
            Console.WriteLine("The amount of students who finished the second task is " + count2);
            Console.WriteLine("The amount of students who didn't finish any of the tasks is " + count0);
        }

        static void Loops16()
        {
            double grade, avg = 0;
            int count = 0;
            double sum = 0;
            Console.WriteLine("Enter 1 to start entering grades.");
            int check = int.Parse(Console.ReadLine());
            while (check == 1)
            {
                Console.WriteLine("Enter grade.");
                grade = double.Parse(Console.ReadLine());
                if (grade >= 50 && grade <= 90)
                {
                    sum = sum + grade;
                    count ++;
                    avg = (double) sum / count;
                }
                Console.WriteLine("Enter 1 to continue entering grades.");
                check = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The average grade for all grades between 50-90 is " + avg + ".");
        }

        static void Loops17()
        {
            double num;
            Console.WriteLine("Enter a number.");
            num = double.Parse(Console.ReadLine());
            while (num != 0)
            {
                Console.WriteLine(Math.Abs(num));
                Console.WriteLine("Enter a number.");
                num = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Finish.");
        }

        static void Loops18A()
        {
            int num1 = 1, num2 = 1;
            Console.Write($"{num1}, {num2}");
            int num3 = num1 + num2;
            while (num3 < 50)
            {
                Console.Write($", {num3}");
                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
            }
            Console.WriteLine();
            Console.WriteLine("Finish");
        }

        static void Loops18B()
        {
            int num1 = 1, num2 = 1;
            Console.Write($"{num1}, {num2}");
            int num3 = num1 + num2;
            int sum = 2;
            while (sum < 1000)
            {
                Console.Write($", {num3}");
                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
                sum = sum + num3;
            }
            Console.WriteLine();
            Console.WriteLine("Sum = " + (sum - num3));
            Console.WriteLine("Finish");
        }

        static void UsdToIls()
        {
            double uti, price;
            int count = 0;
            Console.WriteLine("Enter the exchange rate of 1 dollar in shekels.");
            uti = double.Parse(Console.ReadLine());
            Console.WriteLine("1 dollar = " + uti + " shekels.");
            Console.WriteLine("Enter a price (in dollars).");
            price = double.Parse(Console.ReadLine());
            while (count < 10)
            {
                Console.WriteLine(uti * price);
                Console.WriteLine("Enter a price (in dollars).");
                price = double.Parse(Console.ReadLine());
                count++;
            }
        }

        static void MoreWhile1()
        {
            string name;
            double grade;
            int count = 0;
            Console.WriteLine("Enter the student's name (enter FINISH to finish).");
            name = Console.ReadLine();
            while (name != "FINISH")
            {
                Console.WriteLine("Enter the student's grade.");
                grade = double.Parse(Console.ReadLine());
                Console.WriteLine(name + "'s grade is " + grade + "");
                if (grade > 95)
                {
                    count++;
                }
                Console.WriteLine("Enter the student's name (enter FINISH to finish).");
                name = Console.ReadLine();
            }
            Console.WriteLine("The amount of students who got a grade greater than 95 is " + count + ".");
        }

        static void MoreWhile2()
        {
            string customer;
            int dish;
            int count = 0;
            Console.WriteLine("Enter the customer's name (enter SOF to finish).");
            customer = Console.ReadLine();
            while (customer != "SOF")
            {
                Console.WriteLine("Enter the amount of dishes the customer has ordered.");
                dish = int.Parse(Console.ReadLine());
                Console.WriteLine(customer + " needs to pay " + (9 * dish) + " shekels");
                count++;
                Console.WriteLine("Enter the customer's name (enter SOF to finish).");
                customer = Console.ReadLine();
            }
            Console.WriteLine(count + " customer(s) were in the restaurant today.");
        }

        static void MoreWhile3()
        {
            double minprice, min, sum = 0;
            string customer;
            Console.WriteLine("Enter the price for 1 minute of calling someone abroad.");
            minprice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the customer's name (enter BYE to finish).");
            customer = Console.ReadLine();
            while (customer != "BYE")
            {
                Console.WriteLine("Enter the number of minutes the customer has called.");
                min = double.Parse(Console.ReadLine());
                Console.WriteLine(customer + " needs to pay " + (minprice * min) + ".");
                sum = sum + (minprice * min);
                Console.WriteLine("Enter the customer's name (enter BYE to finish).");
                customer = Console.ReadLine();
            }
            Console.WriteLine("The total price is " + sum + ".");
        }

        static void MoreWhile4()
        {
            int check, chagi = 0, hadas = 0;
            string name;
            Console.WriteLine("Enter the student's name (enter SOF to finish).");
            name = Console.ReadLine();
            while (name != "SOF")
            {
                Console.WriteLine("Enter who you want to vote for (1 - Chagi, 2 - Hadas).");
                check = int.Parse(Console.ReadLine());
                Console.Write(name + " voted for ");
                if (check == 1)
                {
                    chagi++;
                    Console.WriteLine("Chagi (1).");
                }
                else if (check == 2)
                {
                    hadas++;
                    Console.WriteLine("Hadas (2).");
                }
                else
                {
                    Console.WriteLine("no one (invalid number).");
                }
                Console.WriteLine("Enter the student's name (enter SOF to finish).");
                name = Console.ReadLine();
            }
            Console.WriteLine("Chagi (1) got " + chagi + " vote(s).");
            Console.WriteLine("Hadas (2) got " + hadas + " vote(s).");
        }

        static void MoreWhile5()
        {
            string act;
            int studentspa, sum = 0;
            Console.WriteLine("Enter the activity's name (enter BYE BYE to finish).");
            act = Console.ReadLine();
            while (act != "BYE BYE")
            {
                Console.WriteLine("Enter the number of students that came to the party and participate in that activity.");
                studentspa = int.Parse(Console.ReadLine());
                Console.WriteLine(studentspa + " students participate in " + act + ".");
                sum = sum + studentspa;
                Console.WriteLine("Enter the activity's name (enter BYE BYE to finish).");
                act = Console.ReadLine();
            }
            Console.WriteLine(sum + " students were at the party.");
            Console.WriteLine((10 * sum) + " shekels were gathered for the party.");
        }

        static void MoreWhile6()
        {
            string name;
            int fun, sum = 0;
            Console.WriteLine("Enter the child's name (enter END OF DAY to finish).");
            name = Console.ReadLine();
            while (name != "END OF DAY")
            {
                Console.WriteLine("Enter the amount of activities the child has participated in.");
                fun = int.Parse(Console.ReadLine());
                Console.WriteLine($"{name} needs to pay {fun * 4} shekels.");
                sum++;
                Console.WriteLine("Enter the child's name (enter END OF DAY to finish).");
                name = Console.ReadLine();
            }
            Console.WriteLine($"{sum} children were in the fun day.");
        }

        static void MoreWhile8()
        {
            string name;
            int age;
            Console.WriteLine("Enter the subscriber's name (enter SOF to finish).");
            name = Console.ReadLine();
            while (name != "SOF")
            {
                Console.WriteLine("Enter the age of the subscriber.");
                age = int.Parse(Console.ReadLine());
                if (age > 50)
                {
                    Console.WriteLine($"{name} got a gift card.");
                }
                else
                {
                    Console.WriteLine($"{name} got a book.");
                }
                Console.WriteLine("Enter the subscriber's name (enter SOF to finish).");
                name = Console.ReadLine();
            }
        }

        static void Songs()
        {
            double time, max, min;
            int i, maxi, mini;
            Console.Write("Enter the time of the song.");
            time = double.Parse(Console.ReadLine());
            max = time;
            min = time;
            maxi = 1;
            mini = 1;
            for (i = 2; i <= 100; i++)
            {
                Console.Write("Enter the time of the song.");
                time = double.Parse(Console.ReadLine());
                if (time > max)
                {
                    max = time;
                    maxi = i;
                }
                if (time < min)
                {
                    min = time;
                    mini = i;
                }
            }
            Console.WriteLine("The number of the longest song is " + maxi + " and its length is " + max + " minute(s).");
            Console.WriteLine("The number of the shortest song is " + mini + " and its length is " + min + " minute(s).");
        }

        static void For7_3()
        {
            //X**********X
        }

        static void For7_4()
        {
            Console.WriteLine("Enter a character.");
            char c = char.Parse(Console.ReadLine());
            for (int i = 0; i < 50; i++)
            {
                Console.Write(c);
            }
        }

        static void For7_5()
        {
            int num;
            Console.WriteLine("Enter 20 positive 2-digit numbers.");
            for (int i = 0; i < 20; i++)
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine(num / 10 + num % 10);
            }
        }

        static void For7_9()
        {
            int listSize;
            Console.WriteLine("Enter the length of the list.");
            listSize = int.Parse(Console.ReadLine());
            int capsum = 0;
            char c;
            for (int i = 0; i < listSize; i++)
            {
                Console.WriteLine("Enter a character.");
                c = char.Parse(Console.ReadLine());
                if (c >= 'A' && c <= 'Z')
                {
                    capsum++;
                }
            }
            Console.WriteLine($"The number of capital letters entered is {capsum}");
        }

        static void For7_10()
        {
            //A: 10 times.

            //B: 1 time.

            //C:
            int listSize = 3;
            char letter;
            int counter = 0;
            for (int i = 1; i <= listSize; i++)
            {
                Console.Write("Enter a char: ");
                letter = char.Parse(Console.ReadLine());
                if (letter != 'A')
                {
                    counter++;
                }
            }
            Console.WriteLine("There are {0} letters different than A", counter);
        }

        static void For7_11()
        {
            //A: 5.

            //B: Yes, d.

            //C: 16 times.

            //D: 1 2 2 1 2 2 2 1 1 1 1 2 1 2 1 1

            //E: X 1 X X X X X X X X X X X X X X

            //F: There is 1 X in them.

            //G: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16.

            //H: The purpose is to check how many time the score was X, scoreX.
        }

        static void For7_12()
        {
            Console.WriteLine("Enter the list's length.");
            int length = int.Parse(Console.ReadLine());
            double num;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter a number.");
                num = double.Parse(Console.ReadLine());
                sum += (int)num;
            }
            Console.WriteLine($"The sum of the int parts of the numbers entered is {sum}.");
        }

        static void For7_13()
        {
            Console.WriteLine("Enter a number.");
            int amt = int.Parse(Console.ReadLine());
            int num;
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < amt; i++)
            {
                num = rnd.Next(10, 51);
                if (num % 2 == 0)
                {
                    sum++;
                }
            }
            Console.WriteLine($"{sum} number(s) were even.");
        }

        static void For7_14()
        {
            Random rnd = new Random();
            int sum = 0;
            int num;
            for (int i = 0; i < 10; i++)
            {
                num = rnd.Next(100, 1000);
                if (num % 2 == 1)
                {
                    sum += num;
                }
            }
            Console.WriteLine($"The sum of the odd numbers is {sum}.");
        }

        static void For7_15()
        {
            Console.WriteLine("Enter 50 numbers.");
            int num;
            int mult = 1;
            for (int i = 0; i < 50; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num < 10)
                {
                    mult *= num;
                }
            }
            Console.WriteLine($"The product of the numbers smaller than 10 is {mult}.");
        }

        static void For7_17()
        {
            Console.WriteLine("Enter a number.");
            int num = int.Parse(Console.ReadLine());
            int mult = 1;
            for (int i = 1; i <= num; i++)
            {
                mult *= i;
            }
            Console.WriteLine($"The product is {mult}.");
        }

        static void For7_18()
        {
            Console.WriteLine("Enter a number.");
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += (double)1 / i;
            }
            Console.WriteLine($"The sum is {sum}.");
        }

        static void For7_19()
        {
            for (int i = 1; i <= 50; i = i * 2)
            {
                Console.WriteLine(i);
            }
            //A:

            /*
              i  | i <= 50 | Output
            -----------------------
              1  |         |
                 |   True  |
                 |         |   1
            -----------------------
              2  |         |
                 |   True  |
                 |         |   2
            -----------------------
              4  |         |
                 |   True  |
                 |         |   4
            -----------------------
              8  |         |
                 |   True  |
                 |         |   8
            -----------------------
              16 |         |
                 |   True  |
                 |         |   16
            -----------------------
              32 |         |
                 |   True  |
                 |         |   32
            -----------------------
              64 |         |
                 |  False  |
            */

            //B: Prints all numbers smaller than N that are Math.Pow(2, x).
        }

        static void For7_20()
        {
            Console.WriteLine("Enter a number.");
            int num = int.Parse(Console.ReadLine());
            for (int i = num - 1; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void For32()
        {
            int num1 = 1, num2 = 1, num3;
            Console.Write($"{num1}, {num2}");
            for (int i = 0; i < 10; i++)
            {
                num3 = num2;
                num2 += num1;
                num1 = num3;
                Console.Write($", {num2}");
            }
        }

        static void For33()
        {
            Console.WriteLine("Enter 2 numbers.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3;
            if (num1 > num2)
            {
                num3 = num1;
                num1 = num2;
                num2 = num3;
            }
            Console.Write(num1);
            for (int i = num1 + 1; i <= num2; i++)
            {
                Console.Write($" {i}");
            }
        }

        static void For34()
        {
            Console.WriteLine("Enter 2 numbers.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3;
            int sum = 0;
            if (num1 > num2)
            {
                num3 = num1;
                num1 = num2;
                num2 = num3;
            }
            for (int i = num1; i <= num2; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        static void For40()
        {
            Console.WriteLine("Enter a number.");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void For44()
        {
            Console.WriteLine("Enter 10 numbers.");
            int num, sum = 0, count = 0;
            for (int i = 0; i < 10; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                    sum += num;
                    count++;
                }
            }
            Console.WriteLine($"The sum of the even numbers is {sum}.");
            Console.WriteLine($"The number of even numbers entered is {count}.");
        }

        static void For45()
        {
            Console.WriteLine("Enter 7 heights.");
            int ht, count = 0;
            for (int i = 0; i < 7; i++)
            {
                ht = int.Parse(Console.ReadLine());
                if (ht < 75)
                {
                    Console.WriteLine(ht);
                    count++;
                }
            }
            Console.WriteLine($"The number of plants that have a height lower than 75 is {count}.");
        }

        static void MaxNegative()
        {
            bool neg = false;
            int max, g;
            max = 0;
            for (int i = 0; i < 5; i++)
            {
                g = int.Parse(Console.ReadLine());
                if (g < 0)
                {
                    if (!neg) //neg == false
                    {
                        neg = true;
                        max = g;
                    }
                    else if (g > max)
                    {
                        max = g;
                    }
                }
            }
            Console.WriteLine(max);
        }

        static void Loops7_24()
        {
            Console.WriteLine("Enter 40 grades.");
            int grade;
            int maxf = -1;
            for (int i = 0; i < 40; i++)
            {
                grade = int.Parse(Console.ReadLine());
                if (grade > maxf && grade < 55)
                {
                    maxf = grade;
                }
            }
            if (maxf >= 0)
            {
                Console.WriteLine($"The highest grade for a students who failed this test is {maxf}.");
            }
            else
            {
                Console.WriteLine("No one has failed the test.");
            }
        }

        static void Loops7_25()
        {
            int players, num, scores, maxscores = 0, max = 0;
            Console.WriteLine("Enter the number of players.");
            players = int.Parse(Console.ReadLine());
            for (int i = 0; i < players; i++)
            {
                Console.WriteLine("Enter the player's number.");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter the number of times player {num} has scored this season.");
                scores = int.Parse(Console.ReadLine());
                if (scores > maxscores)
                {
                    max = num;
                    maxscores = scores;
                }
            }
            Console.WriteLine($"The player who has scored most this season is player {max}.");
        }

        static void Loops7_28()
        {
            int grade, sum = 0;
            Console.WriteLine("Enter a grade (enter 101 to finish).");
            grade = int.Parse(Console.ReadLine());
            while (grade != 101)
            {
                if (grade >= 60)
                {
                    sum++;
                }
                Console.WriteLine("Enter a grade (enter 101 to finish).");
                grade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number of grades that are higher or equal to 60 is {sum}.");
        }

        static void Loops7_29()
        {
            int av = 0, bv = 0;
            char ab;
            Console.WriteLine("Enter the votes (A - Alon, B - Beni, # - finish).");
            ab = char.Parse(Console.ReadLine());
            while (ab != '#')
            {
                if (ab == 'A')
                {
                    av++;
                }
                else
                {
                    bv++;
                }
                ab = char.Parse(Console.ReadLine());
            }
            if (av > bv)
            {
                Console.WriteLine("Alon wins.");
            }
            else
            {
                Console.WriteLine("Alon didn't win.");
            }
        }

        static void Loops7_30()
        {
            int votes = 0, lvote = 0, v;
            Console.WriteLine("Enter a vote (1 - mouse, 2 - lion, 3 - ant, 0 - finish).");
            v = int.Parse(Console.ReadLine());
            while (v != 0)
            {
                if (v == 2)
                {
                    lvote++;
                }
                votes++;
                Console.WriteLine("Enter a vote (1 - mouse, 2 - lion, 3 - ant, 0 - finish).");
                v = int.Parse(Console.ReadLine());
            }
            if ((double)(0.3 * votes) > lvote)
            {
                Console.WriteLine("Be very careful.");
            }
            else if (lvote > (double)(0.7 * votes))
            {
                Console.WriteLine("No need to be careful.");
            }
            else
            {
                Console.WriteLine("Be a little careful.");
            }
        }

        static void Loops7_31()
        {
            string word = "";
            char c;
            Console.WriteLine("Enter a word (capital letters only, one letter at a time, enter * to finish).");
            c = char.Parse(Console.ReadLine());
            while (c != '*')
            {
                if (c == 'Z')
                {
                    word += 'A';
                }
                else
                {
                    word += (char)(c + 1);
                }
                c = char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The word you got is {word}.");
        }

        static void Loops7_32()
        {
            int d1, d2, count = 1;
            Random roll = new Random();
            d1 = roll.Next(1, 7);
            d2 = roll.Next(1, 7);
            while ((d1 != 5 && d2 != 6) || (d1 != 6 && d2 != 5))
            {
                count++;
                d1 = roll.Next(1, 7);
                d2 = roll.Next(1, 7);
            }
            Console.WriteLine($"The number of times the dice rolled until they got 5-6 or 6-5 is {count}.");
        }

        static void Loops7_39()
        {
            int num, mult = 1;
            Console.WriteLine("Enter a number.");
            num = int.Parse(Console.ReadLine());
            while (mult < num)
            {
                mult *= 2;
            }
            Console.WriteLine(mult);
        }

        static void Loops7_41()
        {
            int x, y;
            Console.Write("Enter a number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            y = int.Parse(Console.ReadLine());
            while (x > y)
            {
                x = x - y;
            }
            Console.WriteLine($"x % y = {x}");
        }

        static void Loops7_42()
        {
            int x, y, i;
            Console.Write("Enter a number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            y = int.Parse(Console.ReadLine());
            for (i = 0; x > y; i++)
            {
                x = x - y;
            }
            Console.WriteLine($"x / y = {i}");
        }

        static void Loops7_43()
        {
            double length;
            int p1 = 0, p2 = 0;
            Console.Write("Enter the length of the line: ");
            length = double.Parse(Console.ReadLine());
            while (length >= 1)
            {
                length /= 2;
                if (p2 >= p1)
                {
                    p1++;
                }
                else
                {
                    p2++;
                }
            }
            if (p1 > p2)
            {
                Console.WriteLine("Player 1 wins.");
            }
            else
            {
                Console.WriteLine("Player 2 wins.");
            }
        }

        static void Loops7_45()
        {
            int firstAmt, max, current;
            Console.Write("Enter the starting number of the bacterias: ");
            firstAmt = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum amount the bacterias can reach: ");
            max = int.Parse(Console.ReadLine());
            for (current = firstAmt; current < max; current *= 5)
            {

            }
            Console.WriteLine($"The number of bacterias at the last minute is {current}");
        }

        static void StaticFuncs1A_ut()
        {
            Console.WriteLine(Functions.StaticFuncs1A_f(2, 2009));
            Console.WriteLine(Functions.StaticFuncs1A_f(7, 2009));
            Console.WriteLine(Functions.StaticFuncs1A_f(4, 2025));
            Console.WriteLine(Functions.StaticFuncs1A_f(11, 2010));
        }

        static void StaticFuncs1B_t()
        {
            int month, year, countMale = 0, countFemale = 0, sex;
            bool b;
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Month: ");
                month = int.Parse(Console.ReadLine());
                Console.Write("Year: ");
                year = int.Parse(Console.ReadLine());
                b = Functions.StaticFuncs1A_f(month, year);
                if (b)
                {
                    Console.Write("Male or female? (1 - male, 2 - female) ");
                    sex = int.Parse(Console.ReadLine());
                    if (sex == 1)
                    {
                        countMale++;
                    }
                    else
                    {
                        countFemale++;
                    }
                }
            }
            Console.WriteLine($"The number of males born in the months 1-6 in the year 2009 are {countMale}.");
            Console.WriteLine($"The number of females born in the months 1-6 in the year 2009 are {countFemale}.");
        }

        static void StaticFuncs2A_ut()
        {
            Console.WriteLine(Functions.StaticFuncs2A_f(23, 60, 1));
            Console.WriteLine(Functions.StaticFuncs2A_f(44, 60, 2));
            Console.WriteLine(Functions.StaticFuncs2A_f(99, 60, 1));
            Console.WriteLine(Functions.StaticFuncs2A_f(30, 60, 1));
        }

        static void StaticFuncs2B_t()
        {
            int age, years, count = 0;
            double maxSpeed, speed;
            for (int i = 0; i < 500; i++)
            {
                Console.Write("Enter age: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Enter the maximum speed in the area: ");
                maxSpeed = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of years you have a driver's license: ");
                years = int.Parse(Console.ReadLine());
                Console.WriteLine($"The maximum speed you can drive is {Functions.StaticFuncs2A_f(age, maxSpeed, years)}.");
                Console.Write("Enter your speed: ");
                speed = double.Parse(Console.ReadLine());
                if (speed <= Functions.StaticFuncs2A_f(age, maxSpeed, years))
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of drivers who were driving their allowed speed is {count}.");
        }

        static void StaticFuncs3A_ut()
        {
            Console.WriteLine(Functions.StaticFuncs3A_f(10, 1500));
            Console.WriteLine(Functions.StaticFuncs3A_f(7, 2763));
            Console.WriteLine(Functions.StaticFuncs3A_f(2, 100));
            Console.WriteLine(Functions.StaticFuncs3A_f(12, 9999));
            Console.WriteLine(Functions.StaticFuncs3A_f(6, 1333));
            Console.WriteLine(Functions.StaticFuncs3A_f(3, 911));
        }

        static void StaticFuncs3B_t()
        {
            int subYears, count = 0;
            double money, sum = 0;                                                             
            for (int i = 0; i < 5000; i++)
            {
                Console.Write("Enter the number of subscription years: ");
                subYears = int.Parse(Console.ReadLine());
                Console.Write("Enter the amount of money spent monthly: ");
                money = double.Parse(Console.ReadLine());
                if (Functions.StaticFuncs3A_f(subYears, money) != 0)
                {
                    count++;
                }
                sum += Functions.StaticFuncs3A_f(subYears, money);
            }
            Console.WriteLine($"The number of people who got a gift card is {count}.");
            Console.WriteLine($"The sum of all the gift cards' money is {sum}.");
        }

        static void StaticFuncs4A_ut()
        {
            Console.WriteLine(Functions.StaticFuncs4A_f(16));
            Console.WriteLine(Functions.StaticFuncs4A_f(12));
            Console.WriteLine(Functions.StaticFuncs4A_f(22));
        }

        static void StaticFuncs4B_t()
        {
            int age, hours, count = 0;
            for (int i = 0; i < 492; i++)
            {
                Console.Write("Enter age: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of hours you listened to music: ");
                hours = int.Parse(Console.ReadLine());
                if (Functions.StaticFuncs4A_f(age) && hours > 3)
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of people whose age is between 15 and 18 and listened to music to more than 3 hours is {count}.");
        }

        static void StaticFuncs5A_ut()
        {
            Console.WriteLine(Functions.StaticFuncs5A_f(1, 2, 3));
            Console.WriteLine(Functions.StaticFuncs5A_f(100, 99, 7));
            Console.WriteLine(Functions.StaticFuncs5A_f(95, 97, 98));
            Console.WriteLine(Functions.StaticFuncs5A_f(93, 54, 55));
        }

        static void StaticFuncs5B_t()
        {
            int students, grade1, grade2, grade3, count = 0;
            string name;
            Console.Write("Enter the number of students: ");
            students = int.Parse(Console.ReadLine());
            for (int i = 0; i < students; i++)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                Console.Write("Enter your first grade: ");
                grade1 = int.Parse(Console.ReadLine());
                Console.Write("Enter your second grade: ");
                grade2 = int.Parse(Console.ReadLine());
                Console.Write("Enter your third grade: ");
                grade3 = int.Parse(Console.ReadLine());
                if (Functions.StaticFuncs5A_f(grade1, grade2, grade3) == 3)
                {
                    Console.WriteLine("You got in the national tournament.");
                    count++;
                }
                else
                {
                    Console.WriteLine("You didn't get in the national tournament.");
                }
            }
            Console.WriteLine($"The number of students who got to the national tournament is {count}.");
        }

        static void StaticFuncs6A_ut()
        {
            Console.WriteLine(Functions.StaticFuncs6A_f(2));
            Console.WriteLine(Functions.StaticFuncs6A_f(6));
            Console.WriteLine(Functions.StaticFuncs6A_f(12));
            Console.WriteLine(Functions.StaticFuncs6A_f(3));
        }

        static void StaticFuncs6A_t()
        {
            int num, count = 0;
            for (int i = 0; i < 850; i++)
            {
                Console.Write("Enter the number of things you have ordered: ");
                num = int.Parse(Console.ReadLine());
                if (!Functions.StaticFuncs6A_f(num))
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of people who need to pay for shipping is {count}.");
        }

        static void StaticFuncs8A_ut()
        {
            Console.WriteLine(Functions.StaticFuncs8A_f("male", "female"));
            Console.WriteLine(Functions.StaticFuncs8A_f("female", "male"));
            Console.WriteLine(Functions.StaticFuncs8A_f("female", "female"));
            Console.WriteLine(Functions.StaticFuncs8A_f("male", "male"));
        }
        
        static void StaticFuncs8B_t()
        {
            string sex1, sex2;
            int countm = 0, countf = 0;
            for (int i = 0; i < 1371; i++)
            {
                Console.Write("Enter the first twin's sex: ");
                sex1 = Console.ReadLine();
                Console.Write("Enter the second twin's sex: ");
                sex2 = Console.ReadLine();
                if (Functions.StaticFuncs8A_f(sex1, sex2) == 'm')
                {
                    countm += 2;
                }
                if (Functions.StaticFuncs8A_f(sex1, sex2) == 'f')
                {
                    countf += 2;
                }
                if (Functions.StaticFuncs8A_f(sex1, sex2) == 'v')
                {
                    countm++;
                    countf++;
                }
            }
            if (countm > countf)
            {
                Console.WriteLine("MALE");
            }
            else if (countf > countm)
            {
                Console.WriteLine("FEMALE");
            }
            else
            {
                Console.WriteLine("EQUAL");
            }
        }

        static void StaticFuncs10A_ut()
        {
            Console.WriteLine(Functions.StaticFuncs10A_f(1200, 2359));
            Console.WriteLine(Functions.StaticFuncs10A_f(1424, 2111));
            Console.WriteLine(Functions.StaticFuncs10A_f(1800, 2345));
        }

        static void StaticFuncs10B_t()
        {
            int timestart, timeend, min;
            Console.Write("Enter the time you started: ");
            timestart = int.Parse(Console.ReadLine());
            Console.Write("Enter the time you finished: ");
            timeend = int.Parse(Console.ReadLine());
            Console.WriteLine($"You ran for {Functions.StaticFuncs10A_f(timestart, timeend)} minutes.");
            min = Functions.StaticFuncs10A_f(timestart, timeend);
            for (int i = 1; i < 127; i++)
            {
                Console.Write("Enter the time you started: ");
                timestart = int.Parse(Console.ReadLine());
                Console.Write("Enter the time you finished: ");
                timeend = int.Parse(Console.ReadLine());
                Console.WriteLine($"You ran for {Functions.StaticFuncs10A_f(timestart, timeend)} minutes.");
                if (Functions.StaticFuncs10A_f(timestart, timeend) < min)
                {
                    min = Functions.StaticFuncs10A_f(timestart, timeend);
                }
            }
            Console.WriteLine($"The minimum time is {min} mintutes.");
        }

        static void StaticFuncs12A_ut()
        {
            Console.WriteLine(Functions.StaticFuncs12A_f(12, 2));
            Console.WriteLine(Functions.StaticFuncs12A_f(4, 7));
            Console.WriteLine(Functions.StaticFuncs12A_f(20, 40));
        }

        static void StaticFuncs12AB_ut()
        {
            Console.WriteLine(Functions.StaticFuncs12AB_f(2.2, 4.4, 6));
            Console.WriteLine(Functions.StaticFuncs12AB_f(11, 33, 6));
            Console.WriteLine(Functions.StaticFuncs12AB_f(3, 12, 10));
        }

        static void StaticFuncs12B_ut()
        {
            Console.WriteLine(Functions.StaticFuncs12B_f(2));
            Console.WriteLine(Functions.StaticFuncs12B_f(3));
        }

        static void StaticFuncs12C_t()
        {
            double totalPrice;
            int num;
            for (int i = 0; i < 142; i++)
            {
                Console.Write("Enter the number of books you bought: ");
                num = int.Parse(Console.ReadLine());
                totalPrice = Functions.StaticFuncs12B_f(num);
                Console.WriteLine($"Your total price is {totalPrice}.");
            }
        }

        static void StaticFuncs14A_ut()
        {
            Console.WriteLine(Functions.StaticFuncs14A_f(445, 3));
            Console.WriteLine(Functions.StaticFuncs14A_f(12865, 0));
        }

        static void StaticFuncs14B_ut()
        {
            Console.WriteLine(Functions.StaticFuncs14B_f(2));
            Console.WriteLine(Functions.StaticFuncs14B_f(4));
            Console.WriteLine(Functions.StaticFuncs14B_f(7));
        }

        static void StaticFuncs14C_t()
        {
            int firstDigit, num, count9 = 0;
            for (int i = 0; i < 980; i++)
            {
                Console.WriteLine("Enter the first digit you have pressed:");
                firstDigit = int.Parse(Console.ReadLine());
                num = Functions.StaticFuncs14B_f(firstDigit);
                if (num % 10 == 9)
                {
                    count9++;
                }
            }
            Console.WriteLine($"The number of people who finished the call with the number 9 is {count9}.");
        }

        static void Nested_Loops()
        {
            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
        }

        static void NestedLoops7_66()
        {
            /*
            
            A:
            
            *****
            *****
            *****
            *****
            *****
            

            B:

            *
            **
            ***
            ****
            *****


            C:

            12345
            12345
            12345
            12345
            12345


            D:

            *****
            ****
            ***
            **
            *

            */
        }

        static void NestedLoops7_67_A()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void NestedLoops7_67_B()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void NestedLoops7_67_C()
        {
            for (int i = 4; i >= -4; i--)
            {
                for (int j = 0; j <= Math.Abs(i); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void NestedLoops7_67_D()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void NestedLoops7_67_E()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void NestedLoops7_67_F()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void NestedLoops7_67_G()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void NestedLoops7_67_H()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void NestedLoops7_68()
        {
            const int STUDENT_NUM = 40;
            const int GRADE_NUM = 20;
            double grade;
            double sum = 0;
            for (int i = 1; i <= STUDENT_NUM; i++)
            {
                for (int j = 1; j <= GRADE_NUM; j++)
                {
                    Console.WriteLine("Enter next student grade: ");
                    grade = int.Parse(Console.ReadLine());
                    sum = sum + grade;
                }
            }
            Console.WriteLine(sum / 20.0);
        }

        static void NestedLoops7_69()
        {
            int num, n, length = 1, maxLength = 0;
            Console.Write("Enter the number of rows: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                length = 0;
                Console.WriteLine("Enter numbers:");
                n = int.Parse(Console.ReadLine());
                while (n != -1)
                {
                    n = int.Parse(Console.ReadLine());
                    length++;
                }
                if (length > maxLength)
                {
                    maxLength = length;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"The longest row of numbers' length is {maxLength}.");
        }

        static void NestedLoops7_70()
        {
            int workers;
            double sum = 0, minSum = 0, payment = 0, lastPoorPayment = 0;
            Console.Write("Enter the number of workers: ");
            workers = int.Parse(Console.ReadLine());
            for (int i = 0; i < workers; i++)
            {
                sum = 0;
                Console.WriteLine("Enter all payments you got last year:");
                for (int j = 0; j < 12; j++)
                {
                    payment = double.Parse(Console.ReadLine());
                    sum += payment;
                }
                if (i == 0)
                {
                    minSum = sum;
                    lastPoorPayment = payment;
                }
                else if (sum < minSum)
                {
                    minSum = sum;
                    lastPoorPayment = payment;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"The last payment the worker whose total year payment was the lowest is {lastPoorPayment}.");
        }

        static void NestedLoops47()
        {
            double price = 0, sum = 0, maxSum = 0;
            for (int i = 1; i <= 3; i++)
            {
                sum = 0;
                Console.WriteLine("Enter the prices of the 5 pen types:");
                for (int j = 0; j < 5; j++)
                {
                    price = double.Parse(Console.ReadLine());
                    sum += price;
                }
                if (i == 1)
                {
                    maxSum = sum;
                }
                else if (sum > maxSum)
                {
                    maxSum = sum;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"The most expensive total price of all 5 pen types is {maxSum}.");
        }

        static void NestedLoops48()
        {
            double sum = 0, grade, avg, minAvg = 0;
            for (int i = 1; i <= 3; i++)
            {
                sum = 0;
                Console.WriteLine("Enter the 4 grades of the students in the group.");
                for (int j = 1; j <= 4; j++)
                {
                    grade = double.Parse(Console.ReadLine());
                    sum += grade;
                }
                avg = sum / 4;
                if (i == 1)
                {
                    minAvg = avg;
                }
                else if (avg < minAvg)
                {
                    minAvg = avg;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"The group with the smallest average grade is {minAvg}.");
        }

        static void WordNum()
        {
            string str = "";
            int words = 1;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    words++;
                }
            }
            Console.WriteLine(words);
        }

        public static void LapTime()
        {
            double time = 0, sum = 0, avg;
            string times = "", crntT = "";
            int count = 4, countB = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("What is your time? ");
                time = double.Parse(Console.ReadLine());
                sum += time;
                times += time.ToString() + " ";
            }
            avg = sum / count;
            for (int i = 0; i < times.Length; i += 2)
            {
                crntT = "";
                for (int j = i; times[j] != ' '; j++)
                {
                    crntT += times[j];
                    if (times[j + 1] == ' ')
                    {
                        i += j;
                    }
                }
                if (double.Parse(crntT) < avg)
                {
                    countB++;
                }
            }
            Console.WriteLine($"The average is {avg}.");
            Console.WriteLine($"The number of people whose time is below average is {countB}.");
        }
    }
}
