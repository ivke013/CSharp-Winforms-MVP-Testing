using System;
using System.Windows.Forms;

namespace Asseco.Core.Form
{
    /// <summary>
    /// 
    /// Main base class that shares the same members and methods in derived form classes.
    /// 
    /// </summary>
    abstract public class AssecoForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// 
        /// Initializes a new instance of the Asseco.Core.AssecoException class.
        /// 
        /// </summary>
        public AssecoForm()
        {
        }

        /// <summary>
        /// 
        /// Wire all registred events
        /// 
        /// </summary>
        abstract public void WireEvents();

        /// <summary>
        /// 
        /// Initialize all System.Windows.Forms components
        /// 
        /// </summary>
        abstract public void InitializeComponents();

        
    }
}
