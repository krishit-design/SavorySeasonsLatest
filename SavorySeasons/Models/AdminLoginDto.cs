﻿namespace SavorySeasons.Models
{
    public class AdminLoginDto
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }

        public string Role { get; set; }

        public string RefreshToken { get; set; }
    }
}
