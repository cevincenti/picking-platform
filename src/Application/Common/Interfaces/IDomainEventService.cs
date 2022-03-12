using PickingWSApi.Domain.Common;
using System.Threading.Tasks;

namespace PickingWSApi.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
