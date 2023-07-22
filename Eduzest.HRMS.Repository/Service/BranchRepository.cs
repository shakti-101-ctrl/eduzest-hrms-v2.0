using AutoMapper;
using Eduzest.HRMS.DataAccess;
using Eduzest.HRMS.Entities.Entities.Employee;
using Eduzest.HRMS.Repository.DTO.Employee;
using Eduzest.HRMS.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Diagnostics;
using Serilog.Core;
using System.Linq.Expressions;

namespace Eduzest.HRMS.Repository.Service
{
    public class BranchRepository:GenericRepository<Branch>,IBranchRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
       
        
        public BranchRepository(DataContext context,IMapper _mapper) :base(context,_mapper)
        {
            this._dataContext = context;
            this._mapper = _mapper;    
            
        }
    }
}
