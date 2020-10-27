using App.Entities.Querys;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class TrackDA
    {
        private ChinookModel _context;
        public TrackDA()
        {
            _context = new ChinookModel();
        }
        public IEnumerable<TrackConsultas> GetTrackByName(string name)
        {
            name = !string.IsNullOrEmpty(name) ? $"%{name}%" : "%";
            return _context.Database.SqlQuery<TrackConsultas>("usp_GetTracks @artistName", new SqlParameter("@artistName", name)).ToList();
        }
      
    }
}
