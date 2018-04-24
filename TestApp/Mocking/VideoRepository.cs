using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace TestApp.Mocking
{

    public interface IVideoRepository
    {
        IEnumerable<Video> GetUnprocessedVideo();
    }

    public class VideoRepository : IVideoRepository
    {
        public IEnumerable<Video> GetUnprocessedVideo()
        {
            using (var context = new VideoContext())
            {
                var videos =
                   (from video in context.Videos
                    where !video.IsProcessed
                    select video).ToList();
                return videos;
            }
        }
    }
}
