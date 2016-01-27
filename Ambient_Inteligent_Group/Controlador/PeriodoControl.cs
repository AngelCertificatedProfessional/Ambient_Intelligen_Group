using Ambient_Inteligent_Group.Delegate;
using Ambient_Inteligent_Group.Entidad;
using Ambient_Inteligent_Group.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Controlador
{
    public class PeriodoControl : BaseControl
    {

        public PeriodoControl(InterfaceComunicador comunicador, Type clazz)
            : base(comunicador, clazz)
        {
            ;
        }

        public void BuscarPeriodo(String nombrePeriodo, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(PeriodoDelegate.BuscarPeriodo(nombrePeriodo), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void ModificarPeriodo(Periodo periodo)
        {
            Boolean resultado;
            resultado = PeriodoDelegate.ModificarPeriodo(periodo);
            if (resultado == true)
            {
                com.setMensaje("La modificacion fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro la modificacion");
            }
        }

        public void GuardarPeriodo(Periodo periodo)
        {
            Boolean resultado;
            resultado = PeriodoDelegate.GuardarPeriodo(periodo);
            if (resultado == true)
            {
                com.setMensaje("El registro fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro el registro");
            }

        }
    }
}
