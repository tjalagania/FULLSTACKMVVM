﻿using SimpleTrader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Services
{
    public  interface IMajorIndexService
    {
        Task<Statement> GetStatement(StatementType statementtype);
    }
}
