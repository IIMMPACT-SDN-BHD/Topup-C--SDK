# iimmpact.Api.TransactionHistoryApi

All URIs are relative to *https://api.iimmpact.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1BalanceStatementGet**](TransactionHistoryApi.md#v1balancestatementget) | **GET** /v1/balance-statement | 
[**V1TransactionsGet**](TransactionHistoryApi.md#v1transactionsget) | **GET** /v1/transactions | 


<a name="v1balancestatementget"></a>
# **V1BalanceStatementGet**
> BalanceStatementResponse V1BalanceStatementGet (string date, string limit = null, string remarks = null, string sort = null, string type = null, string direction = null, string page = null, string amount = null)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1BalanceStatementGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionHistoryApi();
            var date = date_example;  // string | 
            var limit = limit_example;  // string |  (optional) 
            var remarks = remarks_example;  // string |  (optional) 
            var sort = sort_example;  // string |  (optional) 
            var type = type_example;  // string |  (optional) 
            var direction = direction_example;  // string |  (optional) 
            var page = page_example;  // string |  (optional) 
            var amount = amount_example;  // string |  (optional) 

            try
            {
                BalanceStatementResponse result = apiInstance.V1BalanceStatementGet(date, limit, remarks, sort, type, direction, page, amount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionHistoryApi.V1BalanceStatementGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **string**|  | 
 **limit** | **string**|  | [optional] 
 **remarks** | **string**|  | [optional] 
 **sort** | **string**|  | [optional] 
 **type** | **string**|  | [optional] 
 **direction** | **string**|  | [optional] 
 **page** | **string**|  | [optional] 
 **amount** | **string**|  | [optional] 

### Return type

[**BalanceStatementResponse**](BalanceStatementResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1transactionsget"></a>
# **V1TransactionsGet**
> TransactionsResponse V1TransactionsGet (string date, string refid = null, string limit = null, string sort = null, string offset = null, string direction = null, string status = null, string account = null, string acceptEncoding = null, string sn = null, string product = null)



### Example
```csharp
using System;
using System.Diagnostics;
using iimmpact.Api;
using iimmpact.Client;
using iimmpact.Model;

namespace Example
{
    public class V1TransactionsGetExample
    {
        public void main()
        {
            // Configure API key authorization: SSO
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransactionHistoryApi();
            var date = date_example;  // string | 
            var refid = refid_example;  // string |  (optional) 
            var limit = limit_example;  // string |  (optional) 
            var sort = sort_example;  // string |  (optional) 
            var offset = offset_example;  // string |  (optional) 
            var direction = direction_example;  // string |  (optional) 
            var status = status_example;  // string |  (optional) 
            var account = account_example;  // string |  (optional) 
            var acceptEncoding = acceptEncoding_example;  // string |  (optional) 
            var sn = sn_example;  // string |  (optional) 
            var product = product_example;  // string |  (optional) 

            try
            {
                TransactionsResponse result = apiInstance.V1TransactionsGet(date, refid, limit, sort, offset, direction, status, account, acceptEncoding, sn, product);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionHistoryApi.V1TransactionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **string**|  | 
 **refid** | **string**|  | [optional] 
 **limit** | **string**|  | [optional] 
 **sort** | **string**|  | [optional] 
 **offset** | **string**|  | [optional] 
 **direction** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **account** | **string**|  | [optional] 
 **acceptEncoding** | **string**|  | [optional] 
 **sn** | **string**|  | [optional] 
 **product** | **string**|  | [optional] 

### Return type

[**TransactionsResponse**](TransactionsResponse.md)

### Authorization

[SSO](../README.md#SSO)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

