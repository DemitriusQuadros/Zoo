﻿using System;
namespace Zoo.Models
{
    public class Peixe : Animal
    {
        public Peixe(string especie, string nome, string identificador, Local local, Tratamento tratamento = null) : base(especie, nome, identificador, local, tratamento)
        {
        }
    }
}
