using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_SENAI.interfaces;

namespace Backend_SENAI.classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }
        // ? = string pode iniciar sem nenhum valor

        public float rendimento { get; set; }

        public string? endereco { get; set; }

        public abstract float CalcularImposto(float rendimento);
    }
}