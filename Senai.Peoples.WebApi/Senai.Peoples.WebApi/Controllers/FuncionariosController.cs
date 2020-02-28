using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Interfaces;
using Senai.Peoples.WebApi.Repositories;

namespace Senai.Peoples.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private IFuncionarioRepository _funcionarioRepository { get; set; }

        public FuncionariosController()
        {
            _funcionarioRepository = new FuncionarioRepository();
        }

        // GET: api/Funcionarios
        //Read
        [HttpGet]
        public IEnumerable<FuncionariosDomain> Get()
        {
            return _funcionarioRepository.Listar();
        }

        // GET: api/Funcionarios/5
        //Read
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            FuncionariosDomain funcionarioBuscado = _funcionarioRepository.BuscarPorId(id);

            if(funcionarioBuscado == null)
            {
                return NotFound("Não Foi Encontrado Nenhum Funcionário com este ID");
            }

            return Ok(funcionarioBuscado);
        }

        //GET
        //Read
        [HttpGet("Buscar/{nome}")]
        public IActionResult GetByName(string nome)
        {
            FuncionariosDomain funcionarioBuscado = _funcionarioRepository.BuscarPorNome(nome);

            if (funcionarioBuscado == null)
            {
                return NotFound("Não Foi Encontrado Nenhum Funcionário com este ID");
            }

            return Ok(funcionarioBuscado);
        }

        //GET
        //Read
        [HttpGet("Buscar/{nome}")]
        public IActionResult GetByFullName(string nomeCompleto)
        {
            FuncionariosDomain funcionarioBuscado = _funcionarioRepository.BuscarPorNomeCompleto(nomeCompleto);

            if (funcionarioBuscado == null)
            {
                return NotFound("Não Foi Encontrado Nenhum Funcionário com este ID");
            }

            return Ok(funcionarioBuscado);
        }

        // POST: api/Funcionarios
        //Create
        [HttpPost]
        public IActionResult Post(FuncionariosDomain novoFuncionario)
        {
            _funcionarioRepository.Cadastrar(novoFuncionario);

            return StatusCode(201);
        }

        // PUT: api/Funcionarios/5
        //Update
        [HttpPut]
        public IActionResult PutIdCorpo(FuncionariosDomain funcionarioAtualizado)
        {
            FuncionariosDomain funcionarioBuscado = _funcionarioRepository.BuscarPorId(funcionarioAtualizado.idFuncionario);

            if(funcionarioBuscado != null)
            {
                try
                {
                    _funcionarioRepository.AtualizarIdCorpo(funcionarioAtualizado);

                    return NoContent();
                }
                catch (Exception erro)
                {
                    return BadRequest(erro);
                }
            }

            return NotFound
                (
                    new
                    {
                        mensagem = "Funcionário Não Encontrado",
                        erro = true
                    }
                );
        }

        // PUT: api/Funcionarios/5
        //Delete
        [HttpPut("{id}")]
        public IActionResult PutIdUrl(int id, FuncionariosDomain funcionarioAtualizado)
        {
            FuncionariosDomain funcionarioBuscado = _funcionarioRepository.BuscarPorId(id);

            if (funcionarioBuscado == null)
            {
                return NotFound
                    (
                        new
                        {
                            mensagem = "Funcionário Não Encontrado",
                            erro = true
                        }
                    );
            }

            try
            {
                _funcionarioRepository.AtualizarIdUrl(id, funcionarioAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        // DELETE: api/ApiWithActions/5
        //Delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _funcionarioRepository.Deletar(id);

            return Ok("Os Dados do Funcionário Foram Apagados");
        }
    }
}
