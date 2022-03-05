using System;
namespace Zoo.Models
{
    public class Reptil : Animal
    {
        public Reptil(string especie, string nome, string identificador, Local local, Tratamento tratamento = null) : base(especie, nome, identificador, local, tratamento)
        {
        }
    }
}
