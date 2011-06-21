﻿using System;
using System.Net;

namespace KeePass.Sources.Web.Dav
{
    internal interface IWebAction
    {
        /// <summary>
        /// Gets the method.
        /// </summary>
        string Method { get; }

        /// <summary>
        /// Handles the response.
        /// </summary>
        /// <param name="response">The response.</param>
        void Complete(HttpWebResponse response);

        /// <summary>
        /// Handles the exception.
        /// </summary>
        /// <param name="ex">The ex.</param>
        void Error(WebException ex);

        /// <summary>
        /// Initializes the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        void Initialize(HttpWebRequest request);
    }
}