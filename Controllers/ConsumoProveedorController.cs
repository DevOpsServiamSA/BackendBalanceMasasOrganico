using Microsoft.AspNetCore.Mvc;
using BackEndBalanceMasasOrganico.Data;
using BackEndBalanceMasasOrganico.Services;
using Microsoft.EntityFrameworkCore;

namespace BackEndBalanceMasasOrganico.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConsumoProveedorController : _BaseController
{
    public ConsumoProveedorController(BaseContext context) : base(context) { }

    [HttpGet("LoteMadre/{lote_madre}")]
    public async Task<ActionResult<object>> GetConsumoProveedor(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetConsumoProveedor(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("Proveedor_x_lote/{lote_madre}/{proveedor}")]
    public async Task<ActionResult<object>> GetLote_x_Proveedor(string lote_madre, string proveedor)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetLote_x_Proveedor(lote_madre,proveedor);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }


    //[HttpGet("ConsumoProveedorDetalle/{lote_madre}/{lote_proveedor}/{proveedor}")]
    [HttpGet("ConsumoProveedorDetalle/DetalleFibra")]
    public async Task<ActionResult<object>> GetConsumoProveedorDetalle(/*string lote_madre, string lote_proveedor, string proveedor*/)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetConsumoProveedorDetalle();
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("LoteMadre/All")]
    public async Task<ActionResult<object>> GetLoteMadre()
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetLoteMadre();
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("LoteMadre/InvInicioHilo/{descripcion_lote}")]
    public async Task<ActionResult<object>> GetInvInicioHilo(string descripcion_lote)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetInvInicioHilo(descripcion_lote);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("LoteMadre/IngresosHilo/{descripcion_lote}")]
    public async Task<ActionResult<object>> GetIngresosHilo(string descripcion_lote)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetIngresosHilo(descripcion_lote);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("LoteMadre/SalidasHilo/{descripcion_lote}")]
    public async Task<ActionResult<object>> GetSalidasHilo(string descripcion_lote)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetSalidasHilo(descripcion_lote);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("LoteMadre/InvFinHilo/{descripcion_lote}")]
    public async Task<ActionResult<object>> GetInvFinHilo(string descripcion_lote)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetInvFinHilo(descripcion_lote);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("LoteMadre/ResumenConsumo/{descripcion_lote}")]
    public async Task<ActionResult<object>> GetResumenConsumo(string descripcion_lote)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetResumenConsumo(descripcion_lote);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("LoteMadre/ResumenMerma/{descripcion_lote}")]
    public async Task<ActionResult<object>> GetResumenMerma(string descripcion_lote)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetResumenMerma(descripcion_lote);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("DetalleMovimientos/IngresosHilo")]
    public async Task<ActionResult<object>> GetDetalleMovimientoIngresoHilo()
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleMovimientoIngresoHilo();
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("DetalleMovimientos/ConsecutivoIngresos/{lote_madre}/{lote_hijo}/{consecutivo}")]
    public async Task<ActionResult<object>> GetDetalleConsecutivoIngresoHilo(string lote_madre, string lote_hijo, string consecutivo)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleConsecutivoIngresos(lote_madre, lote_hijo, consecutivo);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("DetalleMovimientos/SalidasHilo/{lote_madre}/{lote_hijo}/{consecutivo}")]
    public async Task<ActionResult<object>> GetDetalleMovimientoSalidaHilo(string lote_madre, string lote_hijo, string consecutivo)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleMovimientoSalidaHilo(lote_madre, lote_hijo, consecutivo);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("Subproducto/InventarioInicio/{lote_madre}")]
    public async Task<ActionResult<object>> GetInvInicioSubproducto(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetInvInicioSubproducto(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("Subproducto/InventarioFin/{lote_madre}")]
    public async Task<ActionResult<object>> GetInvFinSubproducto(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetInvFinSubproducto(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("Subproducto/Ingresos/{lote_madre}")]
    public async Task<ActionResult<object>> GetIngresoSubproducto(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetIngresoSubproducto(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("Subproducto/Salidas/{lote_madre}")]
    public async Task<ActionResult<object>> GetSalidaSubproducto(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetSalidaSubproducto(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("ResumenConsecutivo/Ingresos/{lote_madre}/{lote_hijo}")]
    public async Task<ActionResult<object>> GetResumenConsecutivo(string lote_madre, string lote_hijo)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetResumenConsecutivo(lote_madre, lote_hijo);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("ResumenConsecutivo/Salida/{lote_madre}/{lote_hijo}")]
    public async Task<ActionResult<object>> GetResumenConsecutivoSalidaHilo(string lote_madre, string lote_hijo)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetResumenConsecutivoSalidaHilo(lote_madre, lote_hijo);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    

    [HttpGet("DetalleConsumoHilo/{lote_madre}")]
    public async Task<ActionResult<object>> GetDetalleConsumoHilo(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleConsumoHilo(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }


    [HttpGet("DetalleConsumoHiloTodos/{lote_madre}")]
    public async Task<ActionResult<object>> GetDetalleConsumoHiloTodos(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleConsumoHiloTodos(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("DetalleConsumoHiloxArticulo/{lote_madre}/{articulo}/{lote_hijo}")]
    public async Task<ActionResult<object>> GetDetalleHiloxArticulo(string lote_madre, string articulo, string lote_hijo)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleHiloxArticulo(lote_madre, articulo, lote_hijo);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("DetalleConsumoSubproducto/{lote_madre}/{articulo}")]
    public async Task<ActionResult<object>> GetDetalleConsumoSubproducto(string lote_madre, string articulo)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleConsumoSubproducto(lote_madre, articulo);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("DetalleGeneralMovimientoHilo/{lote_madre}")]
    public async Task<ActionResult<object>> GetDetalleGeneralMovimientoHilo(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleGeneralMovimientoHilo(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("SubProductoConcepto/{lote_madre}")]
    public async Task<ActionResult<object>> GetSubProductoConcepto(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetSubProductoConcepto(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }


    [HttpGet("ProductoProcesoxArticulo/{lote_madre}")]
    public async Task<ActionResult<object>> GetProductoProcesoxArticulo(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetSubProductoProceso_x_Articulo(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("ProductoProcesoDetallexArticulo/{lote_madre}/{articulo}")]
    public async Task<ActionResult<object>> GetProductoProcesoDetallexArticulo(string lote_madre, string articulo)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetProductoProcesoDetalle_x_Articulo(lote_madre,articulo);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }


    [HttpGet("DetalleProductoProcesoTodos/{lote_madre}")]
    public async Task<ActionResult<object>> DetalleGetProductoProcesoTodos(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleProductoProcesoTodos(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }


    [HttpGet("DetalleSubProductTodos/{lote_madre}")]
    public async Task<ActionResult<object>> DetalleGetSubProductoTodos(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleSubProductoTodos(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("ConsumoProveedorCompleto/{lote_madre}")]
    public async Task<ActionResult<object>> GetConsumoProveedorCompleto(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetConsumoProveedorCompleto(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("DetalleHiloxLoteHijo/{lote_madre}/{articulo}")]
    public async Task<ActionResult<object>> GetDetalleHiloxLoteHijo(string lote_madre, string articulo)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleHiloxLoteHijo(lote_madre, articulo);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("DetalleFibraReutilizable/{lote_madre}/{articulo}")]
    public async Task<ActionResult<object>> GetDetalleFibraReutilizable(string lote_madre, string articulo)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleFibraReutilizable(lote_madre, articulo);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("DetalleFibraReutilizableXArticulo/{lote_madre}")]
    public async Task<ActionResult<object>> GetDetalleFibraReutilizableXArticulo(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleFibraReutilizableXArticulo(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    /*PERIODO PRODUCCION*/

    [HttpGet("PeriodoProduccionLoteMadre/{lote_madre}")]
    public async Task<ActionResult<object>> GetPeriodoProduccion(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetFechaPeriodoProduccion(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    /*FIBRA REUTILIZABLE*/

    [HttpGet("DetalleFibraProduccion/{lote_madre}")]
    public async Task<ActionResult<object>> GetDetalleFibraReutilizable(string lote_madre)
    {
        try
        {
            var result = await new ConsumoProveedorService(_context).GetDetalleFibraProduccion(lote_madre);
            return result;
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpPost("DetalleIngresosHilos/CargarExcelHilos")]
    public async Task<IActionResult> CargarExcelHilos(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("No se proporcionó un archivo.");

        try
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM FILASUR.XTUS_BM_ORG_DETALLE_KARDEX_HILO");

            
            // Procesar el archivo Excel
            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            stream.Position = 0;

            // Extraer datos y guardarlos en la base de datos
            var result = await new ConsumoProveedorService(_context).ProcesarYGuardarExcelHilos(stream);

            return Ok(new { mensaje = "Archivo procesado exitosamente.", result });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error al procesar el archivo: {ex.Message}");
        }
    }


    [HttpPost("ConsumoProveedor/CargarExcelDetalleFibra")]
    public async Task<IActionResult> CargarExcelDetalleFibra(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("No se proporcionó un archivo.");

        try
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM FILASUR.XTUS_BM_ORG_DETALLE_KARDEX_FIBRA");


            // Procesar el archivo Excel
            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            stream.Position = 0;

            // Extraer datos y guardarlos en la base de datos
            var result = await new ConsumoProveedorService(_context).ProcesarYGuardarExcelFibraDetalle(stream);

            return Ok(new { mensaje = "Archivo procesado exitosamente.", result });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error al procesar el archivo: {ex.Message}");
        }
    }

    [HttpPost("ConsumoProveedor/CargarExcelDetalleCinta")]
    public async Task<IActionResult> CargarExcelDetalleCinta(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("No se proporcionó un archivo.");
            
        try
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM FILASUR.XTUS_BM_ORG_DETALLE_KARDEX_CINTA");


            // Procesar el archivo Excel
            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            stream.Position = 0;

            // Extraer datos y guardarlos en la base de datos
            var result = await new ConsumoProveedorService(_context).ProcesarYGuardarExcelCintaDetalle(stream);

            return Ok(new { mensaje = "Archivo procesado exitosamente.", result });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error al procesar el archivo: {ex.Message}");
        }
    }
}
