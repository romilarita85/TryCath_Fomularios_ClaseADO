using System.Runtime.Serialization;

namespace LibreriaDeExcepciones22_11
{
    public class CantidadErroneaException : Exception
    {
        public CantidadErroneaException()
        {
        }

        public CantidadErroneaException(string? message) : base(message)
        {
        }

       
    }
}
