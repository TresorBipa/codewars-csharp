/*
https://www.codewars.com/kata/5220b7f77e831a7e79000417/csharp

7 kyu
generateRules

While creating IPtables rules to protect your server you want to write a function generateRules to help you with this. 
The function generateRules should take two arguments:

a function which takes 1 port argument and creates a single IPtables rule
an array with the ports for which the IPtables rules should be generated.
The generateRules function should return one string with the iptables commands.

This is how the generateRules function will be used:

string myrules = Kata.GenerateRules(MakeTcpRule, new List<uint> {22, 80, 443});
For this example the result would be this string (without linebreakings!):

"iptables -I INPUT -p tcp --dport 22 -j ACCEPT ;
iptables -I INPUT -p tcp --dport 80 -j ACCEPT ;
iptables -I INPUT -p tcp --dport 443 -j ACCEPT ;"
The makeTCPRule function is already provided for you and looks like this:

string MakeTcpRule(uint port) => $"iptables -I INPUT -p tcp --dport {port} -j ACCEPT ;";
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataGenerateRules
    {
        public static string GenerateRules(Func<uint, string> func, List<uint> portList)
        {
            return string.Concat(portList.Select(func));
        }
    }
}