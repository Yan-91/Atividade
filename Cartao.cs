using System;
namespace Aula08
{
    public class Cartao : Pagamento
    {
        protected string token = "aSDASD%''@M''JFJFJDSAKA";
        public string titular {get; set;}
        public string cvv {get ; set;}
        public string bandeira {get;set;}

        public bool ValidarToken(){
            if(token !=null){
                return true;
            }
            return false;
        }

    }
}