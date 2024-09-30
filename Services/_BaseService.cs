using BackEndBalanceMasasOrganico.Data;
using Microsoft.AspNetCore.Authorization;

namespace BackEndBalanceMasasOrganico.Services;
//[Authorize]

public class _BaseService
{
    protected readonly BaseContext _context = null!;
    public _BaseService(BaseContext context) => _context = context;
}

