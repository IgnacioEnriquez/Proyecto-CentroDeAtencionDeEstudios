using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    interface IArchivos <T>        
        where T : class
    {
        /// <summary>
        /// Metodo para guardar datos en un archivo
        /// </summary>
        /// <param name="path"> Direccion de donde se quiere guardar el archivo</param>
        /// <param name="tipoDeArchivo"> Tipo de Archivo que se quiere guardar</param>
        void Guardar(string path, T tipoDeArchivo);

        /// <summary>
        /// Metodo para Leer datos de un archivo
        /// </summary>
        /// <param name="path">Direccion de donde se quiere leer el archivo</param>
        /// <returns></returns>
        int Leer(string path);


    }
}
