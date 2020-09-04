using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Laba_1_baldezhnaya
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;

            Console.WriteLine("Введите количество элементов:");
            Init(out N);

            Console.WriteLine("Введите количество потоков:");
            Init(out M);

            int[] arr = new int[N];

            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(1, 15);
            }

            ThreadWorker[] threads = new ThreadWorker[M]; 

            // разбить массив для потоков
        }

        static void Init(out int n) {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                Console.WriteLine("Некорректный ввод. Введите целое число");
            }
        }
    }
}
