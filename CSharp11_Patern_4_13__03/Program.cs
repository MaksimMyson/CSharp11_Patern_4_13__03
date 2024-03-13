namespace CSharp11_Patern_4_13__03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
            Light light = new Light();
            RemoteControl remote = new RemoteControl();

           
            remote.SetCommand(new TurnOnCommand(light));
            remote.PressButton(null);

            remote.SetCommand(new BrightnessCommand(light, 50));
            remote.PressButton(null);

            remote.SetCommand(new TurnOffCommand(light));
            remote.PressButton(null);
        }
    }
}
