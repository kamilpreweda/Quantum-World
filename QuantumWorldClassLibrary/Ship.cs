using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace QuantumWorldClassLibrary;

public class Ship
{
    public string ShipName { get; set; }
    public string ShipDescription { get; set; }
    public int ShipQuantity { get; set; }
    public int ShipCost { get; set; }
    public DateTime ShipTimeToUpgrade { get; set; }
    public int ShipPower { get; set; }

}
