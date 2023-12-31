using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Channels;
using System.Threading;
using System;

namespace HelloWorld
{
    class Program
	{
        static void Letters_Writting(char[] y,int ASCII, int number)
        {
            int x;
            string z;
            for (x = 65; x <= 122; x++)
            {
                if (x == ASCII)
                {
                    y[number] = (char)x;
                    break;
                }
                else
                    y[number] = (char)x;

                z = new string(y);
                Console.WriteLine(z);
                Thread.Sleep(50);
            }
        }

		static void Main(string[] args)
		{
            Console.SetWindowSize(48, 2);

            //letter arrays + space[5]
            char[] letters = new char[11];
            letters[5] = (char)32;
            //H
            Letters_Writting(letters, 72, 0);
            //e
            Letters_Writting(letters, 101, 1);
            //l
            Letters_Writting(letters, 108, 2);
            //l
            Letters_Writting(letters, 108, 3);
            //o
            Letters_Writting(letters, 111, 4);
            //W
            Letters_Writting(letters, 87, 6);
            //o
            Letters_Writting(letters, 111, 7);
            //r
            Letters_Writting(letters, 114, 8);
            //l
            Letters_Writting(letters, 108, 9);
            //d
            Letters_Writting(letters, 101, 10);

            Console.ReadKey();
        }
	}
}