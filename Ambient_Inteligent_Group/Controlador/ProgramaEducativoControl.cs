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
    public class ProgramaEducativoControl : BaseControl
    {
        public ProgramaEducativoControl(InterfaceComunicador comunicador, Type clazz)
            : base(comunicador, clazz)
        {
            ;
        }

        public void BuscarDescripcion(String nombrePrograma, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(ProgramaEducativoDelegate.BuscarDescripcion(nombrePrograma), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void ModificarPrograma(ProgramaEducativo programa)
        {
            Boolean resultado;
            resultado = ProgramaEducativoDelegate.ModificarPrograma(programa);
            if (resultado == true)
            {
                com.setMensaje("La modificacion fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro la modificacion");
            }
        }

        public void GuardarPrograma(ProgramaEducativo programa)
        {
            Boolean resultado;
            resultado = ProgramaEducativoDelegate.GuardarPrograma(programa);
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
