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
    internal class MusicService : IService<Music>
    {
        public void Add(Music model)
        {
            Sql.ExecCommand($"insert into Musics values ('{model.Name}','{model.Duration}','{model.CategoryId}')");
        }

        public void Delete(int Id)
        {
            Sql.ExecCommand($"delete Musics where ID={Id}");
        }

        public List<Music> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT*FROM Musics");
            List<Music> list = new List<Music>();
            foreach (DataRow dr in dt.Rows)
            {
                Music music = new Music
                (
                     Convert.ToInt32(dr["Id"]),
                    dr["Name"].ToString(),
                   Convert.ToInt32(dr["Duration"]),
                   Convert.ToInt32(dr["CategoryId"])
                 );
                list.Add(music);
            }
            return list;
        }

        public Music GetById(int Id)
        {
            DataTable dt = Sql.ExecQuery($"SELECT*FROM Musics WHERE ID={Id}");
            DataRow dr = dt.Rows[0];
            Music music = new Music
                 (
                    Convert.ToInt32(dr["ID"]),
                    dr["Name"].ToString(),
                    Convert.ToInt32(dr["Duration"]),
                    Convert.ToInt32(dr["CategoryId"])
                  );
            return music;
        }

        public void Update(Music model)
        {
            throw new NotImplementedException();
        }
    }
}
