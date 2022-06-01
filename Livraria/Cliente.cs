using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Livraria
{
    class Cliente
    {
        public MySqlConnection conexao;
        private int codigo;
        private string nome;
        private DateTime dataDeNascimento;
        private string telefone;
        private string usuario;
        private string senha;
        private string endereco;
        private string dados;
        private string comando;
        private string resultado;

        public Cliente()
        {

            AcessarCodigo = 0;
            AcessarNome = "";
            AcessarTelefone = "";
            AcessarUsuario = "";
            AcessarSenha = "";
            dataDeNascimento = new DateTime();
            //Script para conexão do banco de dados
            conexao = new MySqlConnection("server=localhost;Database=LivrariaTI14T;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                conexao.Open();//tentando conectar ao banco de dados
                Console.WriteLine("Conectado com sucesso.");
                Console.ReadLine(); //manter o prompt aberto
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado.\n\n" + e);//mostrar o erro em tela
                conexao.Close();//Fechar a conexão com o banco de dados
            }
        }// fim método cliente


        //Método para inserir dados no banco de dados
        public void Inserir(string nome, DateTime dataDeNascimento, string telefone, string usuario, string senha)
        {
            try
            {
                dados = "('','" + nome + "', '" + dataDeNascimento + "', '" + telefone + "', '" + usuario + "', '" + senha + "')";
                comando = "insert into pessoa(codigoCliente, nome, dataDeNascimento, telefone, usuario, senha) values" + dados;
                //Executar o comando de inserção no banco de dados
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                resultado = "" + sql.ExecuteNonQuery();//Executa o insert no BD
                Console.WriteLine(resultado + "Linhas afetadas");
            }
            catch(Exception e)
            {
                Console.WriteLine("Algo de errado.\n\n" + e);
                Console.ReadLine();//Manter o programa aberto
            }
        }//fim do método inserir
        public int AcessarCodigo
        {
            get
            {

                return codigo;

            }

            set
            {

                this.codigo = value;

            }
        }// fim método AcessarCodigo

        public DateTime AcessarData
        {
            get
            {

                return dataDeNascimento;

            }

            set
            {

                this.dataDeNascimento = value;

            }


        }// Fim método AcessarData

        public string AcessarNome

        {
            get

            {

                return nome;

            }

            set

            {

                this.nome = value;

            }

        }// fim método AcessarNome

        public string AcessarTelefone

        {

            get

            {

                return telefone;

            }

            set

            {

                this.telefone = value;

            }

        }// fim método AcessarTelefone

        public string AcessarUsuario
        {
            get

            {

                return usuario;

            }

            set

            {

                this.usuario = value;

            }

        }// fim método AcessarUsuario

        public string AcessarSenha
        {

            get

            {

                return senha;

            }

            set
            {

                this.senha = value;

            }
        }// fim método AcessarSenha

        public string AcessarEndereco
        {

            get
            {

                return endereco;

            }

            set

            {

                this.endereco = value;

            }

        }// fim método AcessarEndereco

        public void Cadastrar(int codigo, string nome, DateTime data, string telefone, string endereco, string usuario, string senha)
        {

            AcessarCodigo = codigo;
            AcessarNome = nome;
            AcessarData = data;
            AcessarTelefone = telefone;
            AcessarUsuario = usuario;
            AcessarSenha = senha;
            AcessarEndereco = endereco;

        }// fim do método Cadastrar

        public string Consultar(int codigo)
        {

            if (AcessarCodigo == codigo)

            {

                return "Código: " + AcessarCodigo +
                      "\nNome: " + AcessarNome +
                      "\nData de Nascimento: " + AcessarData +
                      "\nTelefone: " + AcessarTelefone +
                      "\nEndereço: " + AcessarEndereco +
                      "\nUsuário: " + AcessarUsuario +
                      "\nSenha: " + AcessarSenha;

            }
            else
            {

                return "Código inválido";

            }

        }// fim método Consultar

        public string Login(string usuario, string senha)
        {
            if (AcessarUsuario == usuario & AcessarSenha == senha)

            {

                return "Logado com sucesso";

            }

            else
            {

                return "Usuário e senha inválidos";

            }

        }// fim método Login
    }// fim class
}// fim projeto
