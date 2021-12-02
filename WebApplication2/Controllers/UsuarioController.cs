using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GameSuporte.Context;
using gameSuporte.Entity;

namespace GameSuporte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

       
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
           
            using (MyContext ctx = new MyContext())
            {
              
                return Ok(ctx.Usuarios.ToList());
            }
        }

       
        [HttpGet("{id}")]
        public ActionResult<Usuario> GetPeloId(int id)
        {
            using (MyContext context = new MyContext())
            {
               
                Usuario user = context.Usuarios.Where(u => u.ID.Equals(id)).FirstOrDefault();

                if (user == null)
                    return NotFound();


                return user;
            }
        }

      
        [HttpPost]
        public ActionResult<Usuario> Post(Usuario usuario)
        {
            using (MyContext ctx = new MyContext())
            {
               
              
                ctx.Usuarios.Add(usuario);
               
                ctx.SaveChanges();
            }
           
            return usuario;
        }

       
        [HttpPut]
        public ActionResult<Usuario> Put(Usuario usuario)
        {
           
            using (MyContext ctx = new MyContext())
            {
               
                ctx.Usuarios.Update(usuario);
                
                ctx.SaveChanges();
            }

            return usuario;
        }

       
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           
            using (MyContext ctx = new MyContext())
            {
                
               
                Usuario usuario = ctx.Usuarios.Where(u => u.ID.Equals(id)).FirstOrDefault();

                
                if (usuario == null)
                    return NotFound();

               
                ctx.Usuarios.Remove(usuario);
               
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
