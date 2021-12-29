namespace StructuredMinimalApi.Application.Todos.Queries.GetTodo5
{
    public class PagingData
    {
        public int CurrentPage { get; init; } = 1;
        public int PageSize { get; init; } = 5;

        public PagingData(int page, int pagesize)
        {
            CurrentPage = page;
            PageSize = pagesize;
        }
        public PagingData()
        {

        }

        public static ValueTask<PagingData?> BindAsync(HttpContext context)
        {

            int.TryParse(context.Request.Query["page"], out var page);
            int.TryParse(context.Request.Query["pageSize"], out var pageSize);

            var result = new PagingData
            {
                CurrentPage = page,
                PageSize = pageSize
            };

            // init key word block 
            //result.PageSize = pageSize;

            return ValueTask.FromResult<PagingData?>(result);
        }

        public static bool TryParse(string? value, IFormatProvider? provider, out PagingData? pagingData)
        {
            pagingData = new PagingData();
            return false;
        }
    }
}
