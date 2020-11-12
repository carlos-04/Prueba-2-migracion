using Microsoft.EntityFrameworkCore;
using Prueba_Migraciones.Models;
using Prueba_Migraciones.Persistens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Migraciones.Services.Servicios
{
    public class ServicesPersona : IPersona
    {
        private readonly SystemDbContext _systemDb;

        public ServicesPersona(SystemDbContext SbPersona)
        {
            _systemDb =  SbPersona;
        }
        public bool Add(Persona model)
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
                _systemDb.Entry(new Persona { Id = id }).State = EntityState.Deleted;
                _systemDb.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }

            return true;
        }

        public Persona Get(int id)
        {
            var resultado = new Persona();
            try
            {
        
               resultado = _systemDb.persona.Single(p => p.Id == id);

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public IEnumerable<Persona> GetAll()
        {
            var resultado = new List<Persona>();

            try
            {
                resultado = _systemDb.persona.Where(x => x.Id == x.Id).Include(x => x.Solicitudes).ToList();

            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }

        public bool Update(Persona model)
        {
            try
            {
                var OriginModel = _systemDb.persona.Single(

   X => X.Id == model.Id
    );

                OriginModel.Id = model.Id;
                OriginModel.Nombre = model.Nombre;
                OriginModel.FechaNac = model.FechaNac;
                OriginModel.Pasaporte = model.Pasaporte;
                OriginModel.Direccion = model.Direccion;
                OriginModel.Sexo = model.Sexo;

                _systemDb.Update(OriginModel);
                _systemDb.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }
    }
}

