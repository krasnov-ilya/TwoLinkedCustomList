namespace List
{
    public class Notebook
    {
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public Notebook(int serialNumber, string name)
        {
            SerialNumber = serialNumber;
            Name = name;
        }
    }
}
