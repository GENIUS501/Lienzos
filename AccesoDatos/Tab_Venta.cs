//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tab_Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tab_Venta()
        {
            this.Tab_Venta_detallada = new HashSet<Tab_Venta_detallada>();
        }
    
        public int ID_Usuario { get; set; }
        public int ID_Cliente { get; set; }
        public string Tipo_pago { get; set; }
        public int Numero_factura { get; set; }
        public System.DateTime Fecha_venta { get; set; }
        public double Total { get; set; }
    
        public virtual Tab_Clientes Tab_Clientes { get; set; }
        public virtual Tab_Usuarios Tab_Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tab_Venta_detallada> Tab_Venta_detallada { get; set; }
    }
}