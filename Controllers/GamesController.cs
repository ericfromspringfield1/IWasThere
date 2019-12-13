using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IWasThere.Data;
using IWasThere.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace IWasThere.Controllers
{
    [Authorize]
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public GamesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            var games = _context.Game
                .Include(g => g.AwayTeam)
                .Include(g => g.HomeTeam)
                .Include(g => g.Location)
                .Include(g => g.User)
                .Where(g => g.UserId == user.Id);

            return View(await games.ToListAsync());
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await GetCurrentUserAsync();
            var game = await _context.Game
                .Include(g => g.AwayTeam)
                .Include(g=> g.AwayScore)
                .Include(g => g.HomeTeam)
                .Include(g=> g.HomeScore)
                .Include(g => g.Location)
                .Include(g => g.User)
                .Where(g => g.UserId == user.Id)
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var viewModel = new GameCreateViewModel()
            {
                Teams = await _context.Team
                .Where(t => t.UserId == user.Id).ToListAsync(),
                Locations = await _context.Location
                .Where(l => l.UserId == user.Id).ToListAsync()
            };
            return View(viewModel);
        }

        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GameCreateViewModel viewModel)
        {
            var user = await GetCurrentUserAsync();
            ModelState.Remove("User");
            ModelState.Remove("UserId");
            if (ModelState.IsValid)
            {
                viewModel.Game.UserId = user.Id;
                _context.Add(viewModel.Game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }
            /* ViewData["AwayTeamId"] = new SelectList(_context.Team, "TeamId", "UserId", game.TeamId);
            ViewData["HomeTeamId"] = new SelectList(_context.Team, "TeamId", "UserId", game.TeamId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationId", game.LocationId);
            ViewData["TeamId"] = new SelectList(_context.Team, "TeamId", "UserId", game.TeamId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", game.UserId); */


        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            ViewData["AwayTeamId"] = new SelectList(_context.Team, "TeamId", "UserId", game.TeamId);
            ViewData["HomeTeamId"] = new SelectList(_context.Team, "TeamId", "UserId", game.TeamId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationId", game.LocationId);
            ViewData["TeamId"] = new SelectList(_context.Team, "TeamId", "UserId", game.TeamId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", game.UserId);
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameId,GameName,Date,UserId,LocationId,TeamId,HomeTeamId,HomeScore,AwayTeamId,AwayScore")] Game game)
        {
            if (id != game.GameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.GameId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AwayTeamId"] = new SelectList(_context.Team, "TeamId", "UserId", game.AwayTeamId);
            ViewData["HomeTeamId"] = new SelectList(_context.Team, "TeamId", "UserId", game.HomeTeamId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationId", game.LocationId);
            ViewData["TeamId"] = new SelectList(_context.Team, "TeamId", "UserId", game.TeamId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", game.UserId);
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .Include(g => g.AwayTeam)
                .Include(g => g.HomeTeam)
                .Include(g => g.Location)
                .Include(g => g.Team)
                .Include(g => g.User)
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Game.FindAsync(id);
            _context.Game.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _context.Game.Any(e => e.GameId == id);
        }
    }
}
