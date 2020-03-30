using System;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Integration1C.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpPost, Route("v1")]
        [Consumes("application/json", "application/xml")]
        [Produces("application/json", "application/xml")]
        public TestRequest Test([FromBody] TestRequest data)
        {
            return data;
        }
    }

    [DataContract]
    public class TestRequest
    {
        [DataMember]
        public Guid TestGuid { get; set; }
        [DataMember]
        public string TestString { get; set; }
    }
}
