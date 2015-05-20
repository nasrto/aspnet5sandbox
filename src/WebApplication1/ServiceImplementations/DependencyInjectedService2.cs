using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ServiceInterface;

namespace WebApplication1.ServiceImplementations
{
    public class DependencyInjectedService2 :  IDependenceyInjectedService
    {
        public string[] GetValues()
        {
            return new string[] { "4", "5", "6" };
        }
    }
}
