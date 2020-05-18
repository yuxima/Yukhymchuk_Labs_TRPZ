using AutoMapper;
using Reservations.BussinessLogic.Interfaces;
using Reservations.Data;
using System.Collections.Generic;
using System.Linq;

namespace Reservations.BussinessLogic.Services
{
    class ShopService : IShopService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public ShopService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<Shop> GetAll()
        {
            var shops = _unitOfWork.ShopRepository.GetAll();
            IEnumerable<Shop> myShops = _mapper.Map<IEnumerable<Shop>>(shops);
            return myShops;
        }
        public IEnumerable<Shop> GetShopsByProduct(string productName)
        {
            var productInShop = _unitOfWork.ProductInShopRepository.GetAll();
            IEnumerable<ProductInShop> products = _mapper.Map<IEnumerable<ProductInShop>>(productInShop);
            IEnumerable<Shop> shops = products.Where(p => p.Product.Name == productName).Select(p=>p.Shop);
            return shops;
        }
        public Shop GetShopByName(string name)
        {
            var shops = _unitOfWork.ShopRepository.GetAll();
            IEnumerable<Shop> myShops = _mapper.Map<IEnumerable<Shop>>(shops);
            Shop myShop = myShops.FirstOrDefault(s => s.Name == name);
            return myShop;
        }
    }
}
