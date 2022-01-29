//This file is used to "seed" or fill up the database for both entities (For testing)
using lab4.Models;

namespace lab4.Data;

public class SampleData {
    public static List<Province> GetProvinces() {
      List<Province> provinces = new List<Province>() {
         new Province {
             ProvinceCode = "BC",
             ProvinceName = "British Columbia",
         },
         new Province {
             ProvinceCode = "AB",
             ProvinceName = "Alberta",
         },
         new Province {
             ProvinceCode = "ON",
             ProvinceName = "Ontario",
         },
      };
      return provinces;
  }
  public static List<City> GetCities() {
      List<City> cities = new List<City>() {
         new City() {
             CityId = 1,
             CityName = "Vancouver",
             ProvinceCode = "BC",
             Population = 100000,
         },
         new City() {
             CityId = 2,
             CityName = "Richmond",
             ProvinceCode = "BC",
             Population = 100000,
         },
         new City() {
             CityId = 3,
             CityName = "Burnaby",
             ProvinceCode = "BC",
             Population = 100000,
         },
         new City() {
             CityId = 4,
             CityName = "Edmonton",
             ProvinceCode = "AB",
             Population = 4000,
         },
         new City() {
             CityId = 5,
             CityName = "Winnipeg",
             ProvinceCode = "AB",
             Population = 100,
         },
         new City() {
             CityId = 6,
             CityName = "Calgary",
             ProvinceCode = "AB",
             Population = 4000,
         },
         new City() {
             CityId = 7,
             CityName = "Toronto",
             Population = 2000,
             ProvinceCode = "ON",
         },
        new City() {
             CityId = 8,
             CityName = "Ottawa",
             ProvinceCode = "ON",
             Population = 7000,
         },
        new City() {
             CityId = 9,
             CityName = "Quebec City",
             ProvinceCode = "ON",
             Population = 2000,
         },
      };

      return cities;
  }
}
