namespace System;

static class StringExtentions
{
    public static string Cut(this string obj, int count)
    {
        if(obj.Length <= count)
        {
            return obj;
        }

        return obj.Substring(0, count) + "...";
    }
}