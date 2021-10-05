using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Basketball_Club
{
    public class Rent
    {
        private int rent_id;
        private int user_id;
        private DateTime date;
        private int period;
        private string type;
    }
    public class Court_Rent : Rent
    {
        private int court_rent_id;
        private int court_id;
    }
    public class Equipment_Rent : Rent
    {
        private int equipment_rent_id;
        private int equipment_id;
    }
}