﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(o => o.UserName)
                .NotEmpty().WithMessage("{UserName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{UserName} must not exceed 50 characters.");

            RuleFor(o => o.EmailAddress)
                .NotEmpty().WithMessage("{Email Address} is required.");

            RuleFor(o => o.TotalPrice)
                .NotEmpty().WithMessage("{Total Price} is required.")
                .GreaterThan(0).WithMessage("{Total Price} should be greater than zero.");
        }
    }
}
