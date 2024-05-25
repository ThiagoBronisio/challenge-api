using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeHackathon.Domain.Interfaces.Repositories;
using Dapper;

namespace ChallengeHackathon.Infra.Data.Repositories
{
    public class FinancaRepository : IFinancaRepository
    {
        private string _connectionString = "Data Source=hackathoncoti.database.windows.net;Initial Catalog=giom;Persist Security Info=True;User ID=giom;Password=hackathon@2024;Encrypt=False";

        public void GetDespesa()
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                 connection.Execute(@"
                    SELECT VALOR, HISTORICO, SALDOANTERIOR, TRANSFERENCIA FROM FINANCEIRO.FLUXOBANCARIO 
                ");
            }
        }

        
    }
}
