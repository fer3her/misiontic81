using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuarios()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Camilo",apellidos= "Vargas",direccion= "calle 13 # 02-13",telefono= "2311111", ciudad="Bogota"},
                new Usuario{id=2,nombre="Eduardo",apellidos= "Rubio",direccion= "calle 20 # 22-03",telefono= "8777777", ciudad="Medellin"},
                new Usuario{id=3,nombre="Juan",apellidos= "Perez",direccion= "carrera 10 # 2-10",telefono= "6522222", ciudad="Cali"}
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetWithId(int id){
            return usuarios.SingleOrDefault(e => e.id == id);
        }

         public Usuario Create(Usuario newUsuario)
        {
           if(usuarios.Count > 0){
             newUsuario.id=usuarios.Max(r => r.id) +1;
            }else{
               newUsuario.id = 1;
            }
           usuarios.Add(newUsuario);
           return newUsuario;
        }

        public Usuario Delete(int id)
        {
            var usuario = usuarios.SingleOrDefault(e => e.id == id);
            usuarios.Remove(usuario);
            return usuario;
        }
    }
}