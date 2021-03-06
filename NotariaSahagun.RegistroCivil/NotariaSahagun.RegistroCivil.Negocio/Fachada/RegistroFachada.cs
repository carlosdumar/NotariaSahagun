﻿//-----------------------------------------------------------------------
// <copyright file="RegistroFachada.cs" company="Notaria Sahagun">
//     Copyright (c) Notaria Sahagun. All rights reserved.
// </copyright>
// <author>Carlos Andrés Rodriguez</author>
//-----------------------------------------------------------------------

namespace NotariaSahagun.RegistroCivil.Negocio.Fachada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NotariaSahagun.RegistroCivil.Soporte;
    using NotariaSahagun.RegistroCivil.Negocio.Controladoras;
    using NotariaSahagun.RegistroCivil.Soporte.Entidades;

    public class RegistroFachada
    {
        /// <summary>
        /// Permite ingresar un registro civil.
        /// </summary>
        /// <param name="primerApellido">Primer Apellido de la persona registrada.</param>
        /// <param name="segundoApellido">Segundo apellido de la persona registrada.</param>
        /// <param name="primerNombre">Primer Nombre de la persona registrada.</param>
        /// <param name="segundoNombre">Segundo Nombre de la persona registrada.</param>
        /// <param name="ano">Año en el cual se registro la persona.</param>
        /// <param name="indSerial">Numero serial con el cual fue registrada la persona.</param>
        /// <returns>Nuevo registro.</returns>
        public static bool IngresarRegistro(string primerApellido, string segundoApellido, string primerNombre, string segundoNombre, int ano, int indSerial)
        {
            return RegistroControladora.IngresarRegistro(primerApellido, segundoApellido, primerNombre, segundoNombre, ano, indSerial);
        }
        /// <summary>
        /// Permite consultar registros civiles.
        /// </summary>
        /// <param name="primerApellido">Primer Apellido de la persona registrada.</param>
        /// <param name="primerNombre">Primer Nombre de la persona registrada.</param>
        /// <param name="indSerial">Numero serial con el cual fue registrada la persona.</param>
        /// <returns>Registros civiles.</returns>
        public static List<Registro> ConsultarRegistro(string primerApellido, string primerNombre, int indSerial)
        {
            return RegistroControladora.ConsultarRegistro(primerApellido, primerNombre, indSerial);
        }
        /// <summary>
        /// Permite consultar registros civiles.
        /// </summary>
        /// <param name="indSerial">Numero serial con el cual fue registrada la persona.</param>
        /// <returns>Registros civiles.</returns>
        public static List<Registro> ConsultarRegistroConSerial(int indSerial)
        {
            return RegistroControladora.ConsultarRegistroConSerial(indSerial);
        }
        /// <summary>
        /// Permite consultar registros civiles.
        /// </summary>
        /// <param name="primerApellido">Primer Apellido de la persona registrada.</param>
        /// <param name="primerNombre">Primer Nombre de la persona registrada.</param>
        /// <returns>Registros civiles.</returns>
        public static List<Registro> ConsultarRegistroConNombres(string primerApellido, string primerNombre)
        {
            return RegistroControladora.ConsultarRegistroConNombres(primerApellido, primerNombre);
        }
    }
}
