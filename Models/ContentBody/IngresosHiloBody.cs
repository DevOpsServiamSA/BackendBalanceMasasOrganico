namespace BackEndBalanceMasasOrganico.Models.ContentBody
{
    public class IngresosHiloBody
    {
        public int id { get; set; }
        public string? lote_madre { get; set; }
        public string? articulo { get; set; }
        public string? descripcion { get; set; }
        public string? unidad_almacen { get; set; }
        public string? alias_produccion { get; set; }
        public string? desc_alias { get; set; }
        public string? fecha { get; set; }
        public string? aplicacion { get; set; }
        public string? naturaleza { get; set; }
        public string? operacion { get; set; }
        public string? bodega { get; set; }
        public string? localizacion { get; set; }
        public string? lote { get; set; }
        public string? color { get; set; }
        public string? unidad_medida { get; set; }
        public decimal? entrada { get; set; }
        public decimal? salida { get; set; }
        public string? referencia { get; set; }
        public string? guia_remision { get; set; }
        public string? orden_servicio { get; set; }
        public string? audit_trans_inv { get; set; }
    }

    public class KardexFibra
    {
        public int id { get; set; }
        public string? articulo { get; set; }
        public string? descripcion { get; set; }
        public string? fecha { get; set; }
        public string? documento { get; set; }
        public string? bodega { get; set; }
        public string? lote { get; set; }
        public string? color { get; set; }
        public string? unidad_medida { get; set; }
        public decimal? entrada { get; set; }
        public decimal? salida { get; set; }
        public decimal? saldo { get; set; }
        public decimal? saldo_tc { get; set; }
        public string? tc { get; set; }
        public string? guia { get; set; }
        public string? fac { get; set; }
        public string? lote_madre { get; set; }
    }

    public class KardexCinta
    {
        public int id { get; set; }
        public string? lote_madre { get; set; }
        public string? articulo { get; set; }
        public string? descripcion { get; set; }
        public string? fecha { get; set; }
        public string? documento { get; set; }
        public string? naturaleza { get; set; }
        public string? operacion { get; set; }
        public string? bodega { get; set; }
        public string? lote { get; set; }
        public string? color { get; set; }
        public string? unidad_medida { get; set; }
        public decimal? entrada { get; set; }
        public decimal? salida { get; set; }
        public decimal? saldo{ get; set; }
        public string? documento_venta { get; set; }
        public string? cliente { get; set; }
        public string? orden_compra { get; set; }
        public string? referencia { get; set; }
        public string? programa { get; set; }
        public string? guia_remision { get; set; }
        public string? orden_servicio { get; set; }
        public string? doc_referencia { get; set; }
        public string? trans_inv { get; set; }
        public string? consecutivo { get; set; }
        public string? localizacion { get; set; }
        public string? art_nombre { get; set; }
    }
}
