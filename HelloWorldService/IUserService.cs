using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        [AspNetCacheProfile("CacheFor60Seconds")]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetAllUsers/")]
        UserDTO GetAllUsers();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetUsersByName/{name}")]
        UserDTO GetUsersByName(string name);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetUsersById/{id}")]
        UserDTO GetUsersById(string id);


        //Code from section 1 of activity
        //return string
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "SayHello/")]
        string SayHello();

        //return parameter
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetData/{value}")]
        string GetData(string value);

        //return object
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetObjectModel/{id}")]
        CompositeType GetObjectModel(string id);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
