using System;
using System.Collections.Generic;
using _29__AgendaTelefonicaBoladona.Models;


namespace _29__AgendaTelefonicaBoladona
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Registro> ListaDeClientes = new List<Registro>();

            string opcao = "n";
            do{
                System.Console.WriteLine("Digite 1 para adicionar mais um contato");
                System.Console.WriteLine("Digite 2 para remover um contato");
                System.Console.WriteLine("Digite 3 para busacar um contato pelo nome");
                System.Console.WriteLine("Digite 4 para mostrar todos os contatos: ");
                System.Console.WriteLine("Digite n para sair");
                System.Console.WriteLine();
                opcao = Console.ReadLine();
                switch(opcao){
                    case "1":
                        System.Console.WriteLine();
                        Console.WriteLine("Digite o nome do usuario");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o telefone do usuario");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Digite o aniversario do usuario");
                        string aniversario = Console.ReadLine();

                        Registro cliente = new Registro(nome,telefone,aniversario);
                        ListaDeClientes.Add(cliente);
                        System.Console.WriteLine();
                        break;
                    

                    case "2":
                        System.Console.WriteLine();

                        System.Console.WriteLine("Digite o nome do usuario que você deseja remover: ");
                        string Remover = Console.ReadLine();
                        int escolhido = -5;
                        for(int i = 0; i < ListaDeClientes.Count; i++){
                            if(Remover == ListaDeClientes[i].Nome){
                                System.Console.WriteLine("Usuario removido");
                                escolhido = i;
                                ListaDeClientes.RemoveAt(i);
                            }
                        }
                        if(escolhido == -5){
                            System.Console.WriteLine("Não foi encontrado o usuario");
                        }
                        System.Console.WriteLine();
                        break;
                    case "3":
                        System.Console.WriteLine();
                        System.Console.WriteLine("Digite o nome do usuario que você deseja buscar: ");
                        string NomeDoBuscado = Console.ReadLine();
                        for(int i = 0; i < ListaDeClientes.Count; i++){
                            System.Console.WriteLine();
                            System.Console.WriteLine(ListaDeClientes[i].Nome);
                            System.Console.WriteLine();
                            if (NomeDoBuscado == ListaDeClientes[i].Nome){
                                
                                System.Console.WriteLine("Nome: "+ListaDeClientes[i].Nome);
                                System.Console.WriteLine("Aniversario: "+ListaDeClientes[i].Aniversario);
                                System.Console.WriteLine("Telefone: "+ListaDeClientes[i].Telefone);
                                System.Console.WriteLine("Achei o fudido");

                            }
                        }
                        System.Console.WriteLine();

                        break;
                    case "4":
                        System.Console.WriteLine();
                        for(int i = 0; i < ListaDeClientes.Count; i ++){
                            System.Console.WriteLine(ListaDeClientes[i].Nome);
                        }
                        System.Console.WriteLine();
                        break;

                }


                
                //opcao = Console.ReadLine();

            }while(opcao != "n");

            
        }
    }
}
