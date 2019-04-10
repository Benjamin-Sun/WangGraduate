using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1.DAL
{
    class GetData
    {
        public List<nacarsdata01> selectAll()
        {
            List<nacarsdata01> db = new List<nacarsdata01>();

            using (var context = new acarsEntities())
            {
                var na = context.nacarsdata01;

                var query = na.Select(nar => nar);       //循环添加到实体类
                foreach (var q in query)
                {
                    db.Add(new nacarsdata01(
                        q.nindex,
                        q.nregister,
                        q.nflightnum,
                        q.nlat,
                        q.nlong,
                        q.naltitude,
                        q.ntemperature,
                        q.nwinddirection,
                        q.nwindspeed,
                        q.ndatetime, q.nsrcreport));
                }

                Console.WriteLine(db);
                return db;
            }
        }
    }
}
