using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomClient
{
    class Encryption
    {
        int value = 30;
        char[] arr;
        
        public Encryption()
        {
            Random rnd = new Random();
            value = 10 + rnd.Next(10);
        }

        public String encrypt(String str)
        {
            String newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                ch -= (char)value;
                newString += ch;
            }
            return newString;
        }

        public String decrypt(String str)
        {
            String newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                ch += (char)value;
                newString += ch;
            }
            return newString;
        }
    }
}
