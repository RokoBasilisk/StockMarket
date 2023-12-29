using Application.Wrapper.Abstract;
using MediatR;

namespace Application.Features.Stocks.Queries
{
    public class GetStockWithId : IRequest<IResponse>
    {
        public GetStockWithId() { }
        
    }
}
