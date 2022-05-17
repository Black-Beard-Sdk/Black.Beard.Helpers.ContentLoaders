﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text;

namespace Bb
{

    public static partial class ContentHelper
    {

        /// <summary>
        /// convert the <see cref="Object"/> in <see cref="JToken" />
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static JToken ConvertToJson(this object self)
        {
            return JToken.FromObject(self);
        }

        /// <summary>
        /// convert the <see cref="StringBuilder"/> in <see cref="JToken" />
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static JToken ConvertToJson(this StringBuilder self)
        {
            return JToken.Parse(self.ToString());
        }

        /// <summary>
        /// convert the <see cref="string"/> in <see cref="JToken" />
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static JToken ConvertToJson(this string self)
        {
            return JToken.Parse(self);
        }

    }


}
