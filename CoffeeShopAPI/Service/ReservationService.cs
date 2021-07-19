using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeShopAPI.Interface;
using CoffeeShopAPI.Models;
using GraphQlProject.Data;

namespace CoffeeShopAPI.Service
{
    public class ReservationService:IReservation
    {
        private GraphQLDbContext _dbContext;

        public ReservationService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Reservation AddReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return _dbContext.Reservations.ToList();

        }
    }
}
