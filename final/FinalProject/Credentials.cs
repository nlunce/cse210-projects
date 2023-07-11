using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TweetSharp;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.CompilerServices;

namespace TwitterBot
{
    class Credentials 
    {
        public string CustomerKey { get; private set; } = "i63zot9oH35ZQVhR4czJDskxd";
        public string CustomerKeySecret { get; private set; } = "E5DfOT1UdQAdaW5hHixreA3LrlY4p3XWMlpvxKDTeuCnxMLYx8";
        public string AccessToken { get; private set; } = "1678517174472966145-L0wpMLiKcn8e70EpzXXrZkfwm0w4dR";
        public string AccessTokenSecret { get; private set; } = "0L3qmWM3cCZKZZ6a0jDYqHxhfyRE3XQ9W5TLYadw3TO3E";
    }
}