using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IAmigoRepositorio
    {
        void AdicionarAmigo();

        void PesquisarAmigo(string termoDePesquisa);
    }
}
