using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using restapi.Models;

namespace restapi.Controllers
{
    public class RootController : Controller
    {
        // GET api/values
        [Route("~/")]
        [HttpGet]
        [Produces(ContentTypes.Root)]
        [ProducesResponseType(typeof(IDictionary<ApplicationRelationship, object>), 200)]
        public IDictionary<ApplicationRelationship, object> Get()
        {
            return new Dictionary<ApplicationRelationship, object>()
            {
                {
                    ApplicationRelationship.Timesheets, new List<DocumentLink>()
                    {
                        new DocumentLink()
                        {
                            Method = Method.Get,
                            Type = ContentTypes.Timesheets,
                            Relationship = DocumentRelationship.Timesheets,
                            Reference = "/timesheets"
                        }
                    }
                },
                {
                    ApplicationRelationship.Version, "0.1"
                }
            };

            // Post api/values
        [Route("~/")]
        [HttpPut]
        [Produces(ContentTypes.Root)]
        [ProducesResponseType(typeof(IDictionary<ApplicationRelationship, object>), 200)]
        public IDictionary<ApplicationRelationship, object> Post()
        {
            return new Dictionary<ApplicationRelationship, object>()
            {
                {
                    ApplicationRelationship.Timesheets, new List<DocumentLink>()
                    {
                        new DocumentLink()
                        {
                            Method = Method.Post,
                            Type = ContentTypes.Timesheets,
                            Relationship = DocumentRelationship.Timesheets,
                            Reference = "/timesheets"
                        }
                    }
                },
                {
                    ApplicationRelationship.Version, "0.1"
                }
            };


            // Patch api/values
        [Route("~/")]
        [HttpGet]
        [Produces(ContentTypes.Root)]
        [ProducesResponseType(typeof(IDictionary<ApplicationRelationship, object>), 200)]
        public IDictionary<ApplicationRelationship, object> Put()
        {
            return new Dictionary<ApplicationRelationship, object>()
            {
                {
                    ApplicationRelationship.Timesheets, new List<DocumentLink>()
                    {
                        new DocumentLink()
                        {
                            Method = Method.Put,
                            Type = ContentTypes.Timesheets,
                            Relationship = DocumentRelationship.Timesheets,
                            Reference = "/timesheets"
                        }
                    }
                },
                {
                    ApplicationRelationship.Version, "0.1"
                }
            };



        }
    }


    
}
