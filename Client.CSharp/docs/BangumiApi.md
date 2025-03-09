# PotatoVN.Client.Api.BangumiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BangumiOauthGet**](BangumiApi.md#bangumioauthget) | **GET** /bangumi/oauth | 使用code换取bgm token |
| [**BangumiRefreshGet**](BangumiApi.md#bangumirefreshget) | **GET** /bangumi/refresh | 使用refresh token换取bgm token |

<a id="bangumioauthget"></a>
# **BangumiOauthGet**
> BangumiToken BangumiOauthGet (string code)

使用code换取bgm token

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
    public class BangumiOauthGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BangumiApi(httpClient, config, httpClientHandler);
            var code = "code_example";  // string | 

            try
            {
                // 使用code换取bgm token
                BangumiToken result = apiInstance.BangumiOauthGet(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BangumiApi.BangumiOauthGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BangumiOauthGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 使用code换取bgm token
    ApiResponse<BangumiToken> response = apiInstance.BangumiOauthGetWithHttpInfo(code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BangumiApi.BangumiOauthGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** |  |  |

### Return type

[**BangumiToken**](BangumiToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功，返回token信息 |  -  |
| **400** | code无效 |  -  |
| **502** | 无法连接至bangumi服务器 |  -  |
| **503** | Bangumi服务没有启用 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bangumirefreshget"></a>
# **BangumiRefreshGet**
> BangumiToken BangumiRefreshGet (string refreshToken)

使用refresh token换取bgm token

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
    public class BangumiRefreshGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BangumiApi(httpClient, config, httpClientHandler);
            var refreshToken = "refreshToken_example";  // string | 

            try
            {
                // 使用refresh token换取bgm token
                BangumiToken result = apiInstance.BangumiRefreshGet(refreshToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BangumiApi.BangumiRefreshGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BangumiRefreshGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 使用refresh token换取bgm token
    ApiResponse<BangumiToken> response = apiInstance.BangumiRefreshGetWithHttpInfo(refreshToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BangumiApi.BangumiRefreshGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **refreshToken** | **string** |  |  |

### Return type

[**BangumiToken**](BangumiToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功，返回token信息 |  -  |
| **400** | code无效 |  -  |
| **502** | 无法连接至bangumi服务器 |  -  |
| **503** | Bangumi服务没有启用 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

