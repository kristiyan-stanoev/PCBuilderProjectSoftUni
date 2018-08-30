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
    public class PowerSuppliesController : BaseController
    {
        public PowerSuppliesController(PCBuilderContext context, IMapper mapper) : base(context, mapper)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            var powerSupplies = context.PowerSupplies as IEnumerable<PowerSupply>;

            var model = mapper.Map<IEnumerable<PowerSupplyViewModel>>(powerSupplies);

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var powerSupply = context.PowerSupplies.FirstOrDefault(p => p.Id == id);

            if (powerSupply == null)
            {
                return NotFound();
            }

            var model = mapper.Map<PowerSupplyViewModel>(powerSupply);

            return View(model);
        }
    }
}