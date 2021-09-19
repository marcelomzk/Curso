using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            //classe abstrata nao pode ser instanciada
            //EntidadeBase minhaClasse = new EntidadeBase();

            Serie meuObjeto = new Serie();

            Console.WriteLine("Hello World!");
        }
    }
}
