using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace APIProvider.Controllers
{
    [Produces("application/json")]
    [Authorize]
    [Route("api/Test")]
    public class TestController : Controller
    {

    }
}