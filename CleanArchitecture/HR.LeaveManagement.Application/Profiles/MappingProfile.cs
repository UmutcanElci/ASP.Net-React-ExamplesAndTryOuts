using AutoMapper;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagementDomain;

namespace HR.LeaveManagement.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
        CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
        
    }
}