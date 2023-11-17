using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Produto
    {
        string nome;
        int quantidade;
        double preco;
        int categoria;

        public string Nome { get => nome; set => nome = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Categoria { get => categoria; set => categoria = value; }
    }
}
