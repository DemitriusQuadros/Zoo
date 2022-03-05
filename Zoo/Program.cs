using System;
using System.Collections.Generic;
using Zoo.Models;
using Zoo.Sistema;

namespace Zoo
{
    class MainClass
    {
        public static List<Animal> animais = new List<Animal>(); 

        public static void Main(string[] args)
        {
            var opcao = "";
            while (opcao != "7")
            {
                opcao = Menu();
                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        CadastrarAnimal.Cadastrar(animais);
                        break;
                    case "2":
                        ListarAnimais();
                        break;
                    case "3":
                        AlterarAnimal.Alterar(animais);
                        break;
                    case "4":
                        ExcluirAnimal.Excluir(animais);
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    default:
                        break;
                }

            }

        }

        public static void ListarAnimais()
        {
            Console.Clear();
            foreach (var animal in animais)
            {
                Console.WriteLine($"Animal: { animal.GetType().Name } id: { animal.Identificador } especie: { animal.Especie } nome: { animal.Nome }");
            }
            Console.ReadKey();

        }

        public static string Menu()
        {
            Console.WriteLine("Bem vindo ao zoologico de blumenau");
            Console.WriteLine("1 - Cadastrar animal");
            Console.WriteLine("2 - Consultar animais");
            Console.WriteLine("3 - Alterar animal");
            Console.WriteLine("4 - Excluir animal");
            Console.WriteLine("5 - Iniciar tratamento");
            Console.WriteLine("6 - Remover tratamento");
            Console.WriteLine("7 - Sair");

            string opcao = Console.ReadLine();
            return opcao;
        }
    }
}
