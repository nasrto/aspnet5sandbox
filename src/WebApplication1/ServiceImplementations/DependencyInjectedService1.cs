using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ServiceInterface;

namespace WebApplication1.ServiceImplementations
{
    public class DependencyInjectedService1 : IDependenceyInjectedService
    {
        public string[] GetValues()
        {
            return new string[] { "1", "2", "3" };
        }
    }
}
