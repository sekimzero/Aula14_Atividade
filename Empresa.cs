namespace Aula13_Atividade
{
    public class Empresa : Administracao
    {
        Dictionary<int, Funcionario> empregado = new Dictionary<int, Funcionario>();

        public override void Cadastrar(int v1, string? v2, string? v3, int v4)
        {
            Funcionario funcionario = new Funcionario();   
            var registrar = empregado.TryAdd(empregado.Count, funcionario);
        }

        public override void Remover(int removerChave)
        {
            var remover = empregado.Remove(removerChave);
        }

        public void Atualizar()
        {
                 
        }

        public void ApresentarTodos()
        {

            foreach (Funcionario funcionario in empregado.Values)
            {
                Console.WriteLine($" ** {funcionario.Nome}\n** {funcionario.Sobrenome}\n** {funcionario.Telefone}\n** {funcionario.Salario}\n** {funcionario.CPF}");
            }

            


        }
    }
}
