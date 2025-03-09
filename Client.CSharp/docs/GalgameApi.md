# PotatoVN.Client.Api.GalgameApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GalgameDelete**](GalgameApi.md#galgamedelete) | **DELETE** /galgame | 删除用户的所有游戏 |
| [**GalgameDeletedGet**](GalgameApi.md#galgamedeletedget) | **GET** /galgame/deleted | 获取已删除的galgame列表 |
| [**GalgameGalgameIdDelete**](GalgameApi.md#galgamegalgameiddelete) | **DELETE** /galgame/{galgameId} | 删除游戏 |
| [**GalgameGalgameIdPlaylogPatch**](GalgameApi.md#galgamegalgameidplaylogpatch) | **PATCH** /galgame/{galgameId}/playlog | 添加游玩记录或游玩时长 |
| [**GalgameGet**](GalgameApi.md#galgameget) | **GET** /galgame | 获取galgame列表 |
| [**GalgamePatch**](GalgameApi.md#galgamepatch) | **PATCH** /galgame | 新建或更新galgame |

<a id="galgamedelete"></a>
# **GalgameDelete**
> void GalgameDelete ()

删除用户的所有游戏

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
    public class GalgameDeleteExample
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
            var apiInstance = new GalgameApi(httpClient, config, httpClientHandler);

            try
            {
                // 删除用户的所有游戏
                apiInstance.GalgameDelete();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GalgameApi.GalgameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GalgameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除用户的所有游戏
    apiInstance.GalgameDeleteWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GalgameApi.GalgameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="galgamedeletedget"></a>
# **GalgameDeletedGet**
> GalgameDeletedDtoPagedResult GalgameDeletedGet (long timestamp, int? pageIndex = null, int? pageSize = null)

获取已删除的galgame列表

获取删除时间严格晚于给定时间戳的galgame列表

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
    public class GalgameDeletedGetExample
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
            var apiInstance = new GalgameApi(httpClient, config, httpClientHandler);
            var timestamp = 789L;  // long | 
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var pageSize = 10;  // int? |  (optional)  (default to 10)

            try
            {
                // 获取已删除的galgame列表
                GalgameDeletedDtoPagedResult result = apiInstance.GalgameDeletedGet(timestamp, pageIndex, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GalgameApi.GalgameDeletedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GalgameDeletedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取已删除的galgame列表
    ApiResponse<GalgameDeletedDtoPagedResult> response = apiInstance.GalgameDeletedGetWithHttpInfo(timestamp, pageIndex, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GalgameApi.GalgameDeletedGetWithHttpInfo: " + e.Message);
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

### Return type

[**GalgameDeletedDtoPagedResult**](GalgameDeletedDtoPagedResult.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="galgamegalgameiddelete"></a>
# **GalgameGalgameIdDelete**
> void GalgameGalgameIdDelete (int galgameId)

删除游戏

只能删除自己的游戏

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
    public class GalgameGalgameIdDeleteExample
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
            var apiInstance = new GalgameApi(httpClient, config, httpClientHandler);
            var galgameId = 56;  // int | 

            try
            {
                // 删除游戏
                apiInstance.GalgameGalgameIdDelete(galgameId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GalgameApi.GalgameGalgameIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GalgameGalgameIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除游戏
    apiInstance.GalgameGalgameIdDeleteWithHttpInfo(galgameId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GalgameApi.GalgameGalgameIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **galgameId** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | 游戏不存在 |  -  |
| **400** | 该游戏不属于此用户 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="galgamegalgameidplaylogpatch"></a>
# **GalgameGalgameIdPlaylogPatch**
> GalgameDto GalgameGalgameIdPlaylogPatch (int galgameId, PlayLogDto? playLogDto = null)

添加游玩记录或游玩时长

若已经有当天游戏的记录，则累加上去

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
    public class GalgameGalgameIdPlaylogPatchExample
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
            var apiInstance = new GalgameApi(httpClient, config, httpClientHandler);
            var galgameId = 56;  // int | 
            var playLogDto = new PlayLogDto?(); // PlayLogDto? |  (optional) 

            try
            {
                // 添加游玩记录或游玩时长
                GalgameDto result = apiInstance.GalgameGalgameIdPlaylogPatch(galgameId, playLogDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GalgameApi.GalgameGalgameIdPlaylogPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GalgameGalgameIdPlaylogPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加游玩记录或游玩时长
    ApiResponse<GalgameDto> response = apiInstance.GalgameGalgameIdPlaylogPatchWithHttpInfo(galgameId, playLogDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GalgameApi.GalgameGalgameIdPlaylogPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **galgameId** | **int** |  |  |
| **playLogDto** | [**PlayLogDto?**](PlayLogDto?.md) |  | [optional]  |

### Return type

[**GalgameDto**](GalgameDto.md)

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
| **404** | 游戏不存在 |  -  |
| **400** | 调用方不是该游戏所属者 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="galgameget"></a>
# **GalgameGet**
> GalgameDtoPagedResult GalgameGet (long timestamp, int? pageIndex = null, int? pageSize = null)

获取galgame列表

获取最后一次更新时间严格晚于给定时间戳的galgame列表

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
    public class GalgameGetExample
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
            var apiInstance = new GalgameApi(httpClient, config, httpClientHandler);
            var timestamp = 789L;  // long | 
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var pageSize = 10;  // int? |  (optional)  (default to 10)

            try
            {
                // 获取galgame列表
                GalgameDtoPagedResult result = apiInstance.GalgameGet(timestamp, pageIndex, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GalgameApi.GalgameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GalgameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取galgame列表
    ApiResponse<GalgameDtoPagedResult> response = apiInstance.GalgameGetWithHttpInfo(timestamp, pageIndex, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GalgameApi.GalgameGetWithHttpInfo: " + e.Message);
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

### Return type

[**GalgameDtoPagedResult**](GalgameDtoPagedResult.md)

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

<a id="galgamepatch"></a>
# **GalgamePatch**
> GalgameDto GalgamePatch (GalgameUpdateDto? galgameUpdateDto = null)

新建或更新galgame

所有字段均可选，覆盖原字段 <br /><b>若Id没有填，则认为是新建galgame</b><br />  务必注意字段是覆盖的，意味着游玩时间记录会覆盖掉原记录，若需要追加记录请使用[PATCH] /galgame/{id}/playlog <br />

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
    public class GalgamePatchExample
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
            var apiInstance = new GalgameApi(httpClient, config, httpClientHandler);
            var galgameUpdateDto = new GalgameUpdateDto?(); // GalgameUpdateDto? |  (optional) 

            try
            {
                // 新建或更新galgame
                GalgameDto result = apiInstance.GalgamePatch(galgameUpdateDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GalgameApi.GalgamePatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GalgamePatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 新建或更新galgame
    ApiResponse<GalgameDto> response = apiInstance.GalgamePatchWithHttpInfo(galgameUpdateDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GalgameApi.GalgamePatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **galgameUpdateDto** | [**GalgameUpdateDto?**](GalgameUpdateDto?.md) |  | [optional]  |

### Return type

[**GalgameDto**](GalgameDto.md)

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
| **404** | 填入了id字段，但不存在具有该id的galgame |  -  |
| **400** | 调用方不是该游戏所属者 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

