using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECCE.Controllers
{
    public class VendaController : Controller
    {
        private readonly IHttpContextAccessor _hCont;

        public VendaController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }
       
    }
}