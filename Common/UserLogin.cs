﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESD_Project.Common
{
    [Serializable]
    public class UserLogin
    {
        public int ID { get; set; }

        public string Username { get; set; }
    }
}