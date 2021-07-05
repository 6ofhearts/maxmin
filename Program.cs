using System;
using System.Collections.Generic;
using System.IO;

namespace maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            long max = 0;
            long min;
            long[] elements = new long[5000000];

            string path = @"D:\max_min_4.txt";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                for (long i = 0; (line = sr.ReadLine()) != null; i++)
                {
                    elements[i]=((long)Convert.ToInt64(line));
                }
                min = elements[0];
                foreach (long element in elements)
                {
                    if (max <= element)
                    {
                       max = element;
                    }
                        
                    if (min >= element)
                    {
                        min = element;
                    }
                    

                }
            }

            Console.WriteLine(max.ToString() + " - максимум" + min.ToString() + " - минимум");
    }
    }
}
