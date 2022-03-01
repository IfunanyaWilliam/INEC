using Models;


namespace Core.Contracts
{
    public interface IPollingUnitRepository : IAsyncRepository<PollingUnit>, IRepository<PollingUnit>
    {
    }

}
