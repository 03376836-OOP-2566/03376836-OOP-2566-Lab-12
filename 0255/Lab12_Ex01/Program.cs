BaseClass BC = new DerivedClass();
BC.A(); 

abstract class BaseClass
{
    abstract public void A();
}
class DerivedClass : BaseClass
{
    public override void A()
    {
        System.Console.WriteLine("Implementation of inheritance classes");
    }
}