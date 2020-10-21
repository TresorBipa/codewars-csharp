/*
https://www.codewars.com/kata/57193694938fcdfe3a001dd7/csharp

7 kyu
IPv4 Validator

In this kata you have to write a method to verify the validity of IPv4 addresses.

Example of valid inputs:

"1.1.1.1"

"127.0.0.1"

"255.255.255.255"

Example of invalid input:

"1444.23.9"

"153.500.234.444"

"-12.344.43.11"
*/

using System.Net;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class IPv4Validator
    {
        public static bool IpValidator(string ip)
        {
            // return Regex.IsMatch(ip, @"^(?:(?:^|\.)(?:2(?:5[0-5]|[0-4]\d)|1?\d?\d)){4}$");
            return ip.Split('.').Length == 4 && IPAddress.TryParse(ip, out _);
        }
    }
}