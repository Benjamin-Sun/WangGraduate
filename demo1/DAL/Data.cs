using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1.DAL
{
    public class Data
    {
        private DateTime date = new DateTime(2019, 4, 1, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        //查询所有
        public List<nacarsdata01> selectAll()
        {
            List<nacarsdata01> db = new List<nacarsdata01>();

            using (var context = new acarsEntities())
            {
                var query = context.nacarsdata01
                    .Select(nar => nar);
                
                foreach (var q in query)
                {
                    nacarsdata01 nacarsdata = new nacarsdata01();

                    nacarsdata.nindex = q.nindex;
                    nacarsdata.nregister = q.nregister;
                    nacarsdata.nflightnum = q.nflightnum;
                    nacarsdata.nlat = q.nlat;
                    nacarsdata.nlong = q.nlong;
                    nacarsdata.naltitude = q.naltitude;
                    nacarsdata.ntemperature = q.ntemperature;
                    nacarsdata.nwinddirection = q.nwinddirection;
                    nacarsdata.nwindspeed = q.nwindspeed;
                    nacarsdata.ndatetime = q.ndatetime;

                    db.Add(nacarsdata);
                }

                return db;
            }
        }
    
        //根据高度范围查询
        public List<nacarsdata01> selectByNalt(int min, int max)
        {
            using (var context = new acarsEntities())
            {
                List<nacarsdata01> db = new List<nacarsdata01>();

                var query = context.nacarsdata01
                    .Where(nalt => nalt.naltitude >= min && nalt.naltitude < max)
                    .Select(nalt => nalt);

                foreach (var q in query)
                {
                    nacarsdata01 nacarsdata = new nacarsdata01();

                    nacarsdata.nindex = q.nindex;
                    nacarsdata.nregister = q.nregister;
                    nacarsdata.nflightnum = q.nflightnum;
                    nacarsdata.nlat = q.nlat;
                    nacarsdata.nlong = q.nlong;
                    nacarsdata.naltitude = q.naltitude;
                    nacarsdata.ntemperature = q.ntemperature;
                    nacarsdata.nwinddirection = q.nwinddirection;
                    nacarsdata.nwindspeed = q.nwindspeed;
                    nacarsdata.ndatetime = q.ndatetime;

                    db.Add(nacarsdata);
                }

                return db;
            }
        }

        public List<nacarsdata01> selectByNaltAndTime(int min, int max, int t)
        {
            using (var context = new acarsEntities())
            {
                List<nacarsdata01> db = new List<nacarsdata01>();

                var query = context.nacarsdata01
                    .Where(nalt => nalt.naltitude >= min && nalt.naltitude < max 
                    && nalt.ndatetime > date.AddHours(t) && nalt.ndatetime < date)
                    .Select(nalt => nalt);

                foreach (var q in query)
                {
                    nacarsdata01 nacarsdata = new nacarsdata01();

                    nacarsdata.nindex = q.nindex;
                    nacarsdata.nregister = q.nregister;
                    nacarsdata.nflightnum = q.nflightnum;
                    nacarsdata.nlat = q.nlat;
                    nacarsdata.nlong = q.nlong;
                    nacarsdata.naltitude = q.naltitude;
                    nacarsdata.ntemperature = q.ntemperature;
                    nacarsdata.nwinddirection = q.nwinddirection;
                    nacarsdata.nwindspeed = q.nwindspeed;
                    nacarsdata.ndatetime = q.ndatetime;

                    db.Add(nacarsdata);
                }

                return db;
            }
        }
    }
}
