﻿using ChallengeHackathon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeHackathon.Domain.Interfaces.Services
{
    public interface IFinancaDomainService
    {
        public List<Cliente> GetData();
        public List<FluxoBancario> GetDataDespesa();
    }
}
