namespace BARS.Internship.Task4.Account
{
    public class Account<T>
    {
        public T Id { get; set; }

        public static T Password { get; set; }

        public Account(T id)
        {
            Id = id;
        }
    }
}