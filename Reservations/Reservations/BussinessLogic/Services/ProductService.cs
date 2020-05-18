using AutoMapper;
using Reservations.BussinessLogic.Interfaces;
using Reservations.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reservations.BussinessLogic.Services
{
    class ProductService:IProductService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<Product> GetAll()
        {
            var products = _unitOfWork.ProductRepository.GetAll();
            IEnumerable<Product> myProducts = _mapper.Map<IEnumerable<Product>>(products);
            return myProducts;
        }
        public Product GetProductByName(string name)
        {
            var products = _unitOfWork.ProductRepository.GetAll();
            IEnumerable<Product> myProducts = _mapper.Map<IEnumerable<Product>>(products);
            Product myProduct = myProducts.FirstOrDefault(p => p.Name == name);
            return myProduct;
        }
    }
}
