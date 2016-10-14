using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ВебФормы
{
    public class GuestResponse
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }

    }

    public class ResponseRepository
    {
        private static ResponseRepository repository = new ResponseRepository();
        private List<GuestResponse> responses = new List<GuestResponse>();

        public static ResponseRepository GetRepository()
        {
            return repository;
        }

        public IEnumerable<GuestResponse> GetAllResponses()
        {
            return responses;
        }

        public void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}