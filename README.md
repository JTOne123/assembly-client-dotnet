# AssemblyClient - the C# library for the Assembly Developer API

The Assembly API is built around the REST and a collection of open standards/protocols in order to comply with as many consumers as possible.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [http://developers.assembly.education](http://developers.assembly.education)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out AssemblyClient.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AcademicYearsApi();
            var id = 56;  // int? | id of the AcademicYear

            try
            {
                // View an Academic Year
                AcademicYear result = apiInstance.AcademicYear(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AcademicYearsApi.AcademicYear: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://api-sandbox.lvh.me:3020*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AcademicYearsApi* | [**AcademicYear**](docs/AcademicYearsApi.md#academicyear) | **GET** /academic_years/{id} | View an Academic Year
*AcademicYearsApi* | [**AcademicYears**](docs/AcademicYearsApi.md#academicyears) | **GET** /academic_years | List Academic Years
*AssessmentPointsApi* | [**AssessmentPoint**](docs/AssessmentPointsApi.md#assessmentpoint) | **GET** /assessment_points/{id} | View an Assessment Point
*AssessmentPointsApi* | [**AssessmentPointResults**](docs/AssessmentPointsApi.md#assessmentpointresults) | **GET** /assessment_points/{id}/results | View Results for an Assessment Point
*AssessmentPointsApi* | [**AssessmentPoints**](docs/AssessmentPointsApi.md#assessmentpoints) | **GET** /assessment_points | List Assessment Points
*AssessmentsApi* | [**Assessment**](docs/AssessmentsApi.md#assessment) | **GET** /assessments/{id} | View an Assessment
*AssessmentsApi* | [**AssessmentGradeSets**](docs/AssessmentsApi.md#assessmentgradesets) | **GET** /assessments/{id}/grade_set | View Grade Set for an Assessment
*AssessmentsApi* | [**AssessmentResults**](docs/AssessmentsApi.md#assessmentresults) | **GET** /assessments/{id}/results | View Results for an Assessment
*AssessmentsApi* | [**Assessments**](docs/AssessmentsApi.md#assessments) | **GET** /assessments | List Assessments
*FacetsApi* | [**Facet**](docs/FacetsApi.md#facet) | **GET** /facets/{id} | View a Facet
*FacetsApi* | [**Facets**](docs/FacetsApi.md#facets) | **GET** /facets | List Facets
*ResultsApi* | [**Results**](docs/ResultsApi.md#results) | **GET** /results | List Results
*ResultsApi* | [**SaveResults**](docs/ResultsApi.md#saveresults) | **POST** /results | Write Results
*StudentsApi* | [**LeftStudents**](docs/StudentsApi.md#leftstudents) | **GET** /students/left | List Left Students
*StudentsApi* | [**Student**](docs/StudentsApi.md#student) | **GET** /students/{id} | View a Student
*StudentsApi* | [**Students**](docs/StudentsApi.md#students) | **GET** /students | List Students


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AcademicYear](docs/AcademicYear.md)
 - [Model.AcademicYearList](docs/AcademicYearList.md)
 - [Model.AcademicYearTerms](docs/AcademicYearTerms.md)
 - [Model.Assessment](docs/Assessment.md)
 - [Model.AssessmentList](docs/AssessmentList.md)
 - [Model.AssessmentPointList](docs/AssessmentPointList.md)
 - [Model.Facet](docs/Facet.md)
 - [Model.FacetList](docs/FacetList.md)
 - [Model.Grade](docs/Grade.md)
 - [Model.GradeList](docs/GradeList.md)
 - [Model.GradeSet](docs/GradeSet.md)
 - [Model.GradeSetList](docs/GradeSetList.md)
 - [Model.Result](docs/Result.md)
 - [Model.ResultList](docs/ResultList.md)
 - [Model.ResultResult](docs/ResultResult.md)
 - [Model.Student](docs/Student.md)
 - [Model.StudentList](docs/StudentList.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="bearerAuth"></a>
### bearerAuth

- **Type**: HTTP basic authentication

