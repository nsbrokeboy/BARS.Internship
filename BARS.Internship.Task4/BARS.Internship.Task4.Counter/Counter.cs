namespace BARS.Internship.Task4.Counter
{
    public class Counter
    {
        public int Seconds { get; set; }

        public Counter(int seconds)
        {
            Seconds = seconds;
        }

        public static implicit operator Counter(int number)
        {
            return new Counter(number);
        }

        public static explicit operator int(Counter counter)
        {
            return counter.Seconds;
        }
    }
}