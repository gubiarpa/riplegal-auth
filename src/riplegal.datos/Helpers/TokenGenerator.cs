using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace riplegal.datos.Helpers
{
    public class TokenGenerator
    {
        public static string Generate()
        {
            return GetSimpleToken() + GetSimpleToken();
        }

        private static string GetSimpleToken()
        {
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            string token = Convert.ToBase64String(time.Concat(key).ToArray());
            return token;
        }
    }
}
