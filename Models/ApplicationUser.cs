using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GigHub.Models
{
    public class ApplicationUser : IdentityUser
    {
        /*[Required]
        [StringLength(100)]
        public string Email { get; set; }*/


        public ApplicationUser()
        {

        }

        /*[Required]
        [StringLength(255)]
        public override string UserName
        {
            get
            {
                return base.UserName;
            }
            set
            {
                base.UserName = value;
            }
        }*/

        //public void Notify(Notification notification)
        //{
        //    var userNotification = new UserNotification(this, notification);
        //    UserNotitifications.Add(userNotification);
        //}
    }
}