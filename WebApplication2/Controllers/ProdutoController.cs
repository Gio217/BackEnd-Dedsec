using gameSuporte.Entity;
using GameSuporte.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSuporte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {

       
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
           
            using (MyContext ctx = new MyContext())
            {
                
                return Ok(ctx.Produtos.ToList());
            }
        }

        
        [HttpGet("{id}")]
        public ActionResult<Produto> GetPeloId(int id)
        {
            using (MyContext context = new MyContext())
            {
                
                Produto user = context.Produtos.Where(u => u.ID.Equals(id)).FirstOrDefault();

                if (user == null)
                    return NotFound();


                return user;
            }
        }

       
        [HttpPost]
        public ActionResult<Produto> Post(Produto produto)
        {
            using (MyContext ctx = new MyContext())
            {
               
                ctx.Produtos.Add(produto);
               
                ctx.SaveChanges();
            }
           
            return produto;
        }

        
        [HttpPut]
        public ActionResult<Produto> Put(Produto produto)
        {
           
            using (MyContext ctx = new MyContext())
            {
               
                ctx.Produtos.Update(produto);
                
                ctx.SaveChanges();
            }

            return produto;
        }

       
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
          
            using (MyContext ctx = new MyContext())
            {
              
                Produto produto = ctx.Produtos.Where(u => u.ID.Equals(id)).FirstOrDefault();

                
                if (produto == null)
                    return NotFound();

                
                ctx.Produtos.Remove(produto);
               
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}