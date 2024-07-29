using HexaArchDemo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaArchDemo.Domain.IRepository
{
    public interface IPersonaRepository
    {
        public List<DepartamentoModel> GetPersonaDepartamentoPar();
    }
}
