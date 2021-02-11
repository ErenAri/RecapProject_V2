using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerService _customerService;
        public void Add(Customers customers)
        {
            _customerService.Add(customers);
            Console.WriteLine(customers.UserId+" Id'li Müşteri eklendi");
        }

        public void Delete(Customers customers)
        {
            _customerService.Delete(customers);
            Console.WriteLine(customers.UserId+" ID'li Müşteri silindi");
        }

        public void Update(Customers customers)
        {
            Console.WriteLine(customers.UserId+" ID'li müşteri güncellendi");
            _customerService.Update(customers);
            
        }
    }
}
