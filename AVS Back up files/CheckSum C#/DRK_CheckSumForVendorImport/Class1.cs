﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace DRK_CheckSumForVendorImport
{
    public class Class1
    {
        public string CalculateSHA256Hash(params object[] fields)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                StringBuilder dataBuilder = new StringBuilder();

                foreach (object field in fields)
                {
                    if (field != null)
                    {
                        dataBuilder.Append(field.ToString());
                    }
                }

                string dataToHash = dataBuilder.ToString();

                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(dataToHash));
                StringBuilder hashBuilder = new StringBuilder();

                foreach (byte hashByte in hashBytes)
                {
                    hashBuilder.Append(hashByte.ToString("x2"));
                }

                return hashBuilder.ToString();
            }
        }

    }
}