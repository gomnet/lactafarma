﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LactafarmaAPI.Data.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public DateTime Modified { get; set; }

        //Navigation Properties
        public virtual ICollection<Drug> Drugs { get; set; }
        public virtual ICollection<GroupMultilingual> GroupsMultilingual { get; set; }
    }
}