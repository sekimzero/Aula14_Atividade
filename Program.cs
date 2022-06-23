namespace Aula13_Atividade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            

            Administracao adm = null;

            adm.Cadastrar();





            



            //Aluno aluno = new Aluno();
            //Console.WriteLine("Digite o nome do aluno");
            //aluno.Atualizar(int.Parse(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), int[] Console.ReadLine());
            //Console.WriteLine("Digite ");


            //Console.WriteLine("Escreva as 4 notas:");
            //aluno.RegistrarNota(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            
        }
    }
}





// public void EscolhaOpcao()
//{
//    string opcao = "";
//    do
//    {
//        Console.WriteLine(" *** Escolha uma opção ***");
//        Console.WriteLine("1 - Adicionar aluno:");
//        Console.WriteLine("2 - Remover aluno:");
//        Console.WriteLine("3 - Atualizar aluno:");
//        Console.WriteLine("4 - Apresentar todos alunos:");
//        Console.WriteLine("5 - Adicionar funcionario:");
//        Console.WriteLine("6 - Remover funcionario:");
//        Console.WriteLine("7 - Atualizar funcionario:");
//        Console.WriteLine("8 - Apresentar todos funcionario:");
//        Console.WriteLine("9 - Apresentar todos cadastrados:");
//        Console.WriteLine("10 - Sair da lista:");
//        opcao = Console.ReadLine();
//        Console.WriteLine("\n");

//        Administracao adm = null;

//        switch (opcao)
//        {
//            case "1":
//                adm = new Administracao();
//                break;
//            case "2":
//                adm = new RemoverAluno();
//                break;
//            case "3":
//                adm = new AtualizarAluno();
//                break;
//            case "4":
//                adm = new ApresentarAluno();
//                break;
//            case "5":
//                adm = new AdicionarFuncionario();
//                break;
//            case "6":
//                adm = new RemoverFuncionario();
//                break;
//            case "7":
//                adm = new AtualizarFuncionario();
//                break;
//            case "8":
//                adm = new ApresentarFuncionario();
//                break;
//            case "9":
//                adm = new ApresentarTodos();
//                break;
//            default:
//                Console.WriteLine("*** Lista encerrada ***");
//                Console.WriteLine("\n");
//                break;
//        }
//        if (adm != null)
//        {
//            adm.Operacao();
//            Console.WriteLine(adm.Imprimir());
//        }
//    }
//    while (opcao != "10");
//}