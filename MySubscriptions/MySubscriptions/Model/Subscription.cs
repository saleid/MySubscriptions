using System;
using System.Collections.Generic;
using System.Text;

namespace MySubscriptions.Model
{


    public class Subscription
    {
        public string Id { get; set; }
        public String UserId { get; set; }
        public String Name { get; set; }
        public DateTime SubscribedDate { get; set; }
        public bool IsActive { get; set; }


        public Subscription()
        {
        }

    }
}
