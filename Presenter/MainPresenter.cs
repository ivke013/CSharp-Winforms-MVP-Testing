using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asseco.Core;
using Asseco.View;
using Asseco.UI;

namespace Asseco.Presenter
{
    public class MainPresenter : IPresenter
    {
        private IMainView _view;
        private ArtistForm _artistView;

        // Constructor
        public MainPresenter(IMainView view)
        {
            this._view = view;
            this.WireEvents();
        }

        // Wire events
        public void WireEvents()
        {
            this._view.OnLoad += OnLoad;
            this._view.ShowArtist += ShowArtist;
            this._view.ShowLibrary += ShowLibrary;
            this._view.ShowTopList += ShowTopList;
        }

        // Show artist
        public void ShowArtistView(Form form)
        {
            MessageBox.Show("ASD");

           
        }


        // On load
        private void OnLoad(object sender, EventArgs e)
        {
            //MessageBox.Show("OnLoad");
        }


        // Show Artist
        private void ShowArtist(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(ArtistForm))
                {
                    f.Activate();
                    return;
                }
            }
            _artistView = new ArtistForm();
            _artistView.TopLevel = false;
            _view.MainPanel.Controls.Add(_artistView);
            _artistView.Show();
        }

        // ShowLibrary
        private void ShowLibrary(object sender, EventArgs e)
        {
            MessageBox.Show("ShowLibrary");
        }

        //ShowTopList
        private void ShowTopList(object sender, EventArgs e)
        {
            MessageBox.Show("ShowTopList");
        }
    }
}
