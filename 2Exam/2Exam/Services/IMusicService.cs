using _2Exam.MusicDtos;

namespace _2Exam.Services
{
    public interface IMusicService
    {
        public interface IMusicService
        {
            public Guid AddMusic(MusicCreateDto musicCreateDto);
            public MusicGetDto? GetMusicByName();
            public string GetMostLikedMusic();
            public List<MusicGetDto> GetAllMusicAboveSize(double minSize);
            public List<MusicGetDto> GetTopMostLikedMusic(int count);
            public List<MusicGetDto> GetMusicWithLikesInRange(int minLikes, int maxLikes);
            public double GetTotalMusicSizeByAuthor(string authorName);


        }
    }
}