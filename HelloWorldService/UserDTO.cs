using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HelloWorldService
{

    [DataContract]
    public class UserDTO //the one suitcase i'm allowed to have when sending info to users
    {
        [DataMember]
        public List<User> userList { get; set; }
        [DataMember]
        public int ErrorCode { get; set; }
        [DataMember]
        public string ErrorMsg { get; set; }
    }
}