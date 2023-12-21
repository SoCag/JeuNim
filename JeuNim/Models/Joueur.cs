using System;
using System.Collections.Generic;

namespace JeuNim.Models;

public partial class Joueur
{
    public int IdJoueur { get; set; }

    public string Login { get; set; } = null!;

    public string MotDePasse { get; set; } = null!;

    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();
}
