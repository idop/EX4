using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces.Logic
{
    public static class Actions
    {
        public static int CountChars(string i_String)
        {
            return i_String.Length;
        }

        public static int CountSpaces(string i_String)
        {
            return i_String.Length - i_String.Replace(" ", string.Empty).Length;
        }

        public static DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}
