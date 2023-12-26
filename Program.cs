using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Elite
{
    class Program
    {
      static void Main(string[] args)
      {
        string BinFile = "file.bin";
        Console.WriteLine("BIN file: " + BinFile);
        //Format the object as Binary  
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
        //Reading the file from the server  
        FileStream fs = File.Open(BinFile, FileMode.Open);
   
        object obj = formatter.Deserialize(fs);
        fs.Flush();
        fs.Close();
        fs.Dispose();
        }
    }
}
