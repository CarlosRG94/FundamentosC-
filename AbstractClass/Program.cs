// See https://aka.ms/new-console-template for more information
public abstract class Bird
{
    public int _wings;
    public Bird(int wings)=>_wings=wings;
}
interface IFly
{
    void Fly()
    {
        Console.WriteLine("Voy a volar desde la interfaz");
    }
}
interface IRun
{
    int legs { get; set; }   
    void Run();
}
interface ISwim
{
    void Swim();
}
public class Ostrich : Bird, IRun
{
    public int _legs;

    public Ostrich(int wings) : base(wings)
    {
    }

    public int legs 
    { 
        get { return _legs; }
        set { _legs = value; } 
    }

    public void Run()
    {
        Console.WriteLine("Corre pajarillo");
    }

    public abstract class Sale
    {
        public decimal _total;
        public Sale(decimal total)=>_total =total;
    }
    interface IInvoice
    {
        void Check();
    }
    interface ICancel
    {
        void Cancel();
    }
    interface ITax
    {
        public decimal Total { get; set; }
    }
    public class SingleSale : Sale, IInvoice, ICancel, ITax
    {
        public SingleSale(decimal total) : base(total)
        {
        }
        private decimal _iva;
        public decimal Total {
            get { return _total + _iva; } 
            set => throw new NotImplementedException(); }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Check()
        {
            throw new NotImplementedException();
        }
    }
}