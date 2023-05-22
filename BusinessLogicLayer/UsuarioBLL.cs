using BusinessEntity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurityLayer;
using DataAccessLayer.Modelos;

namespace BusinessLogicLayer
{
    public class UsuarioBLL : IRepository<Usuario>
    {
        UsuarioDAL GestorUsuario;

        public UsuarioBLL()
        {
            GestorUsuario = new UsuarioDAL();
        } 
        public void Actualizar(Usuario entidad)
        {
            GestorUsuario.Actualizar(entidad);
        }

        public void Agregar(Usuario oUsuario)
        {
            CryptoManager cryptoManager = new CryptoManager();
            oUsuario.Password = cryptoManager.HashPassword(oUsuario.Password);

            GestorUsuario.Agregar(oUsuario);

        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObtenerUsuariosBloqueados()
        {
            List<Usuario> Usuarios = GestorUsuario.ObtenerTodos();
            Usuarios = Usuarios.FindAll(user => user.StateBlock == true).ToList();

            return Usuarios;
        }
    }
}
