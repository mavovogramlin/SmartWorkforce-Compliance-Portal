using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartWorkforcePortal.Data;
using SmartWorkforcePortal.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWorkforcePortal.Controllers
{
    [Authorize(Roles = "Supervisor")]
    public class ApprovalController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ApprovalController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Approval/Pending
        public IActionResult Pending()
        {
            var pendingRequests = _context.Requests
                .Where(r => r.Status == "Pending")
                .ToList();

            return View(pendingRequests);
        }

        // GET: Approval/Review/5
        public IActionResult Review(int id)
        {
            var request = _context.Requests.FirstOrDefault(r => r.RequestId == id);
            if (request == null)
                return NotFound();

            return View(request);
        }

        // POST: Approval/Review/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Review(int id, string decision, string comments)
        {
            var request = _context.Requests.FirstOrDefault(r => r.RequestId == id);
            if (request == null)
                return NotFound();

            var user = await _userManager.GetUserAsync(User);

            // Create Approval record
            var approval = new Approval
            {
                RequestId = id,
                ApproverId = user.Id,
                Decision = decision,
                Comments = comments,
                DecisionDate = DateTime.Now
            };
            _context.Approvals.Add(approval);

            // Update Request status
            request.Status = decision;
            await _context.SaveChangesAsync();

            return RedirectToAction("Pending");
        }
    }
}
