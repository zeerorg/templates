
# Information about this template

The function here takes in a [HttpContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.httpcontext?view=aspnetcore-2.1), the context object contains request and response objects which the function can directly access.

## How to use this template

1. Clone templates with:   `faas-cli template pull https://github.com/zeerorg/templates`
2. Create a function:   `faas-cli new {functionName} --lang csharp-http`
3. Inside the function directory: `cd {functionName}`
4. There are 4 files, the `FunctionHandler.cs` holds the main `Handle` function, `root.csproj` can be opened with Visual Stuudio or you can start the server with `dotnet run`
5. To deploy the function run `faas-cli up -f {functionName}.yml` outside the function directory.
