using System;

namespace Zoologico.Models{
    class Jaula
        {
            public string TipoJaula {get;set;}
            public int QuantidadeMaxJaula {get;set;}
            public int QuantidadeAtualJaula {get;set;}

            public Jaula(string tipoJaula, int quantidadeMaxJaula,int quantidadeAtualJaula){
                this.TipoJaula = tipoJaula;
                this.QuantidadeAtualJaula = quantidadeAtualJaula;
                this.QuantidadeMaxJaula = quantidadeMaxJaula;
            }
        }
}
