namespace BackEndBalanceMasasOrganico.Models.ContentBody
{
    public class FibraDetalleBody
    {
        public int id { get; set; }
        public string? fecha_embarque { get; set; }
        public string? lote_madre { get; set; }
        public string? embarque { get; set; }
        public string? orden_compra { get; set; }
        public string? guia_remision { get; set; }
        public string? articulo { get; set; }
        public decimal? cantidad { get; set; }
        public decimal? cantidad_recibida_oc { get; set; }
        public decimal? cantidad_consumida { get; set; }
    }
}
