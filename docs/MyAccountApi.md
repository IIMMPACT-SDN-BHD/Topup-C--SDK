# iimmpact.Api.MyAccountApi

All URIs are relative to *https://api.iimmpact.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1AuthChangePasswordPost**](MyAccountApi.md#v1authchangepasswordpost) | **POST** /v1/auth/change-password | 
[**V1AuthNewPasswordChallengePost**](MyAccountApi.md#v1authnewpasswordchallengepost) | **POST** /v1/auth/new-password-challenge | 
[**V1BalanceGet**](MyAccountApi.md#v1balanceget) | **GET** /v1/balance | 


<a name="v1authchangepasswordpost"></a>
# **V1AuthChangePasswordPost**
> InlineResponse2001 V1AuthChangePasswordPost (ChangePasswordRequest newPasswordRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1AuthChangePasswordPostExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MyAccountApi();
            var newPasswordRequest = new ChangePasswordRequest(); // ChangePasswordRequest | 

            try
            {
                InlineResponse2001 result = apiInstance.V1AuthChangePasswordPost(newPasswordRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyAccountApi.V1AuthChangePasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newPasswordRequest** | [**ChangePasswordRequest**](ChangePasswordRequest.md)|  | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1authnewpasswordchallengepost"></a>
# **V1AuthNewPasswordChallengePost**
> NewPasswordResponses V1AuthNewPasswordChallengePost (NewPasswordRequest newPasswordRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1AuthNewPasswordChallengePostExample
    {
        public void main()
        {
            var apiInstance = new MyAccountApi();
            var newPasswordRequest = new NewPasswordRequest(); // NewPasswordRequest | 

            try
            {
                NewPasswordResponses result = apiInstance.V1AuthNewPasswordChallengePost(newPasswordRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyAccountApi.V1AuthNewPasswordChallengePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newPasswordRequest** | [**NewPasswordRequest**](NewPasswordRequest.md)|  | 

### Return type

[**NewPasswordResponses**](NewPasswordResponses.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1balanceget"></a>
# **V1BalanceGet**
> InlineResponse200 V1BalanceGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1BalanceGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MyAccountApi();

            try
            {
                InlineResponse200 result = apiInstance.V1BalanceGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyAccountApi.V1BalanceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

