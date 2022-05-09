using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace QuantumWorldClassLibrary;

public class Player
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Points { get; set; }
    public List<Resource> Resources { get; set; }
    public List<Building> Buildings { get; set; }
    public List<Research> Researches { get; set; }
    public List<Ship> Ships { get; set; }
    public List<Villain> Map { get; set; }

}
