using System;
using Microsoft.ReactNative.Managed;
using Newtonsoft.Json.Linq;

namespace RNViewShot
{
    [ReactModule]
    class RNViewShot
    {
        [ReactMethod]
        public string captureRef(int tag, JObject options, ReactPromise<JSValue> promise)
        {
            return "You tag number is: " + tag;
        }
    }
}
