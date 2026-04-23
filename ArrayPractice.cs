using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AdirEf10th
{
    internal class ArrayPractice
    {
        public static void ArrayPracticeUT()
        {
            //Targil1();
            //Array10_6();
            //Array10_7();
            //Array10_12();
            //Array10_18();
            //Array10_19();
            //Array10_23A();
            //Array10_23B();
            //Array10_24();
            //Array10_31();
            //Array10_33();
            //Array10_34();
            //Array10_36();
            //Array10_37();
            //Array10_38();
            //Array10_40();
            //Array10_41();
            //Array10_42();
            //Array_Extra1();
            //Array_Extra3();
            //Array_Extra4();
            //Array_Extra5();
            //Array_More1();
            //string[] am2strs = {"A", "B", "C", "D", "E"};
            //int[] am2ints = {100, 90, 80, 85, 50};
            //Array_More2(am2strs, am2ints);
            //Array_More3(5);
            //Array_More4(4);
            //int[] arr = {1, 0, 0, 0};
            //Array_More5A(arr);
            //Array_More5B(arr);
            //Array_More6A(95, 90, 90);
            //int[] p = {95, 100, 80};
            //int[] s = {90, 87, 92};
            //int[] t = {90, 77, 84};
            //Array_More6B(p, s, t);
            //int[] arr1 = {2, 5, 7, 9, 10, 14};
            //int[] arr2 = {1, 4, 7, 2, 18, 9, 22, 5, 10};
            //Array_More7(arr1, arr2, 2);
            //int[] arr = {1, 8, 5};
            //Console.WriteLine(Array_More8(arr));
            //Array_More9A(17);
            //Array_More9B();
            //Console.WriteLine(Array_More10A(6, 2, 9, 1));
            //int[] arr = {2, 5, 6, 1, 9, 32, 17, 22, 8};
            //Console.WriteLine(Array_More10B(arr));
            //Array_More10C();
            //int[] r = Array_More11A(5);
            //Console.WriteLine(Array_More11B(r, 0));
            //Array_More11C();
            //Console.WriteLine(Array_More12A());
            //double[] a = {9, 8, 7, 6, 6, 6, 6.5, 8.5, 8.8, 4, 4, 10};
            //Console.WriteLine(Array_More12B(a));
            //Array_More12C();
        }

        public static void Targil1()
        {
            double[] lapTime = new double[5];
            double sum = 0, avrg;
            int count = 0;
            for (int i = 0; i < lapTime.Length; i++)
            {
                Console.Write("Enter lap time: ");
                lapTime[i] = double.Parse(Console.ReadLine());
                sum += lapTime[i];
            }
            avrg = sum / lapTime.Length;
            for (int i = 0; i < lapTime.Length; i++)
            {
                if (lapTime[i] < avrg)
                {
                    count++;
                }
            }
            Console.WriteLine("Total below avrg: " + count);
            /*
            lapTime[0] = 17.3;
            Console.WriteLine(lapTime[0]);
            int x = lapTime.Length;
            Console.WriteLine(x);
            lapTime[x - 1] = -17.5;
            Console.WriteLine(lapTime[x - 1]);
            for (int i = 0; i < lapTime.Length; i++)
            {
                Console.WriteLine($"lapTime[{i}]={lapTime[i]}");
            }
            */
        }

        public static void Array10_6()
        {
            double[] grades = new double[10];
            double[] avgDist = new double[10];
            double sum = 0, avg;
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter your grade: ");
                grades[i] = double.Parse(Console.ReadLine());
                sum += grades[i];
            }
            avg = sum / grades.Length;
            Console.WriteLine($"The average grade is {avg}.");
            for (int i = 0; i < avgDist.Length; i++)
            {
                avgDist[i] = Math.Abs(avg - grades[i]);
                Console.WriteLine($"The distance between grade #{i + 1} and the average grade is {avgDist[i]}.");
            }
        }

        public static void Array10_7()
        {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i * i;
                Console.WriteLine($"nums[{i}] = {nums[i]}");
            }
        }

        public static void Array10_8()
        {
            /*
            A:
            Shows the values in index i that are bigger than their indexes.

            B:

            int[] t = new int[20];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == i * 2)
                {
                    Console.WriteLine(i);
                }
            }
            */
        }

        public static void Array10_12()
        {
            int[] nums;
            int x;
            Console.Write("Enter a positive and even number: ");
            x = int.Parse(Console.ReadLine());
            nums = new int[x];
            for (int i = 0; i < (x / 2); i++)
            {
                nums[i] = 0;
            }
            for (int i = (x / 2); i < x; i++)
            {
                nums[i] = 1;
            }
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        public static void Array10_13()
        {
            /*
            A:
            Prints the value in arr[i (the index)] if the value is dividable by 5 without a remainder.

            B:
            Prints the value in arr[i (the index)] if i (the index) is dividable by 5 without a remainder.

            C:
            for (int i = 0; i < arr.Length; i += 5)
            {
                Console.WriteLine(arr[i]);
            }
            */
        }

        public static void Array10_17()
        {
            /*
            A:
            At first it prints if arr's value in index position is the same as arr's value in index position - 1, and then it prints if arr's value in index position is the same as arr's value in index position + 1.

            B:
            Prints the number of times arr's value in index position is the same as arr's value in index position + i (loop's number).

            C:
            for (int i = 0; i < 20; i++)
            {
                if (arr[position + i] > arr[position])
                {
                    Console.WriteLine(position + i);
                }
            }

            D:
            for (int i = 0; i < 20; i++)
            {
                if (arr[position] == arr[position + i] + 1)
                {
                    Console.WriteLine(position + i);
                }
            }
            */
        }

        public static void Array10_18()
        {
            char[] strch = new char[20];
            string str;
            char end1, end2;
            int count = 0;
            Console.Write("Enter a string of 20 characters: ");
            str = Console.ReadLine();
            for (int i = 0; i < strch.Length; i++)
            {
                strch[i] = str[i];
            }
            end1 = strch[strch.Length - 2];
            end2 = strch[strch.Length - 1];
            for (int i = 0; i < strch.Length - 2; i++)
            {
                if (strch[i] == end1 && strch[i + 1] == end2)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void Array10_19()
        {
            int sqs, minVal, maxVal, start, roll, end;
            int[] places;
            Console.Write("Enter the number of squares on the board: ");
            sqs = int.Parse(Console.ReadLine());
            places = new int[sqs + 1];
            Console.Write("Enter the minimum value in each square: ");
            minVal = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum value in each square: ");
            maxVal = int.Parse(Console.ReadLine());
            Console.Write("Enter the number you rolled from the dice: ");
            roll = int.Parse(Console.ReadLine());
            for (int i = 0; i < places.Length; i++)
            {
                places[i] = maxVal - minVal - i % (maxVal - minVal);
            }
            Console.Write("Enter the starting position of the player: ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of sides on the dice: ");
            if (places[start + roll] > roll)
            {
                end = start - roll;
            }
            else
            {
                end = start + roll;
            }
            Console.WriteLine($"The player rolled {roll}.");
            Console.WriteLine($"the value in place of start + roll is {places[start + roll]}.");
            Console.WriteLine($"The ending position of the player is {end}.");
        }

        public static void Array10_22()
        {
            //A:
            //All will have the same value.

            //B:
            //ltf = arr[arr.Length - 1];
            //for (int i = arr.Length - 1; i >= 0; i++)
            //{
            //    arr[i] = arr[i - 1];
            //}
            //arr[0] = ltf;
        }

        public static void Array10_23A()
        {
            string[] names, newNames;
            int num;
            string ftl;
            Console.Write("Enter the number of people: ");
            num = int.Parse(Console.ReadLine());
            names = new string[num];
            newNames = new string[num];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter the name of person #{i + 1}: ");
                names[i] = Console.ReadLine();
            }
            newNames = names;
            for (int i = 0; i < 75 / 20; i++)
            {
                ftl = newNames[0];
                names = newNames;
                for (int j = 1; j < newNames.Length; j++)
                {
                    newNames[j - 1] = names[j];
                }
                newNames[newNames.Length - 1] = ftl;
            }
            Console.Write("The order of the people after an hour and a quarter is");
            for (int i = 0; i < newNames.Length; i++)
            {
                Console.Write($" {newNames[i]}");
                if (i != newNames.Length - 1)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
        }

        public static void Array10_23B()
        {
            string[] names, newNames, boys, newBoys;
            int boysN, girlsN;
            string fbtl;
            Console.Write("Enter the number of boys: ");
            boysN = int.Parse(Console.ReadLine());
            boys = new string[boysN];
            newBoys = new string[boys.Length];
            Console.Write("Enter the number of girls: ");
            girlsN = int.Parse(Console.ReadLine());
            names = new string[boysN + girlsN + 4];
            newNames = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter the name of person #{i + 1}");
                if (i == 0)
                {
                    Console.Write(" (guide)");
                }
                else if (i == names.Length - 3)
                {
                    Console.Write(" (medic)");
                }
                else if (i == names.Length - 2)
                {
                    Console.Write(" (accompanier)");
                }
                else if (i == names.Length - 1)
                {
                    Console.Write(" (rearguard)");
                }
                Console.Write(": ");
                names[i] = Console.ReadLine();
                if (i > girlsN && i < names.Length - 3)
                {
                    boys[i - girlsN - 1] = names[i];
                }
            }
            newNames = names;
            newBoys = boys;
            for (int i = 0; i < 75 / 20; i++)
            {
                fbtl = newBoys[0];
                boys = newBoys;
                for (int j = 1; j < newBoys.Length; j++)
                {
                    newBoys[j - 1] = boys[j];
                }
                newBoys[newBoys.Length - 1] = fbtl;
            }
            for (int i = 0; i < newBoys.Length; i++)
            {
                newNames[i + girlsN + 1] = newBoys[i];
            }
            Console.Write("The order of the people after an hour and a quarter is");
            for (int i = 0; i < newNames.Length; i++)
            {
                Console.Write($" {newNames[i]}");
                if (i != newNames.Length - 1)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
        }

        public static void Array10_24()
        {
            int[] nums, newNums;
            int lngt;
            Console.Write("Enter the number of numbers: ");
            lngt = int.Parse(Console.ReadLine());
            nums = new int[lngt];
            newNums = new int[nums.Length];
            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < nums.Length; i++)
            {
                newNums[i] = nums[nums.Length - i - 1];
            }
            for (int i = 0; i < newNums.Length; i++)
            {
                Console.Write($"{newNums[i]} ");
            }
        }

        public static void Array10_26()
        {
            //A:
            //4, 5, 6

            //B:
            //9, 19, 39, 31, 3, 4, 6, 5

            //C:
            //1, 2, 4
            //1:
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    arr[i] = arr[i + 1];
            //}
            //2:
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    arr[i] = arr[i - 1];
            //}
            //4:
            //for (int i = 0; i < arr.Length / 2; i++)
            //{
            //    arr[i] = arr[i * 2];
            //}
        }

        public static void Array10_28()
        {
            //No.
            //double[] arr = new double[50];
            //for (int i = 0; i < arr.Length * 2; i++)
            //{
            //    arr[i] = (i + 1) / 2;
            //}  
        }

        public static void Array10_29()
        {
            //A:
            /*
             i | n | a[i] | a[i + 2] | i < n - 2 | if | output 
            ---------------------------------------------------
               |10 |      |          |           |    |        
            ---------------------------------------------------
             0 |   |      |          |     T     |    |        
               |   |  3   |    5     |           |    |        
               |   |      |          |           | T  |        
               |   |      |          |           |    |  0 3   
            ---------------------------------------------------
             1 |   |      |          |     T     |    |        
               |   |  18  |    20    |           |    |        
               |   |      |          |           | T  |        
               |   |      |          |           |    |  1 18  
            ---------------------------------------------------
             2 |   |      |          |     T     |    |        
               |   |  5   |    2     |           |    |        
               |   |      |          |           | F  |        
            ---------------------------------------------------
             3 |   |      |          |     T     |    |        
               |   |  20  |    4     |           |    |        
               |   |      |          |           | F  |        
            ---------------------------------------------------
             4 |   |      |          |     T     |    |        
               |   |  2   |    5     |           |    |        
               |   |      |          |           | F  |        
            ---------------------------------------------------
             5 |   |      |          |     T     |    |        
               |   |  4   |    6     |           |    |        
               |   |      |          |           | T  |        
               |   |      |          |           |    |  5 4   
            ---------------------------------------------------
             6 |   |      |          |     T     |    |        
               |   |  5   |    1     |           |    |        
               |   |      |          |           | F  |        
            ---------------------------------------------------
             7 |   |      |          |     T     |    |        
               |   |  6   |    9     |           |    |        
               |   |      |          |           | F  |        
            ---------------------------------------------------
             8 |   |      |          |     F     |    |        
            */

            //B:
            //So the program won't crash.
        }

        public static void Array10_31()
        {
            int[] grade1, grade2, finalGrade;
            int num;
            Console.Write("Enter number of students: ");
            num = int.Parse(Console.ReadLine());
            grade1 = new int[num];
            grade2 = new int[num];
            finalGrade = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter the first grade of student #{i + 1}: ");
                grade1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter the second grade of student #{i + 1}: ");
                grade2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                if (grade1[i] > grade2[i])
                {
                    finalGrade[i] = grade1[i];
                }
                else
                {
                    finalGrade[i] = grade2[i];
                }
            }
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Student #{i + 1}'s best grade is {finalGrade[i]}.");
            }
        }

        public static void Array10_33()
        {
            int num, sumO = 0, sumE = 0;
            int[] nums, oddNums, evenNums;
            Console.Write("Enter length: ");
            num = int.Parse(Console.ReadLine());
            nums = new int[num];
            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < num; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    sumE++;
                }
                else
                {
                    sumO++;
                }
            }
            oddNums = new int[sumO];
            evenNums = new int[sumE];
            sumE = 0;
            sumO = 0;
            for (int i = 0; i < num; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenNums[sumE] = nums[i];
                    sumE++;
                }
                else
                {
                    oddNums[sumO] = nums[i];
                    sumO++;
                }
            }
            Console.Write("All even numbers:");
            for (int i = 0; i < sumE; i++)
            {
                Console.Write($" {evenNums[i]}");
                if (i != sumE - 1)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
            Console.Write("All odd numbers:");
            for (int i = 0; i < sumO; i++)
            {
                Console.Write($" {oddNums[i]}");
                if (i != sumO - 1)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
        }

        public static void Array10_34()
        {
            int[] arr1, arr2, arr3, bigs, smalls;
            int lng1, lng2, smaller, bigger;
            Console.Write("Enter arr1's length: ");
            lng1 = int.Parse(Console.ReadLine());
            arr1 = new int[lng1];
            Console.Write("Enter arr2's length: ");
            lng2 = int.Parse(Console.ReadLine());
            arr2 = new int[lng2];
            Console.WriteLine("Enter arr1 numbers:");
            for (int i = 0; i < lng1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter arr2 numbers:");
            for (int i = 0; i < lng2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            smaller = Math.Min(lng1, lng2);
            bigger = Math.Max(lng1, lng2);
            if (lng1 > lng2)
            {
                bigs = arr1;
                smalls = arr2;
            }
            else
            {
                bigs = arr2;
                smalls = arr1;
            }
            arr3 = new int[bigger];
            for (int i = 0; i < bigger; i++)
            {
                for (int j = 0; j < smaller; j++)
                {
                    if (bigs[i] == smalls[j])
                    {
                        arr3[i] = bigs[i];
                    }
                }
            }
            Console.Write("arr3 numbers:");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write($" {arr3[i]}");
                if (i != arr3.Length - 1)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
            Console.WriteLine("(0's are either a 0 in both arrays or count as empty)");
        }

        public static void Array10_36()
        {
            int[] votes, counts = new int[4];
            int num, c1 = 0, c2 = 0, c3 = 0, c4 = 0, most;
            string winner;
            Console.Write("Enter number of students who voted: ");
            num = int.Parse(Console.ReadLine());
            votes = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter your vote (1 - Ruti, 2 - Ali, 3 - Aviv, 4 - Ofir): ");
                votes[i] = int.Parse(Console.ReadLine());
                switch (votes[i])
                {
                    case 1:
                        c1++;
                        break;
                    case 2:
                        c2++;
                        break;
                    case 3:
                        c3++;
                        break;
                    case 4:
                        c4++;
                        break;
                }
            }
            if (c1 > c2 && c1 > c3 && c1 > c4)
            {
                most = c1;
                winner = "Ruti";
            }
            else if (c2 > c1 && c2 > c3 && c2 > c4)
            {
                most = c2;
                winner = "Ali";
            }
            else if (c3 > c1 && c3 > c2 && c3 > c4)
            {
                most = c3;
                winner = "Aviv";
            }
            else
            {
                most = c4;
                winner = "Ofir";
            }
            Console.WriteLine($"{winner} won!");
        }

        public static void Array10_37()
        {
            Random rnd = new Random();
            int num, roll, c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;
            int[] rolls;
            Console.Write("Enter number of dice rolls: ");
            num = int.Parse(Console.ReadLine());
            rolls = new int[num];
            for (int i = 0; i < rolls.Length; i++)
            {
                roll = rnd.Next(1, 7);
                switch (roll)
                {
                    case 1:
                        c1++;
                        break;
                    case 2:
                        c2++;
                        break;
                    case 3:
                        c3++;
                        break;
                    case 4:
                        c4++;
                        break;
                    case 5:
                        c5++;
                        break;
                    case 6:
                        c6++;
                        break;
                }
            }
            Console.WriteLine($"The number 1 was rolled {c1} times.");
            Console.WriteLine($"The number 2 was rolled {c2} times.");
            Console.WriteLine($"The number 3 was rolled {c3} times.");
            Console.WriteLine($"The number 4 was rolled {c4} times.");
            Console.WriteLine($"The number 5 was rolled {c5} times.");
            Console.WriteLine($"The number 6 was rolled {c6} times.");
        }

        public static void Array10_38()
        {
            int[] rolls = new int[7];
            int win = 0;
            bool end = false;
            Random rnd = new Random();
            for (int i = 0; i < rolls.Length && !end; i++)
            {
                rolls[i] = rnd.Next(1, 7);
                for (int j = 0; j < i; j++)
                {
                    if (rolls[i] == rolls[j])
                    {
                        end = true;
                        win = rolls[i];
                    }
                }
            }
            Console.WriteLine($"The winning number is {win}.");
        }

        public static void Array10_40()
        {
            int num, max = 0;
            string[] colors;
            string maxColor = "";
            string click = "";
            int randomizer;
            int[] corolls;
            Random rnd = new Random();
            Console.Write("Enter number of players: ");
            num = int.Parse(Console.ReadLine());
            colors = new string[num];
            corolls = new int[num];
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write($"Player #{i + 1}, choose your color: ");
                colors[i] = Console.ReadLine();
            }
            while (click != "Q")
            {
                click = Console.ReadLine();
                if (click == "")
                {
                    randomizer = rnd.Next(0, num);
                    corolls[randomizer]++;
                    Console.WriteLine(colors[randomizer]);
                }
            }
            for (int i = 0; i < corolls.Length; i++)
            {
                if (corolls[i] > max)
                {
                    max = corolls[i];
                    maxColor = colors[i];
                }
            }
            Console.WriteLine($"Winner color: {maxColor}");
        }

        public static void Array10_41()
        {
            int[] playerPoints = new int[4];
            int rounds, first, second, third, last, max = 0, maxPlayer = 0;
            int playerNumSum = 0; //!
            Console.Write("Enter number of rounds: ");
            rounds = int.Parse(Console.ReadLine());
            for (int i = 0; i < playerPoints.Length; i++)
            {
                playerNumSum += i;
            }
            for (int i = 0; i < rounds; i++)
            {
                Console.Write("Enter the first place's player number: ");
                first = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Enter the second place's player number: ");
                second = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Enter the third place's player number: ");
                third = int.Parse(Console.ReadLine()) - 1;
                last = playerNumSum - first - second - third; //!
                /*if (first == 0 && second == 1 && third == 2 || first == 1 && second == 2 && third == 0 || first == 2 && second == 0 && third == 1)
                {
                    last = 3;
                }
                else if (first == 1 && second == 2 && third == 3 || first == 2 && second == 3 && third == 1 || first == 3 && second == 1 && third == 2)
                {
                    last = 0;
                }
                else if (first == 2 && second == 3 && third == 0 || first == 3 && second == 0 && third == 2 || first == 0 && second == 2 && third == 3)
                {
                    last = 1;
                }
                else
                {
                    last = 2;
                }*/
                playerPoints[first] += 7;
                playerPoints[second] += 3;
                playerPoints[last] -= 4;
            }
            for (int i = 0; i < 4; i++)
            {
                if (playerPoints[i] > max)
                {
                    max = playerPoints[i];
                    maxPlayer = i + 1;
                }
            }
            Console.WriteLine($"Player #{maxPlayer} won!");
        }

        public static void Array10_42()
        {
            int[] codes = new int[10000];
            int flwr = 1, classCode, movieCode, copiesCode, maxMovies = 0, maxMovieClass = 0, maxCopies = 0, maxCopyClass = 0;
            int[] countsM = new int[6];
            int[] sumsC = new int[6];
            Console.WriteLine("Enter codes:");
            codes[0] = int.Parse(Console.ReadLine());
            while (codes[flwr - 1] != 0)
            {
                codes[flwr] = int.Parse(Console.ReadLine());
                flwr++;
            }
            for (int i = 0; i < flwr; i++)
            {
                classCode = codes[i] / 1000;
                movieCode = (codes[i] / 10) % 100;
                switch (classCode)
                {
                    case 1:
                        countsM[0]++;
                        break;
                    case 2:
                        countsM[1]++;
                        break;
                    case 3:
                        countsM[2]++;
                        break;
                    case 4:
                        countsM[3]++;
                        break;
                    case 5:
                        countsM[4]++;
                        break;
                    case 6:
                        countsM[5]++;
                        break;
                }
                copiesCode = codes[i] % 10;
                switch (classCode)
                {
                    case 1:
                        sumsC[0] += copiesCode;
                        break;
                    case 2:
                        sumsC[1] += copiesCode;
                        break;
                    case 3:
                        sumsC[2] += copiesCode;
                        break;
                    case 4:
                        sumsC[3] += copiesCode;
                        break;
                    case 5:
                        sumsC[4] += copiesCode;
                        break;
                    case 6:
                        sumsC[5] += copiesCode;
                        break;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (countsM[i] > maxMovies)
                {
                    maxMovies = countsM[i];
                    maxMovieClass = i + 1;
                }
                if (sumsC[i] > maxCopies)
                {
                    maxCopies = sumsC[i];
                    maxCopyClass = i + 1;
                }
            }
            Console.WriteLine($"The class that has the most movies is class #{maxMovieClass}.");
            Console.WriteLine($"The class that has the most copies is class #{maxCopyClass}.");
        }

        public static void Array_Extra1()
        {
            int[] playerPoints = new int[5];
            bool[] isMax = new bool[5];
            int[] pointCounts = new int[3];
            int maxPointCount = 0, maxPointNum = 0;
            bool[] isNone = new bool[5];
            int noneCount = 0, noneFollow = 1;
            int maxCount = 0, maxFollow = 1;
            int score, playerNum, sum = 0, max = 0;
            do
            {
                Console.Write("Enter player number: ");
                playerNum = int.Parse(Console.ReadLine());
                if (playerNum != 0)
                {
                    Console.Write("Enter number of points the player got in the score: ");
                    score = int.Parse(Console.ReadLine());
                    playerPoints[playerNum - 1] += score;
                    sum += score;
                    pointCounts[score - 1]++;
                }
            }
            while (playerNum != 0);
            for (int i = 0; i < 5; i++)
            {
                if (playerPoints[i] > max)
                {
                    max = playerPoints[i];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (playerPoints[i] == max)
                {
                    isMax[i] = true;
                    maxCount++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (playerPoints[i] == 0)
                {
                    isNone[i] = true;
                    noneCount++;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (pointCounts[i] > maxPointCount)
                {
                    maxPointCount = pointCounts[i];
                    maxPointNum = i + 1;
                }
            }
            Console.WriteLine();
            Console.Write("The player(s) who got the max score is(are):");
            for (int i = 0; i < 5; i++)
            {
                if (isMax[i])
                {
                    Console.Write($" {i + 1}");
                    if (maxFollow <= maxCount)
                    {
                        if (maxFollow < maxCount)
                        {
                            Console.Write(",");
                        }
                        else if (maxFollow == maxCount)
                        {
                            Console.WriteLine(".");
                        }
                    }
                    maxFollow++;
                }
            }
            Console.WriteLine($"The group got {sum} points in the game.");
            Console.WriteLine($"The most common number of points per score is {maxPointNum}.");
            Console.Write("The player(s) who got no points is(are):");
            for (int i = 0; i < 5; i++)
            {
                if (isNone[i])
                {
                    Console.Write($" {i + 1}");
                    if (noneFollow <= noneCount)
                    {
                        if (noneFollow < noneCount)
                        {
                            Console.Write(",");
                        }
                        else if (noneFollow == noneCount)
                        {
                            Console.WriteLine(".");
                        }
                    }
                    noneFollow++;
                }
            }
        }

        public static void Array_Extra2()
        {
            //A: 5, 3.
            //B: 2, 2, 2, 2, 2, 2, 2, 1, 1, 1.
            //C: The program was made to find the number of even and odd numbers in an array.
        }

        public static void Array_Extra3()
        {
            int[] letterCounts = new int[26];
            int smallA = 'a';
            char ch = ' ';
            Console.WriteLine("Enter chars ('*' - Finish):");
            ch = char.Parse(Console.ReadLine());
            while (ch != '*')
            {
                letterCounts[ch - smallA]++;
                ch = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine($"The letter '{(char)(smallA + i)}' appeared {letterCounts[i]} time(s).");
            }
        }

        public static void Array_Extra4()
        {
            int[] ageGroupSums = new int[4];
            bool[] isMax = new bool[4];
            int age, medNum, numOfMeds, max = 0, maxCount = 0, maxFollow = 1, noneCount = 0, noneFollow = 1;
            bool[] gotMed = new bool[150];
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());
            while (age != -1)
            {
                Console.Write("Enter medicine number: ");
                medNum = int.Parse(Console.ReadLine());
                gotMed[medNum - 1] = true;
                Console.Write("Enter how many: ");
                numOfMeds = int.Parse(Console.ReadLine());
                if (age >= 51)
                {
                    ageGroupSums[3] += numOfMeds;
                }
                else if (age >= 31)
                {
                    ageGroupSums[2] += numOfMeds;
                }
                else if (age >= 11)
                {
                    ageGroupSums[1] += numOfMeds;
                }
                else if (age >= 0)
                {
                    ageGroupSums[0] += numOfMeds;
                }
                Console.Write("Enter age: ");
                age = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                if (ageGroupSums[i] > max)
                {
                    max = ageGroupSums[i];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (ageGroupSums[i] == max)
                {
                    isMax[i] = true;
                    maxCount++;
                }
            }
            Console.Write("The age group(s) who use the most medicine is(are):");
            for (int i = 0; i < 4; i++)
            {
                if (isMax[i])
                {
                    Console.Write($" age group #{i + 1}");
                    switch (i)
                    {
                        case 0:
                            Console.Write(" (0-10)");
                            break;
                        case 1:
                            Console.Write(" (11-30)");
                            break;
                        case 2:
                            Console.Write(" (31-50)");
                            break;
                        case 3:
                            Console.Write(" (51+)");
                            break;
                    }
                    if (maxFollow <= maxCount)
                    {
                        if (maxFollow < maxCount)
                        {
                            Console.Write(",");
                        }
                        else if (maxFollow == maxCount)
                        {
                            Console.WriteLine(".");
                        }
                    }
                    maxFollow++;
                }
            }
            for (int i = 0; i < 150; i++)
            {
                if (!gotMed[i])
                {
                    noneCount++;
                }
            }
            Console.Write("The number(s) of the medicine that didn't get taken is(are):");
            for (int i = 0; i < 150; i++)
            {
                if (!gotMed[i])
                {
                    Console.Write($" {i + 1}");
                    if (noneFollow <= noneCount)
                    {
                        if (noneFollow < noneCount)
                        {
                            Console.Write(",");
                        }
                        else if (noneFollow == noneCount)
                        {
                            Console.WriteLine(".");
                        }
                    }
                    noneFollow++;
                }
            }
        }

        public static void Array_Extra5()
        {
            int[] rooms = new int[16] {14, 11, 10, 8, -1, 6, -1, 2, 0, 13, 4, -1, 15, 1, 7, 5};
            int place, treasurePlace;
            Console.Write("Enter the room to start in: ");
            place = int.Parse(Console.ReadLine());
            while (rooms[place] != -1)
            {
                place = rooms[place];
            }
            treasurePlace = place;
            Console.WriteLine($"The place where the treasure was found is {treasurePlace}.");
        }

        public static int Array_More1(int N)
        {
            int[] resist = new int[N];
            int badCount = 0;
            double sum = 0, avg;
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Enter resistance of resistor #{i + 1}: ");
                resist[i] = int.Parse(Console.ReadLine());
                sum += resist[i];
            }
            avg = sum / N;
            for (int i = 0; i < N; i++)
            {
                if (resist[i] > avg * 1.1 || resist[i] < avg * 0.9)
                {
                    badCount++;
                }
            }
            Console.WriteLine($"The number of resistors that are unstable is {badCount}.");
            return badCount;
        }

        public static void Array_More2(string[] names, int[] grades)
        {
            int num = names.Length;
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < num; i++)
            {
                sum += grades[i];
            }
            avg = (double)sum / num;
            Console.WriteLine("The students that passed are:");
            for (int i = 0; i < num; i++)
            {
                if (grades[i] > avg)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }

        public static int[] Array_More3(int N)
        {
            int vote = 0;
            int[] votesC = new int[N];
            int max = 0, secMax = 0;
            int best = 0, secBest = 0;
            int[] bests = new int[2];
            while (vote != -1)
            {
                Console.Write("Enter your vote: ");
                vote = int.Parse(Console.ReadLine());
                if (vote > 0 && vote <= N)
                {
                    votesC[vote - 1]++;
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (votesC[i] > max)
                {
                    secMax = max;
                    max = votesC[i];
                    best = i + 1;
                }
                else if (votesC[i] > secMax)
                {
                    secMax = votesC[i];
                    secBest = i + 1;
                }
            }
            bests[0] = best;
            bests[1] = secBest;
            //Console.WriteLine(best);
            //Console.WriteLine(secBest);
            return bests;
        }

        public static int[] Array_More4(int N)
        {
            int[] winners;
            int wnum = 0, wrc = 0;
            int[] scores = new int[N];
            int sum = 0, score, max = 0;
            for (int i = 0; i < N; i++)
            {
                sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Judge #{j + 1}, enter your score for project #{i + 1}: ");
                    score = int.Parse(Console.ReadLine());
                    sum += score;
                }
                scores[i] = sum;
            }
            for (int i = 0; i < N; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (max == scores[i])
                {
                    wnum++;
                }
            }
            winners = new int[wnum];
            for (int i = 0; i < N; i++)
            {
                if (max == scores[i])
                {
                    winners[wrc] = i + 1;
                    wrc++;
                }    
            }
            //for (int i = 0; i < wnum; i++)
            //{
            //    Console.WriteLine(winners[i]);
            //}
            return winners;
        }

        public static void Array_More5A(int[] arr)
        {
            int tmp = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = tmp;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
        }

        public static void Array_More5B(int[] arr)
        {
            int tmp = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = tmp;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
        }

        public static int Array_More6A(int proj, int shd, int test)
        {
            double avg = 0.3 * proj + 0.21 * shd + 0.49 * test;
            int final = (int)(avg + 0.5);
            //Console.WriteLine(final);
            return final;
        }

        public static int[] Array_More6B(int[] projs, int[] shds, int[] tests)
        {
            int num = tests.Length;
            int[] finals = new int[num];
            for (int i = 0; i < num; i++)
            {
                finals[i] = Array_More6A(projs[i], shds[i], tests[i]);
            }
            //for (int i = 0; i < finals.Length; i++)
            //{
            //    Console.WriteLine(finals[i]);
            //}
            return finals;
        }

        public static int[] Array_More7(int[] arr1, int[] arr2, int num)
        {
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            int shorter = len1 < len2 ? len1 : len2;
            int longer = len1 > len2 ? len1 : len2;
            bool inOther = false;
            int flen = 0, flwr = 0;
            int[] good;
            for (int i = 0; i < shorter; i++)
            {
                inOther = false;
                if (longer == len1)
                {
                    for (int j = 0; j < len1; j++)
                    {
                        if (arr1[j] == arr2[i])
                        {
                            inOther = true;
                        }
                    }
                    if (inOther && arr2[i] % num == 0)
                    {
                        flen++;
                    }
                }
                else
                {
                    for (int j = 0; j < len2; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            inOther = true;
                        }
                    }
                    if (inOther && arr1[i] % num == 0)
                    {
                        flen++;
                    }
                }
            }
            good = new int[flen];
            for (int i = 0; i < shorter; i++)
            {
                inOther = false;
                if (longer == len1)
                {
                    for (int j = 0; j < len1; j++)
                    {
                        if (arr1[j] == arr2[i])
                        {
                            inOther = true;
                        }
                    }
                    if (inOther && arr2[i] % num == 0)
                    {
                        good[flwr] = arr2[i];
                        flwr++;
                    }
                }
                else
                {
                    for (int j = 0; j < len2; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            inOther = true;
                        }
                    }
                    if (inOther && arr1[i] % num == 0)
                    {
                        good[flwr] = arr1[i];
                        flwr++;
                    }
                }
            }
            //for (int i = 0; i < flen; i++)
            //{
            //    Console.WriteLine(good[i]);
            //}
            return good;
        }

        public static int Array_More8(int[] arr)
        {
            int final = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                final *= 10;
                final += arr[i];
            }
            return final;
        }

        public static int[] Array_More9A(int age)
        {
            int[] allowed = new int[3];
            if (age >= 12)
            {
                allowed[0] = 1;
                if (age >= 16)
                {
                    allowed[1] = 1;
                    if (age >= 18)
                    {
                        allowed[2] = 1;
                    }
                }
            }
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(allowed[i]);
            //}
            return allowed;
        }

        public static void Array_More9B()
        {
            int age;
            int[] counts = new int[3];
            int[] allowed = {1, 1, 1};
            while (allowed[0] == 1)
            {
                Console.Write("Enter your age: ");
                age = int.Parse(Console.ReadLine());
                allowed = Array_More9A(age);
                counts[0]++;
                if (allowed[1] == 1)
                {
                    counts[1]++;
                    if (allowed[2] == 1)
                    {
                        counts[2]++;
                    }
                }
            }
            Console.WriteLine($"{counts[0]} people are allowed to use the springboard.");
            Console.WriteLine($"{counts[1]} people are allowed to use the jacuzzi.");
            Console.WriteLine($"{counts[2]} people are allowed to use the sauna.");
        }

        public static int Array_More10A(int sl, int su, int cl, int cu)
        {
            int num = (cl * 2 + cu) - (sl * 2 + su);
            return num;
        }

        public static int Array_More10B(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static void Array_More10C()
        {
            int num = 3;
            int sl, su, cl, cu;
            int[] unitsNums = new int[num];
            int max, maxC = 0;
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter your starting level: ");
                sl = int.Parse(Console.ReadLine());
                Console.Write("Enter your starting unit: ");
                su = int.Parse(Console.ReadLine());
                Console.Write("Enter your current level: ");
                cl = int.Parse(Console.ReadLine());
                Console.Write("Enter your current unit: ");
                cu = int.Parse(Console.ReadLine());
                unitsNums[i] = Array_More10A(sl, su, cl, cu);
            }
            max = Array_More10B(unitsNums);
            for (int i = 0; i < num; i++)
            {
                if (unitsNums[i] == max)
                {
                    maxC++;
                }
            }
            Console.WriteLine($"The most units a student has finished is {max}.");
            Console.WriteLine($"The number of students who finished the most units is {maxC}.");
        }

        public static int[] Array_More11A(int num)
        {
            int[] regs = new int[3];
            int reg;
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter the number of the activity you want to join: ");
                reg = int.Parse(Console.ReadLine());
                regs[reg]++;
            }
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(regs[i]);
            //}
            return regs;
        }

        public static int Array_More11B(int[] regs, int act)
        {
            int rooms;
            if (regs[act] < 40)
            {
                rooms = 1;
            }
            else
            {
                rooms = 2;
            }
            return rooms;
        }

        public static void Array_More11C()
        {
            int num;
            int[] regs;
            int[] rooms = new int[3];
            int roomNum = 0;
            Console.Write("Enter number of people to register: ");
            num = int.Parse(Console.ReadLine());
            regs = Array_More11A(num);
            for (int i = 0; i < 3; i++)
            {
                rooms[i] = Array_More11B(regs, i);
                roomNum += rooms[i];
            }
            Console.WriteLine($"{roomNum} rooms are needed.");
        }

        public static double Array_More12A()
        {
            int sum = 0, count = 0;
            double avg;
            int rate = 0;
            while (rate != -1)
            {
                Console.Write("Enter your rate: ");
                rate = int.Parse(Console.ReadLine());
                if (rate != -1)
                {
                    sum += rate;
                    count++;
                }
            }
            if (count < 100)
            {
                avg = 0;
            }
            else
            {
                avg = (double)sum / count;
            }
            return avg;
        }

        public static bool Array_More12B(double[] avgs)
        {
            bool funDay = false;
            for (int i = 1; i < 12; i++)
            {
                if (avgs[i - 1] > 8 && avgs[i] > 8)
                {
                    funDay = true;
                }
            }
            return funDay;
        }

        public static void Array_More12C()
        {
            double[] avgs = new double[12];
            bool funDay;
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Enter rates for month #{i + 1}:");
                avgs[i] = Array_More12A();
            }
            funDay = Array_More12B(avgs);
            if (funDay)
            {
                Console.WriteLine("The workers deserve a fun day!");
            }
            else
            {
                Console.WriteLine("The workers don't deserve a fun day.");
            }
        }
    }
}