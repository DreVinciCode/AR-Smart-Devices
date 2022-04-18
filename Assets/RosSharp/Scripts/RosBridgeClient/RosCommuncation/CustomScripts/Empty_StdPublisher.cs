using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class Empty_StdPublisher : UnityPublisher<MessageTypes.Std.Empty>
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
