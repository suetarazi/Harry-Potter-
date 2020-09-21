using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotter.Models.Interfaces
{
    public interface ISortingHat
    {
        public Task<string> SortingHatOutcome();
    }
}
