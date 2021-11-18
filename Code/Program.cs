using System;

namespace Tic_Tac_Toe
{
    class Bebra_s_polem
    {
        string[,] pole = new string[3, 3];
        bool krestic = true;
        public string win()
        {
            string res = "";
            for (int i = 0; i < 3; i++)
            {
                if (pole[0, i] == pole[1, i] & pole[1, i] == pole[2, i])
                {
                    if (!(pole[0, i] == "."))
                    {
                        res = pole[0, i];
                    }
                }
                else if (pole[i, 0] == pole[i, 1] & pole[i, 1] == pole[i, 2])
                {
                    if (!(pole[i, 0] == "."))
                    {
                        res = pole[i, 0];
                    }
                }

                if (pole[0, 0] == pole[1, 1] & pole[1, 1] == pole[2, 2])
                {
                    if (!(pole[0, 0] == "."))
                    {
                        res = pole[0, 0];
                    }
                }
                else if (pole[0, 2] == pole[1, 1] & pole[1, 1] == pole[2, 0])
                {
                    if (!(pole[2, 0] == "."))
                    {
                        res = pole[2, 0];
                    }
                }
            }
            return res;
        }
        public void spavn_field()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pole[i, j] = ".";
                }

            }
        }
        public void draw_field()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(pole[i, j]);
                }
                Console.WriteLine("");
            }
        }
        public void draw_poxvaly()
        {

            if (win() == "x")
            {
                Console.Clear();
                Console.WriteLine("Победа крестика");
            }
            else if (win() == "0")
            {
                Console.Clear();
                Console.WriteLine("Победа нолика");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ничья");

            }
        }
        public void kuda_stawit()
        {

            string yr = Console.ReadLine();
            string xr = Console.ReadLine();
            int num;
            if (int.TryParse(yr, out num) & int.TryParse(xr, out num))
            {
                int y = Convert.ToInt32(yr) - 1;
                int x = Convert.ToInt32(xr) - 1;
                if ((!(x > 2) & !(y > 2)) && pole[x, y] == ".")
                {
                    if (krestic == true)
                    {
                        pole[x, y] = "x";
                    }
                    else
                    {
                        pole[x, y] = "0";
                    }
                    krestic = !krestic;
                }
                else
                {
                    Console.WriteLine("Так нельзя");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Так нельзя");
                Console.ReadKey();
            }


        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Bebra_s_polem ebla_S_Polem = new Bebra_s_polem();
            ebla_S_Polem.spavn_field();
            ebla_S_Polem.draw_field();
            while (ebla_S_Polem.win() == "")
            {
                ebla_S_Polem.kuda_stawit();
                ebla_S_Polem.draw_field();
            }
            ebla_S_Polem.draw_poxvaly();
            Console.ReadKey();
        }
    }
}
