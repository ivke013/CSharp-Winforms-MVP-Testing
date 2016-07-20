using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.Model
{
    public class ArtistModel : IArtistModel
    {
        public DataTable ArtistData { get; set; }


        // Constructor
        public ArtistModel()
        {
            this.ArtistData = new DataTable();

            this.ArtistData.Columns.Add(new DataColumn { ColumnName = "ID", DataType = typeof(int) });
            this.ArtistData.Columns.Add(new DataColumn { ColumnName = "Firstname", DataType = typeof(string) });
            this.ArtistData.Columns.Add(new DataColumn { ColumnName = "Lastname", DataType = typeof(string) });
            this.ArtistData.Columns.Add(new DataColumn { ColumnName = "Nickname", DataType = typeof(string) });

            using (SqlConnection cn = new SqlConnection { ConnectionString = Properties.Settings.Default.ConnectionString })
            {
                using (SqlCommand cmd = new SqlCommand { Connection = cn })
                {
                    cmd.CommandText = "SELECT id, name, lastname, nickname FROM [Artist] ORDER BY id ASC";
                    cn.Open();
                    var Reader = cmd.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            this.ArtistData.Rows.Add(new object[] { Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3) });
                        }
                    }
                }
            }

            this.ArtistData.AcceptChanges();
        }

        // Get all artist
        public DataTable GetArtists()
        {
            return this.ArtistData;
        }

        /// Add artist
        public void AddArtist(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    if (!(string.IsNullOrWhiteSpace(row.Field<string>("Firstname"))))
                    {
                        int id = 0;
                        if (AddNewArtist(row.Field<string>("Firstname"), row.Field<string>("Lastname"), row.Field<string>("Nickname")))
                        {
                            row.SetField<int>("ID", id);
                        }
                    }
                }
            }

            table.AcceptChanges();
        }

        // Add new artist
        public bool AddNewArtist(string firstname, string lastname, string nickname)
        {
            using (SqlConnection cn = new SqlConnection { ConnectionString = Properties.Settings.Default.ConnectionString })
            {
                using (SqlCommand cmd = new SqlCommand { Connection = cn })
                {
                    cmd.CommandText = "INSERT INTO Artists (name, lastname, nickname) VALUES(@name, @lastname, @nickname)";
                    cmd.Parameters.AddWithValue("@name", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@nickname", nickname);
                    cmd.Parameters.AddWithValue("@created", DateTime.Now);

                    cn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }

        public bool UpdateArtist(DataRow row)
        {
            bool Result = false;
            using (SqlConnection cn = new SqlConnection { ConnectionString = Properties.Settings.Default.ConnectionString })
            {
                using (SqlCommand cmd = new SqlCommand { Connection = cn })
                {
                    cmd.CommandText = "UPDATE Artist SET name = @name, lastname = @lastname, nickname = @nickname WHERE id = @id";
                    cmd.Parameters.AddWithValue("@name", row.Field<string>("Firstname"));
                    cmd.Parameters.AddWithValue("@lastname", row.Field<string>("Lastname"));
                    cmd.Parameters.AddWithValue("@nickname", row.Field<string>("Nickname"));
                    cmd.Parameters.AddWithValue("@id", row.Field<int>("ID"));
                    cn.Open();
                    try
                    {
                        if (Convert.ToInt32(cmd.ExecuteNonQuery()) == 1)
                        {
                            Result = true;
                        }
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            return Result;
        }

        public bool RemoveArtist(int id)
        {
            bool Result = false;
            using (SqlConnection cn = new SqlConnection { ConnectionString = Properties.Settings.Default.ConnectionString })
            {
                using (SqlCommand cmd = new SqlCommand { Connection = cn, CommandText = "DELETE FROM Artist WHERE id = " + id.ToString() })
                {
                    cn.Open();
                    Result = (cmd.ExecuteNonQuery() == 1);
                }
            }
            return Result;
        }

    }
}
