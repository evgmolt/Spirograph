using System;
using System.Windows.Forms;

namespace Spiro
{
    public interface IMessageHandler
    {
          event Action<Message> WindowsMessage;
    }
}
