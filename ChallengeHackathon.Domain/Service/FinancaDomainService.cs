using ChallengeHackathon.Domain.Entities;
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

        public List<Cliente> GetData()
        {
            return _financaRepository.GetPessoaData();
        }

        public List<FluxoBancario> GetDataDespesa()
        {
            /*
            int[] array = new int[1134];
            for(int i = 0; i < 1134; i++)
            {
                array[i] = (i % 10) + 1;
            }

            foreach (int i in array)
            {
                FluxoBancario fluxobancario = new FluxoBancario();
                fluxobancario.ClienteId = i;
                fluxobancario.Add(fluxobancario);
            }
             */

            return _financaRepository.GetDespesa();
        }
    }
}
