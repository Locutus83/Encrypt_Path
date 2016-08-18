using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encrypt_path
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //String MyPath = "C:\\Enter\\Path\\Here";
                Console.WriteLine("Please enter your path here:");
                String MyPath = Console.ReadLine();
                String Encrypted = PIDLUtils.Encode(MyPath);
                Console.WriteLine(Encrypted);

                String notEncrypted = PIDLUtils.Decode(Encrypted);
                Console.WriteLine(notEncrypted);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
