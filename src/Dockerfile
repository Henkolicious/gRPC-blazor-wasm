# 1. Build step
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /build

# Copy and restore
COPY /Client ./Client
COPY /Server ./Server
COPY /Shared ./Shared

# Build and publish to /out folder inside the container.
RUN cd Server && dotnet publish -c release -o /out

# 2. runtime step
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app

# Create a least privilaged user
# https://dev.to/nownabe/secure-user-in-docker-1b5m
RUN groupadd -g 61000 docker
RUN useradd -g 61000 -l -M -s /bin/false -u 61000 docker
RUN chown -R docker:docker /app
USER docker

# Copy from build/out folder to the runtime /app directory.
COPY --from=build-env /out ./

EXPOSE 5000
ENTRYPOINT ["dotnet", "gRCP.Server.dll", "--urls", "http://*:5000"]