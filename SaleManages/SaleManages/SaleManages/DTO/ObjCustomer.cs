﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManages.DTO
{
    public class ObjCustomer
    {
        
        public ObjCustomer()
        {
            Sex = "KHAC";
        }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; }
        public string Level { get; set; }
        ObjCustomer(string name,string code,string birthday,string address, string email,string phone,string sex,string level)
        {
            this.Name = name;
            this.Code = code;
            this.Birthday = birthday;
            this.Address = address;
            this.Email = email;
            this.Phone = phone;
            this.Sex = sex;
            this.Level = level;
        }
        
    }
}