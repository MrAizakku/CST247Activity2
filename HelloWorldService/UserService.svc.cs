using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public List<User> UserList = new List<User> { new User(1, "Bodanza", false, 55000, new List<int> { 33, 55, 66 }),
                                                      new User(2, "Vicor", true, 155000, new List<int> { 34, 75, 96 }),
                                                      new User(3, "Filo", false, 25000, new List<int> { 35, 25, 56 }),
                                                      new User(4, "Danci", false, 35000, new List<int> { 36, 35, 46 }) 
                                                    };

        public UserDTO GetAllUsers()
        {
            UserDTO userDTO = new UserDTO
            {
                ErrorCode = 0,
                ErrorMsg = "OK",
                userList = UserList
            };
            return userDTO;
        }

        public UserDTO GetUsersByName(string name)
        {
            UserDTO userDTO = new UserDTO();
            List<User> returnList = UserList.Where(m => m.Name.ToUpper().Contains(name.ToUpper())).ToList();
            userDTO.ErrorCode = returnList.Count > 0 ? 0 : -1;
            userDTO.ErrorMsg = returnList.Count > 0 ? "OK" : "User Does Not Exist";
            userDTO.userList = returnList.Count > 0 ? returnList : null;
            return userDTO;
        }

        public UserDTO GetUsersById(string id)
        {
            UserDTO userDTO = new UserDTO();
            List<User> returnList = UserList.Where(m => m.Id.Equals(Int32.Parse(id))).ToList();
            userDTO.ErrorCode = returnList.Count > 0 ?  0 : -1;
            userDTO.ErrorMsg = returnList.Count > 0 ? "OK" : "User Does Not Exist";
            userDTO.userList = returnList.Count > 0 ? returnList : null;
            return userDTO;
        }

        //Code from section 1 of activity...
        public string SayHello()
        {
            return "Hello, I have been told to say.";
        }

        public string GetData(string value)
        {
            //create some kind of response that incorporates value
            return "if your voice travels " + value + " feet, then the area your voice will cover is " + Int32.Parse(value) * Int32.Parse(value) * 3.14 + " sq feet.";
        }

        public CompositeType GetObjectModel(string id)
        {
            CompositeType ct = new CompositeType();
            if (Int32.Parse(id) > 0)
            {
                ct.BoolValue = true;
                ct.StringValue = "What a wonderful number you've entered there...";
            }
            else
            {
                ct.BoolValue = false;
                ct.StringValue = "I am very saddened by your choices today...";
            }
            return ct;
        }
    }
}
