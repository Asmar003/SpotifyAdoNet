using ADONET.Helper;
using ADONET.context;
using ADONET.Models;
using ADONET.Services;
using System.Net.Http.Headers;

namespace ADONET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context =new Context();
            Console.WriteLine("Cedveli secin: ");
            Console.WriteLine("1.Music \n2.Artist");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.GetAll \n2.GetById \n3.Create \n4.Update \n5.Delete \n0.Exit");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    switch (num)
                    {
                        case 1:
                            List<Music> list = context.Musics.GetAll();
                            foreach (var item in list)
                            {
                                Console.WriteLine($"ID={item.ID}  Name={item.Name}  Duration={item.Duration}  CategoryId={item.CategoryId} ");
                            }
                            break;
                        case 2:
                            Console.WriteLine("ID-ni daxil edin:");
                            int id = Convert.ToInt16(Console.ReadLine());
                            Music item1 = context.Musics.GetById(id);
                            Console.WriteLine($"ID={item1.ID}  Name={item1.Name}  Duration={item1.Duration}  CategoryId={item1.CategoryId}");
                            break;
                        case 3:
                            Console.WriteLine("Name:");
                            string name =Console.ReadLine();
                            Console.WriteLine("Duration:");
                            int duration = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Category:");
                            int categoryid=Convert.ToInt32(Console.ReadLine());
                            List<Music> list1 = context.Musics.GetAll();
                            int max = 0;
                            foreach (var item in list1)
                            {
                                if (item.ID > max)
                                {
                                    max = item.ID;
                                }
                            }
                            Music music = new Music(max, name, duration, categoryid);
                            context.Musics.Add(music);
                            break;
                        case 4:
                        case 5:
                            Console.WriteLine("Id:");
                            int id1=Convert.ToInt16(Console.ReadLine());
                            context.Musics.Delete(id1);
                            break;
                        case 0:
                            return;
                        default:

                            break;
                    }
                    break;
                case 2:
                    switch (num)
                    {
                        case 1:
                            List<Artist> list = context.Artists.GetAll();
                            foreach (var item in list)
                            {
                                Console.WriteLine($"ID={item.ID}  Name={item.Name}  Surname={item.Surname}  Birthday={item.Birthday}  Gender={item.Gender}");
                            }
                            break;
                        case 2:
                            Console.WriteLine("ID-ni daxil edin:");
                            int id = Convert.ToInt16(Console.ReadLine());
                            Artist item1 = context.Artists.GetById(id);
                            Console.WriteLine($"ID={item1.ID}  Name={item1.Name}  Surname={item1.Surname}  Birthday={item1.Birthday} Gender={item1.Gender}");
                            break;
                        case 3:
                            Console.WriteLine("Name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Surname:");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Birthday:");
                            string birthday = Console.ReadLine();
                            Console.WriteLine("Gender:");
                            string gender = Console.ReadLine();
                            List<Artist> list1 = context.Artists.GetAll();
                            int max = 0;
                            foreach (var item in list1)
                            {
                                if (item.ID > max)
                                {
                                    max = item.ID;
                                }
                            }
                            Artist artist = new Artist(max, name, surname, birthday,gender);
                            context.Artists.Add(artist);
                            break;
                        case 4:
                        case 5:
                            Console.WriteLine("Id:");
                            int id1 = Convert.ToInt16(Console.ReadLine());
                            context.Artists.Delete(id1);
                            break;
                        case 0:
                            return;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

        }
    }
}

