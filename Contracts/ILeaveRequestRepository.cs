﻿using System;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
	public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
	{
		Task CreateLeaveRequest(LeaveRequestCreateVM request);

		Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();

		Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);

		Task<List<LeaveRequest>> GetAllAsync(string employeeId);

		Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();

		Task ChangeApprovalStatus(int leaveRequestId, bool approved);

		Task CancelLeaveRequest(int leaveRequestId);
	}
}

