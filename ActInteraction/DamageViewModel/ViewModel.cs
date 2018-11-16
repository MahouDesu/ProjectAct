using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActInteraction.ViewModels
{
    public class ViewModel
    {
        public List<Damage> DamageChart { get; set; } = new List<Damage>();
        public int EncounterIdToDelete { get; set; }
    }
}
