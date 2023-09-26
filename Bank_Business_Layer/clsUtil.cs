using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Business_Layer
{
    public class clsUtil
    {

        static public string GenerateVerificationKey(int digitCount)
        {
            Random random = new Random();
            StringBuilder verificationKeyBuilder = new StringBuilder();

            for (int i = 0; i < digitCount; i++)
            {
                int digit = random.Next(0, 10); // Generates a random digit from 0 to 9
                verificationKeyBuilder.Append(digit);
            }

            return verificationKeyBuilder.ToString();
        }

    }
}
