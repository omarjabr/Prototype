using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateBinary
{
    class Program
    {
        static void CreateBinary()
        {
            Console.WriteLine("Name your binary file: ");
            string fileName = Console.ReadLine();
            FileStream fs = new FileStream(fileName + ".bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            Console.WriteLine("Enter the text to be in the file:");
            string fileContent = Console.ReadLine();
            bw.Write(fileContent);

            bw.Close();
            fs.Close();
        }

        static void ReadBinary()
        {
            Console.WriteLine("Which file do you want to preview: ");
            string fileName = Console.ReadLine();
            FileStream fs = new FileStream(fileName + ".bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            string read = br.ReadString();
            Console.WriteLine(read);
        }

        static void Main(string[] args)
        {
            CreateBinary();
            ReadBinary();
            Console.ReadKey();
        }
    }
}
