using AutoMapper;
using BusinessLogic.Abstract;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.Abstract;

namespace BusinessLogic.Implementation.Services
{
    public class ProductInShopService:IProductInShopService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public ProductInShopService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<ProductInShop> GetAll()
        {
            var products = _unitOfWork.ProductInShopRepository.GetAll();
            IEnumerable<ProductInShop> myProducts = _mapper.Map<IEnumerable<ProductInShop>>(products);
            return myProducts;
        }
        public ProductInShop GetByProduct(Product product)
        {
            var products = _unitOfWork.ProductInShopRepository.GetAll();
            IEnumerable<ProductInShop> myProducts = _mapper.Map<IEnumerable<ProductInShop>>(products);
            ProductInShop pInS = myProducts.FirstOrDefault(p => p.Product.Name == product.Name);
            return pInS;
        }
    }
}
