using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classes
{

    //C:\Users\ntsako.mboweni\source\repos\Csharp\Classes
    class FileStreamer
    {
        private StreamReader streamReader;
        private String cust = String.Empty;

        public void openCustFile()
        {
            try
            {
                streamReader = new StreamReader(@"C:\Users\ntsako.mboweni\source\repos\Csharp\Classes\customer.txt");

            }
            catch(IOException ioe)
            {
                ioe.ToString();
            }
           

        }

        public void readCustFile() 
        {
            try
            {
                cust = streamReader.ReadToEnd();
                closeFile();
            }
            catch(IOException ioe)
            {
                ioe.ToString();
            }
            finally
            {
                if(cust == "")
                { streamReader.Dispose();
                    cust = String.Empty;
                }
                
            }
   
        }

        public void closeFile()
        {
            streamReader.Dispose();
        }

        public String GetCustData()
        {
            return cust;  
        }

    }
}
