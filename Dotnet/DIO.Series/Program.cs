﻿using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
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
                        ListarSeries();
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

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0} - {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da Série");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            
            repositorio Insere(novaSerie);
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
