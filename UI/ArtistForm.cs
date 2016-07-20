using Asseco.Presenter;
using Asseco.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asseco.UI
{
    public partial class ArtistForm : Form, IArtistView
    {
        public ArtistPresenter Presenter { get; set; }
        public DataGridView ArtistListGrid { get; set; }
        public BindingSource BSource { get; set; }

        // Id
        public int  ID
        {
            get { return Int32.Parse(idTextbox.Text); }
            set { idTextbox.Text = Convert.ToString(value); }
        }

        // Name
        public string Name
        {
            get
            {
                return nameTextBox.Text;
            }
            set
            {
                nameTextBox.Text = value;
            }
        }

        // Lastname
        public string Lastname
        {
            get
            {
                return lastnameTextBox.Text;
            }
            set
            {
                lastnameTextBox.Text = value;
            }
        }

        // nickname
        public string Nickname
        {
            get
            {
                return nicknameTextbox.Text;
            }
            set
            {
                nicknameTextbox.Text = value;
            }
        }

        // Constructor
        public ArtistForm()
        {
            this.InitializeComponent();
            this.Init();
            this.Presenter = new ArtistPresenter(this);
            this.WireEvents();
        }

        /// <summary>
        ///  Init
        /// </summary>
        private void Init()
        {
            this.ArtistListGrid = new DataGridView();
            this.ArtistListGrid.Dock = DockStyle.Fill;
            this.ArtistListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ArtistListGrid.AllowUserToAddRows = false;
            this.BSource = new BindingSource();

            this._contentPanel.Controls.Add(ArtistListGrid);

        }

        // Events
        public event EventHandler<EventArgs> OnLoad;
        public event EventHandler<EventArgs> AddRow;
        public event EventHandler<EventArgs> Save;
        public event EventHandler<EventArgs> Reload;
        public event EventHandler<EventArgs> Delete;
        public event EventHandler<EventArgs> Create;


        // Wire events
        private void WireEvents()
        {
            this.Load += new EventHandler(ArtistForm_Load);
            this._saveArtistButton.Click += new EventHandler(_saveArtistButtonClick);
            this._deleteToolbarButton.Click += new EventHandler(_deleteArtistButtonClick);
            this.ArtistListGrid.CellBeginEdit += new DataGridViewCellCancelEventHandler(_artistGridCellBeginEdit);
            this.ArtistListGrid.SelectionChanged += new EventHandler(_artistGridSelectionChanged);
            this._reloadArtistButton.Click += new EventHandler(_reloadButtonClick);
            this.newSave.Click += new EventHandler(_createNewArtistButtonClick);
        }

        private void CreateAddForm()
        {
            Form form = new Form();
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            form.Controls.Add(this.newSave);
            form.Controls.Add(this.textBox3);
            form.Controls.Add(this.nickLabel);
            form.Controls.Add(this.textBox2);
            form.Controls.Add(this.lnameLabel);
            form.Controls.Add(this.textBox1);
            form.Controls.Add(this.fnameLabel);
            form.ResumeLayout(false);
            form.PerformLayout();

            form.ShowDialog();
        }

        // Load
        private void ArtistForm_Load(object sender, EventArgs e)
        {
            if (this.OnLoad != null)
            {
                this.OnLoad(this, EventArgs.Empty);
            }
        }

        // Add row
        private void addRowBtn_Click(object sender, EventArgs e)
        {
            if(this.AddRow != null)
            {
                this.AddRow(this, EventArgs.Empty);
            }
        }

        // Save
        private void _saveArtistButtonClick(object sender, EventArgs e)
        {
            if(this.Save != null)
            {
                this.Save(this, EventArgs.Empty);
            }
        }

        /// Reload
        private void _reloadButtonClick(object sender, EventArgs e)
        {
            if(this.Reload != null)
            {
                this.Reload(this, EventArgs.Empty);
            }
        }

        // Delete 
        private void _deleteArtistButtonClick(object sender, EventArgs e)
        {
            if(this.Delete != null)
            {
                this.Delete(this, EventArgs.Empty);
            }
        }

        // Begin edit 
        private void _artistGridCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _saveArtistButton.Enabled = true;
        }


        // Current row
        private void _artistGridSelectionChanged(object sender, EventArgs e)
        {
            _deleteToolbarButton.Enabled = true;
            int rowIndex = ArtistListGrid.CurrentCell.RowIndex;
            int cellIndex = ArtistListGrid.CurrentCell.ColumnIndex;

            this.ID = ((DataRowView)BSource.Current).Row.Field<Int32>("ID");
            this.Name = ((DataRowView)BSource.Current).Row.Field<string>("Firstname");
            this.Lastname = ((DataRowView)BSource.Current).Row.Field<string>("Lastname");
            this.Nickname = ((DataRowView)BSource.Current).Row.Field<string>("Nickname");


        }

        // SHow new form
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.CreateAddForm();
        }

        // Create new from form
        private void _createNewArtistButtonClick(object sender, EventArgs e)
        {
            this.Presenter.Create(nameTextBox.Text, lastnameTextBox.Text, nicknameTextbox.Text);
        }

    }
}
