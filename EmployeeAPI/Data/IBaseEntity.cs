using System;

namespace EmployeeAPI.Data
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
    }
}
