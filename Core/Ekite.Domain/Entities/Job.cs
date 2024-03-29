﻿using Ekite.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekite.Domain.Entities
{
    public class Job : IBaseEntity
    {
        public Job()
        {
            Employees = new List<Employee>();
            Directors = new List<Director>();
            SiteOwners = new List<SiteOwner>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Director> Directors { get; set; }
        public List<SiteOwner> SiteOwners { get; set; }
    }
}