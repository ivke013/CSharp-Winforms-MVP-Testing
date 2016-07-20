using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asseco.Presenter;

namespace Asseco.View
{
    public interface IArtistView
    {
        int ID { get; set; }
        string Name { get; set; }
        string Lastname { get; set; }
        string Nickname { get; set; }

        ArtistPresenter Presenter { get; set; }
        DataGridView ArtistListGrid { get; set; }
        BindingSource BSource { get; set; }

        event EventHandler<EventArgs> OnLoad;
        event EventHandler<EventArgs> AddRow;
        event EventHandler<EventArgs> Save;
        event EventHandler<EventArgs> Reload;
        event EventHandler<EventArgs> Delete;
        event EventHandler<EventArgs> Create;

    }
}
