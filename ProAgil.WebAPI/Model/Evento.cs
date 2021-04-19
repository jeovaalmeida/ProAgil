using System;

namespace ProAgil.WebAPI.Model
{
    public class Evento
    {
        public int Id { get; set; }
        public string Tema { get; set; }
        public string Local { get; set; }
        public string Lote { get; set; }
        public int QtdeDePessoas { get; set; }
        public DateTime Data { get; set; }
        public string ImagemUrl { get; set; }
    }
}