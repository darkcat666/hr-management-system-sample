# Stage 1: Build the application
FROM gradle:8.5-jdk17 as build
WORKDIR /app
COPY . .
RUN gradle build --no-daemon

# Stage 2: Create the runtime image
FROM eclipse-temurin:17-jdk-jammy
VOLUME /tmp
COPY --from=build /app/build/libs/*.jar app.jar
ENTRYPOINT ["java","-jar","/app.jar"]
