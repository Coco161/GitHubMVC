﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GitHubMVC.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), 
                "dd MMM yyyy", 
                DateTimeFormatInfo.InvariantInfo, 
                DateTimeStyles.None, 
                out dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}