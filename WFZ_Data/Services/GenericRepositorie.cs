using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SQLite.Net;
using SQLite.Net.Interop;
using SQLite.Net.Platform.Win32;

namespace WFZ_Data.Services
{
    public class GenericRepositorie<T> where T : Entity.Entity
    {
        private static ISQLitePlatform _platform;
        protected static ISQLitePlatform Platform => _platform ?? (_platform = new SQLitePlatformWin32());

        public GenericRepositorie()
        {
            using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
            {
                connection.CreateTable<T>();
                connection.Close();
            }
        }

        public Task<int> Insert(T entity)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Insert(entity);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<int> InsertAll(IEnumerable<T> entities)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.InsertAll(entities);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<int> InsertOrReplace(T entity)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.InsertOrReplace(entity);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<int> InsertOrReplaceAll(IEnumerable<T> entities)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.InsertOrReplaceAll(entities);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<int> InsertOrIgnore(T entity)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.InsertOrIgnore(entity);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<int> InsertOrIgnoreAll(IEnumerable<T> entities)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.InsertOrIgnoreAll(entities);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<int> Update(T entity)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Update(entity);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<int> UpdateAll(IEnumerable<T> entities)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Update(entities);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<int> Delete(T entity)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Delete<T>(entity.Id);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<int> DeleteAll()
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.DeleteAll<T>();
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<int> DeleteAll(IEnumerable<T> entities)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = 0;

                    foreach (var entity in entities)
                    {
                        connection.Delete<T>(entity);
                    }

                    connection.Close();
                    return result;
                }
            });
        }

        public Task<T> Get(long pk)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Get<T>(pk);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<T> Get(Expression<Func<T, bool>> predicate)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Get<T>(predicate);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<T> Find(long pk)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Find<T>(pk);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<T> Find(Expression<Func<T, bool>> predicate)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Find<T>(predicate);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<List<T>> Select(Expression<Func<T, bool>> predicate)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Table<T>().Where(predicate).ToList();
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<List<T>> Query(string sql, params object[] args)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Query<T>(sql, args);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<int> RunQuery(string sql, params object[] args)
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Execute(sql, args);
                    connection.Close();
                    return result;
                }
            });
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(Platform, FileManager.DBFileName);
        }

        public async Task<int> DeleteWhere(Expression<Func<T, bool>> predicate)
        {
            var data = await Select(predicate);
            return await DeleteAll(data);
        }

        public Task<long> GetLastId()
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Table<T>().Max(t => t.Id);
                    connection.Close();
                    return result;
                }
            });
        }

        public Task<List<T>> SelectAll()
        {
            return Task.Run(delegate
            {
                using (var connection = new SQLiteConnection(Platform, FileManager.DBFileName))
                {
                    var result = connection.Table<T>().ToList();
                    connection.Close();
                    return result;
                }
            });
        }
    }
}
