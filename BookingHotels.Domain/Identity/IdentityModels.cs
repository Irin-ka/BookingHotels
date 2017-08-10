﻿using BookingHotels.Domain.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingHotels.Domain.Identity
{
    // Extend Identity classes to specify a Guid for the key
    public class CustomUserRole : IdentityUserRole<Guid> 
    {
        //public Guid ApplicationUser_Id { get; set; }
    }
    public class CustomUserClaim : IdentityUserClaim<Guid> { }
    public class CustomRole : IdentityRole<Guid, CustomUserRole>
    {
        public CustomRole()
        {
            Id = Guid.NewGuid();
        }
        public CustomRole(string name) 
            { 
                Id = Guid.NewGuid();
                Name = name; 
            }
    }
    public class CustomUserLogin : IdentityUserLogin<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class CustomUserRegister
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Name { get; set; }
    }
    //  responsible to manage instances of the roles
    public class ApplicationRoleManager : RoleManager<CustomRole, Guid>
    {
        public ApplicationRoleManager(IRoleStore<CustomRole, Guid> roleStore)
            : base(roleStore)
        { }
    }

    //  responsible to manage instances of the user class
    public class ApplicationUserManager : UserManager<ApplicationUser, Guid>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser, Guid> store)
            : base(store)
        { }
    }
}
