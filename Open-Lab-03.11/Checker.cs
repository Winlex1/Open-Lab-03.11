using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            string str1 = new string(chars);
            if(str1 == str)
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
