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

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.toUpper() != "X")
            {
                 switch (opcaoUsuario)
                 {
                     case "1":
                        ListarSerie();
                        break;
                     case "2":
                        InserirSerie();
                        break;
                     case "3":
                        AtualizarSerie();
                        break;
                     case "4":
                        ExcluirSerie();
                     case "5":
                        VisualizarSerie();
                        break;
                     case "C":
                        Console.Clear();
                        break;
                     default:
                        throw new ArgumentOutOfRangeException();
                 }

                 opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos sesrviços!");
            Console.WriteLine();

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
