using System
using System.Text;

namespace ZebraProject
{
    public class ZebraDevice
    {
        public string DeviceName { get; set; }

        public ZebraDevice(string name)
        {
            DeviceName = name;
        }

        public string GenerateZPLSample()
        {
            // Simple ZPL label generation example
            StringBuilder zpl = new StringBuilder();
            zpl.Append("^XA");
            zpl.Append("^FO20,20^A0N25,25^FDHello Zebra^FS");
            zpl.Append("^XZ");
            return zpl.ToString();
        }

        public void PrintLabel()
        {
            Console.WriteLine($"Printing to {DeviceName}...");
            // Add actual Socket/Link-OS connectivity code here
        }
    }
}
            
        

        
        
