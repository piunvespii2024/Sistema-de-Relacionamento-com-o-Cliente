using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Relacionamento_com_o_Cliente
{
    public class Paciente
    {
        private int codigo;
        private string nome;
        private string profissao;
       // private DateTime nascimento;
       /* private string telefone;
        private Decimal limite;
        private Boolean ativo; */

        public Paciente()
        {
            this.codigo = 0;
            this.nome ="";
            //this.endereco ="";
            this.Profissao ="" ;
          /*  this.telefone="";
            this.limite = 0;
            this.ativo = false; */

        }
        public int Codigo 
        {
            get { return codigo;       }
            set { this.codigo = value; }
        }
        public string Nome 
        {
            get { return nome; }
            set { this.nome = value; }
        }

        /*public string Endereco 
        {
            get { return endereco; }
            set { this.endereco = value; }
        }*/
        public string Profissao
        {
            get { return Profissao; }
            set { this.Profissao = value; }
        }
      /*  public string Telefone
        {
            get { return telefone; }
            set { this.telefone = value; }
        }
        public Decimal LimiteCredito
        {
            get { return limite; }
            set { this.limite = value; }
        }
        public Boolean Status
        {
            get { return ativo; }
            set { this.ativo = value; }
        }*/

    }
}
