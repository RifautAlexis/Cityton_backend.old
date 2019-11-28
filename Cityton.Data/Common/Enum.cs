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
        Member = 0,
        Checker = 1,
        Admin = 2
    }

    public enum AllowedExtension
    {
        PNG,
        JPNG,
        GIF
    }
}