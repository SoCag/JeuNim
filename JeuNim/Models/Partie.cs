using System;
using System.Collections.Generic;

namespace JeuNim.Models;

public partial class Partie
{
    public int IdPartie { get; set; }

    public string Numero { get; set; } = null!;

    public int NbBaton { get; set; }

    public bool EstCommence { get; set; }

    public bool EstTermine { get; set; }

    public DateTime? DatePartie { get; set; }

    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();
}
