using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomiendas
    { 
        
        private readonly AppContext _appContext = new AppContext();   
<<<<<<< HEAD

=======
 
>>>>>>> 20800591d2d31546e4c77642c85baf802eb0c5d0
        public IEnumerable<Encomienda> GetAll()
        {
           return _appContext.Encomiendas;
        }
 
        public Encomienda GetWithId(int id){
            return _appContext.Encomiendas.Find(id);
        }
<<<<<<< HEAD

=======
 
>>>>>>> 20800591d2d31546e4c77642c85baf802eb0c5d0
        public Encomienda Update(Encomienda newEncomienda){
            var encomienda = _appContext.Encomiendas.Find(newEncomienda.id);
            if(encomienda != null){
                encomienda.descripcion = newEncomienda.descripcion;
                encomienda.peso = newEncomienda.peso;
                encomienda.tipo = newEncomienda.tipo;
                encomienda.presentacion = newEncomienda.presentacion;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return encomienda;
        }
 
        public Encomienda Create(Encomienda newEncomienda)
        {
           var addEncomienda = _appContext.Encomiendas.Add(newEncomienda);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addEncomienda.Entity;
        }
 
       public bool Delete(int id)
        {
            try{
                var encomienda = _appContext.Encomiendas.Find(id);
                if (encomienda != null){
                    _appContext.Encomiendas.Remove(encomienda);
                    //Guardar en base de datos
                    _appContext.SaveChanges();
                }
                return false;
            }catch(Exception e){
                return true;                  
            }
        }
 
    }
}