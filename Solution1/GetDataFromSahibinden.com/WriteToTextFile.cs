using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromSahibinden.com
{
    public class WriteToTextFile
    {
        private StreamWriter writer;
        private SahibindenConnector connector;
        private string fileName = "Data";
        public WriteToTextFile()
        {
            writer = new StreamWriter(fileName,true);
            connector = new SahibindenConnector();
        }
        //Txt Dosyaya veri yazdırma.
        public void WriteToFile()
        {
            foreach (var data in connector.PrintShowcaseItems())
            {
                writer.WriteLine(data);
            }
        }
    }
}
