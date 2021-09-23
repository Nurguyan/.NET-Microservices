using PlatformService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.SyncDataServices.http
{
    public interface ICommandDataClient
    {
        Task SendPlatofrmToCommand(PlatformReadDto plat);
    }
}
