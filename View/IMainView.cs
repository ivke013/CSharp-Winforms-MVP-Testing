using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asseco.Core;
using Asseco.Presenter;
using System.Windows.Forms;

namespace Asseco.View
{
    public interface IMainView
    {
        MainPresenter Presenter { get; set; }
        Panel MainPanel { get; set; }

        // events
        event EventHandler<EventArgs> OnLoad;
        event EventHandler<EventArgs> ShowArtist;
        event EventHandler<EventArgs> ShowLibrary;
        event EventHandler<EventArgs> ShowTopList;

    }
}
