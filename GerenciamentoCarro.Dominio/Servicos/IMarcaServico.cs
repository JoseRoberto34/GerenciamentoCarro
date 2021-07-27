using GerenciamentoCarro.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoCarro.Dominio.Servicos
{
    public interface IMarcaServico
    {
        public void Incluir(Marca marca);
        public List<Marca> Lista(Marca marca);
        public int BuscarPorId(int id);
        public int Altera(Marca marca);
        public int Deleta(int id);
    }
}
