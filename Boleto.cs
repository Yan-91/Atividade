using System;

namespace Aula08
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento {get;set;}
        public string bancoEmissor {get;set;}
        public string codDeBarras {get; set;}
    }
}