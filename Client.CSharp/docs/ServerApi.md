# PotatoVN.Client.Api.ServerApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ServerInfoGet**](ServerApi.md#serverinfoget) | **GET** /server/info | 获取服务器信息 |

<a id="serverinfoget"></a>
# **ServerInfoGet**
> ServerInfoDto ServerInfoGet ()

获取服务器信息

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
    public class ServerInfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ServerApi(httpClient, config, httpClientHandler);

            try
            {
                // 获取服务器信息
                ServerInfoDto result = apiInstance.ServerInfoGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServerApi.ServerInfoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServerInfoGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取服务器信息
    ApiResponse<ServerInfoDto> response = apiInstance.ServerInfoGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServerApi.ServerInfoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ServerInfoDto**](ServerInfoDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

