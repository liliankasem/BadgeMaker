using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BadgeMakerBackEnd.Models;

namespace BadgeMakerBackEnd.Controllers
{
    public class QuizController : Controller
    {
        private ApplicationDbContext _context;

        public QuizController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Quiz
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quiz.ToListAsync());
        }

        // GET: Quiz/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Quiz quiz = await _context.Quiz.SingleAsync(m => m.Id == id);
            if (quiz == null)
            {
                return HttpNotFound();
            }

            return View(quiz);
        }

        // GET: Quiz/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quiz/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                _context.Quiz.Add(quiz);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(quiz);
        }

        // GET: Quiz/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Quiz quiz = await _context.Quiz.SingleAsync(m => m.Id == id);
            if (quiz == null)
            {
                return HttpNotFound();
            }
            return View(quiz);
        }

        // POST: Quiz/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                _context.Update(quiz);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(quiz);
        }

        // GET: Quiz/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Quiz quiz = await _context.Quiz.SingleAsync(m => m.Id == id);
            if (quiz == null)
            {
                return HttpNotFound();
            }

            return View(quiz);
        }

        // POST: Quiz/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Quiz quiz = await _context.Quiz.SingleAsync(m => m.Id == id);
            _context.Quiz.Remove(quiz);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
