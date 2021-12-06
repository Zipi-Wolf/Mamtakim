using MamtakNetApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamtakNetApp.Interfaces
{
    public interface ICandyService
    {
        Task AddCandy(Candy candy);
        Task EditCandy(Candy candy);
        Task DeleteCandye(int idCandy);
    }
}
