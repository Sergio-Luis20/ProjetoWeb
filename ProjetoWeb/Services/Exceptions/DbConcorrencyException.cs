using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.Services.Exceptions
{
    public class DbConcorrencyException : ApplicationException
    {
        public DbConcorrencyException(string message) : base(message)
        {

        }
    }
}
