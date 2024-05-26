using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
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
                 SELECT 
                     VALOR AS MOVIMENTACAO,
                     HISTORICO AS TRANSACAO,
                     DATAHORA,
                     SALDOANTERIOR, 
                     ENTRADA,
                     CASE 
                         WHEN ENTRADA = 1 THEN SALDOANTERIOR + VALOR
                         WHEN ENTRADA = 0 THEN SALDOANTERIOR - VALOR
                     END AS NOVO_SALDO,

                 SUM(VALOR) 
                    OVER 
                        (ORDER BY DATAHORA ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS MOVIMENTACAO_GERAL,  

                 ROW_NUMBER() OVER (ORDER BY DATAHORA) AS CONTAGEM_MOVIMENTACAO

                 FROM 
                     FINANCEIRO.FLUXOBANCARIO 

                 WHERE 
                     DATAHORA BETWEEN '2024-01-01' AND '2024-03-30'
                ";

                return connection.Query<FluxoBancario>(query).ToList();
            }
        }
    }
}
