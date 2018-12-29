using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Function
{
    public class FunctionHandler
    {
        public async Task Handle(HttpContext context)
        {
            string responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
            await context.Response.WriteAsync(responseString);
        }
            
    }
}
