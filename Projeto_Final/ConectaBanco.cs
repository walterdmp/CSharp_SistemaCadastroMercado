﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_Final
{
    class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=banco_siscadastro_mercado");
        public string mensagem;

        public bool insereProduto(Produto novoProduto)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereProduto", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nome", novoProduto.Nome);
                cmd.Parameters.AddWithValue("quantidade", novoProduto.Quantidade);
                cmd.Parameters.AddWithValue("preco", novoProduto.Preco);
                cmd.Parameters.AddWithValue("fk_categoria", novoProduto.Categoria);
                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }
    }
}