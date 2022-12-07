using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary.Stopwatch
{
    public class AstuteStopwatch
    {
        protected static string _serviceBusConnection { get; set; }
        protected static string _serviceBusTopic { get; set; }

        protected static string _callingApp = string.Empty;

        protected static ITopicClient _topicClient;

        public AstuteStopwatch(bool isProd)
        {
            _serviceBusConnection = isProd ? Azure.Connections.SERVICE_BUS : Azure.Connections.SERVICE_BUS_QA;
            _serviceBusTopic = isProd ? Azure.StopwatchTopics.PROD : Azure.StopwatchTopics.QA;

            if (isProd)
                _topicClient = new TopicClient(Azure.Connections.SERVICE_BUS, Azure.StopwatchTopics.PROD);
            else
                _topicClient = new TopicClient(Azure.Connections.SERVICE_BUS_QA, Azure.StopwatchTopics.QA);

        }

        public string Start()
        {
            var log = new AstuteStopwatchModel()
            {
                ProcessName = "STOPWATCH",
                ProcessType = "START",
                Guid = new Guid().ToString(),
                StartStopTime = DateTime.Now
            };

            var encMessage = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(log)));
            _topicClient.SendAsync(encMessage);
            return log.Guid;
        }
        public void Stop(string guid)
        {
            var log = new AstuteStopwatchModel()
            {
                ProcessName = "STOPWATCH",
                ProcessType = "STOP",
                Guid = guid,
                StartStopTime = DateTime.Now
            };
            var encMessage = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(log)));
            _topicClient.SendAsync(encMessage);
        }
    }
}
