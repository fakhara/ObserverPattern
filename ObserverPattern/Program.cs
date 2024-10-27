namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher();

            var observerA = new Richard();
            publisher.Attach(observerA);

            var observerB = new Linda();
            publisher.Attach(observerB);

            var observerC = new Alicia();
            publisher.Attach(observerC);
        }
    }
}