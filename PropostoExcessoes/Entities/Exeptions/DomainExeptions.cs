using System;
using System.Collections.Generic;
using System.Text;

namespace PropostoExcessoes.Entities.Exeptions
{
    class DomainExeptions : ApplicationException
    {
        public DomainExeptions(string message) : base(message)
        {
        }
    }
}
