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
    public class EnderecoController : ControllerBase
    {

       
        [HttpGet]
        public ActionResult<IEnumerable<Endereco>> Get()
        {
            
            using (MyContext ctx = new MyContext())
            {
               
                return Ok(ctx.Enderecos.ToList());
            }
        }

        
        [HttpGet("{id}")]
        public ActionResult<Endereco> GetPeloId(int id)
        {
            using (MyContext context = new MyContext())
            {
               
                Endereco ende = context.Enderecos.Where(u => u.ID.Equals(id)).FirstOrDefault();

                if (ende == null)
                    return NotFound();


                return ende;
            }
        }

       
        [HttpPost]
        public ActionResult<Endereco> Post(Endereco endereco)
        {
            using (MyContext ctx = new MyContext())
            {
                
                
                ctx.Enderecos.Add(endereco);
               
                ctx.SaveChanges();
            }
          
            return endereco;
        }

       
        [HttpPut]
        public ActionResult<Endereco> Put(Endereco endereco)
        {
            
            using (MyContext ctx = new MyContext())
            {
               
                ctx.Enderecos.Update(endereco);
               
                ctx.SaveChanges();
            }

            return endereco;
        }

        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            
            using (MyContext ctx = new MyContext())
            {
               
                Endereco endereco = ctx.Enderecos.Where(u => u.ID.Equals(id)).FirstOrDefault();

               
                if (endereco == null)
                    return NotFound();

              
                ctx.Enderecos.Remove(endereco);
              
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
