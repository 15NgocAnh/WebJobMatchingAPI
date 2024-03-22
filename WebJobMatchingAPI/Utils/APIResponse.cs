using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebJobMatchingAPI.Utils
{
    public class APIResponse
    {
        public string Message { get; set; }
        public object Data { get; set; }

        public bool Success { get; set; }
    }
}
