using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace MailSender.Infrastructure.ValidationRules
{
    public class RegExValidationRules : ValidationRule
    {
        private Regex regex;
        public string Pattern
        {
            get => regex.ToString();
            set => regex = value is null ? null : value == string.Empty ? null : new Regex(value);
        }

        public bool AllowNull { get; set; }
        public string ErrorMessage { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is null)
                return AllowNull ? ValidationResult.ValidResult : new ValidationResult(false, ErrorMessage ?? "Отсутствует ссылка на строку");

            if (regex == null) return ValidationResult.ValidResult;

            if (!(value is string str)) str = value.ToString();
            return regex.IsMatch(str) ? ValidationResult.ValidResult : new ValidationResult(false, ErrorMessage ?? $"Строка не удовлетворяет регулярному выражению {regex}"); 
        }
        
    }
}
