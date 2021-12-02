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
    public class CategoriaController : ControllerBase
    {

        
        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            
            using (MyContext ctx = new MyContext())
            {
                
                return Ok(ctx.Categorias.ToList());
            }
        }

        
        [HttpGet("{id}")]
        public ActionResult<Categoria> GetPeloId(int id)
        {
            using (MyContext context = new MyContext())
            {
               
                Categoria cate = context.Categorias.Where(u => u.ID.Equals(id)).FirstOrDefault();

                if (cate == null)
                    return NotFound();

                return cate;
            }
        }

        
        [HttpPost]
        public ActionResult<Categoria> Post(Categoria categoria)
        {
            using (MyContext ctx = new MyContext())
            {
                
                ctx.Categorias.Add(categoria);
                
                ctx.SaveChanges();
            }
            
            return categoria;
        }

        
        [HttpPut]
        public ActionResult<Categoria> Put(Categoria categoria)
        {
           
            using (MyContext ctx = new MyContext())
            {
              
                ctx.Categorias.Update(categoria);
                
                ctx.SaveChanges();
            }

            return categoria;
        }

       
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           
            using (MyContext ctx = new MyContext())
            {
                
                Categoria categoria = ctx.Categorias.Where(u => u.ID.Equals(id)).FirstOrDefault();

                
                if (categoria == null)
                    return NotFound();

               
                ctx.Categorias.Remove(categoria);
                
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}