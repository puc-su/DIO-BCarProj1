using DioBCarreProj1;
using System;

namespace DioBCarreProj1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Knight heroi = new Knight("Arus", 23, "Knight",12,13);
            Wizard wizard = new Wizard("Jennica", 19, "Wizard",6,18);

            Console.WriteLine(heroi.Attack() + " e " + heroi.Forca(5));
            Console.WriteLine(wizard.Attack("W") + " e " + wizard.Forca(13));
        }
    }
}
