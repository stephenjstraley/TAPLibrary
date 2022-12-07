using System.Diagnostics;

namespace TAPLibrary.Utilities
{
    public static class ReflectionUtil
    {
        public static StackFrame GetCallerFrame( string callerName )
        {
            StackFrame[] frames = new StackTrace().GetFrames();
            if( frames != null )
            {
                foreach( StackFrame frame in frames )
                {
                    //skip all frames that match this method or underlying logging caller method - Info, Fatal, Error, etc
                    if( frame.GetMethod().Name == "GetCallerFrame" || frame.GetMethod().Name == callerName )
                    {
                        continue;
                    }
                    return frame;
                }
            }
            return new StackTrace().GetFrame( 1 );
        }
    }
}
