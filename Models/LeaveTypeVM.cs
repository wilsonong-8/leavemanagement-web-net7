using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
	public class LeaveTypeVM
	{
		public int Id { get; set; }
		[Display(Name = "Leave Type")]
		[Required]
		public string Name { get; set; }
		[Display(Name = "Default Number of Days")]
        [Required]
		[Range(1,30, ErrorMessage = "Please Enter Valid Number From 1-30")]
        public int DefaultDays { get; set; }
	}
}

