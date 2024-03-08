namespace HR.LeaveManagement.Application.DTOs.LeaveRequest;

public class LeaveRequestListDto
{
    public LeaveTypeDto LeaveType { get; set; }
    public DateTime DateRequested { get; set; }
    public bool? Aprroved { get; set; }
}