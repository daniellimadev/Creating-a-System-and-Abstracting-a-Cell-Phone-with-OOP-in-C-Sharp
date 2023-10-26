using Creating_a_System_and_Abstracting_a_Cell_Phone_with_OOP_in_C_Sharp.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(number: "135643", model: "Model 1", imei: "485302475", memory: 4);
nokia.ToConnect();
nokia.InstallApplication("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iPhone = new Iphone(number: "4564", model: "Model 12", imei: "425893186", memory: 128);
iPhone.ToConnect();
iPhone.InstallApplication("Facebook");

Console.WriteLine("\n");