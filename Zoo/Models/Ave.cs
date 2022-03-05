using System;
namespace Zoo.Models
{
    public class Ave : Animal
    {
        public Ave(string especie, string nome, string identificador, Local local, Tratamento tratamento = null) : base(especie, nome, identificador, local, tratamento)
        {
        }
    }
}
