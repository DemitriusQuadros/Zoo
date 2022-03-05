using System;
namespace Zoo.Models
{
    public abstract class Animal
    {
        public string Especie { get; set; }
        public string Identificador { get; set; }
        public string Nome { get; set; }
        public Local Local { get; set; }
        public Tratamento Tratamento { get; set; }

        public Animal(string especie, string nome, string identificador,
            Local local, Tratamento tratamento = null)
        {
            Especie = especie;
            Nome = nome;
            Identificador = identificador;
            Local = local;
            Tratamento = tratamento;
        }
    }
}
