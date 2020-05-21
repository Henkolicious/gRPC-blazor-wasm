# gRPC Blazor WebAssembly

Very basic example.

Generated from CLI `dotnet new blazorwasm -n gRPC --hosted`

## Why is this nice?

Blazor WebAssembly runs on the client instead of the server (blazor server, other template) which reduces server costs. But the nice thing with this is that the client and the server can share **the same model**, hence you won't have to create DTO:s on the client side, like when you work with any JS-framework + REST APIs - this can be found under the /Shared folder.

Also, I've added gRPC to this, https://grpc.io/, byte array format instead of the larger JSON payloads - very efficient on the bandwidth in comparison.

Project inspiration from https://blog.stevensanderson.com/2020/01/15/2020-01-15-grpc-web-in-blazor-webassembly/ - but with updated public packages from nuget.org.

## How to run

Check browser @ `http://localhost:5000` by default

### CLI
src/Server `dotnet run`

### VS Studio
Set Server as startup project.

### Docker
From src/ `docker build -t grpcwasmdemo . && docker run -p 5000:5000 grpcwasmdemo`

### PWA
Also very limited progressive web application support - if you run from VS Studio, use IIS in the case, or configure the application to run with SSL in another way.

<img src="https://github.com/Henkolicious/gRPC-blazor-wasm/blob/master/assets/pwa.jpg" />

## Result

<img src="https://github.com/Henkolicious/gRPC-blazor-wasm/blob/master/assets/example.jpg" />
