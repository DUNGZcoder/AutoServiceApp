using AutoServiceApp.Models;
using AutoServiceApp.Interfaces;

namespace AutoServiceApp.Services
{
    public class ServiceRequestService : IServiceRequestService
    {
        private static List<ServiceRequest> _data = new List<ServiceRequest>();

        public List<ServiceRequest> GetAll()
        {
            return _data;
        }

        public void Add(ServiceRequest request)
        {
            request.Id = _data.Count + 1;
            request.Status = "Pending";
            _data.Add(request);
        }
    }
}