using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AccesoDatos
{
    public class DVentas
    {
        LienzosEntities db = new LienzosEntities();
        EBitacora_Movimientos Entidad_Movimientos = new EBitacora_Movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();

        #region Agregar
        public int Agregar(EVentas obj, List<EVentas_Detalles> objlista, int IdUsuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    Tab_Venta Objbd = new Tab_Venta();
                    Objbd.ID_Cliente = obj.ID_Cliente;
                    Objbd.Total = obj.Total;
                    Objbd.Fecha_venta = obj.Fecha_venta;
                    Objbd.ID_Usuario = obj.ID_Usuario;
                    Objbd.Tipo_pago = obj.Tipo_pago;
                    db.Entry(Objbd).State = EntityState.Added;
                    //db.Tab_Devoluciones.Add(Objbd);

                    int Resultado = db.SaveChanges();

                    int IdVenta = Objbd.Numero_factura;

                    var Ventas_Anteriores = db.Tab_Venta_detallada.Where(x => x.Numero_factura == IdVenta).ToList();
                    if (Ventas_Anteriores.Count > 0)
                    {
                        db.Tab_Venta_detallada.RemoveRange(Ventas_Anteriores);
                    }
                    if (objlista.Count > 0)
                    {
                        foreach (var Item in objlista)
                        {
                            Tab_Venta_detallada Objbddetalle = new Tab_Venta_detallada();
                            Objbddetalle.ID_Producto = Item.ID_Producto;
                            Objbddetalle.Numero_factura = IdVenta;
                            Objbddetalle.Linea = Item.Linea;
                            db.Entry(Objbddetalle).State = EntityState.Added;
                        }
                        //string Objason = JsonConvert.SerializeObject(obj);
                        //List<Tab_Ventas_Detalles> Objguardar = JsonConvert.DeserializeObject<List<Tab_Ventas_Detalles>>(Objason);
                        //db.Tab_Ventas_Detalles.AddRange(Objguardar);
                    }
                    int ResultaDetalle = db.SaveChanges();
                    if (Resultado > 0 && ResultaDetalle > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = IdUsuario;
                        Entidad_Movimientos.modulo = "Ventas";
                        Entidad_Movimientos.tipo_movimiento = "Agregar";
                        Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        Movimientos.Agregar(Entidad_Movimientos);
                        return IdVenta;
                    }
                    else
                    {
                        Ts.Dispose();
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Afectar inventario
        public int Afectar_Inventario(int Id_Producto)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Tab_Productos.Where(x => x.ID_Producto == Id_Producto).FirstOrDefault();
                    Objbd.Cantidad = Objbd.Cantidad - 1;
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        return Resultado;
                    }
                    Ts.Dispose();
                    return Resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eliminar
        public int Eliminar(int ID)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Ventas_Anteriores = db.Tab_Venta_detallada.Where(x => x.Numero_factura == ID).ToList();
                    if (Ventas_Anteriores.Count > 0)
                    {
                        db.Tab_Venta_detallada.RemoveRange(Ventas_Anteriores);
                    }
                    var Objbd = db.Tab_Venta.Where(x => x.Numero_factura == ID).FirstOrDefault();
                    db.Entry(Objbd).State = EntityState.Deleted;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        return Resultado;
                    }
                    Ts.Dispose();
                    return Resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar Varios
        public List<EVentas> Mostrar()
        {
            try
            {
                List<EVentas> Lista = new List<EVentas>();
                var Objbd = db.Tab_Venta.ToList();
                // var Devoluciones = db.Tab_Devoluciones.ToList();
                foreach (var Item in Objbd)
                {
                    Lista.Add(new EVentas()
                    {
                        ID_Cliente = Item.ID_Cliente,
                        Total = Item.Total,
                        Fecha_venta = Item.Fecha_venta,
                        ID_Usuario = Item.ID_Usuario,
                        Tipo_pago = Item.Tipo_pago,
                        Numero_factura = Item.Numero_factura
                    });
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
