﻿namespace Aula13_Atividade
{
   cclass Aluno
    {
        int Matricula;
        string Nome;
        string Sobrenome;
        string Telefone;
        int[] Notas;

        void Atualizar()
        {

        }

        void RegistrarNota()
        {
            int count;

            foreach (int i in Notas)
            {

            }

            for ( count = 0; count <= 4; count++)
            {
                Console.WriteLine($"Digite a nota do bimestre {count+1} do aluno: ");
                int[count] Notas = int.Parse(Console.ReadLine());

                while(!(Notas[count]>=0 && Notas[count]<=10)) {
                    Console.WriteLine("A nota inserida foi inválida, por favor, insira novamente!");
                    int[count] Notas = int.Parse(Console.ReadLine());
                }
            }

        }
        //public override string Operacao()
        //{
        //    Console.WriteLine("A sua lista é:");
        //    foreach (string i in Tarefas)
        //    {
        //        Console.WriteLine($"-{i}");

        //    }
        //    Console.WriteLine();
        //    return "";
        //}


        void ApresentarNotas()
        {
            Console.WriteLine($"1 bimestre / nota {Notas[0]}");
            Console.WriteLine($"2 bimestre / nota {Notas[1]}");
            Console.WriteLine($"3 bimestre / nota {Notas[2]}");
            Console.WriteLine($"4 bimestre / nota {Notas[3]}");

            /*  1 bimestre / nota 10
                2 bimestre / nota 5
                3 bimestre / nota 7
                4 bimestre / nota 6
            */
        }

        void MediaDasNotas()
        {
            double mediaDoAluno;
            media = (Notas[0]+Notas[1]+Notas[2]+Notas[3])/4;
            Console.WriteLine($"Média das notas: {mediaDoAluno}");
        }

        void Estagio()
        {
            double const mediaParaAprovar = 7;
            double const mediaMaxima = 10;
            double const mediaMinima = 0;
            if (mediaDoAluno >= mediaParaAprovar && mediaDoAluno <= mediaMaxima) {
                Console.WriteLine("Estágio do aluno - Aprovado");
            }   else if (mediaDoAluno>=mediaMinima && mediaDoAluno <mediaParaAprovar) {
                Console.WriteLine("Estágio do aluno - Reprovado");
            }   else {
                Console.WriteLine("Média inválida");
            }      
        }
    }
}