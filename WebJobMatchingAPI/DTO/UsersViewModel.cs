using System;
using System.Collections.Generic;

namespace WebJobMatchingAPI.DTO;

public partial class UsersViewModel
{
    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly BirthDay { get; set; }

    public string FullName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Gender { get; set; } = null!;
}
