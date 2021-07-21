using System;
using System.Collections.Generic;
using DeskBooker.Core.DataInterface;
using DeskBooker.Core.Domain;

namespace DeskBooker.DataAccess.Repositories
{
    public class DeskRepository : IDeskRepository
    {
        private readonly DeskBookerContext _context;

        public DeskRepository(DeskBookerContext context)
        {
            _context = context;
        }
        public IEnumerable<Desk> GetAvailableDesks(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Desk> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
