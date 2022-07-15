using System;
using System;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //if we need the massive
            //int[] m = { 1, 0, 0, 1, 0, 1, 0, 1, 1 };

            var m = new List<int>{0, 1, 1, 0, 1, 0, 1, 0, 0};
            int n;

            /// <summary>
            //Count units
            /// </summary>
            for (int i = 0; i != m.Count; i++)
            {
                int count = 0;
                ///<summary>
                ///// counting units to the right 
                ///</summary>
                if (m[i] == 0 && i != m.Count)
                {
                    for (int j = i; j != m.Count; j++)
                    {
                        if (m[j] == 1) { count++; }
                    }
                }
                /// <summary>
                /// //output units count
                /// </summary>
                if (m[i] == 0)
                {
                    Console.WriteLine("Sum of zero with index {0} = {1}", i, count);
                }
            }
            Console.Read();
        }

    }
}
