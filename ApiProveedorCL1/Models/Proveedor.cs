using System;
using System.Collections.Generic;

namespace ApiProveedorCL1.Models
{
    public partial class Proveedor
    {
        public int ProveedorId { get; set; }
        public string? ProveeedorName { get; set; }
        public string? ProveedorLastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
