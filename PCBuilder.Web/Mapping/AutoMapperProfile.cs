using AutoMapper;
using PCBuilder.Models;
using System;
using System.Collections.Generic;
using System.Text;
using PCBuilder.Common.Models.ViewModels;
using PCBuilder.Common.Models.BindingModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PCBuilder.Web.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<ProcessorBindingModel, Processor>();
            this.CreateMap<ProcessorBindingModel, Processor>().ReverseMap();
            this.CreateMap<Processor, ProcessorViewModel>();

            this.CreateMap<CaseBindingModel, Case>();
            this.CreateMap<CaseBindingModel, Case>().ReverseMap();
            this.CreateMap<Case, CaseViewModel>();

            this.CreateMap<MemoryBindingModel, Memory>();
            this.CreateMap<MemoryBindingModel, Memory>().ReverseMap();
            this.CreateMap<Memory, MemoryViewModel>();

            this.CreateMap<PowerSupplyBindingModel, PowerSupply>();
            this.CreateMap<PowerSupplyBindingModel, PowerSupply>().ReverseMap();
            this.CreateMap<PowerSupply, PowerSupplyViewModel>();

            this.CreateMap<MotherboardBindingModel, Motherboard>();
            this.CreateMap<MotherboardBindingModel, Motherboard>().ReverseMap();
            this.CreateMap<Motherboard, MotherboardViewModel>();

            this.CreateMap<HardDiskDriveBindingModel, HardDiskDrive>();
            this.CreateMap<HardDiskDriveBindingModel, HardDiskDrive>().ReverseMap();
            this.CreateMap<HardDiskDrive, HardDiskDriveViewModel>();

            this.CreateMap<SolidStateDriveBindingModel, SolidStateDrive>();
            this.CreateMap<SolidStateDriveBindingModel, SolidStateDrive>().ReverseMap();
            this.CreateMap<SolidStateDrive, SolidStateDriveViewModel>();
        }
    }
}
