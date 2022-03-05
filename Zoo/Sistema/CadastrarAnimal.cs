using System;
using System.Collections.Generic;
using Zoo.Models;

namespace Zoo.Sistema
{
    public static class CadastrarAnimal
    {
        public static void Cadastrar(List<Animal> animais)
        {
            Console.WriteLine("Informe a especie do animal");
            var especie = Console.ReadLine();

            Console.WriteLine("Informe o nome do animal");
            var nome = Console.ReadLine();

            var identificador = new Random().Next(99999).ToString();

            while (ExisteIdentificador(identificador, animais))
            {
                identificador = new Random().Next(99999).ToString();
            }

            Console.WriteLine("Informe a descricao do local");
            var descricaoLocal = Console.ReadLine();

            Animal animal = CriarAnimal(especie, identificador, descricaoLocal, nome);

            while (animal == null)
            {
                animal = CriarAnimal(especie, identificador, descricaoLocal, nome);
            }

            animais.Add(animal);

            Console.WriteLine("Animal cadastrado com sucesso");
            Console.ReadKey();
        }

        private static Animal CriarAnimal(string especie, string identificador, string descricaoLocal, string nome)
        {
            Console.WriteLine("Informe o tipo do animal");
            Console.WriteLine("1 - Peixe");
            Console.WriteLine("2 - Reptil");
            Console.WriteLine("3 - Mamifero");
            Console.WriteLine("4 - Ave");

            var tipo = Console.ReadLine();

            switch (tipo)
            {
                case "1":
                    return new Peixe(especie, nome, identificador, new Local(descricaoLocal));
                case "2":
                    return new Reptil(especie, nome, identificador, new Local(descricaoLocal));
                case "3":
                    return new Mamifero(especie, nome, identificador, new Local(descricaoLocal));
                case "4":
                    return new Ave(especie, nome, identificador, new Local(descricaoLocal));
                default:
                    Console.WriteLine("Opcao de tipo de animal Invalida");
                    break;
            }
            return null;
        }

        private static bool ExisteIdentificador(string identificador, List<Animal> animais)
        {
           foreach(Animal animal in animais)
           {
                if (animal.Identificador == identificador)
                    return true;
           }
           return false;
        }
    }
}
