using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_rtj34.Models
{
    public class EFEntertainerRepository : IEntertainerRepository
    {
        private EntertainerContext context { get; set; }

        public EFEntertainerRepository(EntertainerContext bsc) => context = bsc;

        public IQueryable<Entertainer> Entertainers => context.Entertainers;
    }
}
