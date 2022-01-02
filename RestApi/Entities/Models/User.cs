using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class User : IdentityUser
    {
        public override string Id { get; set; }

        [MaxLength(60)]
        public string Email { get; set; }

        [MaxLength(60)]
        public string Name { get; set; }

        [MaxLength(60)]
        public string Surname { get; set; }

        [MaxLength(256)]
        public string PasswordHash { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Walk>? Walks { get; set; }
        public ICollection<Donation>? Donations { get; set; }
        public ICollection<Config>? Configs { get; set; }
        public ICollection<Fundraiser>? Fundraisers { get; set; }
        public ICollection<Animal>? Animals { get; set; }
        public ICollection<AdoptionApplication>? AdoptionApplications { get; set; }

    }
}