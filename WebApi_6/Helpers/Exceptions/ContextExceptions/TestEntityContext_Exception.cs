
using System.Globalization;

namespace Helpers.Exceptions.ContextExceptions
{
    public class TestEntityContext_Exception : Exception
    {
        public TestEntityContext_Exception() : base()
        {
        }
        public TestEntityContext_Exception(string message) : base(message) { }
        public TestEntityContext_Exception(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }

        
    }


}