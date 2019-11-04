using System;
using System.Collections.Generic;
using Zoologico.Models;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jaula> Jaulas = new List<Jaula>();
            Jaulas.Add(CriarJaula("Pasto", 3,0));
            Jaulas.Add(CriarJaula("Gaiola", 3,0));
            Jaulas.Add(CriarJaula("Casa em árvore", 3,0));
            Jaulas.Add(CriarJaula("Caverna de pedra", 3,0));
            Jaulas.Add(CriarJaula("Aquário Gelado", 3,0));
            Jaulas.Add(CriarJaula("Piscina", 3,0));
            Jaulas.Add(CriarJaula("Aquário", 3,0));
            System.Console.WriteLine();
            ColocarNaJaula("Tubarão Martelo", ref Jaulas);
            ColocarNaJaula("Tucano", ref Jaulas);
            ColocarNaJaula("Arara", ref Jaulas);
            ColocarNaJaula("Leão", ref Jaulas);
            ColocarNaJaula("Orangotango", ref Jaulas);
            ColocarNaJaula("Chimpanzé", ref Jaulas);
            ColocarNaJaula("Pinguim", ref Jaulas);
            ColocarNaJaula("Tartaruga", ref Jaulas);
            ColocarNaJaula("Golfinho", ref Jaulas);

            System.Console.WriteLine();
            
        }
        static public Jaula CriarJaula(string nome, int qntmax, int qntmin){
            Jaula jaula = new Jaula(nome, qntmax, qntmin);
            return jaula;
        }
        static public void ColocarNaJaula(string NomeAnimal, ref List<Jaula> jaulas){

            if(NomeAnimal == "Tubarão Martelo"){
                for(int i = 0; i < jaulas.Count; i++){
                    if(jaulas[i].TipoJaula == "Aquário"){
                        if(jaulas[i].QuantidadeAtualJaula < jaulas[i].QuantidadeMaxJaula){
                            jaulas[i].QuantidadeAtualJaula++;
                            System.Console.WriteLine();
                            System.Console.WriteLine(NomeAnimal+" Foi colocado no tipo de jaula: "+jaulas[i].TipoJaula+" || Lotação das Jaulas: "+jaulas[i].QuantidadeAtualJaula+"/"+jaulas[i].QuantidadeMaxJaula);
                            
                        }else{
                            System.Console.WriteLine();
                            System.Console.WriteLine("O animal: "+NomeAnimal+" Não pode ser colocado na: "+jaulas[i].TipoJaula+" pois estas estão lotadas" );
                            
                        }
                    }
                }
            }
            if(NomeAnimal == "Pinguim"){
                for(int i = 0; i < jaulas.Count; i++){
                    if(jaulas[i].TipoJaula == "Aquário Gelado"){
                        if(jaulas[i].QuantidadeAtualJaula < jaulas[i].QuantidadeMaxJaula){
                            jaulas[i].QuantidadeAtualJaula++;
                            System.Console.WriteLine();
                            System.Console.WriteLine(NomeAnimal+" Foi colocado no tipo de jaula: "+jaulas[i].TipoJaula+" || Lotação das Jaulas: "+jaulas[i].QuantidadeAtualJaula+"/"+jaulas[i].QuantidadeMaxJaula);
                            
                        }else{
                            System.Console.WriteLine();
                            System.Console.WriteLine("O animal: "+NomeAnimal+" Não pode ser colocado na: "+jaulas[i].TipoJaula+" pois estas estão lotadas" );
                            
                        }
                    }
                }
            }
            if(NomeAnimal == "Tartaruga" || NomeAnimal == "Golfinho"){
                for(int i = 0; i < jaulas.Count; i++){
                    if(jaulas[i].TipoJaula == "Aquário"){
                        if(jaulas[i].QuantidadeAtualJaula < jaulas[i].QuantidadeMaxJaula){
                            jaulas[i].QuantidadeAtualJaula++;
                            System.Console.WriteLine();
                            System.Console.WriteLine(NomeAnimal+" Foi colocado no tipo de jaula: "+jaulas[i].TipoJaula+" || Lotação das Jaulas: "+jaulas[i].QuantidadeAtualJaula+"/"+jaulas[i].QuantidadeMaxJaula);
                            
                        }else{
                            System.Console.WriteLine();
                            System.Console.WriteLine("O animal: "+NomeAnimal+" Não pode ser colocado na: "+jaulas[i].TipoJaula+" pois estas estão lotadas" );
                            
                        }
                    }
                }
            }
            if(NomeAnimal == "Tucano" || NomeAnimal == "Arara"){
                for(int i = 0; i < jaulas.Count; i++){
                    if(jaulas[i].TipoJaula == "Casa em árvore"){
                        if(jaulas[i].QuantidadeAtualJaula < jaulas[i].QuantidadeMaxJaula){
                            jaulas[i].QuantidadeAtualJaula++;
                            System.Console.WriteLine();
                            System.Console.WriteLine(NomeAnimal+" Foi colocado no tipo de jaula: "+jaulas[i].TipoJaula+" || Lotação das Jaulas: "+jaulas[i].QuantidadeAtualJaula+"/"+jaulas[i].QuantidadeMaxJaula);
                            
                        }else{
                            System.Console.WriteLine();
                            System.Console.WriteLine("O animal: "+NomeAnimal+" Não pode ser colocado na: "+jaulas[i].TipoJaula+" pois estas estão lotadas" );
                            
                        }
                    }
                }
            }
            if(NomeAnimal == "Leão" || NomeAnimal == "Orangotango" || NomeAnimal == "Chimpanzé"){
                for(int i = 0; i < jaulas.Count; i++){
                    if(jaulas[i].TipoJaula == "Gaiola"){
                        if(jaulas[i].QuantidadeAtualJaula < jaulas[i].QuantidadeMaxJaula){
                            jaulas[i].QuantidadeAtualJaula++;
                            System.Console.WriteLine();
                            System.Console.WriteLine(NomeAnimal+" Foi colocado no tipo de jaula: "+jaulas[i].TipoJaula+" || Lotação das Jaulas: "+jaulas[i].QuantidadeAtualJaula+"/"+jaulas[i].QuantidadeMaxJaula);
                            
                        }else{
                            System.Console.WriteLine();
                            System.Console.WriteLine("O animal: "+NomeAnimal+" Não pode ser colocado na: "+jaulas[i].TipoJaula+" pois estas estão lotadas" );
                            
                        }
                    }
                }
            }
        }
    }
}
