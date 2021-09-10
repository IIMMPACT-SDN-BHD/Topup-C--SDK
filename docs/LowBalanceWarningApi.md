# iimmpact.Api.LowBalanceWarningApi

All URIs are relative to *https://api.iimmpact.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1LowBalanceThresholdGet**](LowBalanceWarningApi.md#v1lowbalancethresholdget) | **GET** /v1/low-balance-threshold | 
[**V1LowBalanceThresholdPost**](LowBalanceWarningApi.md#v1lowbalancethresholdpost) | **POST** /v1/low-balance-threshold | 


<a name="v1lowbalancethresholdget"></a>
# **V1LowBalanceThresholdGet**
> LowBalanceWarningResponse V1LowBalanceThresholdGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1LowBalanceThresholdGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LowBalanceWarningApi();

            try
            {
                LowBalanceWarningResponse result = apiInstance.V1LowBalanceThresholdGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LowBalanceWarningApi.V1LowBalanceThresholdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**LowBalanceWarningResponse**](LowBalanceWarningResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1lowbalancethresholdpost"></a>
# **V1LowBalanceThresholdPost**
> LowBalanceWarningResponse V1LowBalanceThresholdPost (string amount)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1LowBalanceThresholdPostExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LowBalanceWarningApi();
            var amount = amount_example;  // string | 

            try
            {
                LowBalanceWarningResponse result = apiInstance.V1LowBalanceThresholdPost(amount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LowBalanceWarningApi.V1LowBalanceThresholdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **amount** | **string**|  | 

### Return type

[**LowBalanceWarningResponse**](LowBalanceWarningResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

