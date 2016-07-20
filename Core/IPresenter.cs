using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.Core
{
    /// <summary>
    /// 
    /// Base interface for all presenter classes. Keeps track of Model and View classes.
    /// 
    /// </summary>
    /// <remarks>
    /// Asseco
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public interface IPresenter
    {
        /// <summary>
        /// 
        /// Wire all registred events 
        /// 
        /// </summary>
        void WireEvents();
    }
}
