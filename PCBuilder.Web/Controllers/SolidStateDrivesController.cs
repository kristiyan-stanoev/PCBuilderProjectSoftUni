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
    public class SolidStateDrivesController : BaseController
    {
        public SolidStateDrivesController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            var solidStateDrives = context.SolidStateDrives as IEnumerable<SolidStateDrive>;

            var model = mapper.Map<IEnumerable<SolidStateDriveViewModel>>(solidStateDrives);

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var solidStateDrive = context.SolidStateDrives.FirstOrDefault(p => p.Id == id);

            if (solidStateDrive == null)
            {
                return NotFound();
            }

            var model = mapper.Map<SolidStateDriveViewModel>(solidStateDrive);

            return View(model);
        }
    }
}