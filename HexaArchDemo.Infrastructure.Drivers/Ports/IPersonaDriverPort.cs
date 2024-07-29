using HexaArchDemo.Infrastructure.Drivers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaArchDemo.Infrastructure.Drivers.Ports
{
    public interface IPersonaDriverPort
    {
        public Task<List<DepartamentoDriverModel>> GetPersonaDepartamentoPar();
    }
}
