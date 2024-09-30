namespace BackEndBalanceMasasOrganico.Models.ContentResponse
{
    public class SubProductoConceptoResponse
    {
        public string? articulo { get; set; }
        public string? descripcion {  get; set; }
        public decimal cantidad {  get; set; }
    }

    public class SubProductoDetalle
    {
        public string? fecha {  get; set; }
        public string? lote_hijo {  get; set; }
        public string? articulo { get; set; }
        public string? descripcion { get; set; }
        public decimal cantidad { get; set; }
    }
}
