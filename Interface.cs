using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13_Atividade
{
    internal class Interface
    {
        public void Inicio()
        {
            EscolhaOpcao();
        }
        public void EscolhaOpcao()
        {
            string opcao = "";
            do
            {
                Console.WriteLine(" *** Escolha uma opção ***");
                Console.WriteLine("1 - Adicionar aluno:");
                Console.WriteLine("2 - Remover aluno:");
                Console.WriteLine("3 - Atualizar aluno:");
                Console.WriteLine("4 - Apresentar todos alunos:");
                Console.WriteLine("5 - Adicionar funcionario:");
                Console.WriteLine("6 - Remover funcionario:");
                Console.WriteLine("7 - Atualizar funcionario:");
                Console.WriteLine("8 - Apresentar todos funcionario:");
                Console.WriteLine("9 - Apresentar todos cadastrados:");
                Console.WriteLine("10 - Sair da lista:");
                opcao = Console.ReadLine();
                Console.WriteLine("\n");

                Administracao adm = null;

                switch (opcao)
                {
                    case "1":
                        adm = new Curso();   
                        Aluno aluno = new Aluno();
                        Console.WriteLine("Digite o nome do aluno");
                        adm.Cadastrar(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
                        
                        break;
                    case "2":
                        adm = new Curso();
                        Console.WriteLine("Digite a chave do aluno:");
                        adm.Remover(int.Parse(Console.ReadLine()));
                        
                        break;
                    case "3":
                        adm = new Curso();
                        adm.Atualizar();
                        break;
                    case "4":
                        adm = new Curso();
                        adm.ApresentarTodos();
                        break;
                    case "5":
                        adm = new Empresa();
                        Empresa emporegado = new Empresa();
                        Console.WriteLine("Digite o novo empregado:");
                        //adm.Cadastrar(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()));
                        break;
                    case "6":
                        adm = new Empresa();
                        Console.WriteLine("Digite a chave do empregado:");
                        adm.Remover(int.Parse(Console.ReadLine()));
                        break;
                    case "7":
                        adm = new Empresa();
                        adm.Atualizar();
                        break;
                    case "8":
                        adm = new Empresa();
                        adm.ApresentarTodos();
                        break;
                    case "9":
                        adm.ApresentarTodos();
                        break;
                    default:
                        Console.WriteLine("*** Lista encerrada ***");
                        Console.WriteLine("\n");
                        break;
                }
                if (adm != null)
                {
                   
                    Console.WriteLine("alguma coisa aqui");
                }
            }
            while (opcao != "10");
        }
    }
}
