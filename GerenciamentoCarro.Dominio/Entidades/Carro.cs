using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Dominio.Entidades
{
   public class Carro
   {
        public int Id { get; set; }
        public  string Nome { get; set; }
        public int KmPorLitro{ get; set; }
        public int Cilindros { get; set; }
        public int Pontencia { get; set; }
        public int Peso { get; set; }
        public int Aceleracao { get; set; }
        public string Origem { get; set; }
        public int MarcaId { get; set; }
   }
}
