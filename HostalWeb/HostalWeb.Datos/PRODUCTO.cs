//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostalWeb.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTO
    {
        public int ID_PRODUCTO { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public System.DateTime FECHA_VENCIMIENTO { get; set; }
        public int ID_STOCK { get; set; }
        public int ID_DETALLE { get; set; }
        public int ID_MINUTA { get; set; }
    
        public virtual STOCK STOCK { get; set; }
    }
}