﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PCBuilder.Common;
using PCBuilder.Data;

namespace PCBuilder.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected PCBuilderContext context;
        protected IMapper mapper;

        public BaseController(PCBuilderContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

    }
}