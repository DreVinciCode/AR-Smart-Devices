using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class EmptyPublisher : UnityPublisher<MessageTypes.Std.Empty>
    {
        private MessageTypes.Std.Empty message;

        protected override void Start()
        {
            base.Start();
            InitializeMessage();
        }

        private void InitializeMessage()
        {
            message = new MessageTypes.Std.Empty();
        }

        public void UpdateMessage()
        {
            Publish(message);
        }
    }
}
