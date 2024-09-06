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
}
