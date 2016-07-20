using Asseco.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.Model
{
    interface IArtistModel : IModel
    {
        bool AddNewArtist(string firstname, string lastname, string nickname);
        void AddArtist(DataTable table);
        bool UpdateArtist(DataRow row);
        bool RemoveArtist(int id);

        DataTable ArtistData { get; set; }
        DataTable GetArtists();
    }
}
