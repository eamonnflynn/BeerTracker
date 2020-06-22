using BeerTracker.Application.Common.Interfaces;
using System;

namespace BeerTracker.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
