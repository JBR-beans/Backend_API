﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend_API.Data;
using Backend_API.Models;
using Microsoft.AspNetCore.Authorization;

namespace Backend_API.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class ContentsController : ControllerBase
    {
        private readonly Backend_APIContext _context;

        public ContentsController(Backend_APIContext context)
        {
            _context = context;
        }

        // GET: api/Contents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Content>>> GetContent()
        {
            return await _context.Content.Include(c => c.Category).ToListAsync();
        }

        // GET: api/Contents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Content>> GetContent(int id)
        {
            var content = await _context.Content.FindAsync(id);

            if (content == null)
            {
                return NotFound();
            }

            return content;
        }

        [Authorize]
        // PUT: api/Contents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContent(int id, Content content)
        {
            if (id != content.ContentId)
            {
                return BadRequest();
            }

            _context.Entry(content).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

		[Authorize]
		// POST: api/Contents
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
        public async Task<ActionResult<Content>> PostContent(Content content)
        {
            _context.Content.Add(content);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContent", new { id = content.ContentId }, content);
        }

		[Authorize]
		// DELETE: api/Contents/5
		[HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContent(int id)
        {
            var content = await _context.Content.FindAsync(id);
            if (content == null)
            {
                return NotFound();
            }

            _context.Content.Remove(content);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContentExists(int id)
        {
            return _context.Content.Any(e => e.ContentId == id);
        }
    }
}
