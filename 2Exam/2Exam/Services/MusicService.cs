using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2Exam.Entities;
using _2Exam.MusicDtos;
using _2Exam.Repositories;

namespace _2Exam.Services
{
    public class MusicService : IMusicService
    {
       
            IMusicRepository MusicRepository;
            public MusicService()
            {
                MusicRepository = new MusicRepository();
            }

            public Guid AddMusic(MusicCreateDto musicCreateDto)
            {
                Music music = new Music()
                {
                    MusicId = Guid.NewGuid(),
                    Name = musicCreateDto.Name,
                    AuthorName = musicCreateDto.AuthorName,
                    Description = musicCreateDto.Description,
                    QuentityLikes = musicCreateDto.QuentityLikes,
                };
                MusicRepository.AddMusic(music);
                return music.MusicId;

            }

            public List<MusicGetDto> GetAllMusicAboveSize(double minSize)
            {
                return new List<MusicGetDto>();

            }

            public string GetMostLikedMusic()
            {
                throw new NotImplementedException();
            }

            public MusicGetDto? GetMusicByName()
            {
                throw new NotImplementedException();
            }

            public List<MusicGetDto> GetMusicWithLikesInRange(int minLikes, int maxLikes)
            {
                throw new NotImplementedException();
            }

            public List<MusicGetDto> GetTopMostLikedMusic(int count)
            {
                throw new NotImplementedException();
            }

            public double GetTotalMusicSizeByAuthor(string authorName)
            {
                throw new NotImplementedException();
            }
        }
    }

