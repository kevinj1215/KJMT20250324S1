﻿using System;
using System.Collections.Generic;

namespace KJMT20250324S14.AppWebMVC.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }
}
