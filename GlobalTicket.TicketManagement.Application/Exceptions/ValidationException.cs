using FluentValidation.Results;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

using System.Text;

namespace GlobalTicket.TicketManagement.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> ValidationError { get; set; }

        public ValidationException(ValidationResult validationResult)
        {
            ValidationError = new List<string>();

            foreach(var validationError in validationResult.Errors)
            {
                ValidationError.Add(validationError.ErrorMessage);
            }
        }
    }
}
