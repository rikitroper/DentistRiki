﻿using dentist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Services
{
    public interface ITurnServices
    {
        public List<turn> getAll();
    }
}
