# PotatoVN.Client.Api.OssApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OssGetGet**](OssApi.md#ossgetget) | **GET** /oss/get | 获取oss预签名读取路径 |
| [**OssPutGet**](OssApi.md#ossputget) | **GET** /oss/put | 获取oss预签名上传路径， 获取链接后会预先占用请求的空间， 直到客户端使用UpdateSpace通知服务器更新空间 |
| [**OssUpdatePut**](OssApi.md#ossupdateput) | **PUT** /oss/update | 更新某个key下文件占用空间，一般用于上传完成后通知服务器计算具体空间 |

<a id="ossgetget"></a>
# **OssGetGet**
> string OssGetGet (string? objectFullName = null)

获取oss预签名读取路径

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
    public class OssGetGetExample
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
            var apiInstance = new OssApi(httpClient, config, httpClientHandler);
            var objectFullName = "\"\"";  // string? | 上传文件名（包括前缀），如：Galgame/114514.jpg (optional)  (default to "")

            try
            {
                // 获取oss预签名读取路径
                string result = apiInstance.OssGetGet(objectFullName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OssApi.OssGetGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OssGetGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取oss预签名读取路径
    ApiResponse<string> response = apiInstance.OssGetGetWithHttpInfo(objectFullName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OssApi.OssGetGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectFullName** | **string?** | 上传文件名（包括前缀），如：Galgame/114514.jpg | [optional] [default to &quot;&quot;] |

### Return type

**string**

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
| **404** | 文件不存在 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ossputget"></a>
# **OssPutGet**
> string OssPutGet (string? objectFullName = null, long? requireSpace = null)

获取oss预签名上传路径， 获取链接后会预先占用请求的空间， 直到客户端使用UpdateSpace通知服务器更新空间

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
    public class OssPutGetExample
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
            var apiInstance = new OssApi(httpClient, config, httpClientHandler);
            var objectFullName = "\"\"";  // string? | 上传文件名（包括前缀），如：Galgame/114514.jpg (optional)  (default to "")
            var requireSpace = 10485760L;  // long? | 要上传的文件大小（byte），默认为10MB (optional)  (default to 10485760)

            try
            {
                // 获取oss预签名上传路径， 获取链接后会预先占用请求的空间， 直到客户端使用UpdateSpace通知服务器更新空间
                string result = apiInstance.OssPutGet(objectFullName, requireSpace);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OssApi.OssPutGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OssPutGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取oss预签名上传路径， 获取链接后会预先占用请求的空间， 直到客户端使用UpdateSpace通知服务器更新空间
    ApiResponse<string> response = apiInstance.OssPutGetWithHttpInfo(objectFullName, requireSpace);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OssApi.OssPutGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectFullName** | **string?** | 上传文件名（包括前缀），如：Galgame/114514.jpg | [optional] [default to &quot;&quot;] |
| **requireSpace** | **long?** | 要上传的文件大小（byte），默认为10MB | [optional] [default to 10485760] |

### Return type

**string**

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
| **400** | objectFullName不合法 或 用户存储容量已满 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ossupdateput"></a>
# **OssUpdatePut**
> UserDto OssUpdatePut (string? objectFullName = null)

更新某个key下文件占用空间，一般用于上传完成后通知服务器计算具体空间

更新某个key下文件所占用的空间<br /><b>即使是上传失败/取消，也需要调用此接口以释放预占用的空间</b>

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
    public class OssUpdatePutExample
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
            var apiInstance = new OssApi(httpClient, config, httpClientHandler);
            var objectFullName = "\"\"";  // string? |  (optional)  (default to "")

            try
            {
                // 更新某个key下文件占用空间，一般用于上传完成后通知服务器计算具体空间
                UserDto result = apiInstance.OssUpdatePut(objectFullName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OssApi.OssUpdatePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OssUpdatePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新某个key下文件占用空间，一般用于上传完成后通知服务器计算具体空间
    ApiResponse<UserDto> response = apiInstance.OssUpdatePutWithHttpInfo(objectFullName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OssApi.OssUpdatePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **objectFullName** | **string?** |  | [optional] [default to &quot;&quot;] |

### Return type

[**UserDto**](UserDto.md)

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
| **400** | token对应的用户不存在 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

