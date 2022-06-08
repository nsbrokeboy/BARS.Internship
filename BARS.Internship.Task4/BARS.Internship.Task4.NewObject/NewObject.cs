namespace BARS.Internship.Task4.NewObject
{
    public class NewObject
    {
        // комменты чтобы решарпер не ругался
        
        // ReSharper disable once RedundantOverriddenMember
        public override bool Equals(object obj)
        {
            // ReSharper disable once BaseObjectEqualsIsObjectEquals
            return base.Equals(obj);
        }
        
        // ReSharper disable once RedundantOverriddenMember
        public override string ToString()
        {
            return base.ToString();
        }

        // ReSharper disable once RedundantOverriddenMember
        public override int GetHashCode()
        {
            // ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
            return base.GetHashCode();
        }
    }
}