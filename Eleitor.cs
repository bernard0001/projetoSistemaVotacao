using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class EleitorModelo
    {
        int EleitorID { get; set; }

        string Nome { get; set; }
    }

    public EleitorModelo(int eleitorID, string nome)
    {
        EleitorID = eleitorID;
        Nome = nome;
    }
}