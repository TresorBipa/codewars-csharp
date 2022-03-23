/*
https://www.codewars.com/kata/57f21fcd69e09cb0d2000088/csharp

6 kyu
"com", "gov", "org" first

Write a code that orders collection of Uris based on it's domain next way that it will returns fisrt Uris with domain "com", "gov", "org" 
(in alphabetical order of their domains) and then all other Uris ordered in alphabetical order of their domains In addition to that

content of Uri should not be changed,
other part of Uri doesn't affect sorting. (uris "c.com","b.com","a.com" can be placed in any order inside their group, 
so both "c.com","b.com","a.com" and "a.com","c.com","b.com" are correct, till they are stand before *.org)

e.g.
"http://www.google.en/?x=jsdfkj"
"http://www.google.de/?x=jsdfkj"
"http://www.google.com/?x=jsdfkj"
"http://www.google.com/?x=jsdfkj"
"http://www.google.org/?x=jsdfkj"
"http://www.google.gov/?x=jsdfkj"

should be sorted into
"http://www.google.com/?x=jsdfkj"
"http://www.google.com/?x=jsdfkj"
"http://www.google.gov/?x=jsdfkj"
"http://www.google.org/?x=jsdfkj"
"http://www.google.de/?x=jsdfkj"
"http://www.google.en/?x=jsdfkj"
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class ComGovOrgFirst
    {
        public static IEnumerable<string> OrderByDomain(this IEnumerable<string> source)
        {
            return source.OrderBy(x => !(x.Contains(".com") || x.Contains(".gov") || x.Contains(".org"))).ThenBy(x =>
                x[x.LastIndexOf(".")..]);
            // return source.OrderByDescending(s => s.Contains(".com") || s.Contains(".gov") || s.Contains(".org")).ThenBy(s => s[s.LastIndexOf(".")..]);
            // return source.OrderBy(s => (s.Contains(".com") || s.Contains(".gov") || s.Contains(".org")) ? 0 : 1).ThenBy(s => s.Substring(s.LastIndexOf(".")));

            // return source.OrderBy(x =>
            // {
            //     var d = x.Split(".").Last().Split("/")[0];
            //     return d switch
            //     {
            //         "com" => "0",
            //         "gov" => "1",
            //         "org" => "2",
            //         _ => d
            //     };
            // });

            // static string Key(string input)
            // {
            //     var d = input.Split(".").Last().Split("/")[0];
            //
            //     return d switch
            //     {
            //         "com" => "0",
            //         "gov" => "1",
            //         "org" => "2",
            //         _ => d
            //     };
            // }


            // return source
            //     .OrderByDescending(x => x.IndexOf("com"))
            //     .ThenByDescending(x => x.IndexOf("gov"))
            //     .ThenByDescending(x => x.IndexOf("org"))
            //     .ThenBy(x => new System.Uri(x).Host.Split('.').Last());


            // var r = source.Select(x => new {Host = new Uri(x).IdnHost, URL = x})
            //     .OrderBy(x => x.Host)
            //     .ThenBy(x => !x.Host.EndsWith(".com"))
            //     .ThenBy(x => !x.Host.EndsWith(".gov"))
            //     .ThenBy(x => !x.Host.EndsWith(".org")).Select(x => x.URL);
            //
            // return r;
        }
    }
}