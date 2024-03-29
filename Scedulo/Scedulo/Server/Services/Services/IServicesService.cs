using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CalendaroNet.Shared.Models.Services;
using Microsoft.AspNetCore.Identity;
using Scedulo.Server.Data.Entities.Services;

namespace Scedulo.Server.Services.Services
{
    public interface IServicesService
    {
        Task<Service> GetServiceAsync(string id);
        Task<List<Service>> GetListOfAllServicesAsync();
        Task<bool> AddServiceAsync(ServiceViewModel newService);
        Task<bool> DeleteServiceAsync(string id);
        Task<bool> UpdateServiceAsync(string id, ServiceViewModel changedService);
    }
}