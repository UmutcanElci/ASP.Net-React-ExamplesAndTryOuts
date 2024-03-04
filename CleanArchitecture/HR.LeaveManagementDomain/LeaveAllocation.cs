using HR.LeaveManagementDomain.Common;

namespace HR.LeaveManagementDomain;

public class LeaveAllocation : BaseDomainEntity
{
    public int NumberOfDays { get; set; }
    public LeaveType? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}