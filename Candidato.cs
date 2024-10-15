using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class CandidatoModelo
    {
        int CandidatoID { get; set; }

        string Nome { get; set; }
    }

    public CandidatoModelo(int candidatoID, string nome)
    {
        CandidatoID = candidatoID;
        Nome = nome;
    }
}