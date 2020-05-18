using AutoMapper;
using Reservations.BussinessLogic.Interfaces;
using Reservations.Data;
using Reservations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic.Services
{
    class ReservationService:IReservationService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        
        public ReservationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void CreateReservation(Shop shop, Product product, int numberOfProducts)
        {
            Reservation myReservation = new Reservation(shop, product, numberOfProducts);
            var reserve = _mapper.Map<ReservationEntity>(myReservation);
            _unitOfWork.ReservationRepository.Insert(reserve);
            _unitOfWork.Commit();
        }
    }
}
