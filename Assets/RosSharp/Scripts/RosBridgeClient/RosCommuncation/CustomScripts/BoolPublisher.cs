using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class BoolPublisher : UnityPublisher<MessageTypes.Std.Bool>
    {
        private MessageTypes.Std.Bool message;

        protected override void Start()
        {
            base.Start();
        }

        public void UpdateMessage()
        {
            message = new MessageTypes.Std.Bool();
            message.data = true;
            Publish(message);
        }
    }
}
