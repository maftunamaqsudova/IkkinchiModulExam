using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2Exam.Entities;

namespace _2Exam.Repositories
{
    public class MusicRepository:IMusicRepository
    {
       
            public List<Music> Musics;
            public MusicRepository()
            {
                Musics = new List<Music>();
            }
            public Guid AddMusic(Music music)
            {
                Musics.Add(music);
                return music.MusicId;

            }
            public static List<Music> GetAllMusicByAuthorName()
            {
                return MusicRepository.GetAllMusicByAuthorName();
            }
            public static Music GetMusicByName(string name)
            {
                if (name == null)
                {
                    return null;
                }
                if (string.IsNullOrEmpty(name))
                {
                    return new Music();
                }
                return MusicRepository.GetMusicByName(name);
            }

            public string GetMostLikedMusic(int max, int countMusic)
            {


                var maxLike = max;
                foreach (Music music in Musics)
                {
                    if (countMusic > max)
                    {
                        maxLike = countMusic;
                        break;
                    }
                }
                return maxLike.ToString();
            }

            public static List<Music> GetMusicWithLikesInRange(int countMusic, int max, int min)
            {
                List<Music> list = new List<Music>();
                var maxLike = max - 1;
                min = min - 1;
                for (int i = 0; i < countMusic; i++)
                {
                    if (i > max || i < min)
                    {
                        Music music = new Music();
                    }

                }
                return list;
            }
            public static double GetTotalMusicSizeByAuthor(string authorName, int countMusic)
            {
                int total = 0;
                if (authorName == null)
                {
                    total = 0;
                }
                if (!string.IsNullOrEmpty(authorName))
                {
                    total += 1;
                }
                return total;
            }

            
        }
    }