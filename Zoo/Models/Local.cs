using System;
namespace Zoo.Models
{
    public class Local
    {
       public string Descricao { get; set; }

        public Local(string descricao)
        {
            Descricao = descricao;
        }
    }
}
