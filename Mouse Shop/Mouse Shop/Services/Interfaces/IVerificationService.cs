﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouse_Shop.Services.Interfaces
{
    internal interface IVerificationService
    {
        public bool IsMatch(string mail, string code);
    }
}
