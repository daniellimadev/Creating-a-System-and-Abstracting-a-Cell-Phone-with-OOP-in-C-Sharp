
namespace Creating_a_System_and_Abstracting_a_Cell_Phone_with_OOP_in_C_Sharp.Models
{
    public abstract class Smartphone
    {

     public string Number { get; set; }
     private string Model;
     private string IMEI;
     private int Memory;

     public Smartphone(string number, string model, string imei, int memory)
     {
        Number = number;
        Model = model;
        IMEI = imei;
        Memory = memory;
     }

     public void ToConnect()
     {
        Console.WriteLine("Calling...");
     }

     public void ReceiveCall()
     {
        Console.WriteLine("Receiving call...");
     }

     public abstract void InstallApplication(string nameApp);

    }
}