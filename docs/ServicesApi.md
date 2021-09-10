# iimmpact.Api.ServicesApi

All URIs are relative to *https://api.iimmpact.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1BillPresentmentGet**](ServicesApi.md#v1billpresentmentget) | **GET** /v1/bill-presentment | 
[**V1NetworkstatusGet**](ServicesApi.md#v1networkstatusget) | **GET** /v1/networkstatus | 
[**V1TopupPost**](ServicesApi.md#v1topuppost) | **POST** /v1/topup | 


<a name="v1billpresentmentget"></a>
# **V1BillPresentmentGet**
> BillPresentmentResponse V1BillPresentmentGet (string account, string accountName = null, string product = null)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1BillPresentmentGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi();
            var account = account_example;  // string | 
            var accountName = accountName_example;  // string |  (optional) 
            var product = product_example;  // string |  (optional) 

            try
            {
                BillPresentmentResponse result = apiInstance.V1BillPresentmentGet(account, accountName, product);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.V1BillPresentmentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**|  | 
 **accountName** | **string**|  | [optional] 
 **product** | **string**|  | [optional] 

### Return type

[**BillPresentmentResponse**](BillPresentmentResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1networkstatusget"></a>
# **V1NetworkstatusGet**
> NetworkStatusResponse V1NetworkstatusGet (string product)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1NetworkstatusGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi();
            var product = product_example;  // string | 

            try
            {
                NetworkStatusResponse result = apiInstance.V1NetworkstatusGet(product);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.V1NetworkstatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **product** | **string**|  | 

### Return type

[**NetworkStatusResponse**](NetworkStatusResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1topuppost"></a>
# **V1TopupPost**
> TopupResponse V1TopupPost (TopupRequest topupRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1TopupPostExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi();
            var topupRequest = new TopupRequest(); // TopupRequest | 

            try
            {
                TopupResponse result = apiInstance.V1TopupPost(topupRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.V1TopupPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **topupRequest** | [**TopupRequest**](TopupRequest.md)|  | 

### Return type

[**TopupResponse**](TopupResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

