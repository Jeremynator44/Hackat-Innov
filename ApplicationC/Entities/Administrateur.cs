using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Administrateur
{
    public int Idadministrateur { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string? Motpasse { get; set; }

    public string? Email { get; set; }

    public bool Enable2fa { get; set; }

    public string? Google2faSecret { get; set; }

    public string? Recuperation2fa { get; set; }

    public string? Codedesactivation2fa { get; set; }
}
