using System.Collections.Generic;
using Microsoft.OData.ModelBuilder;

namespace AspNetCoreOData8xAutoExpandWithExpandNotConfigured.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [AutoExpand]
        public List<Order> Orders { get; set; }
    }
}
