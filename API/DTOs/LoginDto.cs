using System;
using Microsoft.AspNetCore.Identity;

namespace API.DTOs;

public class LoginDto
{
    public string Email { get; set; }
    public string Password { get; set; }
}
