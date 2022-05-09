using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace QuantumWorldClassLibrary;

public class Building
{
    public string BuildingName { get; set; }
    public string BuildingDescription { get; set; }
    public int BuildingLevel { get; set; }
    public DateTime BuildingTimeToUpgrade { get; set; }
    public int BuildingResourceMultiplier { get; set; }

}
