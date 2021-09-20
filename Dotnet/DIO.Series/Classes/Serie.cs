namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido {get; set; }


        // Metodos

        public Serie(int Id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            //Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.enviroment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Genero: " + this.Genero + Enviroment.NewLine;
            retorno += "Titulo: " + this.Titulo + Enviroment.NewLine;
            retorno += "Descricao: " + this.Descricao + Enviroment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Enviroment.NewLine;
            retorno += "Excluido: " + this.Excluido

            return retorno;
            
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}