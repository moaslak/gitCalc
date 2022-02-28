

namespace gitClac;

public class menuClass
{
    public double Tal1 { get; set; }
    public double Tal2 { get; set; }

    public menuClass()
    {
        Console.Write($"Vælg regnemetode: {}");
        var menu = 
            switch(Tal1, Tal2)
            {
            case 1:

            }
    }
}
