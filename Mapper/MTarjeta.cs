﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BusinessEntity;
using DataAccess;

namespace Mapper
{
    public class MTarjeta : IGestor<BETarjeta>
    {
        Conexion oConexion;

        public bool Guardar(BETarjeta Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Baja(BETarjeta Objeto)
        {
            throw new NotImplementedException();
        }

        public BETarjeta ListarObjeto(BETarjeta Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BETarjeta> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
