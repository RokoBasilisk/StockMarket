using Application.Dtos;
using Application.Wrapper.Abstract;
using Application.Wrapper.Concrete;
using MediatR;

namespace Application.Features.Stocks.Queries
{
    public class GetStockWithIdQuery : IRequest<DataResponse<IEnumerable<StockDto>>>
    {
        public class GetStockWithIdQueryHandler : IRequestHandler<GetStockWithIdQuery, DataResponse<IEnumerable<StockDto>>>
        {
            public GetStockWithIdQueryHandler() {
            }
            public Task<DataResponse<IEnumerable<StockDto>>> Handle(GetStockWithIdQuery request, CancellationToken cancellationToken)
            {
                
            }
        }


    }
}
