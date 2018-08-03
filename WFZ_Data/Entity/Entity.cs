using System;
using SQLite.Net.Attributes;

namespace WFZ_Data.Entity
{
    public class Entity
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
