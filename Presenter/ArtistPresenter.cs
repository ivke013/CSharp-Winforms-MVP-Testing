using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asseco.Core;
using Asseco.View;
using Asseco.Model;
using System.Data;

namespace Asseco.Presenter
{
    public class ArtistPresenter : IPresenter
    {
        private IArtistView _view;
        private IArtistModel _model;

        // Constructor
        public ArtistPresenter(IArtistView view)
        {
            this._view = view;
            this._model = new ArtistModel();
            this.WireEvents();
        }

        // Wire events
        public void WireEvents()
        {
            this._view.OnLoad += OnLoad;
            this._view.Save += Save;
            this._view.AddRow += AddRow;
            this._view.Reload += Reload;
            this._view.Delete += Delete;

        }

        // On load
        private void OnLoad(object sender, EventArgs e)
        {
            this._view.BSource.DataSource = _model.GetArtists();
            this._view.ArtistListGrid.DataSource = _view.BSource;
        }

        // Save
        private void Save(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save current artist?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {              
                if (!(_model.UpdateArtist(((DataRowView)_view.BSource.Current).Row)))
                {
                    MessageBox.Show("Update failed");
                }else
                {
                    MessageBox.Show("Artist successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Add row
        private void AddRow(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)_view.BSource.DataSource;
            _model.AddArtist(dt);
        }

        // Reload
        private void Reload(object sender, EventArgs e)
        {
            _view.ArtistListGrid = new DataGridView();
            _view.BSource = new BindingSource();

            _view.BSource.DataSource = _view.ArtistListGrid;
            _view.ArtistListGrid.DataSource = _view.BSource;
        }

        // Delete
        private void Delete(object sender, EventArgs e)
        {
            string artistName = ((DataRowView)_view.BSource.Current).Row.Field<string>("Firstname");

            if (MessageBox.Show("Remove " + artistName + " artist?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (_model.RemoveArtist(((DataRowView)_view.BSource.Current).Row.Field<int>("ID")))
                {
                    _view.BSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Failed to remove '" + artistName + "'");
                }
            }
        }

        public void Create(string firstname, string lastname, string nickname)
        {
            MessageBox.Show(firstname + lastname + nickname);
            
        }
    }
}
