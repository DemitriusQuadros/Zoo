using System;
using System.Collections.Generic;
using Zoo.Models;

namespace Zoo.Sistema
{
    public static class AlterarAnimal
    {
        public static void Alterar(List<Animal> animais)
        {
            ListarAnimais(animais);
            Console.WriteLine("Informe o identificador do animal que deseja alterar");
            var id = Console.ReadLine();

            var animal = EncontrarAnimal(id, animais);

            if (animal != null)
            {
                animais.Remove(animal);
                Console.WriteLine("Informe o novo nome");
                var nome = Console.ReadLine();
                Console.WriteLine("Informe o novo local");
                var local = Console.ReadLine();

                animal.Nome = nome;
                animal.Local.Descricao = local;

                animais.Add(animal);

                Console.WriteLine("Animal alterado com sucesso");
            }
            else
            {
                Console.WriteLine("Animal nao encontrado");
            }

            Console.ReadKey();


        }

        private static Animal EncontrarAnimal(string id, List<Animal> animais)
        {
            foreach (var animal in animais)
            {
                if (animal.Identificador == id)
                    return animal;
            }
            return null;
        }

        private static void ListarAnimais(List<Animal> animais)
        {
           foreach(var animal in animais)
            {
                Console.WriteLine($"id: { animal.Identificador } nome: { animal.Nome } especie: { animal.Especie }");
            }
        }
    }
}
