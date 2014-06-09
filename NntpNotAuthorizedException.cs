using System;
using System.Runtime.Serialization;

namespace NntpClientLib
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class NntpNotAuthorizedException : NntpException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NntpNotAuthorizedException"/> class.
        /// </summary>
        public NntpNotAuthorizedException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="NntpNotAuthorizedException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public NntpNotAuthorizedException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="NntpNotAuthorizedException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public NntpNotAuthorizedException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="NntpNotAuthorizedException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"></see> is zero (0). </exception>
        /// <exception cref="T:System.ArgumentNullException">The info parameter is null. </exception>
        protected NntpNotAuthorizedException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    } 
}

