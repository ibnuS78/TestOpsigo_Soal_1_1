using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOpsigo_Soal_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan Pesan : ");
            string sentence = Console.ReadLine();
            sentence = sentence.PadRight(16, '*').Substring(0,16);
            string enkripsi = Program.pesan_rahasia(sentence);
            Console.WriteLine("Hasil Enkripsi Pesan : " + enkripsi);
            Console.ReadLine();
        }

        public static string pesan_rahasia(string pesan)
        {
            var pesannya = pesan.ToCharArray();
            int M = 4;
            int lengthstr = pesannya.Length-M;
            int idx = 0;

            string Result = "";
            for(int i = 0; i < M; i++)
            {
                idx = lengthstr+i;
                for(int j=0; j < M; j++)
                {
                    if(pesannya[idx] != '*')
                    {
                        Result += pesannya[idx];
                    }

                    idx = idx - M;
                }

            }
            return Result;
        }
    }
}
