
namespace BackEndBalanceMasasOrganico.Models.ContentResponse
{
    public class ConsumoProveedorResponse
    {
        //public int lote_madre {  get; set; }
        public long NRO { get; set; }
        public string? NOMBRE { get; set; }
        public decimal? KG { get; set; }
        public decimal? PORCENTAJE { get; set; }
    }

    public class LotexProveedor
    {
        public string? lote { get; set;}
        public decimal cantidad { get; set; }
        public decimal porcentaje { get; set;}
    }

    public class ConsumoProveedorCompleto
    {
        public string? fecha { get; set; }
        public string? bodega { get; set; }
        public string? articulo { get; set; }
        public string? desc_articulo { get; set; }
        public decimal? cantidad { get; set; }
        public string? consecutivo { get; set; }
        public string? desc_consecutivo { get; set; }
        public string? aplicacion { get; set; }
        public string? referencia { get; set; }
        public string? proveedor { get; set; }
        public string? descripcion_articulo { get; set; }
        public string? lote { get; set; }
    }

    public class FibraReutilizable
    {
        public string? fecha { get; set; }
        public string? lote_madre { get; set; }
        public string? lote_hijo { get; set; }
        public string? bodega { get; set; }
        public string? articulo { get; set; }
        public string? descripcion { get; set; }
        public decimal cantidad { get; set; }
        public string? consecutivo { get; set; }
        public string? desc_consecutivo { get; set; }
        public string? referencia { get; set; }
        public string? observacion { get; set; }
    }

    public class FibraReutilizableXArticulo
    {
        public string? articulo { get; set; }
        public string? descripcion { get; set; }
        public decimal cantidad { get; set; }
    }

    public class PeriodoProduccion
    {
        public string? fecha_inicio { get; set; }
        public string? fecha_fin { get; set; }
    }
}
