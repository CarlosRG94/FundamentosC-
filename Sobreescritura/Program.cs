// See https://aka.ms/new-console-template for more information
class Clase1 
{
    static void Main(string[] args)
    {
        Sale sale = new Sale(5);
        sale.Add(3);
        sale.Add(5);
        sale.Add(6);
        sale.Add(7);
        sale.Add(8);
        Console.WriteLine(sale.GetTotal());
        SaleWithTax saleWithTax = new SaleWithTax(3,1.23m);
        saleWithTax.Add(5);
        saleWithTax.Add(3);
        saleWithTax.Add(2);
        Console.WriteLine(saleWithTax.GetTotal());

    }
}
public class Sale 
{
    private decimal[] _amounts;
    private int _n;
    private int _end;
    public Sale(int n)
    {
        _amounts = new decimal[n];
        _n = n;
        _end = 0;
    }
    public void Add (decimal amount)
    {
        while (_end < _n)
        {
            _amounts[_end] = amount;
            _end++;
        }
    }
    public virtual decimal GetTotal() 
    {
        decimal total = 0;
        int i = 0;
        while (i < _amounts.Length) 
        {
            total+=_amounts[i];
            i++;
        }
        return total;
    }
}
public class SaleWithTax : Sale
{
    private decimal _tax;
    public SaleWithTax(int n, decimal tax) : base(n) 
    {
        _tax = tax; 
    }
    public override decimal GetTotal()
    {
        return base.GetTotal()*_tax;
    }
}
