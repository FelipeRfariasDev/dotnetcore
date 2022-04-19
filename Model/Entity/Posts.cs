namespace dotnetcore.Model.Entity
{
    public class Posts
    {
        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }

        public override string? ToString()
        {
            var retorno = "Id: " + this.Id + ", Titulo é: " + this.Titulo + ", Descrição é: " + this.Descricao;
            return retorno;
        }
    }
}