using System;

namespace DateModifier
{
    public static class DateModifier
    {
        public static int GetDiffBetweenTwoDates(string dateOneStr, string dateTwoStr)
        {
            DateTime dateOne = DateTime.Parse(dateOneStr);

            DateTime dateTwo = DateTime.Parse(dateTwoStr);

            TimeSpan diff = dateOne - dateTwo;
            return diff.Days;
        }
    }
}
