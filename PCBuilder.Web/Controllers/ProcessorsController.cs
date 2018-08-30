using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PCBuilder.Common.Models.BindingModels;
using PCBuilder.Common.Models.ViewModels;
using PCBuilder.Data;
using PCBuilder.Models;

namespace PCBuilder.Web.Controllers
{
    public class ProcessorsController : BaseController
    {
        public ProcessorsController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            var processors = context.Processors as IEnumerable<Processor>;

            var model = mapper.Map<IEnumerable<ProcessorViewModel>>(processors);

            return View(model);
        }

        [HttpGet]
        public IActionResult Index2()
        {
            var processors = context.Processors as IEnumerable<Processor>;

            var model = mapper.Map<IEnumerable<ProcessorViewModel>>(processors);

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var processor = context.Processors.FirstOrDefault(p => p.Id == id);

            if (processor == null)
            {
                return NotFound();
            }

            var model = mapper.Map<ProcessorViewModel>(processor);

            return View(model);
        }
    }
}