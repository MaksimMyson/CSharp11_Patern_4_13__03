namespace CSharp11_Patern_4_13__03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleague1 colleague1 = new ConcreteColleague1("Колега 1");
            ConcreteColleague2 colleague2 = new ConcreteColleague2("Колега 2");

            mediator.Register(colleague1);
            mediator.Register(colleague2);

            colleague1.Send("Привіт, колега 2!");
            colleague2.Send("Привіт, колега 1!");
        }
    }
}
