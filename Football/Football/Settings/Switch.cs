using Football.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Switch
    {
        Lazy<Video> video;
        Lazy<Camera> camera;
        Lazy<WebCamera> webCamera;

        public Switch()
        {
            video = new Lazy<Video>();
            camera = new Lazy<Camera>();
            webCamera = new Lazy<WebCamera>();
        }

        public enum Sources
        {
            Video,
            PC_Camera,
            Web_Camera
        }


        public ISource Controler (int index) // comboBox1.SelectedIndex;
        {
                switch (index)
                {
                    case 0:
                        return video.Value;
                    case 1:
                        return camera.Value;
                    case 2:
                        return webCamera.Value;
                    default:
                        return null;
                }
 
        }
    }
}
