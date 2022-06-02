using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchMaster.Common.Core.Models;

public class Restaurant
{
    string Name { get; set; }
    string Description { get; set; }
    decimal DrivingDistance { get; set; }
    byte RelativeCost { get; set; }
    int[] UsersWhoBannedRestaurant { get; set; }a
}