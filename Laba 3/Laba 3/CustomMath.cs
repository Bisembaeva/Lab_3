using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    public static class CustomMath
    {
        public static long Task1(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int product = 1;
                for (int j = i; j <= 2 * i; j++)
                {
                    product *= j;
                }
                sum += product;
            }
            return sum;
        }
        public static BigInteger Task2(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n), "n должно быть >= 0");

            if (n == 0 || n == 1)
                return BigInteger.One;

            BigInteger result = BigInteger.One;

            int start = (n % 2 == 0) ? 2 : 1;
            for (int i = start; i <= n; i += 2)
            {
                result *= new BigInteger(i);
            }
            return result;
        }
        public static List<int> Task3(int a, int b)
        {
            if (a > b)
                throw new ArgumentException("a должно быть <= b");
            if (a < 0 || b < 0)
                throw new ArgumentException("a, b должно быть <= 0");
            if (a < 100 || b < 100)
                throw new ArgumentException("a, b должно быть больше 99");

            var result = new List<int>();

            int[] cube = new int[10];
            for (int d = 0; d <= 9; d++)
                cube[d] = d * d * d;

            for (int n = a; n <= b; n++)
            {
                int sum = 0;
                int x = n;

                while (x > 0)
                {
                    int digit = x % 10;
                    sum += cube[digit];
                    x /= 10;
                    if (sum > n)
                        break;
                }

                if (sum == n)
                    result.Add(n);
            }

            return result;
        }
        private static int SumOfProperDivisors(int n)
        {
            if (n < 2) 
                return 0;

            int sum = 1; 
            int sqrt = (int)Math.Sqrt(n);

            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    int pair = n / i;
                    if (pair != i) 
                        sum += pair;
                }
            }

            return sum;
        }
        public static List<(int, int)> Task4(int a, int b)
        {
            var result = new List<(int, int)>();

            for (int x = a; x <= b; x++)
            {
                int y = SumOfProperDivisors(x);

                if (y > x && y <= b && y >= a) 
                {
                    if (SumOfProperDivisors(y) == x)
                    {
                        result.Add((x, y));
                    }
                }
            }

            return result;
        }
        public static double Task5(double x, int n)
        {
            double result = 1; 
            for (int i = 0; i < n; i++)
            {
                result *= x;
            }
            return result;
        }
        public static void Task6()
        {
            for (int num = 0; num <= 999999; num++)
            {
                string ticket = num.ToString("D6"); // формат с ведущими нулями то есть 7 будет как 000007
                int sum1 = (ticket[0] - '0') + (ticket[1] - '0') + (ticket[2] - '0');
                int sum2 = (ticket[3] - '0') + (ticket[4] - '0') + (ticket[5] - '0');

                if (sum1 == sum2) 
                { 
                    Console.WriteLine(ticket); 
                } 
            }
        }
        public static BigInteger Task7(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n должно быть положительным");
            } 
            if (n == 1 || n == 2)
            {
                return 1;
            }  
            BigInteger a = 1, b = 1; 
            for (int i = 3; i <= n; i++) 
            { 
                BigInteger temp = a + b; 
                a = b;
                b = temp;
            }
            return b;
        }
        public static double Task8(double x)
        {
            double[] coeffs = new double[11]; 
            for (int i = 1; i < 11; i++)
            {
                coeffs[i] = i + 1;
            }
                
            double result = coeffs[0]; // 1

            for (int i = 1; i < coeffs.Length; i++)
            {
                result = result * x + coeffs[i];
            }
                
            return result;
        }
    }
}


