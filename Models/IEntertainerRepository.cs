﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_rtj34.Models
{
    public interface IEntertainerRepository
    {
            IQueryable<Entertainer> Entertainers { get; }
      
    }
}
