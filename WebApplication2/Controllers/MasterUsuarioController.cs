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
    public class MasterUsuarioController : ControllerBase
    {

       
        [HttpGet]
        public ActionResult<IEnumerable<MasterUsuario>> Get()
        {
           
            using (MyContext ctx = new MyContext())
            {
                
                return Ok(ctx.MasterUsuarios.ToList());
            }
        }

        
        [HttpGet("{id}")]
        public ActionResult<MasterUsuario> GetPeloId(int id)
        {
            using (MyContext context = new MyContext())
            {
               
                MasterUsuario user = context.MasterUsuarios.Where(u => u.ID.Equals(id)).FirstOrDefault();

                if (user == null)
                    return NotFound();


                return user;
            }
        }

        
        [HttpPost]
        public ActionResult<MasterUsuario> Post(MasterUsuario masterUsuario)
        {
            using (MyContext ctx = new MyContext())
            {
              
                ctx.MasterUsuarios.Add(masterUsuario);
               
                ctx.SaveChanges();
            }
           
            return masterUsuario;
        }

       
        [HttpPut]
        public ActionResult<MasterUsuario> Put(MasterUsuario masterUsuario)
        {
          
            using (MyContext ctx = new MyContext())
            {
              
                ctx.MasterUsuarios.Update(masterUsuario);
             
                ctx.SaveChanges();
            }

            return masterUsuario;
        }

       
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           
            using (MyContext ctx = new MyContext())
            {
              
                MasterUsuario masterUsuario = ctx.MasterUsuarios.Where(u => u.ID.Equals(id)).FirstOrDefault();

              
                if (masterUsuario == null)
                    return NotFound();

                
                ctx.MasterUsuarios.Remove(masterUsuario);
               
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
