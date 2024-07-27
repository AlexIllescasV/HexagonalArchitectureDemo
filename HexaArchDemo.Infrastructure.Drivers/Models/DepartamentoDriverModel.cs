using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaArchDemo.Infrastructure.Drivers.Models
{
    public class DepartamentoDriverModel
    {
        public string NameDepartamento { get; set; }
        public string NamePersona { get; set; }

        public DepartamentoDriverModel(string _nameDepartamento, string _namePersona) { 
            NameDepartamento = _nameDepartamento;
            NamePersona = _namePersona;
        }
    }
}
