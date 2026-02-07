using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartWorkforcePortal.Data;
using SmartWorkforcePortal.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWorkforcePortal.Controllers
{
    [Authorize]
    public class RequestController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public RequestController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Request/Create
        [Authorize(Roles = "Employee")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Request/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> Create(Request request)
        {
            var user = await _userManager.GetUserAsync(User);
            request.UserId = user.Id;
            request.Status = "Pending";
            request.CreatedDate = System.DateTime.Now;

            _context.Requests.Add(request);
            await _context.SaveChangesAsync();

            return RedirectToAction("MyRequests");
        }

        // GET: Request/MyRequests
        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> MyRequests()
        {
            var user = await _userManager.GetUserAsync(User);
            var requests = _context.Requests
                .Where(r => r.UserId == user.Id)
                .ToList();
            return View(requests);
        }
    }
}
