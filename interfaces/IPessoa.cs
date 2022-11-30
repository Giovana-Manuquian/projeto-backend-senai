using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SENAI.interfaces
{
    public interface IPessoa
    {
        float CalcularImposto(float rendimentos);
    }
}