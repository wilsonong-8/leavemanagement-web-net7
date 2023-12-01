﻿using System;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
	public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
	{
		Task CreateLeaveRequest(LeaveRequestCreateVM request);
		Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
		Task<List<LeaveRequest>> GetAllAsync(string employeeId);
		Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
	}
}
