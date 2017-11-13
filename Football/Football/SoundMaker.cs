using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace Football
{
    public class SoundMaker
    {
        private SoundPlayer []sounds;
        public SoundMaker()
        {
            sounds = new SoundPlayer[12];
            sounds[0] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\multikill.wav");
            sounds[1] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\damnson.wav");
            sounds[2] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\darkness.wav");
            sounds[3] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\eagleeye.wav");
            sounds[4] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\headshot.wav");
            sounds[5] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\johncena.wav");
            sounds[6] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\niceshot.wav");
            sounds[7] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\nope.wav");
            sounds[8] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\unstopabble.wav");
            sounds[9] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\victory.wav");
            sounds[10] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\startsong.wav");
            sounds[11] = new SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\FootBall\Football\Football\Sounds\panther.wav");
        }
        public void PlayRandomSound()
        {
            int SoundIndex = GetRandomNumber();
            sounds[SoundIndex].Play();
        }
        private int GetRandomNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 8);
            return number;
        }
        public void PlayIndexedSound( int index )
        {
            sounds[index].Play();
        }
        public void StopAllTracks()
        {
            for ( int i = 0; i <= 10; i++ )
            {
                sounds[i].Stop();
            }
        }
    }
}
