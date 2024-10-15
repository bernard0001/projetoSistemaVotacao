using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class VotacaoModelo
    {
        int VotacaoID { get; set; }

        //necessário adicionar posteriormente o id do usuário para anexar a criação do processo seletivo a alguém
    }

    public VotacaoModelo(int votacaoID)
    {
        VotacaoID = votacaoID;
    }
}