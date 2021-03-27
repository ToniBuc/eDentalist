using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Procedures,
        Profile,
        BookAppointment
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
