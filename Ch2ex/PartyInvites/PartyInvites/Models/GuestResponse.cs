using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{

    // 2.9 The model (or domain model)
    // 2.10 see Views\Home\Index.cshtml
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        // WillAttend is a nullable boolean property (bool?). It can be true, false, or null
        public bool? WillAttend { get; set; }
    }
}