namespace BackEndBalanceMasasOrganico.Models.ContentResponse
{
    public class ResumenConsecutivoResponse
    {
        public string? lote_madre {  get; set; }
        public string? consecutivo {  get; set; }
        public string? desc_consecutivo { get; set; }
        public decimal cantidad { get; set; }
    }
}
