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
    public class HardDiskDrivesController : BaseController
    {
        public HardDiskDrivesController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            var hardDiskDrives = context.HardDiskDrives as IEnumerable<HardDiskDrive>;

            var model = mapper.Map<IEnumerable<HardDiskDriveViewModel>>(hardDiskDrives);

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var hardDiskDrive = context.HardDiskDrives.FirstOrDefault(p => p.Id == id);

            if (hardDiskDrive == null)
            {
                return NotFound();
            }

            var model = mapper.Map<HardDiskDriveViewModel>(hardDiskDrive);

            return View(model);
        }
    }
}