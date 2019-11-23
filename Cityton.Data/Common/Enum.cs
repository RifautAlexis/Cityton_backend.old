using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Common
{
    public enum Status
    {
        Waiting,
        Accepted
    }

    public enum StatusChallenge
    {
        InProgress,
        Waiting,
        Validated,
        Rejected
    }

    public enum Role
    {
        Member,
        Checker,
        Admin
    }

    public enum AllowedExtension
    {
        PNG,
        JPNG,
        GIF
    }
}