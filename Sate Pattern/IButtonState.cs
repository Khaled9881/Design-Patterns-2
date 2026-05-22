using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sate_Pattern
{
    public interface IButtonState
    {
        public void Play(Button button);
        public void Pause(Button button);
        public void Resume(Button button);
    }
}
