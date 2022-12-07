using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_SENAI.interfaces;

namespace Backend_SENAI.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * 0.03f; // 3%
            }
            else if (rendimento > 3000 && rendimento <= 6000)
            {
                return rendimento * 0.05f; // 5%
            }
            else if (rendimento > 6000 && rendimento <= 10000)
            {
                return rendimento * 0.07f; // 7%
            }
            else
            {
                return rendimento * 0.09f; // 9%
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}
