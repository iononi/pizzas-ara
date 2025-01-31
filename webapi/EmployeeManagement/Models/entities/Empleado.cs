﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EmployeeManagement.Models.entities;

public partial class Empleado
{
    public int Idempleado { get; set; }

    public string? Name { get; set; }

    public string? Lastname { get; set; }

    public string? Celular { get; set; }

    public string? Username { get; set; }

    public string? Pass { get; set; }

    [JsonIgnore]
    public int? Idcargo { get; set; }

    [JsonIgnore]
    public virtual Cargo? IdcargoNavigation { get; set; }

    
    public virtual ICollection<Sucursalempleado> Sucursalempleados { get; } = new List<Sucursalempleado>();
}
