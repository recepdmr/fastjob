using Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Domain.Entities
{
    public class Job : Entity
    {
        public Guid UserId { get; set; }
        public string Position { get; set; }
        public string Slug { get; set; }
        public Category Category { get; set; }

        public int JobStatusId { get; set; }
        public JobStatus JobStatus
        {
            get
            {
                return JobStatus.List.FirstOrDefault(x => x.Value.Equals(JobStatusId));
            }
        }

        public int JobTypeId { get; set; }
        public JobType JobType
        {
            get
            {
                return JobType.List.FirstOrDefault(x => x.Value == JobTypeId);
            }
        }
        public int GenderId { get; set; }
        public Gender Gender
        {
            get
            {
                return Gender.List.FirstOrDefault(x => x.Value == GenderId);
            }
        }

        public int ApplyTypeId { get; set; }
        public ApplyType ApplyType
        {
            get
            {
                return ApplyType.List.FirstOrDefault(x => x.Value.Equals(ApplyTypeId));
            }
        }

        public Company Company { get; set; }
        public Location Location { get; set; }
        public Contact Contact { get; set; }
    }
}
