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
        public string customerKey { get; private set; } = "i63zot9oH35ZQVhR4czJDskxd";
        public string customerKeySecret { get; private set; } = "E5DfOT1UdQAdaW5hHixreA3LrlY4p3XWMlpvxKDTeuCnxMLYx8";
        public string accessToken { get; private set; } = "1678517174472966145-L0wpMLiKcn8e70EpzXXrZkfwm0w4dR";
        public string accessTokenSecret { get; private set; } = "0L3qmWM3cCZKZZ6a0jDYqHxhfyRE3XQ9W5TLYadw3TO3E";
    }
}