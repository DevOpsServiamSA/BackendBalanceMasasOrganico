namespace BackEndBalanceMasasOrganico.Models.ContentResponse
{
    public class ResumenConsecutivoSalidasHiloResponse
    {
        public string? lote_madre { get; set; }
        public string? lote_hijo { get; set; }
        public string? consecutivo { get; set; }
        public string? descripcion { get; set; }
        public decimal cantidad { get; set; }
    }
}
