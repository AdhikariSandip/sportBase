using Base.Shared.Enums;

namespace Base.Shared.Helpers.ApiHelper;

public interface IApiHelper
{
    Task<T> GetAsync<T>(string uri);
    Task<T> PostAsync<T>(string uri, T data);
    Task<T> PutAsync<T>(string uri, T data);
    Task<T> PatchAsync<T>(string uri, T data);
    Task DeleteAsync(string uri);
    Task<T> CallServiceAsync<T>(ServiceTypeOption serviceType, string endpoint, HttpMethod method, T data = default);
}
