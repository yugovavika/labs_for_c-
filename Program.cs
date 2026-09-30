namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //задание №1 задача 1
            Console.WriteLine("Введите вещественное число для задания №1.1 (через запятую)");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка. Введите вещественное число:");
            }

            Class1 myClass1_1 = new Class1();
            double result1 = myClass1_1.fraction(x);

            Console.WriteLine("Ответ на №1.1: Дробная часть числа: " + result1);

            //задание№1 задача 3
            Console.WriteLine("Введите число от 0 до 9");
            char y;
            while (!char.TryParse(Console.ReadLine(), out y) || y < '0' || y > '9')
            {
                Console.WriteLine("Ошибка. Введите число от 0 до 9:");
            }

            Class1 myClass1_2 = new Class1();
            int result2 = myClass1_2.charToNum(y);

            Console.WriteLine(result2);

            //задание №1 задача 5
            Console.WriteLine("Введите число для 3 задания:");
            int z;
            while (!int.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Class1 myClass1_3 = new Class1();
            bool result3 = myClass1_3.is2Digits(z);

            Console.WriteLine("Результат: " + result3);

            //задание №1 задача 7
            Console.WriteLine("Введите левую границу: ");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Console.WriteLine("Введите правую границу: ");
            int b;
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Console.WriteLine("Введите число");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Class1 myClass1_4 = new Class1();
            bool result4 = myClass1_4.isInRange(a, b, num);

            Console.WriteLine("Результат: " + result4);

            //задача №1 задание 9
            Console.WriteLine("Введите первое число a:");
            int a1;
            while (!int.TryParse(Console.ReadLine(), out a1))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Console.WriteLine("Введите второе число b:");
            int b1;
            while (!int.TryParse(Console.ReadLine(), out b1))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Console.WriteLine("Введите третье число c:");
            int c1;
            while (!int.TryParse(Console.ReadLine(), out c1))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Class1 myClass1_5 = new Class1();
            bool result5 = myClass1_5.isEqual(a1, b1, c1);

            Console.WriteLine("Результат: " + result5);

            //задача №2 задание 1
            Console.WriteLine("Введите целое число:");
            int x1;
            while (!int.TryParse(Console.ReadLine(), out x1))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Class1 myClass2_1 = new Class1();
            int result6 = myClass2_1.abs(x1);

            Console.WriteLine("Модуль числа: " + result6);

            //задача №2 задание 3
            Console.WriteLine("Введите целое число:");
            int x2;
            while (!int.TryParse(Console.ReadLine(), out x2))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Class1 myClass2_2 = new Class1();
            bool result7 = myClass2_2.is35(x2);

            Console.WriteLine("Результат проверки: " + result7);

            //задача №2 задание 5
            Console.WriteLine("Введите число x:");
            int x3;
            while (!int.TryParse(Console.ReadLine(), out x3))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Console.WriteLine("Введите число y:");
            int y3;
            while (!int.TryParse(Console.ReadLine(), out y3))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Console.WriteLine("Введите число z:");
            int z3;
            while (!int.TryParse(Console.ReadLine(), out z3))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Class1 myClass2_3 = new Class1();
            int result8 = myClass2_3.max3(x3, y3, z3);

            Console.WriteLine("Результат: " + result8);

            //задача №2 задание 7
            Console.WriteLine("Введите число x: ");
            int numX;
            while (!int.TryParse(Console.ReadLine(), out numX))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Console.WriteLine("Введите число y: ");
            int numY;
            while (!int.TryParse(Console.ReadLine(), out numY))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Class1 myClass2_4 = new Class1();
            int result9 = myClass2_4.sum2(numX, numY);

            Console.WriteLine("Результат: " + result9);

            //задача №2 задание 9
            Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
            int dayX;
            while (!int.TryParse(Console.ReadLine(), out dayX) || dayX < 1 || dayX > 7)
            {
                Console.WriteLine("Ошибка. Введите число от 1 до 7:");
            }

            Class1 myClass2_5 = new Class1();
            string result10 = myClass2_5.day(dayX);

            Console.WriteLine("Результат: " + result10);

            //задача №3 задание 1
            Console.WriteLine("Введите целое неотрицательное число x:");
            int listX;
            while (!int.TryParse(Console.ReadLine(), out listX) || listX < 0)
            {
                Console.WriteLine("Ошибка. Введите целое неотрицательное число:");
            }

            Class1 myClass3_1 = new Class1();
            string result11 = myClass3_1.listNums(listX);

            Console.WriteLine("Результат: " + result11 + " ");

            //задача №3 задание 3
            Console.WriteLine("Введите целое неотрицательное число x:");
            int listX2;
            while (!int.TryParse(Console.ReadLine(), out listX2) || listX2 < 0)
            {
                Console.WriteLine("Ошибка. Введите целое неотрицательное число:");
            }

            Class1 myClass3_2 = new Class1();
            string result12 = myClass3_2.chet(listX2);

            Console.WriteLine("Результат: " + result12 + " ");

            //задача №3 задание 5
            Console.WriteLine("Введите целое число: ");
            long lenX;
            while (!long.TryParse(Console.ReadLine(), out lenX))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Class1 myClass3_3 = new Class1();
            int result13 = myClass3_3.numLen(lenX);

            Console.WriteLine("Количество знаков: " + result13);

            //задача №3 задание 7
            Console.WriteLine("Введите размер стороны квадрата x (x > 0): ");
            int sqx;
            while (!int.TryParse(Console.ReadLine(), out sqx) || sqx <= 0)
            {
                Console.WriteLine("Ошибка. Введите целое положительное число:");
            }

            Class1 myClass3_4 = new Class1();
            Console.WriteLine("Результат:");
            myClass3_4.square(sqx);

            //задача №3 задание 9
            Console.WriteLine("Введите высоту треугольника x (x > 0): ");
            int triX;
            while (!int.TryParse(Console.ReadLine(), out triX) || triX <= 0)
            {
                Console.WriteLine("Ошибка. Введите целое положительное число:");
            }

            Class1 myClass3_5 = new Class1();
            Console.WriteLine("Результат:");
            myClass3_5.rightTriangle(triX);

            //задание №4 задача 1
            int[] myArr = { 1, 2, 3, 4, 2, 2, 5 };
            Console.WriteLine("Дан массив: [" + string.Join(", ", myArr) + "]");

            Console.Write("Введите число x для поиска его индекса: ");
            int fFX;
            while (!int.TryParse(Console.ReadLine(), out fFX))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Class1 myClass4_1 = new Class1();
            int indexResult = myClass4_1.findFirst(myArr, fFX);
            Console.WriteLine("Индекс первого вхождения: " + indexResult);

            //задание №4 задача 3
            int[] myArr2 = { 1, -2, -8, 4, 2, 2, 5 };
            Console.WriteLine("Дан массив: [" + string.Join(", ", myArr2) + "]");

            Class1 myClass4_2 = new Class1();
            int maxresult = myClass4_2.maxAbs(myArr2);
            Console.WriteLine("Наибольшее по модулю значение: " + maxresult);

            //задание №4 задача 5
            int[] arrA = { 1, 2, 3, 4, 5 };
            int[] arrIns = { 7, 8, 9 };

            Console.WriteLine("Исходный массив: [" + string.Join(", ", arrA) + "]");
            Console.WriteLine("Массив для вставки: [" + string.Join(", ", arrIns) + "]");

            Console.WriteLine("Введите позицию вставки (от 0 до " + arrA.Length + "):");
            int position;
            while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position > arrA.Length)
            {
                Console.WriteLine("Ошибка. Введите число от 0 до " + arrA.Length + ":");
            }

            Class1 myClass4_3 = new Class1();
            int[] addresult = myClass4_3.add(arrA, arrIns, position);
            Console.WriteLine("Результат: [" + string.Join(", ", addresult) + "]");

            //задание №4 задача 7
            int[] Arr7 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Исходный массив: [" + string.Join(", ", Arr7) + "]");

            Class1 myClass4_4 = new Class1();
            int[] revresult = myClass4_4.reverseBack(Arr7);
            Console.WriteLine("Перевернутый массив: [" + string.Join(", ", revresult) + "]");

            //задание №4 задача 9
            int[] finalArr = { 1, 2, 3, 8, 2, 2, 9 };

            Console.WriteLine("Исходный массив: [" + string.Join(", ", finalArr) + "]");

            Console.Write("Введите искомое число x: ");
            int faX;
            while (!int.TryParse(Console.ReadLine(), out faX))
            {
                Console.WriteLine("Ошибка. Введите целое число:");
            }

            Class1 myClass4_5 = new Class1();
            int[] result20 = myClass4_5.findAll(finalArr, faX);
            Console.WriteLine("Индексы всех вхождений: [" + string.Join(", ", result20) + "]");
        }

    }
}