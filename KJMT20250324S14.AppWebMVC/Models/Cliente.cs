using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KJMT20250324S14.AppWebMVC.Models;

public partial class Cliente
{
    [Display(Name = "Id")]
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
    public string Nombre { get; set; } = null!;
    [Display(Name = "Direcciòn")]
    public string? Direccion { get; set; }
    [Display(Name = "Telèfono")]
    public string? Telefono { get; set; }
    [Display(Name = "Email")]
    public string? Email { get; set; }
}
