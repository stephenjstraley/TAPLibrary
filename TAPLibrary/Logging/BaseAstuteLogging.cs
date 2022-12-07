using System;
using System.Linq;
using System.Diagnostics;
using Microsoft.Azure.ServiceBus;

namespace TAPLibrary.Logging
{
    public class BaseAstuteLogging
    {
        protected static string _serviceBusConnection { get; set; }
        protected static string _serviceBusTopic { get; set; }

        protected static string _callingApp = string.Empty;

        protected static ITopicClient _topicClient;

        public void SetServiceBusConnection(string con)
        {
            _serviceBusConnection = con;
        }
        public void SetServiceBusTopic(string topic)
        {
            _serviceBusTopic = topic;
        }

        protected string GetCallingNamespace(StackTrace trace, int startingAt)
        {
            // skip 0 since it is calling routine

            var item = trace.GetFrame(startingAt);
            var callingNamespace = string.Empty;

            while (true)
            {
                if (item.GetMethod().ReflectedType != null)
                    callingNamespace = item.GetMethod().ReflectedType.Namespace;
                else
                    callingNamespace = item.GetMethod().Name;

                if (callingNamespace.ToLower().Contains("lambda_method"))
                    item = trace.GetFrame(--startingAt);
                else
                    break;
            }

            return callingNamespace;
        }

        protected string GetCallingProcedure(StackTrace trace, int startingAt)
        {
            //            var item = trace.GetFrame(startingAt);
            var procedure = string.Empty;

            var index = trace.GetFrames().ToList().FindIndex(t => t.GetMethod().Name.ToLower().Contains("lambda_method"));

            if (index > 0)
            {
                procedure = trace.GetFrame(--index).GetMethod().Name;
            }
            else
            {
                // Find the lambda expression first
                //                int stackPos = 0;
                //                bool newLook = true;
                //                while (stackPos < trace.GetFrames().Count())
                //                {
                //                    var newItem = trace.GetFrame(stackPos++);
                //                    procedure = item.GetMethod().Name;
                //                    if (procedure.ToLower().Contains("lambda_method"))
                //                    {
                //                        item = trace.GetFrame(--stackPos);
                //                        procedure = item.GetMethod().Name;
                //                        newLook = false;
                //                        break;
                //                    }
                //                }

                //                if (newLook)
                //                {
                while (true)
                {
                    var item = trace.GetFrame(startingAt);
                    if (item.GetMethod().ReflectedType != null)
                        procedure = item.GetMethod().ReflectedType.Namespace;
                    else
                        procedure = item.GetMethod().Name;

                    if (procedure.ToLower().Contains("lambda_method"))
                        procedure = trace.GetFrame(--startingAt).GetMethod().Name;
                    else
                        break;
                }
                //              }
            }

            return procedure;

        }

        // this is for logging re-broadcasts and more
        public void OverrideProcedure(string newName) => _callingApp = newName;

    }
}
