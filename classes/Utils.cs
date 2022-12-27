using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SENAI.classes
{
    public static class Utils // static = serve para avisar que a classe não irá precisar de retorno, só irá rodar a informação dada.
    {
        public static void BarraCarregamento(string texto, int repeticao, string simbolo)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write($">>{texto}");

            for (var i = 0; i < repeticao; i++)
            {
                Console.Write(simbolo);
                Thread.Sleep(300);
            }
            Thread.Sleep(300);
            Console.ResetColor();
        }
    }
}