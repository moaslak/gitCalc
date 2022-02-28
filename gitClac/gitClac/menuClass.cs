

namespace gitClac;

public class menuClass
{
    public double Tal1 { get; set; }
    public double Tal2 { get; set; }

    public menuClass()
    {
        int operation = 0;
        Calc calc = new Calc();
        
            switch (operation)
          {
            case 1:
                calc.plus(Tal1, Tal1);
                break;
            case 2:
                calc.minus(Tal1, Tal1);
                break;
            case 3:
                calc.multiply(Tal1, Tal1);
                break;
            case 4:
                calc.div(Tal1, Tal1);
                break;
            }
    }

}