using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Models
{
    internal class Country
    {
    public string countryName { get; set; }
    public double countryId { get; set; }
    public double area {  get; set; }
    public string anthem {  get; set; }
    public Region region { get; set; }

    public string planet {  get; set; }

    }
}
