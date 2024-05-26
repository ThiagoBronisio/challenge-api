using ChallengeHackathon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeHackathon.Domain.Interfaces.Repositories
{
    public interface IFinancaRepository
    {
        public List<DadosGeral> GetPessoaData();
        public List<FluxoBancario> GetDespesa();
        public List<Cliente> GetDataClientes();
    }
}
