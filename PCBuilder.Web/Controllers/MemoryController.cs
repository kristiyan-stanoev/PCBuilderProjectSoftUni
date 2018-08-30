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
    public class MemoryController : BaseController
    {
        public MemoryController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            var memory = context.Memory as IEnumerable<Memory>;

            var model = mapper.Map<IEnumerable<MemoryViewModel>>(memory);

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var memory = context.Memory.FirstOrDefault(p => p.Id == id);

            if (memory == null)
            {
                return NotFound();
            }

            var model = mapper.Map<MemoryViewModel>(memory);

            return View(model);
        }
    }
}