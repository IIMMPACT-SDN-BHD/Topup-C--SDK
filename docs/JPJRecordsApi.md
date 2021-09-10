# iimmpact.Api.JPJRecordsApi

All URIs are relative to *https://api.iimmpact.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1JpjDrivingLicenseGet**](JPJRecordsApi.md#v1jpjdrivinglicenseget) | **GET** /v1/jpj/driving-license | 
[**V1JpjDrivingTestResultsGet**](JPJRecordsApi.md#v1jpjdrivingtestresultsget) | **GET** /v1/jpj/driving-test-results | 
[**V1JpjMotorVehicleExpiryGet**](JPJRecordsApi.md#v1jpjmotorvehicleexpiryget) | **GET** /v1/jpj/motor-vehicle-expiry | 
[**V1JpjSummonsGet**](JPJRecordsApi.md#v1jpjsummonsget) | **GET** /v1/jpj/summons | 


<a name="v1jpjdrivinglicenseget"></a>
# **V1JpjDrivingLicenseGet**
> JPJRecordsResponse V1JpjDrivingLicenseGet (string idNo, string idType, string captcha = null)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1JpjDrivingLicenseGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JPJRecordsApi();
            var idNo = idNo_example;  // string | 
            var idType = idType_example;  // string | 
            var captcha = captcha_example;  // string |  (optional) 

            try
            {
                JPJRecordsResponse result = apiInstance.V1JpjDrivingLicenseGet(idNo, idType, captcha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JPJRecordsApi.V1JpjDrivingLicenseGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idNo** | **string**|  | 
 **idType** | **string**|  | 
 **captcha** | **string**|  | [optional] 

### Return type

[**JPJRecordsResponse**](JPJRecordsResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1jpjdrivingtestresultsget"></a>
# **V1JpjDrivingTestResultsGet**
> JPJRecordsResponse V1JpjDrivingTestResultsGet (string idNo, string idType, string captcha = null)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1JpjDrivingTestResultsGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JPJRecordsApi();
            var idNo = idNo_example;  // string | 
            var idType = idType_example;  // string | 
            var captcha = captcha_example;  // string |  (optional) 

            try
            {
                JPJRecordsResponse result = apiInstance.V1JpjDrivingTestResultsGet(idNo, idType, captcha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JPJRecordsApi.V1JpjDrivingTestResultsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idNo** | **string**|  | 
 **idType** | **string**|  | 
 **captcha** | **string**|  | [optional] 

### Return type

[**JPJRecordsResponse**](JPJRecordsResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1jpjmotorvehicleexpiryget"></a>
# **V1JpjMotorVehicleExpiryGet**
> JPJRecordsResponse V1JpjMotorVehicleExpiryGet (string idNo, string idType, string vehicleNo, string captcha = null)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1JpjMotorVehicleExpiryGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JPJRecordsApi();
            var idNo = idNo_example;  // string | 
            var idType = idType_example;  // string | 
            var vehicleNo = vehicleNo_example;  // string | 
            var captcha = captcha_example;  // string |  (optional) 

            try
            {
                JPJRecordsResponse result = apiInstance.V1JpjMotorVehicleExpiryGet(idNo, idType, vehicleNo, captcha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JPJRecordsApi.V1JpjMotorVehicleExpiryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idNo** | **string**|  | 
 **idType** | **string**|  | 
 **vehicleNo** | **string**|  | 
 **captcha** | **string**|  | [optional] 

### Return type

[**JPJRecordsResponse**](JPJRecordsResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1jpjsummonsget"></a>
# **V1JpjSummonsGet**
> JPJRecordsResponse V1JpjSummonsGet (string idNo, string idType, string captcha = null)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1JpjSummonsGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new JPJRecordsApi();
            var idNo = idNo_example;  // string | 
            var idType = idType_example;  // string | 
            var captcha = captcha_example;  // string |  (optional) 

            try
            {
                JPJRecordsResponse result = apiInstance.V1JpjSummonsGet(idNo, idType, captcha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JPJRecordsApi.V1JpjSummonsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idNo** | **string**|  | 
 **idType** | **string**|  | 
 **captcha** | **string**|  | [optional] 

### Return type

[**JPJRecordsResponse**](JPJRecordsResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

