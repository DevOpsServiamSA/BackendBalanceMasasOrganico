using BackEndBalanceMasasOrganico.Models.ContentBody;
using BackEndBalanceMasasOrganico.Models.ContentResponse;
using Microsoft.EntityFrameworkCore;

namespace BackEndBalanceMasasOrganico.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options) { }
        public DbSet<ConsumoProveedorResponse> ConsumoProveedorResponse => Set<ConsumoProveedorResponse>();
        public DbSet<LotexProveedor> LotexProveedor => Set<LotexProveedor>();
        public DbSet<LoteMadreResponse> LoteMadreResponse => Set<LoteMadreResponse>();
        public DbSet<InvInicioHiloResponse> InvInicioHiloResponse => Set<InvInicioHiloResponse>();
        public DbSet<IngresosHiloResponse> IngresosHiloService => Set<IngresosHiloResponse>();

        public DbSet<SalidasHiloResponse> SalidasHiloResponse => Set<SalidasHiloResponse>();
        public DbSet<InvFinHiloResponse> InvFinHiloResponse => Set<InvFinHiloResponse>();
        public DbSet<ResumenConsumoResponse> ResumenConsumoResponse => Set<ResumenConsumoResponse>();
        public DbSet<ResumenMermaResponse> ResumenMermaResponse => Set<ResumenMermaResponse>();
        public DbSet<DetalleMovimientosHilo> DetalleMovimientosHiloResponse => Set<DetalleMovimientosHilo>();
        public DbSet<DetalleMovimientoIngresosHilo> DetalleMovimientoIngresosHiloResponse => Set<DetalleMovimientoIngresosHilo>();
        public DbSet<DetalleHiloxArticulo> DetalleHiloxArticuloResponse => Set<DetalleHiloxArticulo>();
        public DbSet<InventarioMovimientosSubproductoResponse> InventarioMovimientosSubproductoResponse => Set<InventarioMovimientosSubproductoResponse>();
        public DbSet<MovimientosSubproductoResponse> MovimientosSubproductoResponse => Set<MovimientosSubproductoResponse>();
        public DbSet<InvFinSubproductoResponse> invFinSubproductoResponse => Set<InvFinSubproductoResponse>();
        public DbSet<ResumenConsecutivoResponse> ResumenConsecutivoResponse => Set<ResumenConsecutivoResponse>();
        public DbSet<ResumenConsecutivoSalidasHiloResponse> resumenConsecutivoSalidasHiloResponse => Set<ResumenConsecutivoSalidasHiloResponse>();
        public DbSet<ConsumoProveedorDetalleResponse> consumoProveedorDetalleResponse => Set<ConsumoProveedorDetalleResponse>();
        public DbSet<DetalleGeneralMovimientoHiloResponse> detalleGeneralMovimientoHiloResponse => Set<DetalleGeneralMovimientoHiloResponse>();
        public DbSet<SubProductoConceptoResponse> subProductoConceptoResponse => Set<SubProductoConceptoResponse>();
        public DbSet<ProductoProcesoResponse> ProductoProcesoResponse => Set<ProductoProcesoResponse>();
        public DbSet<DetalleProductoProcesoTodos> DetalleProductoProcesoTodosResponse => Set<DetalleProductoProcesoTodos>();
        public DbSet<SubProductoDetalle> SubProductoDetalle => Set<SubProductoDetalle>();
        public DbSet<ConsumoProveedorCompleto> ConsumoProveedorCompleto => Set<ConsumoProveedorCompleto>();
        public DbSet<DetalleHiloxLoteHijo> DetalleHiloxLoteHijo => Set<DetalleHiloxLoteHijo>();
        public DbSet<DetalleHiloTodos> DetalleHiloTodos => Set<DetalleHiloTodos>();
        public DbSet<FibraReutilizable> FibraReutilizable => Set<FibraReutilizable>();
        public DbSet<FibraReutilizableXArticulo> FibraReutilizableXArticulo => Set<FibraReutilizableXArticulo>();
        public DbSet<PeriodoProduccion> PeriodoProduccionResponse => Set<PeriodoProduccion>();

        public DbSet<IngresosHiloBody> IngresosHiloBody => Set<IngresosHiloBody>();
        public DbSet<KardexFibra> KardexFibra => Set<KardexFibra>();
        public DbSet<KardexCinta> KardexCinta => Set<KardexCinta>();

        public DbSet<FibraDetalleBody> FibraDetalleBody => Set<FibraDetalleBody>();




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        #region Store Procedure
        modelBuilder.Entity<ConsumoProveedorResponse>().HasNoKey();
        modelBuilder.Entity<LotexProveedor>().HasNoKey();
        modelBuilder.Entity<LoteMadreResponse>().HasNoKey();
        modelBuilder.Entity<InvInicioHiloResponse>().HasNoKey();
        modelBuilder.Entity<IngresosHiloResponse>().HasNoKey();
        modelBuilder.Entity<SalidasHiloResponse>().HasNoKey();
        modelBuilder.Entity<InvFinHiloResponse>().HasNoKey();
        modelBuilder.Entity<ResumenConsumoResponse>().HasNoKey();
        modelBuilder.Entity<ResumenMermaResponse>().HasNoKey();
        modelBuilder.Entity<DetalleMovimientosHilo>().HasNoKey();
        modelBuilder.Entity<InventarioMovimientosSubproductoResponse>().HasNoKey();
        modelBuilder.Entity<MovimientosSubproductoResponse>().HasNoKey();
        modelBuilder.Entity<InvFinSubproductoResponse>().HasNoKey();
        modelBuilder.Entity<ResumenConsecutivoResponse>().HasNoKey();
        modelBuilder.Entity<ResumenConsecutivoSalidasHiloResponse>().HasNoKey();
        modelBuilder.Entity<ConsumoProveedorDetalleResponse>().HasNoKey();
        modelBuilder.Entity<DetalleGeneralMovimientoHiloResponse>().HasNoKey();
        modelBuilder.Entity<SubProductoConceptoResponse>().HasNoKey();
        modelBuilder.Entity<DetalleHiloxArticulo>().HasNoKey();
        modelBuilder.Entity<DetalleMovimientoIngresosHilo>().HasNoKey();
        modelBuilder.Entity<ProductoProcesoResponse>().HasNoKey();
        modelBuilder.Entity<SubProductoDetalle>().HasNoKey();
        modelBuilder.Entity<ConsumoProveedorCompleto>().HasNoKey();
        modelBuilder.Entity<DetalleHiloxLoteHijo>().HasNoKey();
        modelBuilder.Entity<DetalleProductoProcesoTodos>().HasNoKey();
        modelBuilder.Entity<DetalleHiloTodos>().HasNoKey();
        //nuevo
        modelBuilder.Entity<FibraReutilizable>().HasNoKey();
        modelBuilder.Entity<FibraReutilizableXArticulo>().HasNoKey();
        //periodo producicon
        modelBuilder.Entity<PeriodoProduccion>().HasNoKey();
            #endregion
        
        #region Table Transaction
        modelBuilder.Entity<IngresosHiloBody>().ToTable("XTUS_BM_ORG_DETALLE_KARDEX_HILO", "FILASUR").HasKey(x => x.id);
        modelBuilder.Entity<KardexFibra>().ToTable("XTUS_BM_ORG_DETALLE_KARDEX_FIBRA", "FILASUR").HasKey(x => x.id);
        modelBuilder.Entity<KardexCinta>().ToTable("XTUS_BM_ORG_DETALLE_KARDEX_CINTA", "FILASUR").HasKey(x => x.id);
        #endregion
        }

    }
}
