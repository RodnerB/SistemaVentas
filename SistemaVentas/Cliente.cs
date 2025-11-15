using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    internal class Cliente
    {
        public required string CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public required string ApellidoCliente { get; set; }
        public required string DireccionCliente { get; set; }
        public required string SectorCliente { get; set; }
        public required string CiudadCliente { get; set; }
        public required string TelefonoCliente { get; set; }
        public string FaxCliente { get; set; } = string.Empty;
        public decimal LimiteCreditoCliente { get; set; } = 0;
        public decimal BalanceActualCliente { get; set; } = 0;
        public required string ObservacionesCliente { get; set; }

    }
}
