namespace NFCerta.NFe.Util
{
    using NFCerta.NFe.Schemas.TiposBasicos;
using NodaTime;
using System;

    public static class DateTimeHelpers
    {
        private static string sefazDateFormat = "yyyy-MM-ddTHH:mm:ssK";

        private static DateTimeOffset epoch = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

        public static DateTimeOffset FromUnixTime(this long unixTime)
        {
            return epoch.AddSeconds(unixTime);
        }

        public static long ToUnixTime(this DateTimeOffset date)
        {
            return Convert.ToInt64((date.ToUniversalTime() - epoch).TotalSeconds);
        }

        public static string ToSefazTime(this DateTime date)
        {
            return date.ToString(sefazDateFormat);
        }

        public static DateTime FromSefazTime(this string date)
        {
            var datetimeOffset = DateTimeOffset.ParseExact(date, sefazDateFormat, null);
            
            return OffsetDateTime.FromDateTimeOffset(datetimeOffset).ToInstant().ToDateTimeUtc();
        }

        public static DateTime InZone(this DateTime date, TUfEmi uf)
        {
            var zoneName = uf.GetTimeZoneName();

            var zone = DateTimeZoneProviders.Tzdb[zoneName];

            var instant = Instant.FromDateTimeUtc(date);

            return instant.InZone(zone).ToDateTimeUnspecified();
        }
    }
}
