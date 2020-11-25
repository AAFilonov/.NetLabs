using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Lab11.Models
{
    class Film
    {
        private static readonly string _selectFilmsCommand = @"SELECT [id],[producer],[cover],[year],[Title] FROM [DB_dotNet].[dbo].[Film]";
        private static readonly string _insertFilmCommand = @"INSERT INTO [DB_dotNet].[dbo].[Film] ([id],[producer],[cover],[year],[Title]) VALUES (@id,@producer,@cover,@year,@Title)";
        private static readonly string _updateFilmCommand = @"UPDATE [DB_dotNet].[dbo].[Film] SET [id] = @id ,[producer] = @producer,[cover] = @cover,[year] = @year,[Title] = @Title";
        private static readonly string _deleteFilmCommand = @"DELETE FROM [[DB_dotNet].[dbo].[Film] WHERE [id] = @id";

        public int FilmId { get; set; }
        public string Title { get; set; }
        public int ProdusserId { get; set; }
        public int Year { get; set; }
        public byte[] Cover { get; set; }

        public static List<Film> List(SqlConnection connection)
        {
            List<Film> Films = new List<Film>();

            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectFilmsCommand;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Film Film = new Film
                        {
                            FilmId = (int)reader["id"],
                            Title = (string)reader["Title"],
                            ProdusserId = (int)reader["producer"],                
                            Year = (int)reader["year"],
                            Cover = (byte[])reader["cover"]

                        };
                        Films.Add(Film);
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return Films;
        }

        public static void Insert(SqlConnection connection, Film film)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertFilmCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@producer", SqlDbType.Int).Value = film.ProdusserId;
                    command.Parameters.Add("@cover", SqlDbType.Image).Value = film.Cover;
                    command.Parameters.Add("@year", SqlDbType.Int).Value = film.Year;
                    command.Parameters.Add("@Title", SqlDbType.NVarChar, 50).Value = film.Title;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Update(SqlConnection connection, Film film)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updateFilmCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = film.FilmId;
                    command.Parameters.Add("@producer", SqlDbType.Int).Value = film.ProdusserId;
                    command.Parameters.Add("@cover", SqlDbType.Image).Value = film.Cover;
                    command.Parameters.Add("@year", SqlDbType.Int).Value = film.Year;
                    command.Parameters.Add("@Title", SqlDbType.NVarChar, 50).Value = film.Title;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        public static void Delete(SqlConnection connection, int filmId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteFilmCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = filmId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
    }
}
