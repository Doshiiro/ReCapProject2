using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {

       [Key] public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
