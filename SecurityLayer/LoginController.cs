﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLayer
{
    public class LoginController
    {
		public LoginController()
		{
			_intentos = 3;
		}

		private int _intentos;

		public int Intentos
		{
			get { return _intentos; }
			set { _intentos = value; }
		}

		public bool Login(string username, string password)
		{
			
			//TODO: Validar correo y contraseña en BBDD
			if (true)
			{
				

				SessionManager mySession = SessionManager.getInstance();
				resetIntento();
				
				return true;
			}
			else
			{

				return false;
			}
			
			
		}

		public void BlockUsuario(string correo)
		{

		}

		public void resetIntento() => Intentos = 0;

		public void restarIntento() => Intentos -= 1;

	}
}