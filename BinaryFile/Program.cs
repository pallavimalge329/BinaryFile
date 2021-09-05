using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryFile
{
    class BinaryTesting
    {
        FileStream fs;
        int i;
        string n;
        double f;
        public BinaryTesting()
        {
            i = 12;
            n = "geeta";
            f = 34.4F * 34.5F;
        }
        public void WriteData()
        {
            fs = new FileStream(@"C:\Users\HP\Desktop\.NetTraining\FilesIPIO\BinaryFile.Dat", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(i);

            bw.Write(f);
            bw.Write(n);

            bw.Flush();
            bw.Close();
        }
        public void ReadData()
        {
            int i;
            double f;
            string n;
            fs = new FileStream(@"F:\\BinaryFile.Dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            i = br.ReadInt32();
            f = br.ReadDouble();
            n = br.ReadString();
            Console.WriteLine("Integer data :{0}", i);
            Console.WriteLine("String data :{0}", n);
            Console.WriteLine("Double data :{0}", f);
            br.Close();
            fs.Close();
        }
    }

}
