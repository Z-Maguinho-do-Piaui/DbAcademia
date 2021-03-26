namespace ProjetoAcademiaV0._1.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
          
        }

        public Cliente(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public int ID { get; private set; }
        public string Nome { get; private set; }
        public string Senha { get; private set; }
    }
}
