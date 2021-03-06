﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Mobile.Models
{
    public enum MenuItemType
    {
        Home,
        About,
        Procedures,
        Profile,
        BookAppointment,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
