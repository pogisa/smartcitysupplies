using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartcitysupply.Models.HomeViewModels
{
    public class CharityViewModel
    {
        public IDictionary<string, int> DemandCategories { get; set; }
    }
}
