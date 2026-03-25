var builder = DistributedApplication.CreateBuilder(args);
builder.AddAWSLambdaFunction<Projects.MyLambdaFunction>(
    name: "my-lambda",
    lambdaHandler: "MyLambdaFunction::MyLambdaFunction.Function::FunctionHandler"
);

builder.Build().Run();
