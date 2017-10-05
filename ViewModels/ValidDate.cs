﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace PremierHub.ViewModels
{
    public class ValidDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "yyyy-MMM-dd ddd",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return (isValid
                //&& dateTime >= DateTime.Now
                );
        }
    }
}