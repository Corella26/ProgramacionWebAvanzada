﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DO.Objects;
using BS;
using DAL.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace APIMongoCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private IRepository<Usuario> db = new BS.Usuarios();

        //Metodo que devuelve todo 
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await db.GetAll());
        }

        //Metodo que devuelve por id 
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAllDetails(string id)
        {
            return Ok(await db.GetAllById(id));
        }

        //Metodo para crear
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Usuario Usuario)
        {
            if (Usuario == null)
                return BadRequest();
            
            await db.Insert(Usuario);
            return Created("Created", true);
        }

        //Metodo para actualizar
        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromBody] Usuario Usuario, string id)
        {
            if (Usuario == null)
                return BadRequest();

            Usuario.IdUsuario = new MongoDB.Bson.ObjectId(id);
            await db.Update(Usuario);
            return Created("Created", true);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(string id)
        {
            await db.Delete(id);
            return NoContent();//Success
        }
    }
}
