using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Football
{
    class InputThread
    {
        private static InputThread instance = null;
        public Thread TakeData;
        
        private InputThread() {
            TakeInfoAboutTeams();
        }

        public static InputThread Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InputThread();
                }
                return instance;
            }
        }

        private void TakeInfoAboutTeams()
        {
            FormAllTeams teams = new FormAllTeams();
            TakeData = new Thread(() => teams.FillData());
            TakeData.Start();
        }

        public void Start() {

            TakeData.Join();
        }
    }
}
