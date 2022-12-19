using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL_WebApi.Controllers
{
    public class ProductoController : ApiController
    {
        [Route("api/Producto/GetAll")]
        [HttpGet]
        public IHttpActionResult GETALL() {
            ML.Result result = BL.Producto.GETALL();
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else {
                return Content(HttpStatusCode.NotFound, result);    
            }
        }

        [Route("api/Producto/ADD")]
        [HttpPost]

        public IHttpActionResult ADD([FromBody]ML.Producto producto)
        {
            ML.Result result = BL.Producto.ADD(producto);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }

        [Route("api/Producto/GetBYId")]
        [HttpGet]

        public IHttpActionResult GetByID(int producto)
        {
            ML.Result result = BL.Producto.GETBYID(producto);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }


        [Route("api/Producto/DELETE")]
        [HttpDelete]

        public IHttpActionResult DELETE(int producto)
        {
            ML.Result result = BL.Producto.DELETE(producto);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }
        [Route("api/Producto/UPDATE")]
        [HttpPut]

        public IHttpActionResult UPDATE([FromBody] ML.Producto producto)
        {
            ML.Result result = BL.Producto.UPDATE(producto);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);

            }

            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }

        }

    }
}
