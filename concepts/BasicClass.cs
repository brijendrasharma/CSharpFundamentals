using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.concepts
{
    internal class BasicClass
    {
        string basicName = "Some Test Name";
        int basicNumber = 1234567890;
        char basicChar = 'A';
        public BasicClass()
        {
            // basic useless constructor    
        }
        public BasicClass(string BasicName, int BasicNumber, char BasicChar)
        {
            //paramterized constructor
            basicChar = BasicChar;
            basicName = BasicName;
            basicNumber = BasicNumber;
        }

        public string returnBasicName()
        {
            return basicName;
        }
        public int returnBasicNumber()
        {
            return basicNumber;
        }
        public char returnBasicChar()
        {
            return basicChar;
        }
    }
}
