using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public double fraction(double x)
        {
            return x - (int)x;
        }

        public int charToNum(char y)
        {
            return y - 48;
        }

        public bool is2Digits(int z)
        {
            int absZ = Math.Abs(z);
            return absZ >= 10 && absZ <= 99;
        }

        public bool isInRange(int a, int b, int num)
        {
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            return num >= min && num <= max;
        }

        public bool isEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }

        public int abs(int x)
        {
            if (x < 0)
            {
                return -x;
            }
            else
            {
                return x;
            }
        }

        public bool is35(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                return false;
            }
            else if (x % 3 == 0 || x % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int max3(int x, int y, int z)
        {
            int max = x;
            if (y > max)
            {
                max = y;
            }

            if (z > max)
            {
                max = z;
            }
            return max;
        }

        public int sum2(int x, int y)
        {
            int sum = x + y;
            if ((sum >= 10) && (sum <= 19))
            {
                return 20;
            }
            else
            {
                return sum;
            }
        }

        public String day(int x)
        {
            switch (x)
            {
                case 1:
                    return "понедельник";
                case 2:
                    return "вторник";
                case 3:
                    return "среда";
                case 4:
                    return "четверг";
                case 5:
                    return "пятница";
                case 6:
                    return "суббота";
                case 7:
                    return "воскресенье";
                default:
                    return "это не день недели";

            }
        }

        public String listNums(int x)
        {
            int[] mas = new int[x + 1];
            for (int i = 0;i <= x;i++)
            {
                mas[i] = i;
            }
            return string.Join(" ", mas);
        }

        public String chet(int x)
        {
            int count = (x / 2) + 1;
            int[] mas = new int[count];
            int index = 0;
            for (int i = 0; i <= x; i += 2)
            {
                mas[index] = i;
                index ++;
            }
            return string.Join(" ", mas);
        }

        public int numLen(long x)
        {
            if (x < 0)
            {
                x = -x;
            }

            if (x == 0)
            {
                return 1;
            }

            int count = 0;
            while (x > 0)
            {
                x = x / 10;
                count++;
            }
            return count;
        }

        public void square(int x)
        {
            for (int i = 0; i < x; i++) //высота
            {
                for (int j = 0; j < x; j++) //ширина
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public void rightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < x - i; j++)
                {
                    Console.Write(' ');
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public int maxAbs(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(max))
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] result = new int[arr.Length + ins.Length];
            for (int i = 0; i < pos; i++)
            {
                result[i] = arr[i];
            }

            for (int i = 0; i < ins.Length; i++)
            {
                result[pos + i] = ins[i];
            }

            for (int i = pos; i < arr.Length; i++)
            {
                result[i + ins.Length] = arr[i];
            }
            return result;
        }

        public int[] reverseBack(int[] arr)
        {
            int[] rev = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                rev[arr.Length - 1 - i] = arr[i];
            }
            return rev;
        }

        public int[] findAll(int[] arr, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    count++;
                }
            }

            int[] indexes = new int[count];
            int ina = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    indexes[ina] = i;
                    ina++;
                }
            }
            return indexes;
        }
    }
}
