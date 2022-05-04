﻿using SalesMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesMVC.Services
{
    public class SellerService
    {
        private readonly SalesMVCContext _context;

        public SellerService(SalesMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {          
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
