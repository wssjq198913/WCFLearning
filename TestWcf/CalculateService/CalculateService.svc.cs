﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CalculateServiceContract;

namespace CalculateService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculateService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalculateService.svc or CalculateService.svc.cs at the Solution Explorer and start debugging.
    public class CalculateService : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
