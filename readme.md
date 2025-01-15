# Playwright Automation Tests

Project containing automated test scripts using [Playwright](https://playwright.dev/) and [NUnit](https://nunit.org/).

## How to Install

### Clone Repository

```bash
git clone <repository-url>
```

### Install Dependencies

1. Ensure you have the .NET SDK installed. To install, follow the [official .NET documentation](https://dotnet.microsoft.com/en-us/download).

2. Navigate to the project folder and restore dependencies:

```bash
cd PlaywrightAutomation
dotnet restore
```

## How to Run Tests

Run all tests with the following command:

```bash
dotnet test
```

For detailed output:

```bash
dotnet test --logger "html;logfile=test-report.html"
dotnet test --verbosity detailed
```

## Folder Structure

```
/PlaywrightAutomation
    /Pages
        LoginPage.cs         # Contains page object model for login page.
    /Tests
        LoginTest.cs         # Contains test cases for login functionality.
    /Utils
        ReportHelper.cs      # Utility for generating custom reports.
    PlaywrightAutomation.csproj  # Project configuration file.
    Program.cs              # Entry point for the project.
```

## How to Customize

To add or modify tests:

1. Create or update files in the `/Tests` directory to define your test cases.
2. Use the `/Pages` directory to manage page-specific interactions using the Page Object Model pattern.
3. Use `/Utils` for reusable utilities like reporting or logging.

## Links

- [Playwright Documentation](https://playwright.dev/docs/intro)
- [NUnit Documentation](https://nunit.org/)
- [.NET SDK Documentation](https://dotnet.microsoft.com/en-us/download)

---

This README provides a concise overview of the project, its structure, and how to set up and execute tests. Expand as necessary to include additional details or features as the project evolves.

