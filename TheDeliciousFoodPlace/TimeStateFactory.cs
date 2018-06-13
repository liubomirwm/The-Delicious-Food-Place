using System;

namespace TheDeliciousFoodPlace
{
    public class TimeStateFactory
    {
        private static MorningTimeState morningTimeState;
        private static LunchTimeState lunchTimeState;
        private static NightTimeState nightTimeState;

        public static ITimeState GetTimeState()
        {
            TimeSpan timeNow = DateTime.Now.TimeOfDay;
            TimeSpan morningStart = new TimeSpan(06, 30, 00);
            TimeSpan morningEnd = new TimeSpan(11, 30, 00);
            TimeSpan lunchTimeStart = morningEnd;
            TimeSpan lunchTimeEnd = new TimeSpan(18, 00, 00);

            if (timeNow >= morningStart && timeNow < morningEnd)
            {
                if (morningTimeState == null)
                {
                    morningTimeState = new MorningTimeState();
                }
                return morningTimeState;
            }
            else if (timeNow >= lunchTimeStart && timeNow < lunchTimeEnd)
            {
                if (lunchTimeState == null)
                {
                    lunchTimeState = new LunchTimeState();
                }
                return lunchTimeState;
            }
            else
            {
                if (nightTimeState == null)
                {
                    nightTimeState = new NightTimeState();
                }
                return nightTimeState;
            }
        }
    }
}