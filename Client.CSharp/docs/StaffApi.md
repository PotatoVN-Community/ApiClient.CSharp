# PotatoVN.Client.Api.StaffApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**StaffGet**](StaffApi.md#staffget) | **GET** /staff | 获取staff列表 |
| [**StaffPatch**](StaffApi.md#staffpatch) | **PATCH** /staff | 新建或更新staff |

<a id="staffget"></a>
# **StaffGet**
> StaffDtoPagedResult StaffGet (long timestamp, int? pageIndex = null, int? pageSize = null, bool? includeDeleted = null)

获取staff列表

获取最后一次更新时间严格晚于给定时间戳的staff列表<br />  若includeDeleted=true，被删除的staff也会返回，删除的staff的IsDeleted字段为true

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using PotatoVN.Client.Api;
using PotatoVN.Client.Client;
using PotatoVN.Client.Model;

namespace Example
{
    public class StaffGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: oauth2
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new StaffApi(httpClient, config, httpClientHandler);
            var timestamp = 789L;  // long | 
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var includeDeleted = true;  // bool? |  (optional)  (default to true)

            try
            {
                // 获取staff列表
                StaffDtoPagedResult result = apiInstance.StaffGet(timestamp, pageIndex, pageSize, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffApi.StaffGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StaffGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取staff列表
    ApiResponse<StaffDtoPagedResult> response = apiInstance.StaffGetWithHttpInfo(timestamp, pageIndex, pageSize, includeDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffApi.StaffGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **timestamp** | **long** |  |  |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **includeDeleted** | **bool?** |  | [optional] [default to true] |

### Return type

[**StaffDtoPagedResult**](StaffDtoPagedResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **400** | pageIndex小于0或pageSize小于等于0 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="staffpatch"></a>
# **StaffPatch**
> StaffDto StaffPatch (StaffUpdateDto? staffUpdateDto = null)

新建或更新staff

所有字段均可选，覆盖原字段 <br /><b>若Id没有填或为0，则认为是新建staff</b><br />  其中IsDelete表示是否要删除这个staff<br />

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using PotatoVN.Client.Api;
using PotatoVN.Client.Client;
using PotatoVN.Client.Model;

namespace Example
{
    public class StaffPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: oauth2
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new StaffApi(httpClient, config, httpClientHandler);
            var staffUpdateDto = new StaffUpdateDto?(); // StaffUpdateDto? |  (optional) 

            try
            {
                // 新建或更新staff
                StaffDto result = apiInstance.StaffPatch(staffUpdateDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffApi.StaffPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StaffPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 新建或更新staff
    ApiResponse<StaffDto> response = apiInstance.StaffPatchWithHttpInfo(staffUpdateDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffApi.StaffPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **staffUpdateDto** | [**StaffUpdateDto?**](StaffUpdateDto?.md) |  | [optional]  |

### Return type

[**StaffDto**](StaffDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | 填入了id字段，但不存在具有该id的staff |  -  |
| **400** | 调用方不是该Staff所属者 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

