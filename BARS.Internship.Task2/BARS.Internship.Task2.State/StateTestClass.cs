namespace BARS.Internship.Task2.State
{
    public class StateTestClass
    {
        public static void Main(string[] args)
        {
            var state = new State();
            
            // variables:

            // state.name; - private
            
            // state.defaultVar; - private
            
            // state.protectedVar; - protected
            
            var internalVar = state.internalVar;

            var protectedInternalVar = state.protectedInternalVar;

            var publicVar = state.publicVar;
            
            // methods:

            // state.defaultMethod(); - private

            // state.privateMethod(); - private

            // state.protectedMethod(); - protected
            
            state.internalMethod();
            
            state.protectedInternalMethod();
            
            state.publicMethod();
        }
    }
}