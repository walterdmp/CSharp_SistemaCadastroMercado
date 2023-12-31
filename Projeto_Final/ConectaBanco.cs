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
        MySqlConnection conexao = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10665666;password=Rr8mmRiJVl;database=sql10665666");
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
                cmd.ExecuteNonQuery();//executar inserção de novo pedido
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }

        public DataTable listaCategorias()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaCategorias", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }
        public DataTable listaProdutos()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaProdutos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }
        public bool deletaProduto(int idRemoveProduto)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idprodut", idRemoveProduto);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool insereCategoria(string categoria, Sistema sistema)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereCategoria", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("categoria", categoria);
                cmd.ExecuteNonQuery();//executar no banco

                sistema.listaCBCategorias();

                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }

        public bool alteraProduto(Produto p, int idproduto)
        {
            MySqlCommand cmd = new MySqlCommand("sp_alteraProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idprodut", idproduto);
            cmd.Parameters.AddWithValue("nome", p.Nome);
            cmd.Parameters.AddWithValue("fk_categoria", p.Categoria);
            cmd.Parameters.AddWithValue("quantidade", p.Quantidade);
            cmd.Parameters.AddWithValue("preco", p.Preco);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool deletaCategoria(int idRemoveCategoria)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeCategoria", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idcateg", idRemoveCategoria);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
