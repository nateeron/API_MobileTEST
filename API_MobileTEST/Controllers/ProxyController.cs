using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;

namespace API_MobileTEST.Controllers
{
    [Route("proxy")]
    [ApiController]
    public class ProxyController : ControllerBase
    {
        //private readonly HttpClient _httpClient;

        //public ProxyController(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClient = httpClientFactory.CreateClient();
        //}
        //[Route("/")]
        //[HttpGet]
        //public async Task<IActionResult> Run()
        //{
        //    return Ok("Run Proxy Server Mobile");
        //}


        //[Route("{*url}")]
        //[HttpGet]
        //[HttpPost]
        //public async Task<IActionResult> ProxyRequest()
        //{
        //    try
        //    {
        //        //string apiUrl = $"https://uatxml.redfox.travel/{RouteData.Values["url"]}";
        //        string apiUrl = $"http://localhost:44330/{RouteData.Values["url"]}";


        //        var request = new HttpRequestMessage
        //        {
        //            RequestUri = new Uri(apiUrl),
        //            Method = new HttpMethod(Request.Method),

        //        };

        //        var requestHeaders = request.Headers;
        //        requestHeaders.Add("Host", (string?)null);
        //        // Copy request headers
        //        foreach (var header in Request.Headers)
        //        {
        //            if (!request.Headers.TryAddWithoutValidation(header.Key, header.Value.ToArray()))
        //            {
        //                return BadRequest("Invalid request headers.");
        //            }
        //        }

        //        if (Request.ContentLength > 0)
        //        {
        //            //var requestContent = await Request.Content.ReadAsByteArrayAsync();
        //            var buffer = new byte[Convert.ToInt32(Request.ContentLength)];
        //            await Request.Body.ReadAsync(buffer, 0, buffer.Length);
        //            var requestContent = Encoding.UTF8.GetString(buffer);
        //            //var requestContent = await Request.Body.ReadAsync();
        //            request.Content = new StringContent(requestContent, Encoding.UTF8, "application/json");
        //        }

        //        var response = await _httpClient.SendAsync(request);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var content = await response.Content.ReadAsStringAsync();
        //            return Ok(content);
        //        }
        //        else
        //        {
        //            return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}
    }


}
