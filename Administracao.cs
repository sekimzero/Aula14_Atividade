namespace Aula13_Atividade
{
   public abstract class  Administracao
    {
      

        Empresa empresa = new Empresa();
        Curso curso = new Curso();
        public abstract void Cadastrar(int v1, string? v2, string? v3, int v4);

        public abstract void Remover(int remov);


        public virtual void Atualizar()
        {
         
        }
        public virtual void ApresentarTodos()
        {
            curso.ApresentarTodos();
            empresa.ApresentarTodos();
        
        }

 
    }
}
