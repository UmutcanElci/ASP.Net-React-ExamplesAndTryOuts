using HR.LeaveManagementDomain.Common;

namespace HR.LeaveManagementDomain;

public class LeaveType : BaseDomainEntity
{
    public string? Name { get; set; }
    public int DefaultDays { get; set; }
}