namespace BackEndBalanceMasasOrganico.Models.ContentResponse
{
    public class ConsumoProveedorDetalleResponse
    {
        public DateTime? fecha_embarque {  get; set; }
        public string? embarque {  get; set; }
        public string? orden_compra {  get; set; }
        public string? guia_remision {  get; set; }
        public string? articulo {  get; set; }
        public decimal? cantidad_recibida_oc { get; set; }
        public decimal? cantidad_consumida { get; set; }
    }
}
