# iimmpact.Api.CallbackUrlApi

All URIs are relative to *https://api.iimmpact.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1CallbackUrlGet**](CallbackUrlApi.md#v1callbackurlget) | **GET** /v1/callback-url | 
[**V1CallbackUrlPost**](CallbackUrlApi.md#v1callbackurlpost) | **POST** /v1/callback-url | 


<a name="v1callbackurlget"></a>
# **V1CallbackUrlGet**
> CallbackUrlResponse V1CallbackUrlGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1CallbackUrlGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallbackUrlApi();

            try
            {
                CallbackUrlResponse result = apiInstance.V1CallbackUrlGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallbackUrlApi.V1CallbackUrlGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CallbackUrlResponse**](CallbackUrlResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1callbackurlpost"></a>
# **V1CallbackUrlPost**
> CallbackUrlResponse V1CallbackUrlPost (string url)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1CallbackUrlPostExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallbackUrlApi();
            var url = url_example;  // string | 

            try
            {
                CallbackUrlResponse result = apiInstance.V1CallbackUrlPost(url);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallbackUrlApi.V1CallbackUrlPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **url** | **string**|  | 

### Return type

[**CallbackUrlResponse**](CallbackUrlResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

