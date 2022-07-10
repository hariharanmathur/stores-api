using static Dapper.SqlMapper;

namespace Stores.DAL
{
    public interface IDapperGenericRepository
    {
        Task<List<T>> Query<T>(string query, object parameters = null);
        List<T> QueryNonAsync<T>(string query, object parameters = null);
        Task<T> QueryFirstAsync<T>(string strSql, object param);
        Task<T> QuerySingleAsync<T>(string strsql, object param);
        Task<T> QuerySingleOrDefaultAsync<T>(string strsql,object param);
        Task<GridReader> QueryMultipleAsync<T>(string strsql, object param);
        Task<int> QueryExecuteAsync<T> (string strSql,object param);
        T QueryFirst<T> (string sql,object param);
        Task<GridReader> QueryMultipleDataAsync(string sql,object param);
            
    }
}