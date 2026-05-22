using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sate_Pattern
{
    public class Button
    {
        public IButtonState buttonState;

        public Button()
        {
            buttonState = new PlayState();
        }

        public void SetState(IButtonState state)
        {
            this.buttonState = state;
        }

        public void Play()
        {
            buttonState.Play(this);
        }
        public void Pause()
        {
            buttonState.Pause(this);
        }
        public void Resume()
        {
            buttonState?.Resume(this);
        }



    }
}
