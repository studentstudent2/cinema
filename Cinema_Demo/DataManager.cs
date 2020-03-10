using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema_Demo.Models;
using System.Data.SqlClient;
using System.Data;

namespace Cinema_Demo
{
    public class DataManager : DbProvider
    {
        private List<Director> Directors;
        private List<Genre> Genres;
        private List<Language> Languages;
        private List<Film> Films;
        private List<Hall> Halls;
        private List<Session> Sessions;
        private List<Sector> Sectors;
        private List<HallSector> HallSectors;
        private List<Place> Places;
        private List<Ticket> Tickets;

        public DataManager()
        {
            Directors = new List<Director>();
            Genres = new List<Genre>();
            Languages = new List<Language>();
            Films = new List<Film>();
            Halls = new List<Hall>();
            Sessions = new List<Session>();
            Sectors = new List<Sector>();
            HallSectors = new List<HallSector>();
            Places = new List<Place>();
            Tickets = new List<Ticket>();
        }

        public void LoadDirectors()
        {
            string query = "SELECT * FROM Directors";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    Director d = new Director()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()
                    };
                    Directors.Add(d);
                }
            }
        }

        public void LoadGenres()
        {
            string query = "SELECT * FROM Genres";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Genre g = new Genre()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()
                    };
                    Genres.Add(g);
                }
            }
        }

        public void LoadLanguages()
        {
            string query = "SELECT * FROM Languages";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Language l = new Language()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()
                    };
                    Languages.Add(l);
                }
            }
        }

        public void LoadFilms()
        {
            string query = "SELECT * FROM Films";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Film f = new Film()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        DirectorId = (int)reader["DirectorId"],
                        GenreId = (int)reader["GenreId"],
                        Year = (int)reader["Year"],
                        Duration = (int)reader["Duration"],
                        LanguageId = (int)reader["LanguageId"],
                        AgeLimit = (int)reader["AgeLimit"],
                        Rating = (double)reader["Rating"],
                        StartDate = (DateTime)reader["StartDate"],
                        EndDate = (DateTime)reader["EndDate"]
                    };

                    Films.Add(f);
                }
            }
        }

        public void LoadHalls()
        {
            string query = "SELECT * FROM Halls";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Hall h = new Hall()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Capacity = (int)reader["Capacity"],
                        CountRows = (int)reader["CountRows"]
                    };

                    Halls.Add(h);
                }
            }
        }

        public void LoadSessions()
        {
            string query = "SELECT * FROM Sessions";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Session s = new Session
                    {
                        Id = (int)reader["Id"],
                        Date = (DateTime)reader["Date"],
                        FilmId = (int)reader["FilmId"],
                        HallId = (int)reader["HallId"]
                    };

                    Sessions.Add(s);
                }
            }
        }

        public void LoadSectors()
        {
            string query = "SELECT * FROM Sectors";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Sector s = new Sector()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()
                    };

                    Sectors.Add(s);
                }
            }
        }

        public void LoadHallSectors()
        {
            string query = "SELECT * FROM HallSectors";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    HallSector s = new HallSector()
                    {
                        Id = (int)reader["Id"],
                        SectorId = (int)reader["SectorId"],
                        HallId = (int)reader["HallId"],
                        StartRow = (int)reader["StartRow"],
                        EndRow = (int)reader["EndRow"]
                    };

                    HallSectors.Add(s);
                }
            }
        }

        public void LoadPlaces()
        {
            string query = "SELECT * FROM Places";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Place p = new Place()
                    {
                        Id = (int)reader["Id"],
                        HallSectorId = (int)reader["SectorId"],
                        Row = (int)reader["Row"],
                        Number = (int)reader["Number"]
                    };

                    Places.Add(p);
                }
            }
        }

        public void LoadTickets()
        {
            string query = "SELECT * FROM Tickets";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ticket t = new Ticket()
                    {
                        Id = (int)reader["Id"],
                        SessionId = (int)reader["SessionId"],
                        PlaceId = (int)reader["PlaveId"],
                        DateOfSale = (DateTime)reader["DateOfSale"],
                        Price = (decimal)reader["Price"]
                    };

                    Tickets.Add(t);
                }
            }
        }

        public void AddDirector(Director d)
        {
            string query = "INSERT INTO Directors (Name) " +
                           "VALUES (@name)";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = d.Name;

                command.ExecuteNonQuery();
            }

            Directors.Add(d);
        }

        public void DelDirector(int Id)
        {
            Director director = Directors.Find(d => d.Id == Id);
            if (director != null)
            {
                string query = "DELETE Directors WHERE Id = @id";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

                    command.ExecuteNonQuery();
                }

                Directors.Remove(director);
            }
        }

        public void AddGenre(Genre g)
        {
            string query = "INSERT INTO Genres (Name) " +
                           "VALUES (@name)";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = g.Name;

                command.ExecuteNonQuery();
            }

            Genres.Add(g);
        }

        public void DelGenre(string Name)
        {
            Genre genre = Genres.Find(g => g.Name == Name);
            if (genre != null)
            {
                string query = "DELETE Genres WHERE Name = @name";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = Name;

                    command.ExecuteNonQuery();
                }

                Genres.Remove(genre);
            }
        }

        public void AddLanguage(Language l)
        {
            string query = "INSERT INTO Languages (Name) " +
                           "VALUES (@name)";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = l.Name;

                command.ExecuteNonQuery();
            }

            Languages.Add(l);
        }

        public void DelLanguage(string Name)
        {
            Language language = Languages.Find(l => l.Name == Name);
            if (language != null)
            {
                string query = "DELETE Languages WHERE Name = @name";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = Name;

                    command.ExecuteNonQuery();
                }

                Languages.Remove(language);
            }
        }

        public void AddFilm(Film f)
        {
            string query = "INSERT INTO Films (Name, DirectorId, GenreId, Year, Duration, LanguageId, AgeLimit, Rating, StartDate, EndDate) " +
                           "VALUES (@name, @directorId, @genreId, @year, @duration, @languageId, @ageLimit, @rating, @startDate, @endDate)";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = f.Name;
                command.Parameters.Add("@directorId", SqlDbType.Int).Value = f.DirectorId;
                command.Parameters.Add("@genreId", SqlDbType.Int).Value = f.GenreId;
                command.Parameters.Add("@year", SqlDbType.Int).Value = f.Year;
                command.Parameters.Add("@duration", SqlDbType.Int).Value = f.Duration;
                command.Parameters.Add("@languageId", SqlDbType.Int).Value = f.LanguageId;
                command.Parameters.Add("@ageLimit", SqlDbType.Int).Value = f.AgeLimit;
                command.Parameters.Add("@rating", SqlDbType.Float).Value = f.Rating;
                command.Parameters.Add("@startDate", SqlDbType.Date).Value = f.StartDate;
                command.Parameters.Add("@endDate", SqlDbType.Date).Value = f.EndDate;

                command.ExecuteNonQuery();
            }

            Films.Add(f);
        }

        public void DelFilm(int Id)
        {
            Film film = Films.Find(f => f.Id == Id);
            if (film != null)
            {
                string query = "DELETE Films WHERE Id = @id";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

                    command.ExecuteNonQuery();
                }

                Films.Remove(film);
            }
        }

        public void AddHall(Hall h)
        {
            string query = "INSERT INTO Halls (Name, Capacity, CountRows) " +
                           "VALUES (@name, @capacity, @countRows)";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = h.Name;
                command.Parameters.Add("@capacity", SqlDbType.Int).Value = h.Capacity;
                command.Parameters.Add("@countRows", SqlDbType.Int).Value = h.CountRows;

                command.ExecuteNonQuery();
            }

            Halls.Add(h);
        }

        public void DelHall(int Id)
        {
            Hall hall = Halls.Find(h => h.Id == Id);
            if (hall != null)
            {
                string query = "DELETE Halls WHERE Id = @id";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

                    command.ExecuteNonQuery();
                }

                Halls.Remove(hall);
            }
        }

        public void AddSession(Session s)
        {
            string query = "INSERT INTO Sessions (Date, FilmId, HallId) " +
                           "VALUES (@date, @filmId, @hallId)";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@date", SqlDbType.DateTime).Value = s.Date;
                command.Parameters.Add("@filmId", SqlDbType.Int).Value = s.FilmId;
                command.Parameters.Add("@hallId", SqlDbType.Int).Value = s.HallId;

                command.ExecuteNonQuery();
            }

            Sessions.Add(s);
        }

        public void DelSession(int Id)
        {
            Session session = Sessions.Find(s => s.Id == Id);
            if (session != null)
            {
                string query = "DELETE Sessions WHERE Id = @id";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

                    command.ExecuteNonQuery();
                }

                Sessions.Remove(session);
            }
        }

        public void AddSector(Sector s)
        {
            string query = "INSERT INTO Sectors (Name) " +
                           "VALUES (@name)";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = s.Name;

                command.ExecuteNonQuery();
            }

            Sectors.Add(s);
        }

        public void DelSector(int Id)
        {
            Sector sector = Sectors.Find(s => s.Id == Id);
            if (sector != null)
            {
                string query = "DELETE Sectors WHERE Id = @id";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

                    command.ExecuteNonQuery();
                }

                Sectors.Remove(sector);
            }
        }

        public void AddHallSector(HallSector hs)
        {
            string query = "INSERT INTO HallSectors (SectorId, HallId, StartRow, EndRow) " +
                           "VALUES (@sectorId, @hallId, @startRow, @endRow)";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@sectorId", SqlDbType.Int).Value = hs.SectorId;
                command.Parameters.Add("@hallId", SqlDbType.Int).Value = hs.HallId;
                command.Parameters.Add("@startRow", SqlDbType.Int).Value = hs.StartRow;
                command.Parameters.Add("@endRow", SqlDbType.Int).Value = hs.EndRow;

                command.ExecuteNonQuery();
            }

            HallSectors.Add(hs);
        }

        public void DelHallSector(int Id)
        {
            HallSector hallSector = HallSectors.Find(hs => hs.Id == Id);
            if (hallSector != null)
            {
                string query = "DELETE HallSectors WHERE Id = @id";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

                    command.ExecuteNonQuery();
                }

                HallSectors.Remove(hallSector);
            }
        }

        public void AddPlace(Place p)
        {
            string query = "INSERT INTO Places (HallSectorId, Row, Number) " +
                           "VALUES (@hallSectorId, @row, @number)";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@hallSectorId", SqlDbType.Int).Value = p.HallSectorId;
                command.Parameters.Add("@row", SqlDbType.Int).Value = p.Row;
                command.Parameters.Add("@number", SqlDbType.Int).Value = p.Number;

                command.ExecuteNonQuery();
            }

            Places.Add(p);
        }

        public void DelPlace(int Id)
        {
            Place place = Places.Find(p => p.Id == Id);
            if (place != null)
            {
                string query = "DELETE Places WHERE Id = @id";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

                    command.ExecuteNonQuery();
                }

                Places.Remove(place);
            }
        }

        public void AddTicket(Ticket t)
        {
            string query = "INSERT INTO Tickets (SessionId, PlaceId, DateOfSale, Price) " +
                           "VALUES (@sessionId, @placeId, @dateOfSale, @price)";

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@sessionId", SqlDbType.Int).Value = t.SessionId;
                command.Parameters.Add("@placeId", SqlDbType.Int).Value = t.PlaceId;
                command.Parameters.Add("@dateOfSale", SqlDbType.DateTime).Value = t.DateOfSale;
                command.Parameters.Add("@price", SqlDbType.Money).Value = t.Price;

                command.ExecuteNonQuery();
            }

            Tickets.Add(t);
        }

        public void DelTicket(int Id)
        {
            Ticket ticket = Tickets.Find(t => t.Id == Id);
            if (ticket != null)
            {
                string query = "DELETE Tickets WHERE Id = @id";

                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

                    command.ExecuteNonQuery();
                }

                Tickets.Remove(ticket);
            }
        }
    }
}
