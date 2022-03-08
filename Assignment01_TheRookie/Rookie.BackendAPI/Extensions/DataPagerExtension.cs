using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Rookie.ShareClass.Dto;
using Rookie.ShareClass.Enum;
using Rookie.ShareClass.Constants;

namespace Rookie.BackendAPI.Extensions
{
    public static class DataPagerExtension
    {
        public static async Task<PagedModelDto<TModel>> PaginateAsync<TModel>(
            this IQueryable<TModel> query,
            BaseQueryCriteriaDto criteriaDto)
            where TModel : class
        {

            var paged = new PagedModelDto<TModel>();

            paged.CurrentPage = (criteriaDto.Page < 0) ? 1 : criteriaDto.Page;
            paged.PageSize = criteriaDto.Limit;

            if (!string.IsNullOrEmpty(criteriaDto.SortOrder.ToString()) && 
                !string.IsNullOrEmpty(criteriaDto.SortColumn)) {
                var sortOrder = criteriaDto.SortOrder == SortOrderEnum.Accsending ? 
                                    PagingSortingConstants.ASC : 
                                    PagingSortingConstants.DESC;
                var orderString = $"{criteriaDto.SortColumn} {sortOrder}";
                query = query.OrderBy(orderString);
            }

            var startRow = (paged.CurrentPage - 1) * paged.PageSize;

            // paged.Items = await query
            //             .Skip(startRow)
            //             .Take(paged.PageSize).ToListAsync();

            paged.Items = await Task.FromResult(query
                        .Skip(startRow)
                        .Take(paged.PageSize).ToList());

            paged.TotalItems = await Task.FromResult(query.Count());

            // paged.TotalItems = await query.CountAsync();
            paged.TotalPages = (int)Math.Ceiling(paged.TotalItems / (double)paged.PageSize);

            return paged;
        }
    }
}