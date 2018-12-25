using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Hashtable
    {

        const int maxSize = 100; //our table size
        int[] table = new int[maxSize];

        public Hashtable()
        {

            for (int i = 0; i < maxSize; i++)
            {
                table[i] = -1;
            }
        }


        public static int h(int key)
        {
            return key % maxSize;
        }





        public void add(int key, int vale)
        {
            if (table[h(key)] == -1)
            {

                table[h(key)] = vale;

            }
            else
            {
                int index = h(key);
                int i = 0;

                while (table[index] != -1 && index != key)
                {
                    i++;
                    index = (index + i * i) % maxSize;

                }

                if (table[index] == -1)
                {
                    table[index] = vale;
                }


            }

        }


        public void print(int k)
        {

            if (table[h(k)] == -1)
                Console.WriteLine(k + " = it is  Empty ! ");
            else
                Console.WriteLine(k + " = " + table[h(k)]);

        }


        static void Main(string[] args)
        {
            Hashtable mtable = new Hashtable();

            Random rnd = new Random();

            int[] urtec = new int[100];

            for (int i = 0; i < urtec.Length; i++)
            {

                mtable.add(urtec[i] = rnd.Next(0, 100), urtec[i] = rnd.Next(500, 10000));

            }

            for (int i = 0; i <= urtec.Length; i++)
            {

                mtable.print(i);

            }





            Console.ReadLine();

        }
    }
}