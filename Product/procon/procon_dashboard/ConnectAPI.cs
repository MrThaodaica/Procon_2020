using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace procon_dashboard
{
    class ConnectAPI
    {
        public static async Task<bool> Ping(string url)
        {
            using (var client = new HttpClient())
            {
                Console.WriteLine("Da vao day");
                var result = await client.GetAsync(url);
                Console.WriteLine("ket qua server tra ve: "+ result);
                return (int) result.StatusCode == 200;
            }
        }

    
        public static async Task<string> GetWebContent(string url)
        {
            using (var httpClient = new HttpClient())
            {
                Console.WriteLine($"Starting connect {url}");
                try
                {
                    httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml+json");
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Tải thành công - statusCode {(int)response.StatusCode} {response.ReasonPhrase}");
                        //ShowHeaders(response.Headers);
                        Console.WriteLine("Starting read data");

                        response.Content.Headers.ContentType.CharSet = @"ISO-8859-1"; // có thể bỏ dòng này

                        string htmltext = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Received payload of {htmltext.Length} characters");
                        Console.WriteLine();
                        return htmltext;
                    }
                    else
                    {
                        Console.WriteLine($"Lỗi - statusCode {response.StatusCode} {response.ReasonPhrase}");
                        return null;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
    }
}
