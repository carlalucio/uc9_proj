using uc9_prj.interfaces;
using System.Text.RegularExpressions;

namespace uc9_prj.classes{
    public class PessoaJuridica : Pessoa, IPessoaJuridica {
        public string ?cnpj { get;  set; }
        public string ?razaoSocial { get;  set; } 

        public override float PagarImposto(float rendimento){
            throw new NotImplementedException();
        }
        
        // modelo de CNPJ: XX.XXX.XXX/0001-XX ou XXXXXXXXXXXXXX
        // posição do caracter em decimais dentro da string = \d{} "
        // Início da cadeia de caracteres = ^
        // Final da cadeia de caracteres = $
        public bool ValidarCnpj(string cnpj){
            if((cnpj.Length ==18) || (cnpj.Length == 14)) {

                if(Regex.IsMatch(cnpj,@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)")){

                    if(cnpj.Length == 18){
                        //o Substring vai iniciar no caracter 11 caracteres e pegar os próximos 4
                        if(cnpj.Substring(11,4) == "0001")
                        return true;
                    
                    } else if (cnpj.Length == 14){
                        if(cnpj.Substring(8,4)=="0001")
                        return true;
                    }
                }                
                return false;                 
            }                         
            
            return false;
        }

    }           
           
}
