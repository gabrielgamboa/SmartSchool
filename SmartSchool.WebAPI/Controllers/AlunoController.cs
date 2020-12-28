using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        List<Aluno> Alunos = new List<Aluno> {
            new Aluno() {
                Id = 1,
                Nome = "Gabriel",
                Sobrenome = "Gamboa",
                Telefone = "231132233123"
            },

            new Aluno() {
                Id = 2,
                Nome = "Pedro",
                Sobrenome = "Ribeiro",
                Telefone = "23322332"
            }

        };

        public AlunoController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault<Aluno>(x => x.Id == id);
            
            if (aluno == null) {
                return BadRequest("O aluno não foi encontrado");
            }

            return Ok(aluno);
        }

        [HttpGet("byName")]
        public IActionResult GetByName(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault<Aluno>(x => x.Nome.Contains(nome) && x.Nome.Contains(sobrenome));
            
            if (aluno == null) {
                return BadRequest("O aluno não foi encontrado");
            }

            return Ok(aluno);
        }


        [HttpPost] 
        public IActionResult Post(int id, Aluno aluno) 
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")] 
        public IActionResult Put(int id, Aluno aluno) 
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")] 
        public IActionResult Patch(int id, Aluno aluno) 
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")] 
        public IActionResult Delete(int id, Aluno aluno) 
        {
            return Ok(aluno);
        }

    }
}