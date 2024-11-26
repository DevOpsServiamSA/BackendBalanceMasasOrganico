using Microsoft.EntityFrameworkCore;
using BackEndBalanceMasasOrganico.Data;
using BackEndBalanceMasasOrganico.Models.ContentResponse;
using BackEndBalanceMasasOrganico.Models.ContentBody;
using OfficeOpenXml;

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



    public async Task<object> GetConsumoProveedorDetalle(/*string lote_madre, string lote_proveedor, string proveedor*/)
    {
        try
        {
            var result = await _context.FibraDetalleBody.FromSqlInterpolated($"exec FILASUR.XTUS_ORG_BM_DETALLE_FIBRA").ToListAsync();
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

    public async Task<object> GetDetalleMovimientoIngresoHilo()
    {
        try
        {
            var result = await _context.DetalleMovimientoIngresosHiloResponse.FromSqlInterpolated($"exec FILASUR.XTUS_ORG_BM_INGRESOS_HILO").ToListAsync();
            if (result == null) return new object[] { };
            return result;
        }
        catch (System.Exception)
        {
            return new object[] { };
        }
    }

    public async Task<object> GetDetalleConsecutivoIngresos(string lote_madre, string lote_hijo, string consecutivo)
    {
        try
        {
            var result = await _context.DetalleMovimientoIngresosHiloResponse.FromSqlInterpolated($"exec FILASUR.XTUS_ORG_BM_CONSECUTIVO_INGRESOS {lote_madre},{lote_hijo},{consecutivo}").ToListAsync();
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

    //Configuración carga de archivo excel

    public async Task<bool> ProcesarYGuardarExcelHilos(Stream stream)
    {
        using (var package = new ExcelPackage(stream))
        {
            var worksheet = package.Workbook.Worksheets[0]; // Suponiendo que los datos están en la primera hoja
            var rowCount = worksheet.Dimension.Rows;

            for (int row = 2; row <= rowCount; row++) // Asumiendo que la fila 1 tiene los encabezados
            {
                var lote_madre = worksheet.Cells[row, 1].Text; // Fecha
                var articulo = worksheet.Cells[row, 2].Text; // Fecha
                var descripcion = worksheet.Cells[row, 3].Text; // Fecha
                var unidad_almacen = worksheet.Cells[row, 4].Text; // Fecha
                var alias_produccion = worksheet.Cells[row, 5].Text; // Fecha
                var desc_alias = worksheet.Cells[row, 6].Text; // Fecha
                var fecha = worksheet.Cells[row, 7].Text; // Fecha
                var aplicacion = worksheet.Cells[row, 8].Text; // Fecha
                var naturaleza = worksheet.Cells[row, 9].Text; // Fecha
                var operacion = worksheet.Cells[row, 10].Text; // Fecha
                var bodega = worksheet.Cells[row, 11].Text; // Bodega
                var localizacion = worksheet.Cells[row, 12].Text; // Artículo
                var lote = worksheet.Cells[row, 13].Text; // Descripción Artículo
                //var cantidad = worksheet.Cells[row, 7].Text; // Cantidad
                var color = worksheet.Cells[row, 14].Text; // Operación
                var unidad_medida = worksheet.Cells[row, 15].Text; // Descripción Consecutivo

                decimal entrada = 0;
                decimal salida = 0;

                decimal.TryParse(worksheet.Cells[row, 16].Text, out entrada);
                decimal.TryParse(worksheet.Cells[row, 17].Text, out salida);

                var referencia = worksheet.Cells[row, 18].Text; // Referencia
                var guia_remision = worksheet.Cells[row, 19].Text; // Referencia
                var orden_servicio = worksheet.Cells[row, 20].Text; // Referencia
                var audit_trans_inv = worksheet.Cells[row, 21].Text; // Referencia

                decimal cantidad = 0;
                decimal.TryParse(worksheet.Cells[row, 7].Text, out cantidad);

                // Aquí puedes realizar la inserción de los datos en la base de datos
                // Ejemplo:
                await GuardarIngresosHiloBD(new IngresosHiloBody
                {
                    lote_madre = lote_madre,
                    articulo = articulo,
                    descripcion = descripcion,
                    unidad_almacen = unidad_almacen,
                    alias_produccion = alias_produccion,
                    desc_alias = desc_alias,
                    fecha = fecha,
                    aplicacion = aplicacion,
                    naturaleza = naturaleza,
                    operacion = operacion,
                    bodega = bodega,
                    localizacion = localizacion,
                    lote = lote,
                    color = color,
                    unidad_medida = unidad_medida,
                    entrada = entrada,
                    salida = salida,
                    referencia = referencia,
                    guia_remision= guia_remision,
                    orden_servicio = orden_servicio,
                    audit_trans_inv = audit_trans_inv
                });
            }
        }
        return true;
    }


    private async Task GuardarIngresosHiloBD(IngresosHiloBody detalle)
    {
        // Inserta los datos en la tabla SQL
        _context.IngresosHiloBody.Add(detalle);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ProcesarYGuardarExcelFibraDetalle(Stream stream)
    {
        using (var package = new ExcelPackage(stream))
        {
            var worksheet = package.Workbook.Worksheets[0]; // Suponiendo que los datos están en la primera hoja
            var rowCount = worksheet.Dimension.Rows;

            for (int row = 2; row <= rowCount; row++) // Asumiendo que la fila 1 tiene los encabezados
            {
                var articulo = worksheet.Cells[row, 1].Text;
                var descripcion = worksheet.Cells[row, 2].Text;
                var fecha = worksheet.Cells[row, 3].Text;
                var documento = worksheet.Cells[row, 4].Text;
                var bodega = worksheet.Cells[row, 5].Text;
                var lote = worksheet.Cells[row, 6].Text;
                var color = worksheet.Cells[row, 7].Text;
                var unidad_medida = worksheet.Cells[row, 8].Text;

                // Detectar si la cantidad es un entero o un decimal
                decimal entrada = 0;
                decimal salida = 0;
                decimal saldo = 0;
                decimal saldo_tc = 0;

                // Intenta convertir las cantidades a decimal
                decimal.TryParse(worksheet.Cells[row, 9].Text, out entrada);
                decimal.TryParse(worksheet.Cells[row, 10].Text, out salida);
                decimal.TryParse(worksheet.Cells[row, 11].Text, out saldo);
                decimal.TryParse(worksheet.Cells[row, 12].Text, out saldo_tc);

                var tc = worksheet.Cells[row, 13].Text;
                var guia = worksheet.Cells[row, 14].Text;
                var fac = worksheet.Cells[row, 15].Text;
                var lote_madre = worksheet.Cells[row, 16].Text;


                // Aquí puedes realizar la inserción de los datos en la base de datos
                // Ejemplo:
                await GuardarDetalleFibraBD(new KardexFibra
                {
                    articulo = articulo,
                    descripcion = descripcion,
                    fecha = fecha,
                    documento = documento,
                    bodega = bodega,
                    lote = lote,
                    color = color,
                    unidad_medida = unidad_medida,
                    entrada = entrada,
                    salida = salida,
                    saldo = saldo,
                    saldo_tc = saldo_tc,
                    tc = tc,
                    guia = guia,
                    fac = fac,
                    lote_madre = lote_madre,
                });
            }
        }
        return true;
    }

    private async Task GuardarDetalleFibraBD(KardexFibra detalle)
    {
        // Inserta los datos en la tabla SQL
        _context.KardexFibra.Add(detalle);
        await _context.SaveChangesAsync();
    }



    public async Task<bool> ProcesarYGuardarExcelCintaDetalle(Stream stream)
    {
        using (var package = new ExcelPackage(stream))
        {
            var worksheet = package.Workbook.Worksheets[0]; // Suponiendo que los datos están en la primera hoja
            var rowCount = worksheet.Dimension.Rows;

            for (int row = 2; row <= rowCount; row++) // Asumiendo que la fila 1 tiene los encabezados
            {
                var lote_madre = worksheet.Cells[row, 1].Text;
                var articulo = worksheet.Cells[row, 2].Text;
                var descripcion = worksheet.Cells[row, 3].Text;
                var fecha = worksheet.Cells[row, 4].Text;
                var documento = worksheet.Cells[row, 5].Text;
                var naturaleza = worksheet.Cells[row, 6].Text;
                var operacion = worksheet.Cells[row, 7].Text;
                var bodega = worksheet.Cells[row, 8].Text;
                var lote = worksheet.Cells[row, 9].Text;
                var color = worksheet.Cells[row, 10].Text;
                var unidad_medida = worksheet.Cells[row, 11].Text;

                // Detectar si la cantidad es un entero o un decimal
                decimal entrada = 0;
                decimal salida = 0;
                decimal saldo = 0;

                // Intenta convertir las cantidades a decimal
                decimal.TryParse(worksheet.Cells[row, 12].Text, out entrada);
                decimal.TryParse(worksheet.Cells[row, 13].Text, out salida);
                decimal.TryParse(worksheet.Cells[row, 14].Text, out saldo);

                var documento_venta = worksheet.Cells[row, 15].Text;
                var cliente = worksheet.Cells[row, 16].Text;
                var orden_compra = worksheet.Cells[row, 17].Text;
                var referencia = worksheet.Cells[row, 18].Text;
                var programa = worksheet.Cells[row, 19].Text;
                var guia_remision = worksheet.Cells[row, 20].Text;
                var orden_servicio = worksheet.Cells[row, 21].Text;
                var doc_referencia = worksheet.Cells[row, 22].Text;
                var trans_inv = worksheet.Cells[row, 23].Text;
                var consecutivo = worksheet.Cells[row, 24].Text;
                var localizacion = worksheet.Cells[row, 25].Text;
                var art_nombre = worksheet.Cells[row, 26].Text;


                // Aquí puedes realizar la inserción de los datos en la base de datos
                // Ejemplo:
                await GuardarDetalleCintaBD(new KardexCinta
                {
                    lote_madre = lote_madre,
                    articulo = articulo,
                    descripcion = descripcion,
                    fecha = fecha,
                    documento = documento,
                    naturaleza = naturaleza,
                    operacion = operacion,
                    bodega = bodega,
                    lote = lote,
                    color = color,
                    unidad_medida = unidad_medida,
                    entrada = entrada,
                    salida = salida,
                    saldo = saldo,
                    documento_venta = documento_venta,
                    cliente = cliente,
                    orden_compra = orden_compra,
                    referencia = referencia,
                    programa = programa,
                    guia_remision = guia_remision,
                    orden_servicio = orden_servicio,
                    doc_referencia = doc_referencia,
                    trans_inv = trans_inv,
                    consecutivo = consecutivo,
                    localizacion = localizacion,
                    art_nombre = art_nombre
                });
            }
        }
        return true;
    }

    private async Task GuardarDetalleCintaBD(KardexCinta detalle)
    {
        // Inserta los datos en la tabla SQL
        _context.KardexCinta.Add(detalle);
        await _context.SaveChangesAsync();
    }
}

