using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Budgetify.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Budgetify.Areas.User.Controllers
{
    [Area("User")]
    public class DebtCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DebtCategoryController(ApplicationDbContext db)
        {
            _db = db;

        }

        //GET
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            return View(await _db.DebtCategory.Include(c => c.ApplicationUser).Where(u => u.UserId == claim.Value).ToListAsync());
        }

        //Get - CREATE
        public IActionResult Create()
        {
            return View();
        }
    }
}