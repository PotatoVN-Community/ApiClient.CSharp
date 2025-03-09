# PotatoVN.Client.Api.UserApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserGet**](UserApi.md#userget) | **GET** /user | 获取用户列表 |
| [**UserIdGet**](UserApi.md#useridget) | **GET** /user/{id} | 获取指定id的用户 |
| [**UserMeGet**](UserApi.md#usermeget) | **GET** /user/me | 获取自己的用户信息 |
| [**UserMePatch**](UserApi.md#usermepatch) | **PATCH** /user/me | 修改用户信息 |
| [**UserPost**](UserApi.md#userpost) | **POST** /user | 注册账户 |
| [**UserSessionBgmPost**](UserApi.md#usersessionbgmpost) | **POST** /user/session/bgm | 使用bgm账户登录/注册 |
| [**UserSessionPost**](UserApi.md#usersessionpost) | **POST** /user/session | 登录账户 |
| [**UserSessionRefreshGet**](UserApi.md#usersessionrefreshget) | **GET** /user/session/refresh | 获取一个新jwt token |

<a id="userget"></a>
# **UserGet**
> UserDtoPagedResult UserGet (int? pageIndex = null, int? pageSize = null)

获取用户列表

<b>该命令需要管理员权限</b>  <br />              pageIndex从0开始<br />              不返回用户的头像URL

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
    public class UserGetExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var pageSize = 20;  // int? |  (optional)  (default to 20)

            try
            {
                // 获取用户列表
                UserDtoPagedResult result = apiInstance.UserGet(pageIndex, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取用户列表
    ApiResponse<UserDtoPagedResult> response = apiInstance.UserGetWithHttpInfo(pageIndex, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **pageSize** | **int?** |  | [optional] [default to 20] |

### Return type

[**UserDtoPagedResult**](UserDtoPagedResult.md)

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

<a id="useridget"></a>
# **UserIdGet**
> UserDto UserIdGet (int id)

获取指定id的用户

<b>该命令需要管理员权限</b>

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
    public class UserIdGetExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                // 获取指定id的用户
                UserDto result = apiInstance.UserIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定id的用户
    ApiResponse<UserDto> response = apiInstance.UserIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

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
| **404** | 用户不存在 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usermeget"></a>
# **UserMeGet**
> UserDto UserMeGet (bool? withAvatar = null)

获取自己的用户信息

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
    public class UserMeGetExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var withAvatar = true;  // bool? |  (optional)  (default to true)

            try
            {
                // 获取自己的用户信息
                UserDto result = apiInstance.UserMeGet(withAvatar);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserMeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserMeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取自己的用户信息
    ApiResponse<UserDto> response = apiInstance.UserMeGetWithHttpInfo(withAvatar);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserMeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **withAvatar** | **bool?** |  | [optional] [default to true] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usermepatch"></a>
# **UserMePatch**
> UserDto UserMePatch (UserModifyDto? userModifyDto = null)

修改用户信息

所有字段均可选

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
    public class UserMePatchExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var userModifyDto = new UserModifyDto?(); // UserModifyDto? |  (optional) 

            try
            {
                // 修改用户信息
                UserDto result = apiInstance.UserMePatch(userModifyDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserMePatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserMePatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 修改用户信息
    ApiResponse<UserDto> response = apiInstance.UserMePatchWithHttpInfo(userModifyDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserMePatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userModifyDto** | [**UserModifyDto?**](UserModifyDto?.md) |  | [optional]  |

### Return type

[**UserDto**](UserDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功，返回新的用户信息 |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **400** | 填入了新密码但旧密码不正确/没填写 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userpost"></a>
# **UserPost**
> UserWithTokenDto UserPost (UserRegisterDto? userRegisterDto = null)

注册账户

若注册成功则返回用户信息与token

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
    public class UserPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var userRegisterDto = new UserRegisterDto?(); // UserRegisterDto? |  (optional) 

            try
            {
                // 注册账户
                UserWithTokenDto result = apiInstance.UserPost(userRegisterDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 注册账户
    ApiResponse<UserWithTokenDto> response = apiInstance.UserPostWithHttpInfo(userRegisterDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userRegisterDto** | [**UserRegisterDto?**](UserRegisterDto?.md) |  | [optional]  |

### Return type

[**UserWithTokenDto**](UserWithTokenDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | 该用户名已被占用 |  -  |
| **503** | 不允许使用账户密码登录与注册 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usersessionbgmpost"></a>
# **UserSessionBgmPost**
> UserWithTokenDto UserSessionBgmPost (UserLoginViaBgmDto? userLoginViaBgmDto = null)

使用bgm账户登录/注册

如果该bgm账户没有potatoVN账号，则自动注册一个

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
    public class UserSessionBgmPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var userLoginViaBgmDto = new UserLoginViaBgmDto?(); // UserLoginViaBgmDto? |  (optional) 

            try
            {
                // 使用bgm账户登录/注册
                UserWithTokenDto result = apiInstance.UserSessionBgmPost(userLoginViaBgmDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSessionBgmPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSessionBgmPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 使用bgm账户登录/注册
    ApiResponse<UserWithTokenDto> response = apiInstance.UserSessionBgmPostWithHttpInfo(userLoginViaBgmDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSessionBgmPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userLoginViaBgmDto** | [**UserLoginViaBgmDto?**](UserLoginViaBgmDto?.md) |  | [optional]  |

### Return type

[**UserWithTokenDto**](UserWithTokenDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 用户信息与token |  -  |
| **400** | token无效 |  -  |
| **502** | 无法连接至bgm服务器 |  -  |
| **503** | 不允许使用bangumi注册与登录 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usersessionpost"></a>
# **UserSessionPost**
> UserWithTokenDto UserSessionPost (UserLoginDto? userLoginDto = null)

登录账户

若登录成功则返回jwtToken

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
    public class UserSessionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);
            var userLoginDto = new UserLoginDto?(); // UserLoginDto? |  (optional) 

            try
            {
                // 登录账户
                UserWithTokenDto result = apiInstance.UserSessionPost(userLoginDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSessionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSessionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 登录账户
    ApiResponse<UserWithTokenDto> response = apiInstance.UserSessionPostWithHttpInfo(userLoginDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSessionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userLoginDto** | [**UserLoginDto?**](UserLoginDto?.md) |  | [optional]  |

### Return type

[**UserWithTokenDto**](UserWithTokenDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 登录成功，返回token |  -  |
| **400** | 账户不存在或密码不正确 |  -  |
| **503** | 不允许使用账户密码登录与注册 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usersessionrefreshget"></a>
# **UserSessionRefreshGet**
> UserWithTokenDto UserSessionRefreshGet ()

获取一个新jwt token

获取一个当前用户的新token

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
    public class UserSessionRefreshGetExample
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
            var apiInstance = new UserApi(httpClient, config, httpClientHandler);

            try
            {
                // 获取一个新jwt token
                UserWithTokenDto result = apiInstance.UserSessionRefreshGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSessionRefreshGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSessionRefreshGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取一个新jwt token
    ApiResponse<UserWithTokenDto> response = apiInstance.UserSessionRefreshGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSessionRefreshGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserWithTokenDto**](UserWithTokenDto.md)

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

