using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace QuantumWorldClassLibrary;

public class Villain
{
    public string VillainName { get; set; }
    public string VillainDescription { get; set; }
    public List<Ship> VillainShips { get; set; }
    public DateTime VillainTimeToAttack { get; set; }
    public List<Reward> VillainRewards { get; set; }

}
