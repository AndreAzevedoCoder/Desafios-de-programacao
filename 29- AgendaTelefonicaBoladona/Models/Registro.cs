using System;
namespace _29__AgendaTelefonicaBoladona.Models{
    class Registro
        {
            public string Nome {get;set;}
            public string Telefone {get;set;}
            public string Aniversario {get;set;}

            public Registro(string nome, string telefone, string aniversario){
                this.Nome = nome;
                this.Telefone = telefone;
                this.Aniversario = aniversario;
            }
        }
}
    