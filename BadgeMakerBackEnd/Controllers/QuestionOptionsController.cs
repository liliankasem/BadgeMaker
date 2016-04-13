using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BadgeMakerBackEnd.Models;

namespace BadgeMakerBackEnd.Controllers
{
    public class QuestionOptionsController : Controller
    {
        private ApplicationDbContext _context;

        public QuestionOptionsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: QuestionOptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestionOption.ToListAsync());
        }

        // GET: QuestionOptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            QuestionOption questionOption = await _context.QuestionOption.SingleAsync(m => m.Id == id);
            if (questionOption == null)
            {
                return HttpNotFound();
            }

            return View(questionOption);
        }

        // GET: QuestionOptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuestionOptions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(QuestionOption questionOption)
        {
            if (ModelState.IsValid)
            {
                _context.QuestionOption.Add(questionOption);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(questionOption);
        }

        // GET: QuestionOptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            QuestionOption questionOption = await _context.QuestionOption.SingleAsync(m => m.Id == id);
            if (questionOption == null)
            {
                return HttpNotFound();
            }
            return View(questionOption);
        }

        // POST: QuestionOptions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(QuestionOption questionOption)
        {
            if (ModelState.IsValid)
            {
                _context.Update(questionOption);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(questionOption);
        }

        // GET: QuestionOptions/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            QuestionOption questionOption = await _context.QuestionOption.SingleAsync(m => m.Id == id);
            if (questionOption == null)
            {
                return HttpNotFound();
            }

            return View(questionOption);
        }

        // POST: QuestionOptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            QuestionOption questionOption = await _context.QuestionOption.SingleAsync(m => m.Id == id);
            _context.QuestionOption.Remove(questionOption);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
