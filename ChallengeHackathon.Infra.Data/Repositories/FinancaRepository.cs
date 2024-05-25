using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeHackathon.Domain.Entities;
using ChallengeHackathon.Domain.Interfaces.Repositories;
using Dapper;

namespace ChallengeHackathon.Infra.Data.Repositories
{
    public class FinancaRepository : IFinancaRepository
    {
        private string _connectionString = "Data Source=hackathoncoti.database.windows.net;Initial Catalog=arcaclouddev-26cd5c5d06a3442be89b08db1f72fcf7;Persist Security Info=True;User ID=giom;Password=hackathon@2024;Encrypt=False";

        public List<Cliente> GetPessoaData()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = @"
                    SELECT CLIENTE_DATACADASTRO as DataCadastro, CLIENTE_COMERCIAL_FORMAPAGAMENTOID as FormaPagamento FROM GERAL.PESSOA
                ";

                return connection.Query<Cliente>(query).ToList();
            }
        }

        public List<FluxoBancario> GetDespesa()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
                SELECT VALOR, HISTORICO, SALDOANTERIOR, ENTRADA FROM FINANCEIRO.FLUXOBANCARIO WHERE DATAHORA BETWEEN '2024-01-01' AND '2024-03-30'
                ";

                return connection.Query<FluxoBancario>(query).ToList();
            }
        }
    }
}
