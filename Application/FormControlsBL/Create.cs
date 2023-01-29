﻿using Application.Core;
using Domain.Domain.Controls;
using FluentValidation;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FormControlsBL
{
    public class Create 
    {
        public class Command : IRequest<Result<Unit>>
        {
            public FormControls formControls { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.formControls).SetValidator(new FormValidation());
            }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.FormControls.Add(request.formControls);
                var result = await _context.SaveChangesAsync(cancellationToken) > 0;
                if (!result) return Result<Unit>.Failure("Unable to add FormControls");
                return Result<Unit>.Success(Unit.Value);
            }

            }
        }
}
