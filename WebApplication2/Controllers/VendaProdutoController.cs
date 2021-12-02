using GameSuporte.Context;
using GameSuporte.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSuporte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaProdutosController : ControllerBase
    {


        [HttpGet]
        public ActionResult<IEnumerable<VendaProduto>> Get()
        {

            using (MyContext ctx = new MyContext())
            {

                return Ok(ctx.VendaProdutos.ToList());
            }
        }


        [HttpGet("{id}")]
        public ActionResult<VendaProduto> GetPeloId(int id)
        {
            using (MyContext context = new MyContext())
            {

                VendaProduto user = context.VendaProdutos.Where(u => u.ID.Equals(id)).FirstOrDefault();

                if (user == null)
                    return NotFound();


                return user;
            }
        }


        [HttpPost]
        public ActionResult<VendaProduto> Post(VendaProduto vendaProduto)
        {
            using (MyContext ctx = new MyContext())
            {

                ctx.VendaProdutos.Add(vendaProduto);

                ctx.SaveChanges();
            }

            return vendaProduto;
        }


        [HttpPut]
        public ActionResult<VendaProduto> Put(VendaProduto vendaProduto)
        {

            using (MyContext ctx = new MyContext())
            {

                ctx.VendaProdutos.Update(vendaProduto);

                ctx.SaveChanges();
            }

            return vendaProduto;
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            using (MyContext ctx = new MyContext())
            {

                VendaProduto vendaProduto = ctx.VendaProdutos.Where(u => u.ID.Equals(id)).FirstOrDefault();


                if (vendaProduto == null)
                    return NotFound();


                ctx.VendaProdutos.Remove(vendaProduto);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
