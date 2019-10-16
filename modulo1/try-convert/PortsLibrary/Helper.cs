namespace PortsLibrary
{
    public class Helper
    {
        public static string[] GetAllPorts()
        {
            return System.IO.Ports.SerialPort.GetPortNames();
        }
    }
}
