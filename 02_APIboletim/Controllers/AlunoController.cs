﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIboletim.Domains;
using APIboletim.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIboletim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {


        // Chamar o repositorio de aluno
        AlunoRepository repo = new AlunoRepository();


        // GET: api/<AlunoController>
        [HttpGet]
        public List<Aluno> Get()
        {
            return repo.LerTodos();
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return repo.BuscarPoId(id); 
        }

        // POST api/<AlunoController>
        [HttpPost]
        public Aluno Post([FromBody] Aluno a)
        {
            return repo.Cadastrar(a);
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public Aluno Put(int id, [FromBody] Aluno a)
        {

            return repo.Alterar(id, a);

        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Excluir(id);
        }
    }
}
