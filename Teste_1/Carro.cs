using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Carro
{
    public string name { get; }
    public int horsePower { get; }
    public float price { get; }

    public Carro (string name, int horsePower, float price)
    {
        this.name = name;
        this.horsePower = horsePower;
        this.price = price;
    }

    public void vrumm()=>Console.WriteLine("Vrum!!! Vrumm!!!");
}


