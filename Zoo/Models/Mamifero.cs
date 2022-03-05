using System;
namespace Zoo.Models
{
    public class Mamifero : Animal
    {
        public Mamifero(string especie, string nome, string identificador, Local local, Tratamento tratamento = null) : base(especie, nome, identificador, local, tratamento)
        {
        }
    }
}
