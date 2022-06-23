namespace Aula13_Atividade
{
   public abstract class  Administracao
    {
        public abstract void Cadastrar();

        public abstract void Remover(int remov);


        public virtual void Atualizar()
        {

        }
        public virtual void ApresentarTodos()
        {

        }
    }
}
