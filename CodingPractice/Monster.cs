using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using static System.Console;
class Monster : IComparable<Monster>
{
    public string Name;
    public int Power;

    public Monster (string name, int power)
    {
        Name = name;
        Power = power;
    }
    public int CompareTo(Monster m)
    {
        if (m == null)
        {
            return 1;
        }
        return Power.CompareTo(m.Power);
    }
    public override string ToString()
    {
        {
            return $"{Name}(전투력:{Power})";
        }
    }

}
