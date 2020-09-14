using System;

namespace PubSubSample.Contracts
{
    public class SampleEvent
    {
        DateTime created { get; set; }
        string text { get; set; }
    }
}
