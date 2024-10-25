using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4zavd2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Task 2
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                int[] array = new int[10];
                Random rand = new Random();

                Console.WriteLine("Вихідний масив:");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-5, 10);
                    Console.WriteLine($"array[{i}] = {array[i]}");
                }

                // Знаходимо локальні максимуми
                bool hasLocalMax = false;
                for (int i = 1; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        hasLocalMax = true;
                        Console.WriteLine($"Локальний максимум: array[{i}] = {array[i]}");
                    }
                }
                
                if (!hasLocalMax)
                {
                    Console.WriteLine("Локальні максимуми відсутні.");
                Console.ReadKey();
                }
            }
        }
    }
    

