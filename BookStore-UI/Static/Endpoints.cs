using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_UI.Static
{
    public static class Endpoints
    {
#if DEBUG
        public static string BaseUrl = "https://localhost:44360";
#else
        public static string BaseUrl = "";
#endif
        public static string AuthorsEnpoint = $"{BaseUrl}/api/authors/";
        public static string BooksEnpoint = $"{BaseUrl}/api/books/";
        public static string RegisterEnpoint = $"{BaseUrl}/api/users/register/";
        public static string LoginEnpoint = $"{BaseUrl}/api/users/login/";
    }
}
