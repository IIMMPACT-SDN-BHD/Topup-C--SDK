# iimmpact.Api.CarInsuranceApi

All URIs are relative to *https://api.iimmpact.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1CarInsuranceGet**](CarInsuranceApi.md#v1carinsuranceget) | **GET** /v1/car-insurance | 


<a name="v1carinsuranceget"></a>
# **V1CarInsuranceGet**
> CarInsuranceRespone V1CarInsuranceGet (string vehicleNo, string idNo = null)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1CarInsuranceGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CarInsuranceApi();
            var vehicleNo = vehicleNo_example;  // string | 
            var idNo = idNo_example;  // string |  (optional) 

            try
            {
                CarInsuranceRespone result = apiInstance.V1CarInsuranceGet(vehicleNo, idNo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarInsuranceApi.V1CarInsuranceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vehicleNo** | **string**|  | 
 **idNo** | **string**|  | [optional] 

### Return type

[**CarInsuranceRespone**](CarInsuranceRespone.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

