﻿using System;
using System.Collections.Generic;

namespace pizzitas_web.Models.entities
{
    public partial class Sucursalempleado
    {
        public int? Idsucursal { get; set; }
        public int? Idempleado { get; set; }

        public virtual Empleado? IdempleadoNavigation { get; set; }
        public virtual Sucursal? IdsucursalNavigation { get; set; }
    }
}
