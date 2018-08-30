using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PCBuilder.Common.Models.ViewModels;
using PCBuilder.Data;
using PCBuilder.Models;

namespace PCBuilder.Web.Controllers
{
    public class CasesController : BaseController
    {
        public CasesController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cases = context.Cases as IEnumerable<Case>;

            var model = mapper.Map<IEnumerable<CaseViewModel>>(cases);

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var pcCase = context.Cases.FirstOrDefault(p => p.Id == id);

            if (pcCase == null)
            {
                return NotFound();
            }

            var model = mapper.Map<CaseViewModel>(pcCase);

            return View(model);
        }
    }
}