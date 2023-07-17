using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace HomeWorkSeminar4;
class Program
{
    static void Main(string[] args)
    {
        void task25()
        {
            // Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B)
            // и возводит число A в степень B.
            //3, 5 -> 243 (3⁵)
            //2, 4 -> 16

            int Input(string text)
            {
                Console.WriteLine(text);
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }

            int Degree(int x, int y)
            {
                int degree = 1;

                for (int i = 0; i < y; i++)
                {
                    degree = x * degree;

                }
                return degree;
            }

            int numberX = Input("Введите целое число: ");
            int numberY = Input("Введите степень, в которую вы хотите ввести введенное ранее число: ");
            Console.WriteLine($"Ваше число {numberX} в степени  {numberY} равно {Degree(numberX, numberY)}");
            Console.WriteLine($"{numberX} ^ {numberY} = {Degree(numberX, numberY)}");
        }

        void task27()
        {
            // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            //452 -> 11
            //82 -> 10
            //9012 -> 12

            int Input(string text)
            {
                Console.WriteLine(text);
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }

            int userNumber = Input("Введите целое число: ");
            int sumDigitNumber = 0;
            for (int i = userNumber; i > 0; i /= 10)
            {
                sumDigitNumber += i % 10;

            }
            Console.WriteLine($"Cумма цифр вашего числа {userNumber} равна {sumDigitNumber}");

        }

        void task29()
        {
            // Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
            //-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
            //6, 1, -33 -> [1, 6, -33]

            int[] Array(string text)
            {
                Random random = new Random();
                Console.WriteLine(text);
                int length = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[length];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-100, 100);
                }
                return array;
            }

            void PrintArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }

            int[] SortArrayAbs(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int minPosition = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (Math.Abs(array[j]) < Math.Abs(array[minPosition])) minPosition = j;
                    }


                    int temp = array[i];
                    array[i] = array[minPosition];
                    array[minPosition] = temp;
                }
                return array;
            }



            int[] userArray = Array("Введите число, которое будет означать количество элементов вашего массива");
            Console.WriteLine($"Ваш массив на {userArray.Length} элементов, заполненный случайными числами -100 до 100: ");
            PrintArray(userArray);
            SortArrayAbs(userArray);
            Console.WriteLine("");
            Console.WriteLine("Ваш массив отсортированный по модулю: ");
            PrintArray(userArray);
        }

        void task1()
        {
            // Задача 1. На вход подаётся натуральное десятичное число. Проверьте, является ли оно палиндромом в двоичной записи.

            int Input(string text)
            {
                Console.WriteLine(text);
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }

            char[] BinaryDigit(int number)
            {
                string text = "";
                while (number > 0)
                {
                    text += number % 2;
                    number /= 2;
                }
                char[] textBinary = new char[text.Length];
                for (int i = 0; i < textBinary.Length; i++)
                {
                    textBinary[i] = text[i];
                }

                for (int i = 0; i < text.Length / 2; i++)
                {
                    char temp = textBinary[i];
                    textBinary[i] = textBinary[text.Length - 1 - i];
                    textBinary[text.Length - 1 - i] = temp;

                }
                return textBinary;

            }

            void PrintArray(char[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }

            bool Polindrom(char[] binaryNumber)
            {
                bool polindrom = false;
                for (int i = 0; i < binaryNumber.Length; i++)
                {
                    if (binaryNumber[i] == binaryNumber[binaryNumber.Length - 1] - 1) polindrom = true;
                }
                return polindrom;
            }

            int number = Input("Введите число в десятичной системе счисления: ");
            char[] str = BinaryDigit(number);
            bool polindrom = Polindrom(str);

            Console.Write("Ваше число: " + number + " в двоичной системе счисление ");
            PrintArray(str);
            Console.Write("Являяется полиндромом? " + "Ответ: " + polindrom);
        }

        void task2()
        {
            // Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц.
            // Размер массива должен совпадать с квадратом количества единиц в нём.
            Random random = new Random();
            int length = random.Next(1, 100);
            int[] array = new int[length];
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (count == 10) array[i] = 0;
                else array[i] = random.Next(0, 2);
                if (array[i] == 1) count++;
            }

            int newLenght = count * count;
            int[] newArray = new int[newLenght];
            if (newLenght <= length)
            {

                for (int i = 0; i < newLenght; i++)
                {
                    newArray[i] = array[i];
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    newArray[i] = array[i];
                }
            }

            Console.WriteLine($"Массив заполнен случайным количеством 0 и 1 до 100 элементов. Количество элеметов равно сумме едениц в квадрате!");
            Console.WriteLine("В этом случайном массиве: " + count + " едениц! " + "Массив получился на: " + count * count + " элементов!");

            for (int i = 0; i < newLenght; i++)
            {
                Console.Write(newArray[i] + " ");
            }


        }

        void task3()
        {
            // Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99.
            // Определите самый часто встречающийся элемент в массиве. Если таких элементов несколько, вывести их все

            Random random = new Random();
            int[] randomArray = new int[100]; //Создаем массив на 100 элементов
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(1, 100);//Заплняем его рандомными числами от 1 до 99

            }

            int[] elementsArray = new int[100];// Создаем массив 
            for (int i = 0; i < elementsArray.Length-1; i++)
            {
                elementsArray[i] = i;

            }


            int[] newArray = new int[100];
            


            for (int i = 0; i < elementsArray.Length; i++)
            {

                int count = 0;


                for (int j = 0; j < randomArray.Length; j++)
                {


                    if (elementsArray[i] == randomArray[j])
                    {
                        count++;
                        newArray[i] = count;
                        

                    }
                    

                }

            }

            int index = 0;
            
           int max = newArray[0];
            for (int i = 0; i < newArray.Length; i++)
            { 
                
                if (max < newArray[i])
                {
                    max = newArray[i];
                    index = i;
                }
            }
           
            for (int i = 0; i < newArray.Length; i++)
            {
                if (max == newArray[i])
                {
                    index = i;
                    Console.WriteLine($"Больше всего повторялся элемент {index} в количестве {max}");
                }
            }




        }


        Console.Clear();
        Console.WriteLine("Введите номер задачи 25, 27, 29, 1, 2 или 3");
        int task = Convert.ToInt32(Console.ReadLine());
        switch (task)
        {
            case 25: task25(); break;
            case 27: task27(); break;
            case 29: task29(); break;
            case 1: task1(); break;
            case 2: task2(); break;
            case 3: task3(); break;
            default: Console.WriteLine("Задачи с таким номером не существует!"); break;
        }

    }
}

