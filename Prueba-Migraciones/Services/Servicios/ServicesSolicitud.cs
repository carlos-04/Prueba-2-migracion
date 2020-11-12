using Microsoft.EntityFrameworkCore;
using Prueba_Migraciones.Models;
using Prueba_Migraciones.Persistens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Migraciones.Services.Servicios
{
    public class ServicesSolicitud : ISolicitudes
    {
        private readonly SystemDbContext _systemDb;

        public ServicesSolicitud(SystemDbContext SbSolicitudes)
        {
            _systemDb = SbSolicitudes;
        }
        public bool Add(Solicitud model)
        {
            try
            {



                _systemDb.Add(model);
                _systemDb.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }

            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                _systemDb.Entry(new Solicitud { Id = id }).State = EntityState.Deleted;
                _systemDb.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }

            return true;
        }

        public Solicitud Get(int id)
        {
            var resultado = new Solicitud();
            try
            {
                resultado = _systemDb.solicitud.Single(s => s.Id == id);
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public IEnumerable<Solicitud> GetAll()
        {

            var resultado = new List<Solicitud>();
            try
            {

                resultado = _systemDb.solicitud.ToList();


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public bool Update(Solicitud model)
        {

            try
            {
                var OriginalModel = _systemDb.solicitud.Single(
                    X => X.Id == model.Id

                    );

                OriginalModel.Estado = model.Estado;
                OriginalModel.FechaCreacion = model.FechaCreacion;

            }
            catch (Exception)
            {
                return false;

            }

            return true;
        }

    }
}
