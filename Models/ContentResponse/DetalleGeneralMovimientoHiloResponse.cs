namespace BackEndBalanceMasasOrganico.Models.ContentResponse
{
    public class DetalleGeneralMovimientoHiloResponse
    {
        public string? lote { get; set; }
        public decimal ingresos { get; set; }
        public decimal salidas { get; set; }
        public decimal stock_actual { get; set; }
    }
}
