using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionAccount.Entities.Exeptions
{
    class DomainExeption : ApplicationException
    {
        public DomainExeption(string message) : base(message)
        {

        }
    }
}
