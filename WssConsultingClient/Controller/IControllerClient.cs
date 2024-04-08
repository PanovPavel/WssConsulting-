using WssСonsultingBl.Model;

namespace WssConsultingClient.Controller;

public interface IControllerClient<T>
{
    /// <summary>
    /// Создание клиента через фабрику _clientFactory.CreateClient();7
    /// Пулчение ответа от сервера await httpClient.GetAsync("api/");
    /// if (response.IsSuccessStatusCode)
    /// var jsonString = await response.Content.ReadAsStringAsync();
    /// JsonConvert.DeserializeObject<List<T>>(jsonString);
    /// возврат List<T>
    /// </summary>
    Task<IEnumerable<T>> GetAllAsync();
    /// <summary>
    /// Создание клиента через фабрику _clientFactory.CreateClient();7
    /// Пулчение ответа от сервера await httpClient.GetAsync("api/");
    /// if (response.IsSuccessStatusCode)
    /// var jsonString = await response.Content.ReadAsStringAsync();
    /// JsonConvert.DeserializeObject<List<T>>(jsonString);
    /// возврат List<T>
    /// </summary>
    Task<T> GetByIdAsync(Guid id);
    /// <summary>
    /// JsonConvert.SerializeObject(T);
    /// httpClient.PutAsync($"api", new StringContent(json, Encoding.UTF8, "application/json"));
    /// if(response.EnsureSuccessStatusCode())else{
    ///     Обработка ответа от сервера
    /// }
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    Task AddAsync(T t);
    /// <summary>
    /// JsonConvert.SerializeObject(T);
    /// httpClient.PutAsync($"api/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
    /// if(response.EnsureSuccessStatusCode())else{
    ///     Обработка ответа от сервера
    /// }
    /// </summary>
    /// <param name="id"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    Task UpdateAsync(Guid id, T t);
    /// <summary>
    /// await httpClient.DeleteAsync($"api/{id}");
    /// if(response.EnsureSuccessStatusCode())else{
    ///     Обработка ответа от сервера
    /// }
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id);
}