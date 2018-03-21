using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrnoMVC1.Business.Services
{
    public class EmptyEmailService : IEmailService
    {
        public void Send(string message)
        {
            Debug.WriteLine("NIC SE NEPOSILA");
        }
    }
}
