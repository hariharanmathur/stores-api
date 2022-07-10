using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.DAL
{
    public class DapperGenericRespository : IDapperGenericRepository
    {
        private readonly IDbConnection _dbConnection;
        private Task _dbconnection;

        public DapperGenericRespository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;   
        }
        public void Dispose()
        {
            _dbConnection.Close();
        }
        public async Task<List<T>> Query<T>(string query, object parameters = null)
        {
            var result = await _dbConnection.QueryAsync<T>(query, parameters);
            return result.ToList();
        }

        public async Task<int> QueryExecuteAsync<T>(string strSql, object param)
        {
            return await _dbConnection.ExecuteAsync(strSql, param);
        }

        public T QueryFirst<T>(string sql, object param)
        {
            return _dbConnection.QueryFirstOrDefault<T>(sql, param);
        }

        public async Task<T> QueryFirstAsync<T>(string strSql, object param)
        {
            return await _dbConnection.QueryFirstOrDefaultAsync<T>(strSql, param);
        }

        public async Task<SqlMapper.GridReader> QueryMultipleAsync<T>(string strsql, object param)
        {
            return await _dbConnection.QueryMultipleAsync(strsql); 
        }

        public async Task<SqlMapper.GridReader> QueryMultipleDataAsync(string sql, object param)
        {
            return await _dbConnection.QueryMultipleAsync(sql, param);
        }

        public List<T> QueryNonAsync<T>(string query, object parameters = null)
        {
            var result = _dbConnection.Query<T>(query, parameters);
            return result.ToList();
        }

        public async Task<T> QuerySingleAsync<T>(string strsql, object param)
        {
            return await _dbConnection.QuerySingleAsync<T>(strsql, param);
        }

        public async Task<T> QuerySingleOrDefaultAsync<T>(string strsql, object param)
        {
            return await _dbConnection.QuerySingleOrDefaultAsync<T>(strsql, param);
        }
    }
}
