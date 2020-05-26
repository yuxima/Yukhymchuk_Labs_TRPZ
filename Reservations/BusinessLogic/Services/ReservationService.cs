using AutoMapper;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using DataAccessLayer.Data.Entities;
using DataAccessLayer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Services
{
    public class ReservationService:IReservationService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        
        public ReservationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void CreateReservation(int shop, int product, int numberOfProducts)
        {
            Reservation myReservation = new Reservation(shop, product, numberOfProducts);
            var reserve = _mapper.Map<ReservationEntity>(myReservation);
            _unitOfWork.ReservationRepository.Insert(reserve);
            _unitOfWork.Commit();
        }
    }
}
