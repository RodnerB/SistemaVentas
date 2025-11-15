using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    class Cliente
    {
        public string CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string SectorCliente { get; set; }
        public string CiudadCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string FaxCliente { get; set; } = string.Empty;
        public decimal LimiteCreditoCliente { get; set; } = 0;
        public decimal BalanceActualCliente { get; set; } = 0;
        public string ObservacionesCliente { get; set; }

    }
}
