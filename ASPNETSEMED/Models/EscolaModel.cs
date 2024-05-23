namespace TesteMVC.Models
{
    public class EscolaModel
    {
        public string? Id {get;set;}
        public string? Escola {get;set;}
        public string? Cnpj {get;set;}
        public string? Telefone {get;set;}
        public required string Diretor {get;set;}
        public string? Email {get;set;}

        public string? Ra {get;set;}

        public required string Bairro {get;set;}

        public float? Lat {get;set;}

        public float Lon{get;set;}

        public string? Status {get;set;}

        public string? Endereco {get;set;}


    }
}