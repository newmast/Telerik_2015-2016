namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class  Extensions
    {
        public static StringBuilder Substring(this StringBuilder text, int start, int length)
        {
            StringBuilder result = new StringBuilder();

            for (int i = start; i < start + length; i++)
            {
                result.Append(text[i]);
            }
            return result;
        }
    }
}
