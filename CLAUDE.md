# CLAUDE.md - Development Guidelines

## Build & Run Commands
- Build the project: `dotnet build`
- Run the project: `dotnet run --project GeradorDeNumerosAleatorios`
- Build for specific platform: `dotnet build -f net8.0-android` (android|ios|maccatalyst|windows)
- Run on specific platform: `dotnet run -f net8.0-android --project GeradorDeNumerosAleatorios`
- Clean project: `dotnet clean`
- Hot reload: `dotnet watch --project GeradorDeNumerosAleatorios`

## Code Style Guidelines
- **Naming**: PascalCase for classes, methods, properties; camelCase for variables
- **Formatting**: 4-space indentation, braces on same line as declaration
- **Organization**: One class per file, namespace matches project structure
- **String formatting**: Use string interpolation ($"...") over concatenation
- **Comments**: Minimize comments, focus on "why" not "what"
- **XAML**: One element per line, consistent property ordering
- **Error handling**: Use try/catch blocks for specific exceptions
- **Resource naming**: Follow platform conventions for resources in each target platform

This is a .NET MAUI application for generating random numbers, targeting Android, iOS, MacCatalyst and Windows platforms.