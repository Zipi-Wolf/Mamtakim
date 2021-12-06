using MamtakNetApp.Entities;
using MamtakNetApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weather.Interfaces;

namespace MamtakNetApp.Services
{
    public class CandyService :ICandyService
    {
        protected readonly IAsyncRepository<Candy> _candyRepo;

        public CandyService(IAsyncRepository<Candy> candyRepo)
        {
            _candyRepo = candyRepo;
        }


        public Task AddCandy(Candy candy)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCandye(int idCandy)
        {
            throw new NotImplementedException();
        }

        public Task EditCandy(Candy candy)
        {
            throw new NotImplementedException();
        }
    }
}
