//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostalWeb.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_PRODUCTO
    {
        public int ID_TIPO { get; set; }
        public string NOMBRE_TIPO { get; set; }
        public int ID_STOCK { get; set; }
    
        public virtual STOCK STOCK { get; set; }
    }
}
