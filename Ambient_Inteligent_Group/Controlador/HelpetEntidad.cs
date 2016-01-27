using Ambient_Inteligent_Group.Dao;
using Ambient_Inteligent_Group.Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Controlador
{
    public class HelpetEntidad
    {
        public static Sede ContruccionSede(List<Object> sedeLista,String almacenamiento) {
            Sede sede = new Sede();
            if (almacenamiento == "Guardar")
            {
                sede.Nombre = ((String)sedeLista[0]);
                sede.Edificio = ((String)sedeLista[1]);
                sede.Salon = ((String)sedeLista[2]);
            }else {           
                sede.IdSede = ((int)sedeLista[0]);
                sede.Nombre = ((String)sedeLista[1]);
                sede.Edificio = ((String)sedeLista[2]);
                sede.Salon = ((String)sedeLista[3]);
            }
            return sede;
        }

        public static Area ContruccionArea(List<Object> areaLista, String almacenamiento)
        {
            Area area = new Area();
            if (almacenamiento == "Guardar")
            {
                area.Descripcion = ((String)areaLista[0]);
            }
            else
            {
                area.IdArea = ((int)areaLista[0]);
                area.Descripcion = ((String)areaLista[1]);
            }
            return area;
        }


        public static Periodo ContruccionPeriodo(List<Object> periodoLista, String almacenamiento)
        {
            Periodo periodo = new Periodo();
            if (almacenamiento == "Guardar")
            {
                periodo.Anio= ((String)periodoLista[0]);
            }
            else
            {
                periodo.IdPeriodo = ((int)periodoLista[0]);
                periodo.Anio = ((String)periodoLista[1]);
            }
            return periodo;
        }

        public static Universidad ContruccionUniversidad(List<Object> universidadLista, String almacenamiento)
        {
            Universidad universidad = new Universidad();
            if (almacenamiento == "Guardar")
            {
                universidad.NombreUniversidad =  ((String)universidadLista[0]);
                universidad.SetAbreviacion(((String)universidadLista[1]));
            }
            else
            {
                universidad.IdUniversidad = ((int)universidadLista[0]);
                universidad.NombreUniversidad = ((String)universidadLista[1]);
                universidad.SetAbreviacion(((String)universidadLista[2]));
            }
            return universidad;
        }

        public static Tipo_Socio ContruccionTipo_Socio(List<Object> tipo_SocioLista, String almacenamiento)
        {
            Tipo_Socio tipo_Socio = new Tipo_Socio();
            if (almacenamiento == "Guardar")
            {
                tipo_Socio.Descripcion = ((String)tipo_SocioLista[0]);
            }
            else
            {
                tipo_Socio.IdTipo_Socio = ((int)tipo_SocioLista[0]);
                tipo_Socio.Descripcion = ((String)tipo_SocioLista[1]);
            }
            return tipo_Socio;
        }

        public static Escolaridad ContruccionEscolaridad(List<Object> escolaridadLista, String almacenamiento)
        {
            Escolaridad escolaridad = new Escolaridad();
            if (almacenamiento == "Guardar")
            {
                escolaridad.Descripcion = ((String)escolaridadLista[0]);
            }
            else
            {
                escolaridad.IdEscolaridad = ((int)escolaridadLista[0]);
                escolaridad.Descripcion = ((String)escolaridadLista[1]);
            }
            return escolaridad;
        }

        public static ProgramaEducativo ContruccionProgramaEducativo(List<Object> programaEduLista, String almacenamiento)
        {
            ProgramaEducativo programaEducativo = new ProgramaEducativo();
            if (almacenamiento == "Guardar")
            {
                programaEducativo.Descripcion = ((String)programaEduLista[0]);
            }
            else
            {
                programaEducativo.IdPrograma_Educativo = ((int)programaEduLista[0]);
                programaEducativo.Descripcion = ((String)programaEduLista[1]);
            }
            return programaEducativo;
        }


        public static Platica ContruccionPlatica(List<Object> platicaLista, String almacenamiento)
        {
            Platica platica = new Platica();
            if (almacenamiento == "Guardar")
            {
                platica.Fecha = ((DateTime)platicaLista[0]);
                Console.WriteLine(platica.Fecha);
                platica.Nombre_Platica = ((String)platicaLista[1]);
                platica.SetId_Sede(((int)platicaLista[2]));
                platica.Nombre_Evento = ((String)platicaLista[3]);
                platica.Abreviacion_Evento = ((String)platicaLista[4]);
            }
            else
            {
                platica.IdPlatica = ((int)platicaLista[0]);
                platica.Fecha = ((DateTime)platicaLista[1]);
                platica.Nombre_Platica = ((String)platicaLista[2]);
                platica.SetId_Sede(((int)platicaLista[3]));
                platica.Nombre_Evento = ((String)platicaLista[4]);
                platica.Abreviacion_Evento = ((String)platicaLista[5]);
            }
            return platica;
        }

        public static Asociacion ContruccionAsociacion(List<Object> asociacionLista, String almacenamiento)
        {
            Asociacion asociacion = new Asociacion();
            if (almacenamiento == "Guardar")
            {
                
                asociacion.Descripcion = ((String)asociacionLista[0]);
                asociacion.Link = ((String)asociacionLista[1]);
                byte[] img = ((MemoryStream)asociacionLista[2]).ToArray();
                asociacion.SetImangen(img);
            }
            else
            {
                
                asociacion.IdAsociacion = ((int)asociacionLista[0]);
                asociacion.Descripcion = ((String)asociacionLista[1]);
                asociacion.Link = ((String)asociacionLista[2]);
                byte[] img = ((MemoryStream)asociacionLista[3]).ToArray();
                asociacion.SetImangen(img);
            }
            return asociacion;
        }

        public static Persona ContruccionPersona(List<Object> personaLista, String almacenamiento)
        {
            Persona persona = new Persona();
            if (almacenamiento == "Guardar")
            {
                persona.NombreCompleto = (String) personaLista[0];
                persona.ApellidoPaterno = (String)personaLista[1];
                persona.ApellidoMaterno = (String)personaLista[2];
                persona.SetIdEscolaridad((int)personaLista[3]);
                persona.Sexo = (char)personaLista[4];
            }
            else
            {
                persona.IdPersona = (int)personaLista[0];
                persona.NombreCompleto = (String)personaLista[1];
                persona.ApellidoPaterno = (String)personaLista[2];
                persona.ApellidoMaterno = (String)personaLista[3];
                persona.SetIdEscolaridad((int)personaLista[4]);
                persona.Sexo = (char)personaLista[5];
            }
            return persona;
        }



        public static List<Object> DescomponerObjetos(MySqlDataReader mySqlDataReader,String tabla)
        {
            if (tabla == "Sede") {
                return DescomponerSedes(mySqlDataReader);
            }else if(tabla == "Universidad"){
                return DescomponerUniversidades(mySqlDataReader);
            }else if (tabla == "Area") {
                return DescomponerAreas(mySqlDataReader);
            }else if(tabla == "Periodo"){
                return DescomponerPeriodos(mySqlDataReader);
            }else if (tabla == "Tipo_Socio") {
                return DescomponerTipo_Socios(mySqlDataReader);
            }else if (tabla == "Escolaridad"){
                return DescomponerEscolaridades(mySqlDataReader);
            }else if(tabla == "Programa_Educativo"){
                return DescomponerProgramaEducativos(mySqlDataReader);
            }else if (tabla == "Asociacion"){
                return DescomponerAsociaciones(mySqlDataReader);
            }else if (tabla == "Platica") {
                return DescomponerPlaticas(mySqlDataReader);
            }else if (tabla == "Persona") {
                return DescomponerPersonas(mySqlDataReader);
            }
            return null;
        }

        private static List<Object> DescomponerSedes(MySqlDataReader sedeBD){
            List<Object> listaSede = new List<Object>();
            while(sedeBD.Read()){
                Sede sede = new Sede();
                sede.IdSede = sedeBD.GetInt32(0);
                sede.Nombre = sedeBD.GetString(1);
                if (sedeBD.IsDBNull(2))
                {
                    sede.Edificio = "";
                }
                else
                {
                    sede.Edificio = sedeBD.GetString(2);
                }

                if (sedeBD.IsDBNull(3))
                {
                    sede.Salon = "";
                }
                else
                {
                    sede.Salon = sedeBD.GetString(3);
                }
                listaSede.Add(sede);
            }
            return listaSede;
        }


        private static List<Object> DescomponerUniversidades(MySqlDataReader universidadBD)
        {
            List<Object> listaUniversidad = new List<Object>();
            while (universidadBD.Read())
            {
                Universidad universidad = new Universidad();
                universidad.IdUniversidad = universidadBD.GetInt32(0);
                universidad.NombreUniversidad = universidadBD.GetString(1);
                universidad.SetAbreviacion(universidadBD.GetString(2));
                listaUniversidad.Add(universidad);
            }
            return listaUniversidad;
        }

        private static List<Object> DescomponerAreas(MySqlDataReader areaBD)
        {
            List<Object> listaArea = new List<Object>();
            while (areaBD.Read())
            {
                Area area = new Area();
                area.IdArea = areaBD.GetInt32(0);
                area.Descripcion = areaBD.GetString(1);
                listaArea.Add(area);
            }
            return listaArea;
        }

        private static List<Object> DescomponerTipo_Socios(MySqlDataReader tipo_SocioBD)
        {
            List<Object> listaTipo_Socio= new List<Object>();
            while (tipo_SocioBD.Read())
            {
                Tipo_Socio tipo_Socio = new Tipo_Socio();
                tipo_Socio.IdTipo_Socio = tipo_SocioBD.GetInt32(0);
                tipo_Socio.Descripcion = tipo_SocioBD.GetString(1);
                listaTipo_Socio.Add(tipo_Socio);
            }
            return listaTipo_Socio;
        }

        private static List<Object> DescomponerPeriodos(MySqlDataReader periodoBD)
        {
            List<Object> listaPeriodo = new List<Object>();
            while (periodoBD.Read())
            {
                Periodo periodo = new Periodo();
                periodo.IdPeriodo = periodoBD.GetInt32(0);
                periodo.Anio = periodoBD.GetString(1);
                listaPeriodo.Add(periodo);
            }
            return listaPeriodo;
        }

        private static List<Object> DescomponerEscolaridades(MySqlDataReader escolaridadBD)
        {
            List<Object> listaEscolaridad = new List<Object>();
            while (escolaridadBD.Read())
            {
                Escolaridad escolaridad = new Escolaridad();
                escolaridad.IdEscolaridad = escolaridadBD.GetInt32(0);
                escolaridad.Descripcion = escolaridadBD.GetString(1);
                listaEscolaridad.Add(escolaridad);
            }
            return listaEscolaridad;
        }

        private static List<Object> DescomponerProgramaEducativos(MySqlDataReader programaBD)
        {
            List<Object> listaPrograma = new List<Object>();
            while (programaBD.Read())
            {
                ProgramaEducativo programaEducativo = new ProgramaEducativo();
                programaEducativo.IdPrograma_Educativo = programaBD.GetInt32(0);
                programaEducativo.Descripcion = programaBD.GetString(1);
                listaPrograma.Add(programaEducativo);
            }
            return listaPrograma;
        }




        private static List<Object> DescomponerAsociaciones(MySqlDataReader asociacionBD)
        {
            List<Object> listaAsociacion = new List<Object>();
            while (asociacionBD.Read())
            { 
                Asociacion asociacion = new Asociacion();
                asociacion.IdAsociacion = asociacionBD.GetInt32(0);
                asociacion.Descripcion = asociacionBD.GetString(1);

                if (asociacionBD.IsDBNull(2))
                {
                    asociacion.Link = "";
                }
                else {
                    asociacion.Link = asociacionBD.GetString(2);
                }
                listaAsociacion.Add(asociacion);
            }
            return listaAsociacion;
        }

        private static List<Object> DescomponerPlaticas(MySqlDataReader platicaBD)
        {
            List<Object> listaPlatica = new List<Object>();
            while (platicaBD.Read())
            {
                Platica platica = new Platica();
                platica.IdPlatica = platicaBD.GetInt32(0);
                platica.Fecha = platicaBD.GetDateTime(1);
                platica.Nombre_Platica = platicaBD.GetString(2);
                if (platicaBD.GetString(4) == null || platicaBD.IsDBNull(4))
                {
                    platica.Nombre_Evento = "";
                }
                else {
                    platica.Nombre_Evento = platicaBD.GetString(4);
                }
                if (platicaBD.GetString(5) == null || platicaBD.IsDBNull(5))
                {
                    platica.Abreviacion_Evento = "";
                }
                else
                {
                    platica.Abreviacion_Evento = platicaBD.GetString(5);
                }
                listaPlatica.Add(platica);
            }
            return listaPlatica;
        }

        private static List<Object> DescomponerPersonas(MySqlDataReader personaBD)
        {
            List<Object> listaPersona = new List<Object>();
            while (personaBD.Read())
            {
                Persona persona = new Persona();
                persona.IdPersona = personaBD.GetInt32(0);
                persona.NombreCompleto = personaBD.GetString(1);
                persona.ApellidoPaterno = personaBD.GetString(2);
                if (personaBD.IsDBNull(3))
                {
                    persona.ApellidoMaterno = "";
                }
                else {
                    persona.ApellidoMaterno = personaBD.GetString(3);
                }
                if (personaBD.IsDBNull(5))
                {
                    persona.Sexo = ' ';
                }
                else
                {
                    persona.Sexo = personaBD.GetChar(5);
                }


                listaPersona.Add(persona);
            }
            return listaPersona;
        }

        public static List<Object> DescomponerObjeto(MySqlDataReader mySqlDataReader, String tabla)
        {
            if (tabla == "Sede") {
                return DescomponerSede(mySqlDataReader);
            }else if(tabla == "Universidad"){
                return DescomponerUniversidad(mySqlDataReader);
            }else if (tabla == "Area") {
                return DescomponerArea(mySqlDataReader);
            }else if (tabla == "Periodo") {
                return DescomponerPeriodo(mySqlDataReader);
            }else if(tabla == "Tipo_Socio"){
                return DescomponerTipo_Socio(mySqlDataReader);
            }else if (tabla == "Escolaridad"){
                return DescomponerEscolaridad(mySqlDataReader);
            }else if (tabla == "Programa_Educativo"){
                return DescomponerProgramaEducativo(mySqlDataReader);
            }else if (tabla == "Platica") {
                return DescomponerPlatica(mySqlDataReader);
            }
            return null;
        }

        public static List<Object> DescomponerSede(MySqlDataReader sedeBD) { 
            List<Object> listaSede = new List<Object>();
            while (sedeBD.Read())
            {
                listaSede.Add(sedeBD.GetInt32(0));
                listaSede.Add(sedeBD.GetString(1));
                if (sedeBD.IsDBNull(2))
                {
                    listaSede.Add("");
                }
                else
                {
                    listaSede.Add(sedeBD.GetString(2));
                }

                if (sedeBD.IsDBNull(3))
                {
                    listaSede.Add("");
                }
                else
                {
                    listaSede.Add(sedeBD.GetString(3));
                }        
            }
            return listaSede;
        }


        public static List<Object> DescomponerUniversidad(MySqlDataReader universidadBD)
        {
            List<Object> listaUniversidad = new List<Object>();
            while (universidadBD.Read())
            {
                listaUniversidad.Add(universidadBD.GetInt32(0));
                listaUniversidad.Add(universidadBD.GetString(1));
                listaUniversidad.Add(universidadBD.GetString(2));
            }
            return listaUniversidad;
        }

        public static List<Object> DescomponerArea(MySqlDataReader areaBD)
        {
            List<Object> listaArea = new List<Object>();
            while (areaBD.Read())
            {
                listaArea.Add(areaBD.GetInt32(0));
                listaArea.Add(areaBD.GetString(1));
            }
            return listaArea;
        }

        public static List<Object> DescomponerEscolaridad(MySqlDataReader escolaridadBD)
        {
            List<Object> listaEscolaridad = new List<Object>();
            while (escolaridadBD.Read())
            {
                listaEscolaridad.Add(escolaridadBD.GetInt32(0));
                listaEscolaridad.Add(escolaridadBD.GetString(1));
            }
            return listaEscolaridad;
        }

        public static List<Object> DescomponerTipo_Socio(MySqlDataReader tipo_SocioBD)
        {
            List<Object> listaTipo_Socio = new List<Object>();
            while (tipo_SocioBD.Read())
            {
                listaTipo_Socio.Add(tipo_SocioBD.GetInt32(0));
                listaTipo_Socio.Add(tipo_SocioBD.GetString(1));
            }
            return listaTipo_Socio;
        }

        public static List<Object> DescomponerPeriodo(MySqlDataReader periodoBD)
        {
            List<Object> listaPeriodo = new List<Object>();
            while (periodoBD.Read())
            {
                listaPeriodo.Add(periodoBD.GetInt32(0));
                listaPeriodo.Add(periodoBD.GetString(1));
            }
            return listaPeriodo;
        }

        public static List<Object> DescomponerProgramaEducativo(MySqlDataReader programaEducativoBD)
        {
            List<Object> listaPrograma = new List<Object>();
            while (programaEducativoBD.Read())
            {
                listaPrograma.Add(programaEducativoBD.GetInt32(0));
                listaPrograma.Add(programaEducativoBD.GetString(1));
            }
            return listaPrograma;
        }



        private static List<Object> DescomponerPlatica(MySqlDataReader platicaBD)
        {
            List<Object> listaPlatica = new List<Object>();
            while (platicaBD.Read())
            {
                listaPlatica.Add(platicaBD.GetInt32(0));
                listaPlatica.Add(platicaBD.GetDateTime(1));
                listaPlatica.Add(platicaBD.GetString(2));
                listaPlatica.Add(platicaBD.GetInt32(3));
                if (platicaBD.GetString(4) == null || platicaBD.IsDBNull(4))
                {
                    listaPlatica.Add("");
                }
                else
                {
                    listaPlatica.Add(platicaBD.GetString(4));
                }
                if (platicaBD.GetString(5) == null || platicaBD.IsDBNull(5))
                {
                    listaPlatica.Add("");
                }
                else
                {
                    listaPlatica.Add(platicaBD.GetString(5));
                }
            }
            return listaPlatica;
        }




        public static List<Object> DescomponerObjeto(MySqlDataAdapter mySqlDataAdapter, String tabla)
        {
            if (tabla == "Asociacion")
            {
                return DescomponerAsociacion(mySqlDataAdapter);
            }
            return null;
        }

        public static List<Object> DescomponerAsociacion(MySqlDataAdapter asociacionBD)
        {
            List<Object> listaAsociacion = new List<Object>();
            DataTable dt = new DataTable();
            asociacionBD.Fill(dt);
            listaAsociacion.Add(Int32.Parse(dt.Rows[0][0].ToString()));
            listaAsociacion.Add(dt.Rows[0][1].ToString());
            if (dt.Rows[0][2].ToString() == "" || dt.Rows[0][2] == null)
            {
                listaAsociacion.Add("");
            }else{
                listaAsociacion.Add(dt.Rows[0][2].ToString());
            }
            Console.Write(dt.Rows[0][3].ToString());
            if(dt.Rows[0][3].ToString()==""){
                listaAsociacion.Add(null);
            }else{
                listaAsociacion.Add((byte[]) dt.Rows[0][3]);
            }
            asociacionBD.Dispose();
            return listaAsociacion;
        }

    }
}