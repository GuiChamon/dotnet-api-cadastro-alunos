using CadastroAlunos.Data;
using CadastroAlunos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlunosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> Get()
        {
            return await _context.Alunos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> GetById(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null) return NotFound();
            return aluno;
        }

        [HttpPost]
        public async Task<ActionResult<Aluno>> Post(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = aluno.Id }, aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] AtualizarAlunoDto dados)
        {
            var alunoExistente = _context.Alunos.Find(id);
            if (alunoExistente == null)
                return NotFound();

            alunoExistente.Nome = dados.Nome;
            alunoExistente.Curso = dados.Curso;
            alunoExistente.Idade = dados.Idade;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null) return NotFound();

            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}