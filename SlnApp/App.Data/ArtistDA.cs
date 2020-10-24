using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class ArtistDA
    {
        private ChinookModel _context;
        public ArtistDA()
        {
            _context = new ChinookModel();
        }

        public int Count()
        {
            return _context.Artist.Count();
        }



        public Artist Get(int id)
        {
            return _context.Artist.Find(id);
        }


        public int CountCustomers()
        {
            return _context.Customer.Count();
        }

        public List<Artist> Gets(string fitroByNombre)
        {
            return _context.Artist.Where(d=> d.Name.Contains(fitroByNombre)).ToList();
        }

        public List<Customer> GetsCustomer(string fitroByNombre)
        {
            return _context.Customer.Where(d=>d.FirstName.Contains(fitroByNombre)).ToList();
        }


        public int Insert(Artist entity)
        {
            _context.Artist.Add(entity);
            _context.SaveChanges();

            return entity.ArtistId;
        }

        public bool Update(Artist entity)
        {
            _context.Artist.Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            var result = _context.SaveChanges();

            return result > 0;
        }

        public bool Delete(Artist entity)
        {
            _context.Artist.Attach(entity);
            _context.Artist.Remove(entity);

            var result = _context.SaveChanges();


            return result > 0;
        }


        //Customers
        public int InsertCustomer(Customer entity)
        {
            _context.Customer.Add(entity);
            _context.SaveChanges();

            return entity.CustomerId;
        }

        public bool UpdateCustomer(Customer entity)
        {
            _context.Customer.Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            var result = _context.SaveChanges();

            return result > 0;
        }

        public bool DeleteCustomer(Customer entity)
        {
            _context.Customer.Attach(entity);
            _context.Customer.Remove(entity);

            var result = _context.SaveChanges();


            return result > 0;
        }
    }
}
