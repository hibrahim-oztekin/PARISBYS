﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        public User()
        {
            UpdateContactDate = RecordDate = DateTime.Now;
            Status = true;
        }

        public Guid UserId { get; set; }
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobilePhones { get; set; }
        public bool Status { get; set; }
       // public DateTime BirthDate { get; set; }
      //  public int Gender { get; set; }
        public DateTime RecordDate { get; set; }
       
        public DateTime UpdateContactDate { get; set; }

        /// <summary>
        /// This is required when encoding token. Not in db. The default is Person.
        /// </summary>
        [NotMapped]
        public string AuthenticationProviderType { get; set; } = "Person";
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        //public bool UpdateMobilePhone(string mobilePhone)
        //{
        //    if (mobilePhone == MobilePhones)
        //    {
        //        return false;
        //    }

        //    MobilePhones = mobilePhone;
        //    return true;
        //}

    }
}
