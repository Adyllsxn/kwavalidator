# GitHub Workflows

This repository uses GitHub Actions to automate build, test and deployment
processes for the KwaValidator library.

---

## CI Workflow (ci.yml)

The CI workflow is responsible for validating code quality and stability.

### Trigger
- Push to `main` or `develop`
- Pull requests targeting `main`

### Steps
1. Checkout repository
2. Setup .NET SDK (net10.0)
3. Restore dependencies
4. Build the solution in Release mode
5. Run all tests

This workflow ensures that every change compiles and passes tests before being merged.

---

## Deploy Workflow (deploy.yml)

The Deploy workflow is responsible for producing a publishable build.

### Trigger
- Push to `main`

### Steps
1. Checkout repository
2. Setup .NET SDK (net10.0)
3. Restore dependencies
4. Build project in Release mode
5. Publish the KwaValidator project

The output is generated in the `publish/` directory and can be used for
distribution or further automation (e.g. NuGet publishing).

---

## Notes

- Both workflows use the same .NET version as the project target framework.
- NuGet publishing can be added later using a secure API key stored in
  GitHub Secrets.
