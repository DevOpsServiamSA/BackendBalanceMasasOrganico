using BackEndBalanceMasasOrganico.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackEndBalanceMasasOrganico.Controllers;
//[Authorize]

    public class _BaseController : ControllerBase
    {
        protected readonly BaseContext _context = null!;
        public _BaseController(BaseContext context) => _context = context;
    }

