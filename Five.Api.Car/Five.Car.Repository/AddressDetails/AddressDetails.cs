﻿using Five.Car.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;

namespace Five.Car.Repository
{
    public class AddressDetails : IAddressDetails
    {

        public int IAdd(Address addr)
        {
            return 1;
        }
    }
}
