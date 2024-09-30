namespace BackEndBalanceMasasOrganico.Models.ContentResponse
{
    public class ProductoProcesoResponse
    {
        public string? lote_hijo { get; set; }
        public string? fecha { get; set; }
        public string? articulo { get; set; }
        public string? descripcion { get; set; }
        public decimal cantidad { get; set; }
    }

    public class DetalleProductoProcesoTodos
    {
        public string? fecha { get; set; }
        public string? lote_madre { get; set; }
        public string? lote_hijo { get; set; }
        public string? bodega { get; set; }
        public string? articulo { get; set; }
        public string? desc_articulo { get; set; }
        public string? tipo { get; set; }
        public string? naturaleza { get; set; }
        public string? descripcion_articulo { get; set; }
        public decimal cantidad { get; set; }
        public string? consecutivo { get; set; }
        public string? desc_consecutivo { get; set; }
        public string? aplicacion { get; set; }
        public string? referencia { get; set; }
    }
}
