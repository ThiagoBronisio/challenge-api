using ChallengeHackathon.Domain.Interfaces.Repositories;
using ChallengeHackathon.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeHackathon.Domain.Service
{
    public class FinancaDomainService : IFinancaDomainService
    {
        private readonly IFinancaRepository _financaRepository;

        public FinancaDomainService(IFinancaRepository financaRepository)
        {
            _financaRepository = financaRepository;
        }

        public void GetData()
        {
            _financaRepository.GetDespesa();
        }
    }
}
