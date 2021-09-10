# iimmpact.Api.AuthorizationTokenApi

All URIs are relative to *https://api.iimmpact.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1TokenPost**](AuthorizationTokenApi.md#v1tokenpost) | **POST** /v1/token | 
[**V1TokenRefreshPost**](AuthorizationTokenApi.md#v1tokenrefreshpost) | **POST** /v1/token/refresh | 


<a name="v1tokenpost"></a>
# **V1TokenPost**
> TokenResponse V1TokenPost (TokenRequest tokenRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1TokenPostExample
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenRequest** | [**TokenRequest**](TokenRequest.md)|  | 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1tokenrefreshpost"></a>
# **V1TokenRefreshPost**
> RefreshTokenResponse V1TokenRefreshPost (RefreshTokenRequest refreshTokenRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1TokenRefreshPostExample
    {
        public void main()
        {
            var apiInstance = new AuthorizationTokenApi();
            var refreshTokenRequest = new RefreshTokenRequest(); // RefreshTokenRequest | 

            try
            {
                RefreshTokenResponse result = apiInstance.V1TokenRefreshPost(refreshTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationTokenApi.V1TokenRefreshPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refreshTokenRequest** | [**RefreshTokenRequest**](RefreshTokenRequest.md)|  | 

### Return type

[**RefreshTokenResponse**](RefreshTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

