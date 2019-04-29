using System;
using System.Collections;
namespace Palindrome
{
    public class isPalindrome
    {
        public string x, rev;
        public int leng = 0;
        public  InfoInput()
        {
            
            Console.WriteLine("Enter a string");
            String a = Console.ReadLine();
            leng = x.Length - 1;
            while (leng >= 0) {
                x = a;
                rev = rev + x[leng];
                leng--;
           }

            bool IsEqlPalinD()
            {
                if (x == rev)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
              
        }
    }
}
