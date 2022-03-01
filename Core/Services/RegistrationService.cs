using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Contracts;
using Core.DTOs;
using Models;

namespace Core.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IVoterRepository _voterRepo;

        public RegistrationService(IVoterRepository voterRepository)
        {
            _voterRepo = voterRepository;
        }

        public Voter RegisterNewVoter(VoterRegDTO model)
        {
            Voter newVoter = new Voter() 
            { 
                DateOfBirth = model.DateOfBirth,
                FirstName   = model.FirstName,
                MiddleName  = model.MiddleName,
                LastName = model.LastName,
                PollingUnit = new PollingUnit("ABS")
            };

            try
            {
                return _voterRepo.Add(newVoter);
            }
            catch (Exception)
            {

                
            }

            return null;
        }
    }
}
