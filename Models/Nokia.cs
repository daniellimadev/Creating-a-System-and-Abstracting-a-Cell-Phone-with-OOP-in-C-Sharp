namespace Creating_a_System_and_Abstracting_a_Cell_Phone_with_OOP_in_C_Sharp.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
        }

        public override void InstallApplication(string nameApp)
        {
            Console.WriteLine($"Installing the {nameApp} application on Nokia");
        }
    }
}