# IIMMPACT - The C# library for IIMMPACT API

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


### NuGet

#### Package Manager

Install-Package iimmpact 

#### .NET CLI

dotnet add package iimmpact 

#### PackageReference

```
<PackageReference Include="iimmpact" Version="1.2.2" />
```

## How to use       
```csharp
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new AuthorizationTokenApi();
            var tokenRequest = new TokenRequest(); // TokenRequest | 

            try
            {
                TokenResponse result = apiInstance.V1TokenPost(tokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationTokenApi.V1TokenPost: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.iimmpact.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthorizationTokenApi* | [**V1TokenPost**](docs/AuthorizationTokenApi.md#v1tokenpost) | **POST** /v1/token | 
*AuthorizationTokenApi* | [**V1TokenRefreshPost**](docs/AuthorizationTokenApi.md#v1tokenrefreshpost) | **POST** /v1/token/refresh | 
*CallbackUrlApi* | [**V1CallbackUrlGet**](docs/CallbackUrlApi.md#v1callbackurlget) | **GET** /v1/callback-url | 
*CallbackUrlApi* | [**V1CallbackUrlPost**](docs/CallbackUrlApi.md#v1callbackurlpost) | **POST** /v1/callback-url | 
*CarInsuranceApi* | [**V1CarInsuranceGet**](docs/CarInsuranceApi.md#v1carinsuranceget) | **GET** /v1/car-insurance | 
*JPJRecordsApi* | [**V1JpjDrivingLicenseGet**](docs/JPJRecordsApi.md#v1jpjdrivinglicenseget) | **GET** /v1/jpj/driving-license | 
*JPJRecordsApi* | [**V1JpjDrivingTestResultsGet**](docs/JPJRecordsApi.md#v1jpjdrivingtestresultsget) | **GET** /v1/jpj/driving-test-results | 
*JPJRecordsApi* | [**V1JpjMotorVehicleExpiryGet**](docs/JPJRecordsApi.md#v1jpjmotorvehicleexpiryget) | **GET** /v1/jpj/motor-vehicle-expiry | 
*JPJRecordsApi* | [**V1JpjSummonsGet**](docs/JPJRecordsApi.md#v1jpjsummonsget) | **GET** /v1/jpj/summons | 
*LowBalanceWarningApi* | [**V1LowBalanceThresholdGet**](docs/LowBalanceWarningApi.md#v1lowbalancethresholdget) | **GET** /v1/low-balance-threshold | 
*LowBalanceWarningApi* | [**V1LowBalanceThresholdPost**](docs/LowBalanceWarningApi.md#v1lowbalancethresholdpost) | **POST** /v1/low-balance-threshold | 
*MyAccountApi* | [**V1AuthChangePasswordPost**](docs/MyAccountApi.md#v1authchangepasswordpost) | **POST** /v1/auth/change-password | 
*MyAccountApi* | [**V1AuthNewPasswordChallengePost**](docs/MyAccountApi.md#v1authnewpasswordchallengepost) | **POST** /v1/auth/new-password-challenge | 
*MyAccountApi* | [**V1BalanceGet**](docs/MyAccountApi.md#v1balanceget) | **GET** /v1/balance | 
*ProductEnquiryApi* | [**V1ProductsGet**](docs/ProductEnquiryApi.md#v1productsget) | **GET** /v1/products | 
*ServicesApi* | [**V1BillPresentmentGet**](docs/ServicesApi.md#v1billpresentmentget) | **GET** /v1/bill-presentment | 
*ServicesApi* | [**V1NetworkstatusGet**](docs/ServicesApi.md#v1networkstatusget) | **GET** /v1/networkstatus | 
*ServicesApi* | [**V1TopupPost**](docs/ServicesApi.md#v1topuppost) | **POST** /v1/topup | 
*TransactionHistoryApi* | [**V1BalanceStatementGet**](docs/TransactionHistoryApi.md#v1balancestatementget) | **GET** /v1/balance-statement | 
*TransactionHistoryApi* | [**V1TransactionsGet**](docs/TransactionHistoryApi.md#v1transactionsget) | **GET** /v1/transactions | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BalanceResponse](docs/BalanceResponse.md)
 - [Model.BalanceResponseData](docs/BalanceResponseData.md)
 - [Model.BalanceStatementResponse](docs/BalanceStatementResponse.md)
 - [Model.BalanceStatementResponseData](docs/BalanceStatementResponseData.md)
 - [Model.BalanceStatementResponseLinks](docs/BalanceStatementResponseLinks.md)
 - [Model.BalanceStatementResponseMeta](docs/BalanceStatementResponseMeta.md)
 - [Model.BillPresentmentResponse](docs/BillPresentmentResponse.md)
 - [Model.BillPresentmentResponseData](docs/BillPresentmentResponseData.md)
 - [Model.BillPresentmentResponseMetadata](docs/BillPresentmentResponseMetadata.md)
 - [Model.CallbackUrlResponse](docs/CallbackUrlResponse.md)
 - [Model.CallbackUrlResponseData](docs/CallbackUrlResponseData.md)
 - [Model.CallbackUrlResponseMetadata](docs/CallbackUrlResponseMetadata.md)
 - [Model.CarInsuranceRespone](docs/CarInsuranceRespone.md)
 - [Model.CarInsuranceResponeVariant](docs/CarInsuranceResponeVariant.md)
 - [Model.ChangePasswordRequest](docs/ChangePasswordRequest.md)
 - [Model.DepositRequest](docs/DepositRequest.md)
 - [Model.DrivingLicenseRespone](docs/DrivingLicenseRespone.md)
 - [Model.DrivingLicenseResponeInner](docs/DrivingLicenseResponeInner.md)
 - [Model.Empty](docs/Empty.md)
 - [Model.Error](docs/Error.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2002Data](docs/InlineResponse2002Data.md)
 - [Model.InlineResponse200Data](docs/InlineResponse200Data.md)
 - [Model.JPJRecordsResponse](docs/JPJRecordsResponse.md)
 - [Model.LowBalanceWarningResponse](docs/LowBalanceWarningResponse.md)
 - [Model.LowBalanceWarningResponseData](docs/LowBalanceWarningResponseData.md)
 - [Model.LowBalanceWarningResponseMetadata](docs/LowBalanceWarningResponseMetadata.md)
 - [Model.NetworkStatusResponse](docs/NetworkStatusResponse.md)
 - [Model.NetworkStatusResponseData](docs/NetworkStatusResponseData.md)
 - [Model.NetworkStatusResponseMetadata](docs/NetworkStatusResponseMetadata.md)
 - [Model.NewPasswordRequest](docs/NewPasswordRequest.md)
 - [Model.NewPasswordResponses](docs/NewPasswordResponses.md)
 - [Model.OnlyMessageRespone](docs/OnlyMessageRespone.md)
 - [Model.RefreshTokenRequest](docs/RefreshTokenRequest.md)
 - [Model.RefreshTokenResponse](docs/RefreshTokenResponse.md)
 - [Model.RefreshTokenResponseAuthenticationResult](docs/RefreshTokenResponseAuthenticationResult.md)
 - [Model.TokenRequest](docs/TokenRequest.md)
 - [Model.TokenResponse](docs/TokenResponse.md)
 - [Model.TokenResponseAuthenticationResult](docs/TokenResponseAuthenticationResult.md)
 - [Model.TopupRequest](docs/TopupRequest.md)
 - [Model.TopupResponse](docs/TopupResponse.md)
 - [Model.TopupResponseData](docs/TopupResponseData.md)
 - [Model.TransactionsResponse](docs/TransactionsResponse.md)
 - [Model.TransactionsResponseBalance](docs/TransactionsResponseBalance.md)
 - [Model.TransactionsResponseData](docs/TransactionsResponseData.md)
 - [Model.TransactionsResponseMeta](docs/TransactionsResponseMeta.md)
 - [Model.TransactionsResponseProduct](docs/TransactionsResponseProduct.md)
 - [Model.TransactionsResponseStatus](docs/TransactionsResponseStatus.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="IIMMPACT-COGNITO"></a>
### IIMMPACT-COGNITO

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

<a name="SSO"></a>
### SSO

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header

