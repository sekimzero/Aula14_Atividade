namespace Aula13_Atividade
{
    public class Curso : Administracao
    {

        Dictionary<int, Aluno> inscrito = new Dictionary<int, Aluno>();
        public override void Cadastrar(int v1, string? v2, string? v3, int v4)
        {
            Aluno aluno = new Aluno();

            aluno.Matricula = inscrito.Count;

            var registrar = inscrito.TryAdd(inscrito.Count, aluno);

        }

        public override void Remover(int removerChave)
        {

            var remover = inscrito.Remove(removerChave);
        }


        public virtual void Atualizar()
        {

        }

        public virtual void ApresentarTodos()
        {
            foreach (Aluno aluno in inscrito.Values)
            {
                Console.WriteLine($"** {aluno.Matricula}\n** {aluno.Nome}\n** {aluno.Sobrenome}\n** {aluno.Telefone}\n** {aluno.Notas}");
            }
        }
    }

}
