# Coding Challenge (JSONBasedWebService)

This project is used to generate and filter the JSON results based on the provided JSON.

From the list of shows in the request payload, return the ones with DRM enabled (drm: true) and at least one episode (episodeCount > 0).

The returned JSON should have a response key with an array of shows. Each element should have the following fields from the request:

image - corresponding to image/showImage from the request payload
slug
title


## Getting Started

- Clone the Project
- Open the solution in VS 2017
- Restore the Nuget Packages
- Run the project named "JSONBasedWebService.Web"


## Running the tests

- Run the Project named "JSONBasedWebService.Core.Tests" to run unit test cases
- Currently there are 3 unit test cases for different cases.


## Built With

* ASP.Net MVC (Web API)
* C#
* UnitTest Project


## Versioning

* 1.0.0.0

