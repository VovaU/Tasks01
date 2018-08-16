using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Write122();
            Console.ReadKey();
        }

        static double CalculateExpression(double a) // 1,24 a
        {
            return Math.Sqrt((2 * a + Math.Sin(Math.Abs(3 * a))) / 3.56);
        }

        static double CalculateExpressionB(double x) // 1,24 b
        {
            return Math.Sin((3.2 + Math.Sqrt(1 + x)) / Math.Abs(5 * x));
        }

        static int[] Count(int a) // 2.12 
        {
            int[] result = new[] {0, 0, 0, 0};

            for (int i = 0; i < 3; i++)
            {
                if (i < 3)
                {
                    result[i] = a % 10; // 2.12 a,b, c
                    a = a / 10;
                }

                if (i == 3)
                {
                    result[3] = result[0] + result[1] + result[2]; // 2.12 d
                    result[2] = result[0] + result[1] + result[2]; // 2.12 c
                }
            }

            return result;
        }

        static int ReverseNumber(int number) // 2.13
        {
            int reverseNumber = 0;
            while (number > 0)
            {
                reverseNumber = (reverseNumber * 10) + (number % 10);
                number = number / 10;
            }

            return reverseNumber;
        }

        static int ReverseFirstWithLast(int number) // 2.14
        {
            int a = number / 100;
            int c = number % 100;
            return c * 10 + a;
        }

        static int LastWithFirst(int number) //2.15
        {
            int a = number / 100;
            return 100 * (number % 10) + ((number / 10) % 10) * 10 + a;
        }

        static int FirstwithSecond(int number) //2.16
        {
            return 100 * (number / 100) + 10 * (number % 10) + (number % 100 / 10);
        }

        static int SecondWithThird(int number) //2.17
        {
            return 100 * (number / 100) + (number % 10) * 10 + number % 100 / 10;
        }

        static int Combine(int a, int b, int c) // 2.18 helper
        {
            return a * 100 + b * 10 + c;
        }

        static int[] Combinations(int number) // 2.18
        {
            int a = number / 100;
            int b = number % 100 / 10;
            int c = number % 10;
            return new[]
            {
                Combine(a, b, c), Combine(a, c, b), Combine(b, a, c), Combine(b, c, a), Combine(c, a, b),
                Combine(c, b, a)
            };
        }

        static int[] Combinations1111(int number) // 2.19
        {
            int a = number / 1000;
            int b = number % 1000 / 100;
            int c = number % 100 / 10;
            int d = number % 10;
            return new[]
            {
                a + b + c + d,
                a * b * c * d
            };
        }
        // 2.20
        static void Combinations1112221(int number)
        {
            int[] arr=new int[4];
            for (int i = 4; i>=0; i++)
            {
                arr[i] = number % 10;
                number = number / 10;
            }
            Console.WriteLine(arr[3] * 1000 + arr[2] * 100 + arr[1] * 10 + arr[0]);
            Console.WriteLine(arr[1] * 1000 + arr[0] * 100 + arr[3] * 10 + arr[2]);
            Console.WriteLine(arr[0] * 1000 + arr[2] * 100 + arr[1] * 10 + arr[3]);
            Console.WriteLine(arr[2] * 1000 + arr[3] * 100 + arr[0] * 10 + arr[1]);
        }

        //2.21
        static int[] fafafa(int number) 
        {
            return new[]
            {
                number  % 10,
                (number / 10) % 10,
            };
        }

        //2.22
        static int[] fafaf44a(int number)
        {
            return new[]
            {
                (number / 10) % 10,
                (number / 100) % 10,
            };
        }

        //2.23
        static int[] fafaf444a(int number)
        {
            return new[]
            {
                (number / 100) % 10,
                (number / 1000) % 10,
            };
        }

        //3.32

        static bool DotIsInsideA(double x, double y) //A
        {
            if (x <= -2 && y >= 1)
                return true;
            return false;
        }

        static bool DotIsInsideB(double x, double y) //B
        {
            if (y >= -2 && y <= 1.5)
                return true;
            return false;
        }

        static bool DotIsInsideC(double x, double y) //C
        {
            if (y >= 1 && y <= 4 && x >= 1 && x <= 2)
                return true;
            return false;
        }

        static bool DotIsInsideD(double x, double y) //D
        {
            if (y >= 2 && y <= 4 && x >= 1)
                return true;
            return false;
        }

        static bool DotIsInsideE(double x, double y) //E
        {
            if ((y >= 0 && x >= 2) || (x >= 1 && y <= -1))
                return true;
            return false;
        }

        static bool DotIsInsideF(double x, double y) //F
        {
            if ((y >= 1 && x >= 2) || (x >= 2 && y <= -1.5))
                return true;
            return false;
        }

        static bool DotIsInsideU(double x, double y) //U
        {
            if ((y >= -2 && x <= 3 && x >= 1 && y <= -1))
                return true;
            return false;
        }

        static bool DotIsInsideZ(double x, double y) //Z
        {
            if ((y >= 0.5 && y <= 1.5) || (x >= 2))
                return true;
            return false;
        }

        //3.33
        static bool IsInside1(double x, double y) //1
        {
            if (x <= -1 && y <= -2)
                return true;
            return false;
        }

        static bool IsInside2(double x, double y) //2
        {
            if (y >= 1 || y <= -3)
                return true;
            return false;
        }

        static bool IsInside3(double x, double y) //3
        {
            if (y >= 1 || y <= -3 && y >= -4)
                return true;
            return false;
        }

        static bool IsInside4(double x, double y) //4
        {
            if (x >= -1 && x <= 1.5 && y >= -0.5 && y <= 1.5)
                return true;
            return false;
        }

        static bool IsInside5(double x, double y) //5
        {
            if (x >= 1 && x <= 4 && y >= 2 && y >= 4)
                return true;
            return false;
        }

        static bool IsInside6(double x, double y) //6
        {
            if ((x >= 2 && y >= 1) || (x <= -1 && y >= 1))
                return true;
            return false;
        }

        static bool IsInside7(double x, double y) //7
        {
            if (x >= 1 && x <= 3 && y >= -3 && y <= 1)
                return true;
            return false;
        }

        static bool IsInside8(double x, double y) //8
        {
            if ((x >= 1 && x <= 2.5 && y >= -2 && y <= 1.5) || (y >= 1.5))
                return true;
            return false;
        }

        //4.1
        static double Calculate1(double x)
        {
            if (x > 0)
            {
                return Math.Pow(Math.Sin(x), 2);
            }

            return 1 - 2 * Math.Pow(Math.Sin(x), 2);
        }

        //4.2
        static double Calculate2(double x)
        {
            if (x > 0)
            {
                return Math.Pow(Math.Sin(x), 2);
            }

            return 1 + 2 * Math.Pow(Math.Sin(x), 2);
        }

        //4.3
        static int Calculate3(double x, double y)
        {
            if (x > 4)
            {
                return 2;
            }

            return 1;
        }

        //4.4
        static int Calculate4(double x, double y)
        {
            if (y > 3)
            {
                return 1;
            }

            return 2;
        }

        //4.5
        static double Calculate5(double x) //1
        {
            if (x <= 2)
            {
                return x;
            }
            else
            {
                return 2;
            }
        }

        static double Calculate6(double x) //2
        {
            if (x <= 3)
            {
                return -x;
            }
            else
            {
                return -3;
            }
        }

        //4.37
        static bool Calculate7(double x)
        {
            if (x >= -5 && x <= 3)
            {
                return true;
            }

            return false;
        }

        //4.38
        static bool Calculate8(double x, double y) //1
        {
            if (x > 3 && y > 2)
            {
                return true;
            }

            return false;
        }

        static bool Calculate88(double x, double y) //1
        {
            if (x <= -2 && y <= -4)
            {
                return true;
            }

            return false;
        }

        //4.39
        static bool Calculate9(double x, double y)
        {
            if (x > 5 || y < -1)
            {
                return true;
            }

            return false;
        }

        //4.40
        static double Calculate11(double x)
        {
            if (x >= -2.4 && x <= 5.7)
            {
                return Math.Pow(x, 2);
            }
            else return 4;
        }

        //4.41
        static double Calculate12(double x)
        {
            if (x >= 0.2 && x <= 0.9)
            {
                return Math.Sin(x);
            }
            else return 1;
        }

        //4.42
        static bool Calculate13(double a, double b, double c) //a
        {
            if (c > b && b > a) return true;
            return false;
        }

        static bool Calculate14(double a, double b, double c) //b
        {
            if (b > a && a > c) return true;
            return false;
        }

        //4.68
        static bool Calculate15(double a, double v0, double P, double R, double H)
        {
            double g = 9.8;
            double t = R / (Math.Cos(a) * v0);
            double y = v0 * t * Math.Sin(a) - (g * Math.Pow(t, 2) / 2);
            return y>H && y< H+P;
        }

        //4.85
        static double Calculate16(double x)
        {
            if (x < -1) return -1;
            if (x == -1) return 1;
            return x;
        }

        //4.86
        static double Calculate17(double x)
        {
            if (x > 0) return 1;
            if (x == 0) return 0;
            return -1;
        }

        //4.87
        static double Calculate18(double x)
        {
            if (x >= 0) return 0;
            if (x > 0 && x <= 1) return x;
            return Math.Pow(x, 2);
        }

        //4.88
        static double Calculate19(double x)
        {
            if (x > 2) return 2;
            if (x > 0 && x <= 2) return 0;
            return -3 * x;
        }

        //4.89
        static double Calculate20(double x)
        {
            double k;
            if (Math.Sin(x) < 0)
            {
                k = x * x;
            }
            else
            {
                k = Math.Abs(x);
            }

            if (k < x)
            {
                return k * x;
            }

            return k + x;
        }

        //4.90
        static double Calculate21(double x)
        {
            double k;
            if (Math.Sin(x) >= 0)
            {
                k = x * x;
            }
            else
            {
                k = Math.Abs(x);
            }

            if (x >= k)
            {
                return k * x;
            }

            return k + x;
        }

        //4.91
        static double Calculate22(double x) //a
        {
            if (x <= -1)
            {
                return 0;
            }

            if (x >= 0)
            {
                return 1;
            }

            return x;
        }

        static double Calculate23(double x) //b
        {
            if (x <= -1)
            {
                return 1;
            }

            if (x >= 0)
            {
                return -1;
            }

            return -x;
        }

        static double Calculate24(double x) //c
        {
            if (x <= -1 || x >= 1)
            {
                return 1;
            }

            if (x > -1 && x <= 0)
            {
                return -0.5 * x;
            }

            return 0.5 * x;
        }

        //4.92
        static int Calculate25(double x)
        {
            if (x <= 1) return 1;
            if (x >= 5) return 3;
            return 2;
        }

        //4.93
        static int Calculate26(double x)
        {
            if (x >= 5) return 1;
            if (x >= 2.5) return 3;
            return 2;
        }

        //4.104
        static string Calculate26(int x)
        {
            switch (x)
            {
                case 1:
                    return "monday";
                case 2:
                    return "tuesday";
                case 3:
                    return "wednesday";
                case 4:
                    return "thursday";
                case 5:
                    return "friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
            }

            return "";
        }

        //4.105
        static string Calculate27(int x)
        {
            switch (x)
            {
                case 1:
                    return "январьь";
                case 2:
                    return "февраль";
                case 3:
                    return "март";
                case 4:
                    return "апрель";
                case 5:
                    return "май";
                case 6:
                    return "июнь";
                case 7:
                    return "июль";
                case 8:
                    return "август";
                case 9:
                    return "сентябрь";
                case 10:
                    return "октябрь";
                case 11:
                    return "ноябрь";
                case 12:
                    return "декабрь";

            }

            return "";
        }

        //4.106
        static string Calculate28(int x)
        {
            if (x == 12 || x < 3)
            {
                return "winter";
            }

            if (x >= 3 || x < 6)
            {
                return "Spring";
            }

            if (x >= 6 || x < 9)
            {
                return "Summer";
            }

            return "Autumn";
        }

        //4.107
        static int Calculate29(int x) // a
        {
            switch (x)
            {
                case 1:
                    return 31;
                case 2:
                    return 29;
                case 3:
                    return 31;
                case 4:
                    return 31;
                case 5:
                    return 30;
                case 6:
                    return 31;
                case 7:
                    return 30;
                case 8:
                    return 31;
                case 9:
                    return 30;
                case 10:
                    return 31;
                case 11:
                    return 30;
                case 12:
                    return 31;

            }

            return 0;
        }

        //4.107
        static int Calculate29(int x, int visokon) // b
        {
            switch (x)
            {
                case 1:
                    return 31;
                case 2:
                    if (visokon == 1)
                    {
                        return 28;
                    }

                    return 29;
                case 3:
                    return 31;
                case 4:
                    if (visokon == 1)
                    {
                        return 30;
                    }

                    return 31;
                case 5:
                    return 30;
                case 6:
                    if (visokon == 1)
                    {
                        return 30;
                    }

                    return 31;
                case 7:
                    if (visokon == 1)
                    {
                        return 31;
                    }

                    return 30;
                case 8:
                    return 31;
                case 9:
                    return 30;
                case 10:
                    return 31;
                case 11:
                    return 30;
                case 12:
                    return 31;

            }

            return 0;
        }

        //5.13
        static void Calculate30() //
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(i * 7);
            }
        }

        //5.14
        static void Calculate31() //
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(i * 9);
            }
        }

        //5.14
        static void Calculate31(int n) //
        {
            for (int i = 1; i <= 9; i++)
            {

                Console.WriteLine(n * 9);
            }
        }

        //5.27
        static int Calculate32() //1
        {
            int sum = 0;
            for (int i = 100; i <= 500; i++)
            {
                sum += i;
            }

            return sum;
        }

        static int Calculate32(int a) //2
        {
            int sum = 0;
            for (int i = a; i <= 500; i++)
            {
                sum += i;
            }

            return sum;
        }

        static int Calculate33(int a) //3
        {
            int sum = 0;
            for (int i = -10; i <= a; i++)
            {
                sum += i;
            }

            return sum;
        }

        static int Calculate34(int a, int b) //4
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }

            return sum;
        }

        //5.28
        static int Calculate35() //1
        {
            int sum = 1;
            for (int i = 8; i <= 15; i++)
            {
                sum = sum * i;
            }

            return sum;
        }

        static int Calculate36(int a) //2
        {
            int sum = 1;
            for (int i = a; i <= 20; i++)
            {
                sum = sum * i;
            }

            return sum;
        }

        static int Calculate37(int a) //3
        {
            int sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum = sum * i;
            }

            return sum;
        }

        static int Calculate38(int a, int b) //4
        {
            int sum = 1;
            for (int i = a; i <= b; i++)
            {
                sum = sum * i;
            }

            return sum;
        }

        //5.29
        static int Calculate39() //1
        {
            int count = 0;
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += i;
                count++;
            }

            return sum / count;
        }

        static int Calculate40(int a) //2
        {
            int sum = 0;
            for (int i = a; i <= 50; i++)
            {
                sum += i * i;
            }

            return sum;
        }

        static int Calculate41(int a) //3
        {
            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum += i * i;
            }

            return sum;
        }

        static int Calculate42(int a, int b) //4
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i * i;
            }

            return sum;
        }

        //5.31
        static double Calculate43(int n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow((n + i), 2);
            }

            return sum;
        }

        //5.32
        static double Calculate44(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }

            return sum;
        }

        //5.33
        static double Calculate45(int n)
        {
            double sum = 0;
            for (int i = 2; i <= 10; i++)
            {
                sum += i / (i + 1);
            }

            return sum;
        }

        //5.34
        static double Calculate46()
        {
            int tmp;
            double sum = 0;
            for (int i = 0; i <= 8; i++)
            {
                tmp = 1;
                for (int j = 1; j <= i; i++)
                {
                    tmp *= 3;
                }

                sum += i / tmp;
            }

            return sum;
        }

        //5.35
        static double Calculate46(int n)
        {
            int tmp;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum -= 1 / i;
                }
                else
                {
                    sum += 1 / i;

                }
            }

            return sum;
        }

        //5.36
        static double Calculate47()
        {
            int tmp;
            double sum = 0;
            for (int i = 1; i <= 11; i++)
            {
                if (i % 2 != 0)
                {
                    sum += Math.Pow(2, i) / i;
                }
            }

            return sum;
        }

        //5.37
        static double Calculate48()
        {
            int tmp;
            double sum = 1;
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 != 0)
                {
                    sum -= ((i) / (i + 1)) * Math.Pow(2, i - 1);

                }
                else
                {
                    sum += ((i) / (i + 1)) * Math.Pow(2, i - 1);
                }
            }

            return sum;
        }

        //5.40
        static double Calculate49(int[] array, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        //5.41
        static double Calculate50(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        //5.66
        static double[] Calculate51(int n)
        {
            List<double> arr = new List<double>();
            arr.Add(1);
            for (int i = 1; i < n; i++)
            {
                arr.Add(i * arr[i] + 1 / i);
            }

            return arr.ToArray();
        }

        //5.67
        static int Calculate52(int n) // a
        {
            List<int> arr = new List<int>() {1, 1};
            for (int i = 0; i <= n; i++)
            {
                arr.Add(arr[i - 1] + arr[i - 2]);
            }

            return arr[arr.Count - 1];
        }

        static int[] Calculate53(int n) // b
        {
            List<int> arr = new List<int>() {1, 1};
            for (int i = 0; i <= n; i++)
            {
                arr.Add(arr[i - 1] + arr[i - 2]);
            }

            return arr.ToArray();
        }

        static bool Calculate54(int n) // c
        {
            List<int> arr = new List<int>() {1, 1};
            int sum = 2;
            for (int i = 0; i <= n; i++)
            {
                arr.Add(arr[i - 1] + arr[i - 2]);
                sum += arr[i];
            }

            return sum % 2 == 0;
        }

        // 5.68
        static Tuple<int, int> Calculate55(int k) //a+b
        {
            List<Tuple<int, int>> arr =
                new List<Tuple<int, int>>() {new Tuple<int, int>(1, 1), new Tuple<int, int>(2, 1)};
            for (int i = 2; i <= k; i++)
            {
                arr.Add(new Tuple<int, int>(arr[i - 1].Item1 + arr[i - 2].Item1, arr[i - 1].Item2 + arr[i - 2].Item2));
            }

            return arr[k]; // return arr
        }

        static bool Calculate56(int k, int A) // c
        {
            double sum = 3;
            List<Tuple<int, int>> arr =
                new List<Tuple<int, int>>() {new Tuple<int, int>(1, 1), new Tuple<int, int>(2, 1)};
            for (int i = 2; i <= k; i++)
            {
                arr.Add(new Tuple<int, int>(arr[i - 1].Item1 + arr[i - 2].Item1, arr[i - 1].Item2 + arr[i - 2].Item2));
                sum += arr[i].Item1 / arr[i].Item2;
            }

            return sum > A;
        }

        //5.81
        static int Calculate57(int x, int y)
        {
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += y;
            }

            return sum;
        }

        //5.82
        static int Factorial(int x)
        {
            int res = 1;
            for (int i = 1; i <= x; i++)
            {
                res *= i;
            }

            return res;
        }

        //5.83
        static int Calculate58(int a, int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= n;
            }

            return res;
        }

        //6.10
        static int[] Calculate58(int n)
        {
            List<int> arr = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if (Math.Pow(i, 2) <= n)
                {
                    arr.Add(i);
                }
                else break;
            }

            return arr.ToArray();
        }

        //6.11
        static int[] Calculate59(int a)
        {
            List<int> arr = new List<int>();
            int i = 2;
            while (true)
            {
                if (a <= (1 + 1 / i))
                {
                    arr.Add(i);
                    i++;
                }
                else
                {
                    break;
                }

            }

            return arr.ToArray();
        }

        //6.12
        static int Calculate60(int a)
        {
            int i = 2;
            while (true)
            {
                if (a > (1 + 1 / i))
                {
                    return i;
                }

                i++;
            }
        }

        //6.33
        static int[] Calculate61() //a
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < 100; i += 13)
            {
                arr.Add(i);
            }

            return arr.ToArray();
        }

        static int[] Calculate62() //b
        {
            List<int> arr = new List<int>();
            int i = 0;
            while (i <= 100)
            {
                if (i % 13 == 0)
                {
                    arr.Add(i);
                }

                i++;
            }

            return arr.ToArray();
        }

        //6.91
        static int Calculate61(int a) //a
        {
            int res = 0;
            while (a > 0)
            {
                a = a / 10;
                res += 1;
            }

            return res;
        }

        static int Calculate62(int a) //b
        {
            int res = 0;
            while (a > 0)
            {
                res += a % 10;
                a = a / 10;
            }

            return res;
        }

        static int Calculate63(int a) //c
        {
            int res = 1;
            while (a > 0)
            {
                res *= a % 10;
                a = a / 10;
            }

            return res;
        }

        static int Calculate64(int a) //c
        {
            int res = 0;
            int count = 0;
            while (a > 0)
            {
                res += a % 10;
                a = a / 10;
                count++;
            }

            return res / count;
        }

        static double Calculate65(int a) //c
        {
            double res = 0;
            while (a > 0)
            {
                int tmp = a % 10;
                res += Math.Pow(tmp, 2); // or 3
                a = a / 10;
            }

            return res;
        }

        static int Calculate66(int a) //d
        {
            int res = 0;
            while (a > 0)
            {
                res = a % 10;
                a = a / 10;
            }

            return res;
        }

        static int Calculate67(int a) //е
        {
            int last = 0;
            int first = a % 10;
            while (a > 0)
            {
                last = a % 10;
                a = a / 10;
            }

            return first + last;
        }

        //8.1
        static void Write1() //a
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(5 + " ");
                }

                Console.WriteLine();
            }
        }

        static void Write2() //b
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        static void Write3() //c
        {
            int start = 40;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(start + j + " ");
                }

                start += 10;
                Console.WriteLine();
            }
        }

        //8.2
        static void Write5() //a
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(5 + " ");
                }

                Console.WriteLine();
            }
        }

        static void Write6() //b
        {
            for (int i = 4; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(1 + " ");
                }

                Console.WriteLine();
            }
        }

        //8.3
        static void Write7() //a
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i + 1 + " ");
                }

                Console.WriteLine();
            }
        }

        static void Write8() //b
        {
            int c = 5;
            for (int i = 4; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(c + " ");
                }

                c++;
                Console.WriteLine();
            }
        }

        static void Write10() //c
        {
            int c = 10;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(c + " ");
                }

                c += 10;
                Console.WriteLine();
            }
        }

        static void Write11() //e
        {
            int c = 5;
            for (int i = 4; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(c + " ");
                }

                c += 5;
                Console.WriteLine();
            }
        }

        //8.4 
        static void Write122() //1
        {
            int tmp = 0;
            for (int i = 0; i < 5; i++)
            {
                tmp = i;
                for (int j = i; j >= 0; j--)
                {
                    if ((i == 4  && j==2) || (j==1 && i == 3))
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.Write(tmp + " ");
                    }
                    tmp--;
                }
                Console.WriteLine();
            }
        }

        static void Write12332() //2
        {
            int tmp = 6;
            int tmp2 = tmp;
            int tmp3 = tmp;
            for (int i = 0; i < 5; i++)
            {
                tmp3 = tmp2;
                for (int j = 4; j >= i; j--)
                {
                    if (j == 4 && i!=4)
                    {
                        Console.Write(tmp+ " ");
                    }
                    else
                    {
                        Console.Write(tmp3+" ");
                    }
                    tmp3--;
                }

                tmp++;
                tmp2--;
                Console.WriteLine();
            }
        }
        static void Write2122() //3
        {
            int def = 30;

            for (int i = 0; i < 5; i++)
            {
                int tmp = 0;
                for (int j = i; j >= 0; j--)
                {
                    //if()
                    Console.Write((def+tmp)+ " ");
                    tmp++;
                }

                def--;

                Console.WriteLine();
            }
        }

        static void Write12222() //4
        {
            int def = 20;

            for (int i = 0; i < 5; i++)
            {
                int tmp = 0;
                for (int j = 4; j >= i; j--)
                {
                    Console.Write((def + tmp) + " ");
                    tmp++;
                }

                def--;

                Console.WriteLine();
            }
        }
        //8.5
        static void Write11141()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(j + " + " + i + " = " + (i + j) + "  ");
                }

                Console.WriteLine();

            }
        }

        //8.6
        static void Write111()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i + " + " + j + " = " + (i + j) + "  ");
                }

                Console.WriteLine();

            }
        }

        //8.7
        static void Write1445()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i + " x " + j + " = " + (i * j) + "  ");
                }

                Console.WriteLine();

            }
        }

        //8.8
        static void Write4141()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(j + " x " + i + " = " + (i * j) + "  ");
                }

                Console.WriteLine();

            }
        }

        //8.36
        static void Writeafaf()
        {
            int s;
            for (int i = 2; i < 100000; i++)
            {
                s = 1;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0) s += j;
                    if (s == i) Console.WriteLine(i);
                }
            }
        }

        //9.41
        static void write(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }

        //9.42
        static void write1(string name)
        {
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
        }

        //9.43
        static void write2(string name)
        {
            string str = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (i % 2 == 0) str += name[i];
            }

            Console.WriteLine(str);

        }

        //9.44
        static void write3(string name)
        {
            string str = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                str += name[i];
            }

            Console.WriteLine(str);

        }

        //9.45
        static void write4(string name)
        {
            string str = "";
            for (int i = 0; i < 5; i++)
            {
                str += "*";
            }

            Console.WriteLine(str);

        }

        //9.46
        static void write5(string name)
        {
            string str = "";
            for (int i = 0; i < 8; i++)
            {
                str += "_";
            }

            Console.WriteLine(str);

        }

        //9.47
        static void write6(char symbol, int count)
        {
            string str = "";
            for (int i = 0; i < count; i++)
            {
                str += symbol;
            }

            Console.WriteLine(str);

        }

        //9.48
        static void write7(string word)
        {
            string str = "++++" + word + "-----";
            Console.WriteLine(str);
        }

        //9.49
        static void write8(string word)
        {
            string str = "";
            for (int i = 0; i < word.Length; i++)
            {
                str += "*";
            }

            str = str + word + str;
            Console.WriteLine(str);
        }

        //9.50
        static void write9(string word2, string word1, int count)
        {
            word2 = word2.Substring(word1.Length);
            word2 = word1 + word2;
            Console.WriteLine(word2);
        }

        //9.51
        static void write10(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'u') Console.WriteLine(word[i]);
            }
        }

        //9.52
        static void write11(string word, char symbol)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol) Console.WriteLine(word[i]);
            }
        }

        //9.53
        static void write12(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] % 3 == 0) Console.WriteLine(word[i]);
            }
        }

        //9.54
        static void write13(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'm' && word[i] == 'n') Console.WriteLine(word[i]);
            }
        }

        //9.55
        static void write14(string word, char f, char s)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == 'f' && word[i + 1] == 's') Console.WriteLine(f + s);
            }
        }

        //9.56
        static void write15(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == 'н' && word[i + 1] == 'н') Console.WriteLine("нн");
            }
        }

        //9.57
        static void write16(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] % 2 == 0 && word[i] == 'u') Console.WriteLine('u');
            }
        }

        //9.58
        static void write17(string word)
        {
            for (int i = 0; i < word.Length - 1; i = i + 4)
            {
                Console.WriteLine(word[i] + word[i + 1]);
            }
        }

        //9.59
        static void write18(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'o') count++;
            }

            Console.WriteLine(count);

        }

        //9.60
        static void write81(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ') count++;
            }

            Console.WriteLine(count);

        }

        //9.61
        static void write811(string word, char symbol)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol) count++;
            }

            Console.WriteLine(count);

        }

        //9.62
        static void write81441(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a') count++;
            }

            Console.WriteLine(count / word.Length * 100);

        }

        //9.63
        static void write814421(string word)
        {
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '+') count1++;
                if (word[i] == '*') count1++;
            }

            Console.WriteLine(count1 + " " + count2);

        }

        //9.64
        static void write8144921(string word)
        {
            int count1 = 0;

            for (int i = 0; i < word.Length - 1; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j]) count1++;
                }
            }

            Console.WriteLine(count1);

        }

        //9.65
        static void wri6te81844921(string word) //a
        {
            int count1 = 0;

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == 'p' && word[i + 1] == 'o') count1++;
            }

            Console.WriteLine(count1);


        }

        static void wri6afte81844921(string word, string ss) //b
        {
            int count1 = 0;

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == ss[0] && word[i + 1] == ss[1]) count1++;
            }

            Console.WriteLine(count1);


        }

        static void wri6afte818sf44921(string word, string ss) //c
        {
            int count1 = 0;

            for (int i = 0; i < word.Length - ss.Length - 1; i++)
            {
                for (int j = 0; j < ss.Length; j++)
                {
                    if (word[i + j] != word[j])
                    {
                        break;
                    }

                    if (j == ss.Length - 1) count1++;
                }
            }

            Console.WriteLine(count1);


        }

        //9.66
        static int writeFff(string words)
        {
            string[] arr = words.Split(' ');
            return arr.Length;
        }

        //9.67
        static int write2Fff12(string words) //a
        {
            int count = 1;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i] == ' ' && words[i-1]!=' ') count++;
              

            }
            Console.WriteLine(count);
            return count;
        }

        static int writeFff12(string words) //b
        {
            int count = 0;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i] == ' ' && words[i - 1] != ' ') count++;


            }
            Console.WriteLine(count);
            return count;
        }

        //9.68
        static int writeFff1112(string words)
        {
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == '+' || words[i] == '-')
                {
                    count++;
                }

            }

            return count;
        }

        //9.69
        static int writeFff1aa112(string words)
        {
            string[] arr = words.Split('.');
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }

            return arr.Length;
        }

        //9.70
        static int writeFf4f1aa112(string words)
        {
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                switch (words[i])
                {
                    case 'а':
                    case 'А':
                    case 'о':
                    case 'О':
                    case 'у':
                    case 'У':
                    case 'е':
                    case 'Е':
                    case 'ё':
                    case 'Ё':
                    case 'и':
                    case 'И':
                    case 'ы':
                    case 'Ы':
                    case 'э':
                    case 'Э':
                    case 'ю':
                    case 'Ю':
                    case 'я':
                    case 'Я':
                        count++;
                        break;
                        ;
                }
            }

            return count;
        }

        //9.71
        static int writeFf4f1aa1132(string words)
        {
            int mm = 0;
            int nn = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == 'm') mm++;
                if (words[i] == 'n') nn++;

            }

            return mm > nn ? 'm' : 'n';
        }

        //9.72
        static bool writeFf4f1aa11342(string words)
        {
            return words.Split(' ').Length > 3;
        }

        //9.73
        static char writeFf411f1aa11342(string words)
        {
            char symbol = ' ';
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == 'c' || words[i] == 'т')
                {
                    symbol = words[i];
                }
            }

            return symbol;
        }

        //9.74
        static bool writeFf411f12aa11342(string words)
        {
            Regex r = new Regex(@"(.)\1\1\1\1");
            return r.IsMatch(words);
        }

        //9.74
        static bool writeF3f411f12aa11342(string words)
        {
            Regex r = new Regex(@"(.)\1\1\1\1");
            return r.IsMatch(words);
        }

        //9.75
        static void writeWF3f411f12aa11342(string words) // a
        {
            int i = 0;
            while (words[i] != ',')
            {
                Console.Write(words[i]);
                i++;
            }
        }
        
        static void writeWF3f41gg1f12aa11342(string words) //b
        {
            int i = 0;
            while (words[i] != ',' || i!=words.Length)
            {
                Console.Write(words[i]);
                i++;
            }
        }

        //9.76
        static void writeWF3f411f1f2aa11342(string words) // a
        {
            int i = 0;
            while (words[i] != ',')
            {
                i++;
            }
            Console.Write(i);
        }

        //9.76
        static void writeWF3f411f1f2aa113432(string words) // a
        {
            int i = 0;
            while (words[i] != ',')
            {
                i++;
            }
            Console.Write(i+1);
        }
        //9.77
        static void writeWF3f4113f1f2aa113432(string words) // b
        {
            int i = words.Length-1;
            while (words[i] != ',')
            {
                i--;
            }
            Console.Write(i+1);
        }
        // 9.78
        static void writeWF3f4113f1f3422aa113432(string words)
        {
            string str = "";
            for(int i=0;i<words.Length;i++)
            {
                str = words[i] + str;
            }
            Console.WriteLine(str==words ? "palindrom" : "not palindr");
        }

        //9.90
        static string write99(string words)
        {
            StringBuilder strB = new StringBuilder(words);

            for (int i = 0; i < words.Length; i++)
            {
                if (strB[i] == 'е')
                {
                    strB[i] = 'u';
                }
            }

            return strB.ToString();
        }

        //9.91
        static string write919(string words)
        {
            StringBuilder strB = new StringBuilder(words);

            for (int i = 0; i < words.Length; i++)
            {
                if (strB[i] == ' ')
                {
                    strB[i] = '_';
                }
            }

            return strB.ToString();
        }

        //9.92
        static string write9129(string words)
        {
            StringBuilder strB = new StringBuilder(words);

            for (int i = 0; i < words.Length; i++)
            {
                if (i%2==0)
                {
                    strB[i] = '_';
                }
            }

            return strB.ToString();
        }

        //9.93
        static string write91239(string words)
        {
            StringBuilder strB = new StringBuilder(words);

            for (int i = 0; i < words.Length; i++)
            {
                if (i % 3 == 0)
                {
                    strB[i] = 'a';
                }
            }

            return strB.ToString();
        }

        //9.94
        static string write912339(string words)
        {
            StringBuilder strB = new StringBuilder(words);

            for (int i = 0; i < words.Length-1; i++)
            {
                if (words[i]=='a' && words[i+1]=='x')
                {
                    strB[i] = 'y';
                    i++;
                }
            }

            return strB.ToString();
        }

        //9.95
        static string write9123339(string words)
        {
            return words.Replace("да", "не");

        }

        //9.96
        static string write91233339(string words)
        {
            return words.Replace("про", "нет");

        }

        //9.97
        static string write912333339(string words)
        {
            return words.Replace("бит", "рог");
        }

        //9.98
        static string write222(string words, string first, string second)
        {
            return words.Replace(first, second);
        }

        //9.99
        static string write2212(string words)
        {
            return words.Replace("очепатка", "опечатка");
        }

        //9.100
        static string write12212(string words)
        {
            StringBuilder word=new StringBuilder(words);
            char tmp = word[1];
            word[1] = word[4];
            word[4] = tmp;
            return word.ToString();
        }

        //9.101
        static string write122122(string words)
        {
            StringBuilder word = new StringBuilder(words);
            char tmp = word[2];
            word[2] = word[word.Length-1];
            word[word.Length - 1] = tmp;
            return word.ToString();
        }

        //9.102
        static string write2122122(string words, int m,int n)
        {
            StringBuilder word = new StringBuilder(words);
            char tmp = word[m-1];
            word[m-1] = word[n-1];
            word[m-1] = tmp;
            return word.ToString();
        }

        //9.103
        static string write12122122(string words, int m, int n)
        {
            StringBuilder word = new StringBuilder(words);
            for (int i = 0; i < word.Length; i=i+2)
            {
                char tmp = word[i];
                word[i] = word[i+1];
                word[i+1] = tmp;
            }

            return word.ToString();
        }

        //9.104
        static string write412122122(string words, int m, int n)
        {
            StringBuilder word = new StringBuilder(words);
            for (int i = 0; i < word.Length/2; i++)
            {
                char tmp = word[i];
                word[i] = word[word.Length-1-i];
                word[word.Length - 1 - i] = tmp;
            }

            return word.ToString();
        }

        //9.138
        static bool writefff(char ch)
        {
            return Char.IsNumber(ch);
        }

        //9.139
        static void writef4ff(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if(Char.IsNumber(text[i])) Console.WriteLine(text[i]);
            }
        }

        //9.140
        static int wr3itef4ff(string text)
        {
            int count=0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsNumber(text[i])) count++;
            }

            return count;
        }

        //9.141
        static int[] wr3itef43ff(string text)
        {
            int sum = 0;
            int max =Int32.MinValue;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsNumber(text[i]))
                {
                    sum += text[i];
                    if (text[i] > max) 
                    max=text[i];
                }
            }

            return new int[]{sum,max};
        }

        //9.142
        static int wr3itef443ff(string text)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsNumber(text[i]))
                {
                    if (text[i] > max)
                        max = text[i];
                }
            }

            return max ;
        }

        //9.143
        static bool wr3itef4443ff(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsNumber(text[i]))
                {
                    return false;
                }
            }

            return true;
        }

        //9.152
        static int wr3itef24443ff(string text)
        {
            int k = 0;
            int max = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    k++;
                }
                else
                {
                    if (k > max)
                    {
                        max = k;
                        k = 0;
                    }
                }
            }

            return max;
        }

        //9.153
        static int wr3itef24443f3f(string text, char c)
        {
            int k = 0;
            int max = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == c)
                {
                    k++;
                }
                else
                {
                    if (k > max)
                    {
                        max = k;
                        k = 0;
                    }
                }
            }

            return max;
        }

        //9.154
        static int wr3itef244443f3f(string text)
        {
            text=text.Distinct().ToString();
            return text.Length;
        }

        //9.155
        static int[] wr3itef0244443f3f(string text)
        {
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    return new int[]{text[i],text[i+1]};
                }
            }

            return null;
        }
    }
}

