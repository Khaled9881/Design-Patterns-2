using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sate_Pattern
{
    internal class PauseState : IButtonState
    {
        public void Pause(Button button)
        {
            throw new NotImplementedException();
        }

        public void Play(Button button)
        {
            button.SetState(new PlayState());

        }

        public void Resume(Button button)
        {
            button.SetState(new ResumState());
        }
    }
}
