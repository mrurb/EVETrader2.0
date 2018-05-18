using System;
using System.Collections.Generic;
using System.Text;

namespace IOApiClient.ESI.Client
{
    public class ApiResponse<T>
    {
		public int StatusCode { get; private set; }
		public IDictionary<string, string> Headers { get; private set; }
		public T Data { get; private set; }

		public ApiResponse(int statusCode, IDictionary<string, string> headres, T data)
		{
			this.StatusCode = statusCode;
			this.Headers = Headers;
			this.Data = data;
		}
	}
}
