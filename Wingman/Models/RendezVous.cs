using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wingman.Models
{
    public class RendezVous
    {
        int RdvID { get; set; }
        string RdvType { get; set; }
        int BudgetID { get; set; }
        int TimeID { get; set; }
        int SeasonID { get; set; }
        int LengthID { get; set; }
        int LocationID { get; set; }
        int MoodID { get; set; }


    }
}