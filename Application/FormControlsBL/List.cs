using Application.Core;
using Domain.Domain.Controls;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FormControlsBL
{
    public class List
    {
        public class Query : IRequest<Result<List<FormControls>>> 
        {
            public int FormId { get; set; }

        }
        public class Handler : IRequestHandler<Query, Result<List<FormControls>>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<List<FormControls>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var formControls = await _context.FormControls.Where(x=>x.FormId == request.FormId).Include(x=>x.OtherFields).ToListAsync();
                return Result<List<FormControls>>.Success(formControls);
            }
        }
    }
}
