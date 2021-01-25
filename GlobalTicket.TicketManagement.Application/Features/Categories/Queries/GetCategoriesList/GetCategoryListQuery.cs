using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoryListQuery : IRequest<List<CategoryListVm>>
    {
    }
}
