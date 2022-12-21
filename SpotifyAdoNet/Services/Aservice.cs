using ADONET.Abstractions;
using ADONET.Helper;
using ADONET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET.Services
{
    internal class ArtistService : IService<Artist>
    {
        public void Add(Artist model)
        {
            Sql.ExecCommand($"insert into Artists values ('{model.Name}','{model.Surname}','{model.Birthday}','{model.Gender}')");

        }

        public void Delete(int Id)
        {
            Sql.ExecCommand($"delete Artists where ID={Id}");

        }

        public List<Artist> GetAll()
        {
            DataTable dt1 = Sql.ExecQuery("SELECT*FROM Artists");
            List<Artist> list1 = new List<Artist>();
            foreach (DataRow dr in dt1.Rows)
            {
                Artist artist = new Artist
                (
                    Convert.ToInt32(dr["Id"]),
                    dr["Name"].ToString(),

                   dr["Surname"].ToString(),
                   dr["Birthday"].ToString(),
                   dr["Gender"].ToString()
                 );
                list1.Add(artist);
            }
            return list1;
        }

        public Artist GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery($"SELECT*FROM Artists WHERE ID={Id}");
            DataRow dr = dt.Rows[0];
            Artist music = new Artist
                 (
                    Convert.ToInt32(dr["ID"]),
                    dr["Name"].ToString(),
                    dr["Surname"].ToString(),
                    dr["Birthday"].ToString(),
                    dr["Gender"].ToString()
                  );
            return music;
        }

        public void Update(Artist model)
        {
            throw new NotImplementedException();
        }

    }
}
