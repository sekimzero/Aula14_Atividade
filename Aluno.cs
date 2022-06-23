namespace Aula13_Atividade
{
    public class Aluno
    {
        public int Matricula;
        public string Nome;
        public string Sobrenome;
        public string Telefone;
        public int Notas;

        public void Atualizar(int atualMatricula, string atualNome, string atualSobrnome, int atualNotas)
        {
            //this.Matricula = atualMatricula;
            //this.Nome = atualNome;
            //this.Sobrenome = atualSobrnome;
            //this.Notas = atualNotas;


        }

        public void RegistrarNota(int nota1, int nota2, int nota3, int nota4)
        {
            List<int> notaAluno = new List<int>();

            notaAluno.Add(nota1);
            notaAluno.Add(nota2);
            notaAluno.Add(nota3);
            notaAluno.Add(nota4);

            foreach (int n in notaAluno)
            {
                Console.WriteLine($"nota {n}");
            }


        }







        //Dictionary<int, int> Notas = new Dictionary<int, int>();

        //Notas.Add(0, 9);
        //Notas.Add(1, 6);
        //Notas.Add(2, 5);
        //Notas.Add(3, 4);

        //int count;


        //for (count = 0; count <= 4; count++)
        //{
        //    Console.WriteLine($"Digite a nota do bimestre {count + 1} do aluno: ");
        //    int[count] Notas = int.Parse(Console.ReadLine());

        //    while (!(Notas[count] >= 0 && Notas[count] <= 10))
        //    {
        //        Console.WriteLine("A nota inserida foi inválida, por favor, insira novamente!");
        //        int[count] Notas = int.Parse(Console.ReadLine());
        //    }
        //}





    //    public void ApresentarNotas()
    //    {
    //        Program.
    
    //foreach (int n in Aluno notaAluno)
    //{
    //            Console.WriteLine($"nota {n}");
    //        }


            //Console.WriteLine($"1 bimestre / nota {Notas[0]}");
            //Console.WriteLine($"2 bimestre / nota {Notas[1]}");
            //Console.WriteLine($"3 bimestre / nota {Notas[2]}");
            //Console.WriteLine($"4 bimestre / nota {Notas[3]}");

            //  1 bimestre / nota 10
            //    2 bimestre / nota 5
            //    3 bimestre / nota 7
            //    4 bimestre / nota 6

        }

        //public void MediaDasNotas()
        //{
        //    //double mediaDoAluno;
        //    //mediaDoAluno = (Notas[0] + Notas[1] + Notas[2] + Notas[3]) / 4;
        //    //Console.WriteLine($"Média das notas: {mediaDoAluno}");
        //}

        //public void Estagio()
        //{
            //double const mediaParaAprovar = 7;
            //double const mediaMaxima = 10;
            //double const mediaMinima = 0;
            //if (mediaDoAluno >= mediaParaAprovar && mediaDoAluno <= mediaMaxima)
            //{
            //    Console.WriteLine("Estágio do aluno - Aprovado");
            //}
            //else if (mediaDoAluno >= mediaMinima && mediaDoAluno < mediaParaAprovar)
            //{
            //    Console.WriteLine("Estágio do aluno - Reprovado");
            //}
            //else
            //{
            //    Console.WriteLine("Média inválida");
            //}
        }
    


