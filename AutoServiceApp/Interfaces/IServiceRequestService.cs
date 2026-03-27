using AutoServiceApp.Models;

namespace AutoServiceApp.Interfaces
{
    public interface IServiceRequestService
    {
        List<ServiceRequest> GetAll();
        void Add(ServiceRequest request);
    }
}