using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PCBuilder.Common.Models.BindingModels;
using PCBuilder.Common.Models.ViewModels;
using PCBuilder.Data;
using PCBuilder.Models;

namespace PCBuilder.Web.Controllers
{

    public class BuildsController : BaseController
    {
        private UserManager<User> userManager;

        public BuildsController(PCBuilderContext context, IMapper mapper, UserManager<User> userManager) : base(context, mapper)
        {
            this.userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<PC> pcs = IncludeProperties() as IEnumerable<PC>;

            IEnumerable<PCViewModel> model = GetIEnumerableModel(pcs);

            var userBuildsModel = model.Where(m => m.Username == this.User.Identity.Name) as IEnumerable<PCViewModel>;

            return View(userBuildsModel);
        }

        [HttpGet]
        public IActionResult All()
        {
            var pcs = IncludeProperties().ToList();

            pcs.ForEach(p => RateSystem(p));

            var model = GetIEnumerableModel(pcs as IEnumerable<PC>);

            context.SaveChanges();

            return View(model);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Rate(int id)
        {
            var pc = IncludeProperties()
                .FirstOrDefault(p => p.Id == id);

            if (pc == null)
            {
                return NotFound();
            }

            PCViewModel model = GetModel(pc);

            model.UsersRatedIds = pc.UsersRatedIds;

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Rate(double Rating, string UserId, string Builder, string BuildName)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Invalid rate!";
                return RedirectToAction("Rate");
            }
            if (Rating < 1 || Rating > 10)
            {
                TempData["Error"] = "Invalid rate!";
                return RedirectToAction("Rate");
            }

            if (this.User.Identity.Name == Builder || this.User.Claims.Any(c => c.Value == Builder))
            {
                TempData["Error"] = "You cannot rate your own build!";
                return RedirectToAction("All");
            }

            var user = context.Users.FirstOrDefault(u => u.Id == UserId);

            var user2 = context.Users.FirstOrDefault(u => u.UserName == Builder);
            if (user == null || user2 == null)
            {
                return NotFound();
            }

            var pc = context.PCs.Include(p => p.User).FirstOrDefault(p => p.User.UserName == Builder && p.BuildName == BuildName);

            if (pc.UsersRatedIds.Contains(this.User.Identity.Name))
            {
                TempData["Error"] = "You have already rated this build!";
                return RedirectToAction("All");
            }

            pc.UserRating = Math.Round(((pc.UserRating * pc.UsersRatedCount) + Rating) / ++pc.UsersRatedCount, 1);
            pc.UsersRatedIds = string.Concat(pc.UsersRatedIds, UserId, " ");

            context.SaveChanges();

            return RedirectToAction("All");
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            InitializeView();

            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(PCBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Invalid form.";
                return RedirectToAction("Create");
            }

            if (context.PCs.Any(p => p.BuildName == model.BuildName))
            {
                TempData["Error"] = "Build name already exists.";
                return RedirectToAction("Create");
            }

            if (model.SolidStateDrive == null && model.HardDiskDrive == null)
            {
                TempData["Error"] = "Select at least one drive.";
                return RedirectToAction("Create");
            }

            PC pc = await BuildPC(model);

            context.PCs.Add(pc);
            await context.SaveChangesAsync();

            return RedirectToAction("Details", new { id = pc.Id });
        }

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var pc = context.PCs
        //        .Include(p => p.User)
        //        .Include(p => p.Processor)
        //        .Include(p => p.GraphicsCard)
        //        .Include(p => p.PowerSupply)
        //        .Include(p => p.Memory)
        //        .Include(p => p.User)
        //        .Include(p => p.User)
        //        .Include(p => p.User)
        //        .Include(p => p.User)
        //        .FirstOrDefault(p => p.Id == id);

        //    if (pc == null)
        //    {
        //        return NotFound();
        //    }
        //    if (this.User.Identity.Name != pc.User.UserName)
        //    {
        //        return Unauthorized();
        //    }


        //    var model = new PCBindingModel()
        //    {
        //        BuildName = pc.BuildName,
        //        Case = $"{pc.Case.Manufacturer} {pc.Case.ModelName}",
        //        GraphicsCard = $"{pc.GraphicsCard.Manufacturer} {pc.GraphicsCard.ModelName}",
        //        Processor = $"{pc.Processor.Manufacturer} {pc.Processor.ModelName}",
        //        PowerSupply = $"{pc.PowerSupply.Manufacturer} {pc.PowerSupply.ModelName}"
        //    };

        //    return View(model);
        //}

        //[HttpPost]
        //public IActionResult Edit(int id, MotherboardBindingModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var pcMotherboard = context.Motherboards.FirstOrDefault(p => p.Id == id);

        //    if (pcMotherboard == null)
        //    {
        //        return NotFound();
        //    }

        //    MapProperties(pcMotherboard, model);

        //    context.SaveChanges();

        //    return RedirectToAction("Details", "Motherboards", new { area = "", id });
        //}

        [HttpGet]
        public IActionResult Details(int id)
        {
            var pc = IncludeProperties()
                .FirstOrDefault(p => p.Id == id);

            if (pc == null)
            {
                return NotFound();
            }

            RateSystem(pc);

            context.SaveChanges();

            PCViewModel model = GetModel(pc);

            return View(model);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var pc = IncludeProperties()
                .FirstOrDefault(p => p.Id == id);

            if (pc == null)
            {
                return NotFound();
            }

            if (this.User.Identity.Name != pc.User.UserName)
            {
                return Unauthorized();
            }

            var model = GetModel(pc);

            return View(model);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var pc = context.PCs.FirstOrDefault(p => p.Id == id);

            if (pc == null)
            {
                return NotFound();
            }

            context.PCs.Remove(pc);
            context.SaveChanges();

            return RedirectToAction("Index", "Builds", new { area = "" });
        }


        private void InitializeHardDiskDrives()
        {
            var HardDiskDrives = context.HardDiskDrives.ToList();

            ViewBag.HardDiskDrives = new List<SelectListItem>();

            var HardDiskDrivestoselectlistiem = HardDiskDrives.Select(hdd => new SelectListItem() { Text = $"{hdd.Manufacturer} {hdd.ModelName} {hdd.MemoryCapacity} GB", Value = $"{hdd.Manufacturer} {hdd.ModelName} {hdd.MemoryCapacity} GB" });

            ViewBag.HardDiskDrives.AddRange(HardDiskDrivestoselectlistiem);
        }

        private void InitializeSolidStateDrives()
        {
            var SolidStateDrives = context.SolidStateDrives.ToList();

            ViewBag.SolidStateDrives = new List<SelectListItem>();

            var SolidStateDrivestoselectlistiem = SolidStateDrives.Select(ssd => new SelectListItem() { Text = $"{ssd.Manufacturer} {ssd.ModelName} {ssd.MemoryCapacity} GB", Value = $"{ssd.Manufacturer} {ssd.ModelName} {ssd.MemoryCapacity} GB" });

            ViewBag.SolidStateDrives.AddRange(SolidStateDrivestoselectlistiem);
        }

        private void InitializePowerSupplies()
        {
            var PowerSupplies = context.PowerSupplies.ToList();

            ViewBag.PowerSupplies = new List<SelectListItem>();

            var PowerSuppliestoselectlistiem = PowerSupplies.Select(p => new SelectListItem() { Text = $"{p.Manufacturer} {p.ModelName}", Value = $"{p.Manufacturer} {p.ModelName}" });

            ViewBag.PowerSupplies.AddRange(PowerSuppliestoselectlistiem);
        }

        private void InitializeMotherboards()
        {
            var Motherboards = context.Motherboards.ToList();

            ViewBag.Motherboards = new List<SelectListItem>();

            var Motherboardstoselectlistiem = Motherboards.Select(m => new SelectListItem() { Text = $"{m.Manufacturer} {m.ModelName}", Value = $"{m.Manufacturer} {m.ModelName}" });

            ViewBag.Motherboards.AddRange(Motherboardstoselectlistiem);
        }

        private void InitializeMemory()
        {
            var Memory = context.Memory.ToList();

            ViewBag.Memory = new List<SelectListItem>();

            var Memorystoselectlistiem = Memory.Select(m => new SelectListItem() { Text = $"{m.Manufacturer} {m.ModelName} {m.Amount} GB", Value = $"{m.Manufacturer} {m.ModelName} {m.Amount} GB" });

            ViewBag.Memory.AddRange(Memorystoselectlistiem);
        }

        private IActionResult InitializeGraphicsCards()
        {
            var GraphicsCards = context.GraphicsCards.ToList();

            ViewBag.GraphicsCards = new List<SelectListItem>();

            var graphicsCardsstoselectlistiem = GraphicsCards.Select(g => new SelectListItem() { Text = $"{g.Manufacturer} {g.ModelName}", Value = $"{g.Manufacturer} {g.ModelName}" });

            ViewBag.GraphicsCards.AddRange(graphicsCardsstoselectlistiem);

            return this.View();
        }

        private void InitializeProcessors()
        {
            var processors = context.Processors.ToList();

            ViewBag.Processors = new List<SelectListItem>();

            var processorstoselectlistiem = processors.Select(p => new SelectListItem() { Text = $"{p.Manufacturer} {p.ModelName}", Value = $"{p.Manufacturer} {p.ModelName}" });

            ViewBag.Processors.AddRange(processorstoselectlistiem);
        }

        private void InitializeCases()
        {
            var Cases = context.Cases.ToList();

            ViewBag.Cases = new List<SelectListItem>();

            var Casestoselectlistiem = Cases.Select(c => new SelectListItem() { Text = $"{c.Manufacturer} {c.ModelName}", Value = $"{c.Manufacturer} {c.ModelName}" });

            ViewBag.Cases.AddRange(Casestoselectlistiem);
        }

        private void RateSystem(PC pc)
        {
            var builder = new StringBuilder();
            double systemRating = pc.MaxSystemRating;

            if (!AreEqual(pc.Processor.Socket, pc.Motherboard.ProcessorSocketNumber))
            {
                systemRating -= 1;
                builder.AppendLine("Processor socket number and motherboard processor socket number do not match. You cannot connect the two parts.<br/>");
            }

            if (!AreEqual(pc.GraphicsCard.Socket, pc.Motherboard.GraphicsCardSocketNumber))
            {
                systemRating -= 1;
                builder.AppendLine("Graphics card socket number and motherboard graphics card socket number do not match. You cannot connect the two parts.<br/>");
            }

            if (!AreEqual(pc.Memory.Type, pc.Motherboard.MemoryType))
            {
                systemRating -= 1;
                builder.AppendLine("Motherboard does not support memory's type.<br/>");
            }

            if (!AreEqual(pc.Memory.Socket, pc.Motherboard.MemorySocketNumber))
            {
                systemRating -= 1;
                builder.AppendLine("Memory socket number and motherboard memory socket number do not match. You cannot connect the two parts.<br/>");
            }

            if ((pc.Memory.Amount) * pc.NumberOfMemorySticks > pc.Motherboard.MaxMemory)
            {
                systemRating -= 1;
                builder.AppendLine("Memory is more than the motherboard can support.<br/>");
            }

            if (pc.NumberOfMemorySticks > pc.Motherboard.NumberOfMemorySlots)
            {
                systemRating -= 1;
                builder.AppendLine("There are more memory sticks than memory slots in the motherboard.<br/>");
            }

            if (!AreEqual(pc.PowerSupply.Connector, pc.Motherboard.PowerConnector))
            {
                systemRating -= 1;
                builder.AppendLine("Motherboard does not support the power connector.<br/>");
            }

            if (pc.HardDiskDrive != null && !AreEqual(pc.HardDiskDrive.Interface, pc.Motherboard.HDDInterface))
            {
                systemRating -= 1;
                builder.AppendLine("Motherboard hard disk drive interface does not support the hard disk drive.<br/>");
            }

            if (pc.SolidStateDrive != null && !AreEqual(pc.SolidStateDrive.Interface, pc.Motherboard.SSDInterface))
            {
                systemRating -= 1;
                builder.AppendLine("Motherboard solid state drive interface does not support the solid state drive.<br/>");
            }

            if (!AreEqual(pc.Case.FormFactor, pc.Motherboard.FormFactor))
            {
                systemRating -= 1;
                builder.AppendLine("Motherboard form factor does not match case form factor.<br/>");
            }

            if (((pc.Processor.Power + pc.GraphicsCard.MaxPower) * 2) > pc.PowerSupply.Power)
            {
                systemRating -= 1;
                builder.AppendLine("Power supply cannot sustain the energy requirements of the PC's parts.<br/>");
            }

            if ((pc.Memory.Amount * pc.NumberOfMemorySticks) > pc.Processor.MaxMemorySize)
            {
                systemRating -= 1;
                builder.AppendLine("Memory is more than the processor can utilize.<br/>");
            }

            pc.SystemRating = systemRating;
            pc.SystemSummary = builder.ToString().Trim();
        }

        private bool AreEqual(string model1, string model2)
        {
            if (model1.ToLower().Trim() != model2.ToLower().Trim())
            {
                return false;
            }

            return true;
        }
        private IEnumerable<PC> IncludeProperties()
        {
            return context.PCs
                            .Include(p => p.User)
                            .Include(p => p.Processor)
                            .Include(p => p.GraphicsCard)
                            .Include(p => p.PowerSupply)
                            .Include(p => p.Memory)
                            .Include(p => p.SolidStateDrive)
                            .Include(p => p.HardDiskDrive)
                            .Include(p => p.Case)
                            .Include(p => p.Motherboard);
        }
        private static IEnumerable<PCViewModel> GetIEnumerableModel(IEnumerable<PC> pcs)
        {
            return pcs.Select(pc => new PCViewModel()
            {
                Id = pc.Id,
                Username = pc.User.UserName,
                BuildName = pc.BuildName,
                Processor = $"{pc.Processor.Manufacturer} {pc.Processor.ModelName}",
                GraphicsCard = $"{pc.GraphicsCard.Manufacturer} {pc.GraphicsCard.ModelName}",
                Memory = $"{pc.Memory.Manufacturer} {pc.Memory.ModelName} {pc.Memory.Amount} GB",
                NumberOfMemorySticks = pc.NumberOfMemorySticks,
                Motherboard = $"{pc.Motherboard.Manufacturer} {pc.Motherboard.ModelName}",
                PowerSupply = $"{pc.PowerSupply.Manufacturer} {pc.PowerSupply.ModelName}",
                SolidStateDrive = pc.SolidStateDrive != null ? $"{pc.SolidStateDrive.Manufacturer} {pc.SolidStateDrive.ModelName} {pc.SolidStateDrive.MemoryCapacity} GB" : "None",
                HardDiskDrive = pc.HardDiskDrive != null ? $"{pc.HardDiskDrive.Manufacturer} {pc.HardDiskDrive.ModelName} {pc.HardDiskDrive.MemoryCapacity} GB" : "None",
                Case = $"{pc.Case.Manufacturer} {pc.Case.ModelName}",
                CaseUrl = pc.Case.ImageUrl,
                TotalPrice = pc.TotalPrice,
                SystemRating = pc.SystemRating,
                UserRating = pc.UserRating,
                MaxSystemRating = pc.MaxSystemRating,
                UsersRatedIds = pc.UsersRatedIds
            });
        }
        private async Task<PC> BuildPC(PCBindingModel model)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var pcCase = context.Cases.FirstOrDefault(c => $"{c.Manufacturer} {c.ModelName}" == model.Case);
            var processor = context.Processors.FirstOrDefault(p => $"{p.Manufacturer} {p.ModelName}" == model.Processor);
            var graphicsCard = context.GraphicsCards.FirstOrDefault(gc => $"{gc.Manufacturer} {gc.ModelName}" == model.GraphicsCard);
            var motherboard = context.Motherboards.FirstOrDefault(m => $"{m.Manufacturer} {m.ModelName}" == model.Motherboard);
            var memory = context.Memory.FirstOrDefault(m => $"{m.Manufacturer} {m.ModelName} {m.Amount} GB" == model.Memory);
            var powerSupply = context.PowerSupplies.FirstOrDefault(ps => $"{ps.Manufacturer} {ps.ModelName}" == model.PowerSupply);
            HardDiskDrive hardDiskDrive = context.HardDiskDrives.FirstOrDefault(hdd => $"{hdd.Manufacturer} {hdd.ModelName} {hdd.MemoryCapacity} GB" == model.HardDiskDrive);
            SolidStateDrive solidStateDrive = context.SolidStateDrives.FirstOrDefault(ssd => $"{ssd.Manufacturer} {ssd.ModelName} {ssd.MemoryCapacity} GB" == model.SolidStateDrive);

            var pc = new PC()
            {
                BuildName = model.BuildName,
                Case = pcCase,
                GraphicsCard = graphicsCard,
                Processor = processor,
                Memory = memory,
                Motherboard = motherboard,
                PowerSupply = powerSupply,
                User = user,
                NumberOfMemorySticks = model.NumberOfMemorySticks,
                TotalPrice = pcCase.Price + graphicsCard.Price + processor.Price + (memory.Price * model.NumberOfMemorySticks) + motherboard.Price + powerSupply.Price
            };

            if (hardDiskDrive != null)
            {
                pc.HardDiskDrive = hardDiskDrive;
                pc.TotalPrice += hardDiskDrive.Price;
                if (solidStateDrive != null)
                {
                    pc.SolidStateDrive = solidStateDrive;
                    pc.TotalPrice += solidStateDrive.Price;
                }
                else
                {
                    pc.MaxSystemRating -= 1;
                }
            }
            else
            {
                pc.SolidStateDrive = solidStateDrive;
                pc.TotalPrice += solidStateDrive.Price;
                pc.MaxSystemRating -= 1;
            }

            return pc;
        }
        private static PCViewModel GetModel(PC pc)
        {
            return new PCViewModel()
            {
                Username = pc.User.UserName,
                BuildName = pc.BuildName,
                Processor = $"{pc.Processor.Manufacturer} {pc.Processor.ModelName}",
                GraphicsCard = $"{pc.GraphicsCard.Manufacturer} {pc.GraphicsCard.ModelName}",
                Memory = $"{pc.Memory.Manufacturer} {pc.Memory.ModelName} {pc.Memory.Amount} GB",
                NumberOfMemorySticks = pc.NumberOfMemorySticks,
                Motherboard = $"{pc.Motherboard.Manufacturer} {pc.Motherboard.ModelName}",
                PowerSupply = $"{pc.PowerSupply.Manufacturer} {pc.PowerSupply.ModelName}",
                SolidStateDrive = pc.SolidStateDrive != null ? $"{pc.SolidStateDrive.Manufacturer} {pc.SolidStateDrive.ModelName} {pc.SolidStateDrive.MemoryCapacity} GB" : "None",
                HardDiskDrive = pc.HardDiskDrive != null ? $"{pc.HardDiskDrive.Manufacturer} {pc.HardDiskDrive.ModelName} {pc.HardDiskDrive.MemoryCapacity} GB" : "None",
                Case = $"{pc.Case.Manufacturer} {pc.Case.ModelName}",
                CaseUrl = pc.Case.ImageUrl,
                TotalPrice = pc.TotalPrice,
                SystemRating = pc.SystemRating,
                UserRating = pc.UserRating,
                SystemSummary = pc.SystemSummary,
                MaxSystemRating = pc.MaxSystemRating
            };
        }
        private void InitializeView()
        {
            InitializeProcessors();
            InitializeGraphicsCards();
            InitializeMemory();
            InitializeMotherboards();
            InitializePowerSupplies();
            InitializeSolidStateDrives();
            InitializeHardDiskDrives();
            InitializeCases();
        }
    }
}