using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Matur.Services
{
    public abstract class Service
    {
        protected HttpClient _client;
        protected string BaseUri = @"https://devrobot.com.br/api/Autenticacaos/1";

        public Service()
        {
            _client = new HttpClient();
        }
    }
}
