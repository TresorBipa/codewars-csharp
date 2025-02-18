﻿/*
https://www.codewars.com/kata/526989a41034285187000de4/csharp

5 kyu
Count IP Addresses

Implement a function that receives two IPv4 addresses, and returns the number of addresses between them (including the first one, excluding the last one).

All inputs will be valid IPv4 addresses in the form of strings. The last address will always be greater than the first one.

Examples
ips_between("10.0.0.0", "10.0.0.50")  ==   50 
ips_between("10.0.0.0", "10.0.1.0")   ==  256 
ips_between("20.0.0.10", "20.0.1.0")  ==  246
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net;

namespace CodeWars
{
    public static class CountIpAddresses
    {
        public static long IpsBetween(string start, string end)
        {
            return IPAddress.NetworkToHostOrder(BitConverter.ToInt32(IPAddress.Parse(end).GetAddressBytes())) -
                   IPAddress.NetworkToHostOrder(BitConverter.ToInt32(IPAddress.Parse(start).GetAddressBytes()));
        }
    }
}