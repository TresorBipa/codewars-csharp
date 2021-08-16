/*
https://www.codewars.com/kata/58a369fa5b3daf464200006c/csharp

7 kyu
How many e-mails we sent today?

Every day we can send from the server a certain limit of e-mails.

Task:
Write a function that will return the integer number of e-mails sent in the percentage of the limit.
Example:

limit       - 1000;
emails sent - 101;
return      - 10%; // becouse integer from 10,1 = 10
Arguments:

Integer, limit;
Integer, number of e-mails sent today;
When:

the argument ```$sent = 0```, then return the message: "No e-mails sent";
the argument ```$sent >= $limit```, then return the message: "Daily limit is reached";
the argument ```$limit is empty```, then default ```$limit = 1000``` emails;
Good luck!
*/

namespace CodeWars
{
    public class HowManyE_mailsWeSentToday
    {
        public static string CountEmails(int sent, int limit)
        {
            // return sent == 0 ? "No e-mails sent" : sent >= limit ? "Daily limit is reached" : $"{sent / (limit / 100)}%";
            return sent == 0 ? "No e-mails sent" : sent >= limit ? "Daily limit is reached" : $"{100 * sent / limit}%";
        }
    }
}