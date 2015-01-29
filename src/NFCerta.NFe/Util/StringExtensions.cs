namespace NFCerta.NFe.Util
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StringExtensions
    {
        public static bool HasValue(this string str)
        {
            return !String.IsNullOrEmpty(str);
        }

        public static string F(this string str, params object[] args)
        {
            return String.Format(str, args);
        }

        public static IEnumerable<string> SplitChunks(this string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

        public static string JoinString(this IEnumerable<string> strs, string separator)
        {
            return string.Join(separator, strs);
        }
    }
}
