namespace Aula13_Atividade
{
    public class Empresa : Administracao
    {
        Dictionary<int, Funcionario> empregado = new Dictionary<int, Funcionario>();

        public override void Cadastrar()
        {
            Funcionario funcionario = new Funcionario();   
            
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
