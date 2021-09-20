using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            //classe abstrata nao pode ser instanciada
            //EntidadeBase minhaClasse = new EntidadeBase();

            //Serie meuObjeto = new Serie();

            Console.WriteLine("Hello World!");
        }

        private string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().toUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
