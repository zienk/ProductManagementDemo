﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class AccountMember
    {
        public string MemberId { get; set; } = null!;
        public string MemberPassword { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string? EmailAddress { get; set; } = null!;
        public int? MemberRole { get; set; }
    }
}
