using System;

namespace ClassLibrary1.Extentions
{
    public static class NotNested
    {
        public static string Run(this string str)
        {
            return $"{str} is running...";
        }
    }
}

