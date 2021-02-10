using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson30
{
    class DAO : IDAO
    {
        public object GetCountyAndItsCapitalCityName(int countryId)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\User\\Desktop\\SQLite\\30.db; Version = 3;"))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *, Country.name as nameOfCountry, CapitalCity.name as nameOfCapitalCity FROM Country JOIN CapitalCity ON Country.CapitalCity_id ==CapitalCity.id WHERE Country.id = {countryId}", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Country c = new Country
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["nameOfCountry"],
                                SizeKm = (int)reader["size_km"],
                                BithYear = (int)reader["bith_year"],
                                CapitalCityId = (int)reader["CapitalCity_id"],
                            };

                            CapitalCity cc = new CapitalCity
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["nameOfCapitalCity"],
                                NumCitizens = (int)reader["NumCitizens"],
                                CountryId = (int)reader["Country_id"],
                            };

                            var result = new {
                                Country = c.Name,
                                CapitalCity = cc.Name
                            };

                            con.Close();
                            return result;
                        }
                    }
                }
            }
            return null;
        }
        public object GetCountyAndItsCapitalCityDDetails(int countryId)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\User\\Desktop\\SQLite\\30.db; Version = 3;"))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *, Country.name as nameOfCountry, CapitalCity.name as nameOfCapitalCity FROM Country JOIN CapitalCity ON Country.CapitalCity_id ==CapitalCity.id WHERE Country.id = {countryId}", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Country c = new Country
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["nameOfCountry"],
                                SizeKm = (int)reader["size_km"],
                                BithYear = (int)reader["bith_year"],
                                CapitalCityId = (int)reader["CapitalCity_id"],
                            };

                            CapitalCity cc = new CapitalCity
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["nameOfCapitalCity"],
                                NumCitizens = (int)reader["NumCitizens"],
                                CountryId = (int)reader["Country_id"],
                            };

                            var result = new
                            {
                                Country = c.Name,
                                IdOfCapitalCity = cc.Id,
                                CapitalCity = cc.Name,
                                NumCitizens = cc.NumCitizens,
                                IdOfCountry = cc.CountryId
                            };

                            con.Close();
                            return result;
                        }
                    }
                }
            }
            return null;
        }
            
        public object GetCountyAndItsCapitalCityName(string countryName)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\User\\Desktop\\SQLite\\30.db; Version = 3;"))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *, Country.name as nameOfCountry, CapitalCity.name as nameOfCapitalCity FROM Country JOIN CapitalCity ON Country.CapitalCity_id ==CapitalCity.id WHERE Country.name = '{countryName}'", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Country c = new Country
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["nameOfCountry"],
                                SizeKm = (int)reader["size_km"],
                                BithYear = (int)reader["bith_year"],
                                CapitalCityId = (int)reader["CapitalCity_id"],
                            };

                            CapitalCity cc = new CapitalCity
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["nameOfCapitalCity"],
                                NumCitizens = (int)reader["NumCitizens"],
                                CountryId = (int)reader["Country_id"],
                            };

                            var result = new
                            {
                                Country = c.Name,
                                CapitalCity = cc.Name
                            };

                            con.Close();
                            return result;
                        }
                    }
                }
            }
            return null;
        }
        
        public object GetCountyAndItsCapitalCityDDetails(string countryName)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\User\\Desktop\\SQLite\\30.db; Version = 3;"))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *, Country.name as nameOfCountry, CapitalCity.name as nameOfCapitalCity FROM Country JOIN CapitalCity ON Country.CapitalCity_id ==CapitalCity.id WHERE Country.name = '{countryName}'", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Country c = new Country
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["nameOfCountry"],
                                SizeKm = (int)reader["size_km"],
                                BithYear = (int)reader["bith_year"],
                                CapitalCityId = (int)reader["CapitalCity_id"],
                            };

                            CapitalCity cc = new CapitalCity
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["nameOfCapitalCity"],
                                NumCitizens = (int)reader["NumCitizens"],
                                CountryId = (int)reader["Country_id"],
                            };

                            var result = new
                            {
                                Country = c.Name,
                                IdOfCapitalCity = cc.Id,
                                CapitalCity = cc.Name,
                                NumCitizens = cc.NumCitizens,
                                IdOfCountry = cc.CountryId
                            };

                            con.Close();
                            return result;
                        }
                    }
                }
            }
            return null;
        }

        public object GetCountyAndItsCapitalCityNameFromFirstLetter(string firstLetter)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\User\\Desktop\\SQLite\\30.db; Version = 3;"))
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *, Country.name as nameOfCountry, CapitalCity.name as nameOfCapitalCity FROM Country JOIN CapitalCity ON Country.CapitalCity_id ==CapitalCity.id WHERE Country.name Like '{firstLetter}%'", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Country c = new Country
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["nameOfCountry"],
                                SizeKm = (int)reader["size_km"],
                                BithYear = (int)reader["bith_year"],
                                CapitalCityId = (int)reader["CapitalCity_id"],
                            };

                            CapitalCity cc = new CapitalCity
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["nameOfCapitalCity"],
                                NumCitizens = (int)reader["NumCitizens"],
                                CountryId = (int)reader["Country_id"],
                            };

                            var result = new
                            {
                                Country = c.Name,
                                CapitalCity = cc.Name
                            };

                            con.Close();
                            return result;
                        }
                    }
                }
            }
            return null;
        }

    }
}
