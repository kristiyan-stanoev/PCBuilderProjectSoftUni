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
    public class MotherboardsController : BaseController
    {
        public MotherboardsController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            var motherboards = context.Motherboards as IEnumerable<Motherboard>;

            var model = mapper.Map<IEnumerable<MotherboardViewModel>>(motherboards);

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var motherboard = context.Motherboards.FirstOrDefault(p => p.Id == id);

            if (motherboard == null)
            {
                return NotFound();
            }

            var model = mapper.Map<MotherboardViewModel>(motherboard);

            return View(model);
        }

        public IEnumerable<Motherboard> GetAllMotherboards(Motherboard motherboard)
        {
            if (motherboard == null)
            {
                return null;
            }
            return context.Motherboards as IEnumerable<Motherboard>;
        }
    }
}