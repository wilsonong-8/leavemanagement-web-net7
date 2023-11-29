using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public EmployeesController(UserManager<Employee>userManager,
            IMapper mapper,
            ILeaveAllocationRepository leaveAllocationRepository,
            ILeaveTypeRepository leaveTypeRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.leaveTypeRepository = leaveTypeRepository;
        }

        // GET: Employees
        public async Task<IActionResult> IndexAsync()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: Employees/ViewAllocations/employeeId
        public async Task<ActionResult> ViewAllocations(string id)
        {
            var model = await leaveAllocationRepository.GetEmployeeAllocations(id);
            return View(model);
        }


        // GET: Employees/Edit/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var model = await leaveAllocationRepository.GetEmployeeAllocation(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                // TODO: Add update logic here
                if(ModelState.IsValid)
                {
                    var leaveAllocation = await leaveAllocationRepository.GetAsync(model.Id);
                    if(leaveAllocation == null)
                    {
                        return NotFound();
                    }
                    leaveAllocation.Period = model.Period;
                    leaveAllocation.NumberOfDays = model.NumberOfDays;
                    await leaveAllocationRepository.UpdateAsync(leaveAllocation);

                    return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An Error has occured. Please try again later.");
            }
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(model.LeaveTypeId));
            return View(model);
        }
    }
}