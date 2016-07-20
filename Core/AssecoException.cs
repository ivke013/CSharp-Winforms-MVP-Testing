using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.Core.Exception
{
    /// <summary>
    /// 
    /// Base user-defined exception class
    /// 
    /// </summary>
    public class AssecoException : System.Exception
    {
        /// <summary>
        /// 
        /// Initializes a new instance of the Asseco.Core.AssecoException class.
        /// 
        /// </summary>
        public AssecoException()
        {
        }

        /// <summary>
        /// 
        /// Initializes a new instance of the Asseco.Core.AssecoException class with a specified error
        /// 
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AssecoException(string message)
            :base(message)
        {
        }

        /// <summary>
        /// 
        /// Initializes a new instance of the Asseco.Core.AssecoException class with a specified error
        /// message and a reference to the inner exception that is the cause of this exception.
        /// 
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public AssecoException(string message, System.Exception inner)
            :base(message, inner)
        {

        }
    }
}
