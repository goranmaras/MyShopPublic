using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyShopPublic.WebUI.Tests.Mocks
{
    public class MockHttpContext: HttpContextBase
    {
        private MockRequest request;
        private MockResponse response;
        private HttpCookieCollection coockies;

        public MockHttpContext()
        {
            coockies = new HttpCookieCollection();
            this.request = new MockRequest(coockies);
            this.response = new MockResponse(coockies);
        }

        public override HttpRequestBase Request
        {
            get
            {
                return request;
            }
        }

        public override HttpResponseBase Response
        {
            get
            {
                return response;
            }
        }
    }

    public class MockResponse : HttpResponseBase
    {
        private readonly HttpCookieCollection cookies;

        public MockResponse(HttpCookieCollection cookieCollection)
        {
            this.cookies = cookieCollection;
        }

        public override HttpCookieCollection Cookies
        {
            get
            {
                return cookies;
            }
        }
    }

    public class MockRequest : HttpRequestBase
    {
        private readonly HttpCookieCollection cookies;

        public MockRequest(HttpCookieCollection cookieCollection)
        {
            this.cookies = cookieCollection;
        }

        public override HttpCookieCollection Cookies
        {
            get
            {
                return cookies;
            }
        }
    }

}
