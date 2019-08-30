using asp.netcorewebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.netcorewebapi.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T:class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();

        List<City> GetCities();
        City GetCityById(int cityId);
        List<Photo> GetPhotosByCity(int cityId);
        Photo GetPhoto(int id);
    }
}
