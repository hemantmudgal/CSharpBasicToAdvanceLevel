# Events
- A mechanisms for communication between objects.
- Used in a loosely coupled architecture.
- Helps extending application.
- In event system one should be work as a event publisher and another one should be referred as a event subscriber.

# Delegate

- Delegate is an agreement/contract between publisher and subscriber.
- Determines the signautre of the event handler method in subscriber.

### Steps for publisher and subscriber mechanism

- 1.Define a delegate.

     Defining delegate in the publisher class.<Br>
        public delegate void VideoEncodeEventHandler(object source, EventArgs arg);
-2.Define an event based on that delegate.<Br>
        public event VideoEncodeEventHandler VideoEncoded;
-3.Raise an event.<br>
        protected virtual void OnVideoEncoded(){
                if(VideoEncoded != null) 
                VideoEncoded(this, EventArgs.Empty);
        }
-4.Event publisher method should be protected, virtual and void and in the naming convetion should be start with "On".