using System;
using System.Collections.Generic;
using CoffeeShopAPI.Models;

namespace CoffeeShopAPI.Interface
{
    public interface IReservation
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
