using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BusinessEntity;
using Mapper;

namespace BussinesLogic
{
    public class BLCliente : IGestor<BECliente>
    {
        public BLCliente()
        {
            oMCliente = new MCliente();
        }

        MCliente oMCliente;

        public bool Guardar(BECliente oBECliente)
        {
            return oMCliente.Guardar(oBECliente);
        }

        public bool Baja(BECliente oBECliente)
        {
            return oMCliente.Baja(oBECliente);
        }

        public List<BECliente> ListarTodo()
        {
            return oMCliente.ListarTodo();
        }

        public BECliente ListarObjeto(BECliente oBECliente)
        {
            return oMCliente.ListarObjeto(oBECliente);
         }

        public bool AgregarTarjeta_Int_Cliente(BECliente oBECli, BETarjetaInternacional oBETarj)
        {
            return oMCliente.AgregarTarjeta_Int_Cliente(oBECli, oBETarj);

        }

        public bool AgregarTarjeta_Nac_Cliente(BECliente oBECli, BETarjetaNacional oBETarj)
        {
            return oMCliente.AgregarTarjeta_Nac_Cliente(oBECli, oBETarj);

        }

        public bool QuitarTarjeta_Int_Cliente(BECliente oBECli, BETarjetaInternacional oBETarj)
        {
            return oMCliente.QuitarTarjeta_Int_Cliente(oBECli, oBETarj);
        }

        public bool QuitarTarjeta_Nac_Cliente(BECliente oBECli, BETarjetaNacional oBETarj)
        {
            return oMCliente.QuitarTarjeta_Nac_Cliente(oBECli, oBETarj);
        }
    }
}
