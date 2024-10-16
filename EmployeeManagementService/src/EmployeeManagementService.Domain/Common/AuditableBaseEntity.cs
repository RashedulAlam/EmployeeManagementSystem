﻿namespace EmployeeManagementService.Domain.Common
{
    public abstract class AuditableBaseEntity<T> : BaseEntity<T>
    {
        public DateTimeOffset CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset LastModifiedAt { get; set; }

        public string LastModifiedBy { get; set; }
    }
}
