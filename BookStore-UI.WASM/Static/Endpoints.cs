using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_UI.WASM.Static
{
    public static class Endpoints
    {
        public static string BaseUrl = "https://localhost:44360";
        public static string AuthorsEnpoint = $"{BaseUrl}/api/authors/";
        public static string BooksEnpoint = $"{BaseUrl}/api/books/";
        public static string RegisterEnpoint = $"{BaseUrl}/api/users/register/";
        public static string LoginEnpoint = $"{BaseUrl}/api/users/login/";
    }
}
