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
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.EMPLEADO = new HashSet<EMPLEADO>();
            this.PROVEEDOR = new HashSet<PROVEEDOR>();
            this.TRABAJADOR = new HashSet<TRABAJADOR>();
        }
    
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string CONTRASENA { get; set; }
        public int TIPO_USUARIO_ID { get; set; }
    
        public virtual ICollection<EMPLEADO> EMPLEADO { get; set; }
        public virtual ICollection<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
        public virtual ICollection<TRABAJADOR> TRABAJADOR { get; set; }
    }
}
