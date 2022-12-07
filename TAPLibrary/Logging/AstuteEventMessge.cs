using System;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;
using Microsoft.Azure.ServiceBus;

namespace TAPLibrary.Logging
{
    public class AstuteEventMessge : BaseAstuteLogging
    {
        public AstuteEventMessge(string connection, string topic)
        {
            SetServiceBusConnection(connection);
            SetServiceBusTopic(topic);
            _topicClient = new TopicClient(_serviceBusConnection, _serviceBusTopic);
        }
        public void Message(int companyId, string eventType, string msg)
        {
            AstuteEventModel log = null;
            
            log = CreateLog(new StackTrace().GetFrame(1));

            log.Message = msg;
            log.CompanyId = companyId;
            log.PatientId = 0;
            log.Event = eventType;

            var encMessage = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(log)));
            _topicClient.SendAsync(encMessage);
        }

        public void Message(int companyId, int patientId, string eventType, string msg)
        {
            AstuteEventModel log = null;

            log = CreateLog(new StackTrace().GetFrame(1));

            log.Message = msg;
            log.CompanyId = companyId;
            log.PatientId = patientId;
            log.Event = eventType;

            var encMessage = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(log)));
            _topicClient.SendAsync(encMessage);
        }

        protected AstuteEventModel CreateLog(StackFrame item)
        {
            var obj = new AstuteEventModel
            {
                CallingProcudure = item.GetMethod().Name,
            };
            if (item.GetMethod().ReflectedType != null)
                obj.CallingNamespace = item.GetMethod().ReflectedType.Namespace;
            else
                obj.CallingNamespace = item.GetMethod().Name;
            return obj;
        }


    }
}
