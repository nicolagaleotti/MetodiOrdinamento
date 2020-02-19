using System;
using System.Diagnostics;
using Ordinamento;
using System.IO;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] dimensioni = {500, 1000, 5000, 10000, 15000, 20000, 25000, 30000};
            string file = "BubbleSort.csv";
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            using (StreamWriter w = new StreamWriter(file, true))
            {
                w.WriteLine("Algoritmo; Dimensione; Tempo");
                foreach (int dim in dimensioni)
                {
                    int[] array = new int[dim];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = r.Next(0, 100000);
                    }
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    array = BubbleSort.Bubble_Sort(array);
                    s.Stop();
                    long elapsed = s.ElapsedMilliseconds;
                    w.WriteLine($"Bubblesort; {dim}; {elapsed}");
                    s.Reset();
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = r.Next(0, 100000);
                    }
                    s.Start();
                    array = Ordinamento.InsertionSort.Insertion_Sort(array);
                    s.Stop();
                    elapsed = s.ElapsedMilliseconds;
                    w.WriteLine($"InsertionSort; {dim}; {elapsed}");
                    w.Flush();
                }
                Console.WriteLine("finito");
                Console.ReadLine();
            }
        }
    }
}
