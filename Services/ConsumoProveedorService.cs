using Microsoft.EntityFrameworkCore;
using BackEndBalanceMasasOrganico.Data;
using BackEndBalanceMasasOrganico.Models.ContentResponse;

namespace BackEndBalanceMasasOrganico.Services;

    public class ConsumoProveedorService : _BaseService
    {
        public ConsumoProveedorService(BaseContext context) : base(context) { }


    public async Task<object> GetConsumoProveedor(string lote_Madre)
    {
        try
        {
            var result = await _context.ConsumoProveedorResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_PROVEEDOR_CONSUMO {lote_Madre}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }

    public async Task<object> GetLote_x_Proveedor(string lote_Madre,string proveedor)
    {
        try
        {
            var result = await _context.LotexProveedor.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_PROVEEDOR_LOTE {lote_Madre},{proveedor}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }



    public async Task<object> GetConsumoProveedorDetalle(string lote_madre, string lote_proveedor, string proveedor)
    {
        try
        {
            var result = await _context.consumoProveedorDetalleResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_PROVEEDOR_CONSUMO_DETALLE {lote_madre},{lote_proveedor},{proveedor}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }


    public async Task<object> GetLoteMadre()
        {
            try
            {
                var result = await _context.LoteMadreResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_LT_MADRE").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetInvInicioHilo(string descripcion_lote)
        {
            try
            {
                var result = await _context.InvInicioHiloResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_INV_INI {descripcion_lote}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetIngresosHilo(string descripcion_lote)
        {
            try
            {
                var result = await _context.IngresosHiloService.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_INV_ING {descripcion_lote}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }
        public async Task<object> GetSalidasHilo(string descripcion_lote)
        {
            try
            {
                var result = await _context.SalidasHiloResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_INV_SAL {descripcion_lote}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetInvFinHilo(string descripcion_lote)
        {
            try
            {
                var result = await _context.InvFinHiloResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_INV_FIN {descripcion_lote}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetResumenConsumo(string descripcion_lote)
        {
            try
            {
                var result = await _context.ResumenConsumoResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_INV_RESUMEN {descripcion_lote}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetResumenMerma(string descripcion_lote)
        {
            try
            {
                var result = await _context.ResumenMermaResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_INV_MERMA {descripcion_lote}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetDetalleMovimientoIngresoHilo(string lote_madre, string lote_hijo, string consecutivo)
        {
            try
            {
                var result = await _context.DetalleMovimientoIngresosHiloResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_INV_ING_DET2 {lote_madre},{lote_hijo},{consecutivo}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetDetalleMovimientoSalidaHilo(string lote_madre, string lote_hijo, string consecutivo)
        {
            try
            {
                var result = await _context.DetalleMovimientoIngresosHiloResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_INV_SAL_DET2 {lote_madre},{lote_hijo},{consecutivo}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }
        public async Task<object> GetInvInicioSubproducto(string lote_madre)
        {
            try
            {
                var result = await _context.InventarioMovimientosSubproductoResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_SUBP_INV_INI {lote_madre}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetInvFinSubproducto(string lote_madre)
        {
            try
            {
                var result = await _context.invFinSubproductoResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_SUBP_INV_FIN {lote_madre}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

    public async Task<object> GetIngresoSubproducto(string lote_madre)
        {
            try
            {
                var result = await _context.MovimientosSubproductoResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_SUBP_INV_ING {lote_madre}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetSalidaSubproducto(string lote_madre)
        {
            try
            {
                var result = await _context.MovimientosSubproductoResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_SUBP_INV_SAL {lote_madre}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetResumenConsecutivo(string lote_madre, string lote_hijo)
        {
            try
            {
                var result = await _context.ResumenConsecutivoResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_INV_ING_DET1 {lote_madre},{lote_hijo}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetResumenConsecutivoSalidaHilo(string lote_madre, string lote_hijo)
        {
            try
            {
                var result = await _context.resumenConsecutivoSalidasHiloResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_INV_SAL_DET1 {lote_madre},{lote_hijo}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }
        

        public async Task<object> GetDetalleConsumoSubproducto(string lote_madre,string articulo)
        {
            try
            {
                var result = await _context.SubProductoDetalle.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_SUBPRODUCTO_DET {lote_madre},{articulo}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetDetalleGeneralMovimientoHilo(string lote_madre)
        {
            try
            {
                var result = await _context.detalleGeneralMovimientoHiloResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_DETALLE_MOVIMIENTOS_HILO {lote_madre}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetSubProductoConcepto(string lote_madre)
        {
            try
            {
                var result = await _context.subProductoConceptoResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_SUBPRODUCTO_AGRUPADO {lote_madre}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

        public async Task<object> GetSubProductoProceso_x_Articulo(string lote_madre)
        {
            try
            {
                var result = await _context.subProductoConceptoResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_PRODUCTO_PROCESO_X_ARTICULO {lote_madre}").ToListAsync();
                if (result == null) return new object[] { };
                return result;
            }
            catch (System.Exception)
            {
                return new object[] { };
            }
        }

    /*Resumen consumo - PRODUCTO EN PROCESO DETALLE POR ARTICULO*/
    public async Task<object> GetProductoProcesoDetalle_x_Articulo(string lote_madre, string articulo)
    {
        try
        {
            var result = await _context.ProductoProcesoResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_PRODUCTO_PROCESO_DETALLE_X_ARTICULO {lote_madre},{articulo}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }

    /*Resumen consumo - PRODUCTO EN PROCESO DETALLE POR ARTICULO*/
    public async Task<object> GetDetalleProductoProcesoTodos(string lote_madre)
    {
        try
        {
            var result = await _context.DetalleProductoProcesoTodosResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_PRODUCTO_PROCESO_DETALLE_TODOS {lote_madre}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }


    /*Resumen consumo - SUBPRODUCTO DETALLE TODOS*/
    public async Task<object> GetDetalleSubProductoTodos(string lote_madre)
    {
        try
        {
            var result = await _context.DetalleProductoProcesoTodosResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_SUBPRODUCTO_DETALLE_TODOS {lote_madre}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }

    /*Resumen consumo - HILO*/
    public async Task<object> GetDetalleConsumoHilo(string lote_madre)
    {
        try
        {
            var result = await _context.DetalleMovimientosHiloResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_PRODUCCION_HILO_DET {lote_madre}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }

    /*Resumen consumo - HILO -MOSTRAR TODOS*/
    public async Task<object> GetDetalleConsumoHiloTodos(string lote_madre)
    {
        try
        {
            var result = await _context.DetalleHiloTodos.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_DETALLE_TODOS {lote_madre}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }

    /*Resumen consumo - HILO DETALLE POR ARTICULO-HL*/
    public async Task<object> GetDetalleHiloxArticulo(string lote_madre, string articulo, string lote_hijo)
    {
        try
        {
            var result = await _context.DetalleHiloxArticuloResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_PRODUCCION_HILO_DETALLE_X_ARTICULO {lote_madre},{articulo},{lote_hijo}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }


    public async Task<object> GetConsumoProveedorCompleto(string lote_madre)
    {
        try
        {
            var result = await _context.ConsumoProveedorCompleto.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_PROVEEDOR_CONSUMO_GENERAL {lote_madre}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }

    /*Resumen consumo - HILO DETALLE POR ARTICULO-HL y POR LOTE HIJO*/
    public async Task<object> GetDetalleHiloxLoteHijo(string lote_madre, string articulo)
    {
        try
        {
            var result = await _context.DetalleHiloxLoteHijo.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HILO_AGRUPADO_LOTE_HIJO {lote_madre},{articulo}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }

    /*Resumen consumo - Fibra Reutilizable detalle*/
    public async Task<object> GetDetalleFibraReutilizable(string lote_madre,string articulo)
    {
        try
        {
            var result = await _context.FibraReutilizable.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_DETALLE_FIBRA_REUTILIZABLE {lote_madre},{articulo}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }

    /*Resumen consumo - Fibra Reutilizable detalle X Articulo*/
    public async Task<object> GetDetalleFibraReutilizableXArticulo(string lote_madre)
    {
        try
        {
            var result = await _context.FibraReutilizableXArticulo.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_FIBRA_REUTILIZABLE_X_ARTICULO {lote_madre}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }

    /* FECHA INICIO - FIN DE PRODUCCION */
    public async Task<object> GetFechaPeriodoProduccion(string lote_madre)
    {
        try
        {
            var result = await _context.PeriodoProduccionResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_PERIODO_PRODUCCION {lote_madre}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }

    /* DETALLE FIBRA REUTILIZABLE */
    public async Task<object> GetDetalleFibraProduccion(string lote_madre)
    {
        try
        {
            var result = await _context.ResumenConsumoResponse.FromSqlInterpolated($"exec FILASUR.XTUS_SP_BM_HL_RESUMEN__FIBRA_REUTILIZABLE {lote_madre}").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }
}

