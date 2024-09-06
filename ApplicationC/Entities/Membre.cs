using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Membre
{
    public int Idmembre { get; set; }

    public int? Idequipe { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Telephone { get; set; }

    public DateOnly? Datenaissance { get; set; }

    public string? Lienportfolio { get; set; }

    public virtual Equipe? IdequipeNavigation { get; set; }
}
