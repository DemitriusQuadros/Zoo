using System;
using System.Collections.Generic;
using Zoo.Models;

namespace Zoo.Sistema
{
    public static class ExcluirAnimal
    {
        public static void Excluir(List<Animal> animais)
        {
            ListarAnimais(animais);

            Console.WriteLine("Informe o id do animal que deseja excluir");
            var id = Console.ReadLine();

            var animal = EncontrarAnimal(id, animais);
            if (animal != null)
            {
                animais.Remove(animal);

                Console.WriteLine("Animal alterado com sucesso");
         
            }
            else
            {
                Console.WriteLine("Identificador informado invalido");
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
            foreach (var animal in animais)
            {
                Console.WriteLine($"id: { animal.Identificador } nome: { animal.Nome } especie: { animal.Especie }");
            }
        }
    }
}
