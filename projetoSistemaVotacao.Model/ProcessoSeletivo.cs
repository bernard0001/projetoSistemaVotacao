using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class ProcessoSeletivoModelo
    {
       int Status { get; set; }//controle do processo seletivo estar aberto ainda para votação ou não 

       string Descricao { get; set; }
    }

    public ProcessoSeletivoModelo(int status, string descricao)
    {
        Status = status;
        Descricao = descricao;
    }
}