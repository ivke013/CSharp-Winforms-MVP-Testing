using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asseco.View;
using Asseco.Core;
using Asseco.Presenter;

namespace Asseco.UI
{
    public partial class MainForm : Form, IMainView
    {
        #region Properties

        public MainPresenter Presenter { get; set; }
        public Panel MainPanel { get; set; }

        #endregion

        // Constructor
        public MainForm()
        {
            this.InitializeComponent();
            this.Presenter = new MainPresenter(this);
            this.WireEvents();

             

         }

        public event EventHandler<EventArgs> OnLoad;
        public event EventHandler<EventArgs> ShowArtist;
        public event EventHandler<EventArgs> ShowLibrary;
        public event EventHandler<EventArgs> ShowTopList;

        // Wire events
        private void WireEvents()
        {
            this.Load += new EventHandler(MainForm_Load);
            this._artistToolbarButton.Click += new EventHandler(_artistToolbarButton_Click);
            this._libraryToolbarButton.Click += new EventHandler(_libraryToolbarButton_Click);
            this._topListToolbarButton.Click += new EventHandler(_topListToolbarButton_Click);
        }

        #region Events
        // Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            if(this.OnLoad != null)
            {
                this.OnLoad(this, EventArgs.Empty);
            }
        }

        // Artist
        private void _artistToolbarButton_Click(object sender, EventArgs e)
        {
            if (this.ShowArtist != null)
            {
                this.ShowArtist(this, EventArgs.Empty);
            }
        }

        // Library
        private void _libraryToolbarButton_Click(object sender, EventArgs e)
        {
            if (this.ShowLibrary != null)
            {
                this.ShowLibrary(this, EventArgs.Empty);
            }
        }

        // Top list
        private void _topListToolbarButton_Click(object sender, EventArgs e)
        {
            if (this.ShowTopList != null)
            {
                this.ShowTopList(this, EventArgs.Empty);
            }
        }
        #endregion
    }
}
