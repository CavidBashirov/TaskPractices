using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPractices.Exceptions
{
    internal class NotFoundExceptions:Exception
    {
        public NotFoundExceptions(string msj = "Data notfound"): base(msj)
        {
            
        }
    }
}
