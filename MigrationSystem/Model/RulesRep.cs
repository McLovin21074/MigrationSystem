﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationSystem.Model
{
    internal static class RulesRep
    {
        public static List<IRule> GetRules()
        {
            return new List<IRule> { new CertificateRule() };
        }
    }
}
