using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using CakeMaui.Models;

namespace CakeMaui.Data
{
    public class OfficialFormDatabase
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<OfficialFormDatabase> Instance =
            new AsyncLazy<OfficialFormDatabase>(async () =>
            {
                var instance = new OfficialFormDatabase();
                try
                {
                    CreateTableResult result = await Database.CreateTableAsync<OfficialForm>();
                }
                catch (Exception ex)
                {

                    throw;
                }
                return instance;
            });


        public OfficialFormDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<OfficialForm>> GetItemsAsync()
        {
            return Database.Table<OfficialForm>().ToListAsync();
        }

        public Task<List<OfficialForm>> GetItemsNotDoneAsync()
        {
            return Database.QueryAsync<OfficialForm>("SELECT * FROM [OfficialForm] WHERE [Done] = 0");
        }

        public Task<OfficialForm> GetItemAsync(int id)
        {
            return Database.Table<OfficialForm>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(OfficialForm form)
        {
            if (form.ID != 0)
            {
                return Database.UpdateAsync(form);
            }
            else
            {
                return Database.InsertAsync(form);
            }
        }

        public Task<int> DeleteItemAsync(OfficialForm form)
        {
            return Database.DeleteAsync(form);
        }
    }
}
