using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly MySqlContext _context;
        private IMapper _mapper;

        public ProductRepository(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(long id)
        {
            Product product = await _context.Products.Where(
                currentProduct => currentProduct.Id == id
                ).FirstOrDefaultAsync() ?? new Product();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> Create(ProductVO product)
        {
            Product productCreated = _mapper.Map<Product>(product);
            _context.Products.Add(productCreated);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(productCreated);

        }
        public async Task<ProductVO> Update(ProductVO product)
        {
            Product productToUpdate = _mapper.Map<Product>(product);
            _context.Products.Update(productToUpdate);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(productToUpdate);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Product product = await _context.Products.Where(
                currentProduct => currentProduct.Id == id
                ).FirstOrDefaultAsync() ?? new Product();

                if(product.Id <= 0)
                {
                    return false;
                }
                _context.Products.Remove(product);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
