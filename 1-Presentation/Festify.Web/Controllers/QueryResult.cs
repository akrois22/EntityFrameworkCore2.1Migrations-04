using System;
using System.Linq;

namespace Festify.Web.Controllers
{
    public class QueryResult<T>
    {
        private readonly T _result;
        private readonly bool _satisfied;

        private QueryResult(T result, bool satisfied)
        {
            _result = result;
            _satisfied = satisfied;
        }

        public T OrElse(Func<T> defaultValue)
        {
            if (_satisfied)
                return _result;
            else
                return defaultValue();
        }

        public static QueryResult<T> Some(T result)
        {
            return new QueryResult<T>(result, true);
        }

        public static QueryResult<T> None()
        {
            return new QueryResult<T>(default(T), false);
        }
    }

    public static class QueryResultExtensions
    {
        public static QueryResult<U> Return<T, U>(this IQueryable<T> query, Func<T, U> selector)
        {
            var result = query.SingleOrDefault();
            if (result != null)
                return QueryResult<U>.Some(selector(result));
            else
                return QueryResult<U>.None();
        }
    }
}