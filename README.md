## Description

This is a library of persistense for the System management information system.

## Automatic package
The Nuget package is hold in GitHub. This is automatically packaged and published by the GitHub workflow "dotnet.hml".

The workflow use the GITHUB_TOKEN for security. The permission of the GITHUB_TOKEN are set to read and write. 

As default this is set to read. But here it set to write too otherwise the CI will not be able to access the GitHub Packages repository.

## How to set GITHUB_TOKEN permission

1.  In your repository click **Setting**.If you cannot see the "Settings" tab, select the  dropdown menu, then click **Settings**.
2.  In the left sidebar, click  **Actions**, then click **General**.
3.  Under **Workflow permissions**, use the **Allow GitHub Actions to create and approve pull requests** setting to configure whether GITHUB_TOKEN can create and approve pull requests.
4.  Click **Save** to apply the settings.

## Versioning

Versining is given bu the GitVersion file. If you want to change the version od this package, you will need to change the version in teh GitVersion.yml file.

## packages.sh

This will build and create a packages in the local environment.
Usage:

```
./package.sh Release|Debug
```
Release or Debug are the configuration.

This will create a nuget package into the **./published** directory and then will store the package at **../package** directory
