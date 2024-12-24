using Grpc.Core;
using static GrpcService.ProductService;

namespace GrpcService.Services
{
    public partial class ProductService : ProductServiceBase // Add 'partial'.
    {
        public override Task<ProductResponse> GetProductDetails(ProductRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ProductResponse
            {
                ProductDetails = $"Details for Product ID: {request.ProductId}"
            });
        }
    }
}
