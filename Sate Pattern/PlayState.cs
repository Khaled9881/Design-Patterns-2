using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sate_Pattern
{
    internal class PlayState : IButtonState
    {
        public void Pause(Button button)
        {
            button.SetState(new PauseState());
        }

        public void Play(Button button)
        {
            throw new NotImplementedException();
        }

        public void Resume(Button button)
        {
            throw new NotImplementedException();
        }
    }
}
