Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Diagnostics
Imports System.Threading
Imports System.Net
Imports System.Net.Http
Imports System.IO
Imports System.Data
Imports Microsoft.Win32
Imports System.Reflection
Imports System.ComponentModel
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text.RegularExpressions
Imports System.Data.SqlTypes


Imports HtmlAgilityPack

'Imports FranConnectLibrary
'Imports SRCorrigo
Module Main
    Private _DomainFieldNameInAccount As String = "new_domain"
    Private _TicketFieldNameInCase As String = "new_CaseNumber"
    Private _SubjectIdInCase As String = "fe350118-22fd-4813-b801-791ac32e9dde"
    Sub Main()
        Dim stopWatch As Stopwatch = New Stopwatch()
        stopWatch.Start()
        Console.WriteLine(String.Format("{0}{1}{0}", New String("="c, 5), DateTime.Now))

        testCLR()

        stopWatch.[Stop]()
        Dim ts As TimeSpan = stopWatch.Elapsed
        Console.WriteLine(String.Format(vbLf & "{0}{1}{0}", New String("="c, 5), DateTime.Now))
        Console.WriteLine($"Elapsed: {ts:c}")
        Console.WriteLine("THE END")
        Console.ReadLine()
    End Sub

    Private Sub testCLR()
        Dim paraInput As SqlString = "Test"
        Dim paraOutput As SqlString

        TestDatabase.TestSqlStoredProcedure.TestStoredProcedure(paraInput, paraOutput)
        Console.WriteLine(paraOutput)
    End Sub

    Private Sub testRegex()
        Dim values As System.Text.RegularExpressions.MatchCollection
        Dim patten As String
        Dim ticket As String
        Dim testStr As String
        Dim regex As System.Text.RegularExpressions.Regex

        testStr = "(Andrew Huang)andrew@huang@websan.com"
        patten = "\((?<Name>.*)\)(?<Email>.*)"
        regex = New Regex(patten, RegexOptions.IgnoreCase)
        Console.WriteLine($"{testStr} - [{regex.Match(testStr).Groups("Name").Value}] - [{regex.Match(testStr).Groups("Email").Value}]")

    End Sub

    Private Sub testRegex5()
        Dim values As System.Text.RegularExpressions.MatchCollection
        Dim patten As String
        Dim ticket As String
        Dim testStr As String
        Dim regex As System.Text.RegularExpressions.Regex

        testStr = "RE: Issue [#No1234 5678]: [TEST] Test for Websan CRM Ticketing System"
        Dim firstNumber As String
        patten = "(.*)Issue \[\#(?<part1>\w+)\]\:(.*)"
        Dim str1 = Regex.Escape("Issue [#")
        Dim str2 = Regex.Escape("]: ")
        'patten = "(.*)Issue \[\#(?<part1>\w+)\]\:(.*)"
        patten = $"(.*){str1}(?<part1>.*){str2}(.*)"
        regex = New Regex(patten, RegexOptions.IgnoreCase)
        firstNumber = regex.Match(testStr).Groups("part1").Value

        Dim casePrefix = "Issue [#{TicketNumber}]:"
        Dim subject = "RE: Issue #1234 5678]: [TEST] Test for Websan CRM Ticketing System"
        Dim words = System.Text.RegularExpressions.Regex.Split(casePrefix, "{TicketNumber}")
        Dim startDelimiter = Regex.Escape(words(0))
        Dim endDelimiter = Regex.Escape(words(1))
        patten = $"(.*){startDelimiter}(?<TicketNumber>.*){endDelimiter}(.*)"
        regex = New Regex(patten, RegexOptions.IgnoreCase)
        ticket = regex.Match(testStr).Groups("TicketNumber").Value
        Console.WriteLine($"{subject} - [{ticket}]")

        casePrefix = "#{TicketNumber}:"
        subject = "RE: Issue #1234 5678]: [TEST] Test for Websan CRM Ticketing System"
        words = System.Text.RegularExpressions.Regex.Split(casePrefix, "{TicketNumber}")
        startDelimiter = Regex.Escape(words(0))
        endDelimiter = Regex.Escape(words(1))
        patten = $"(.*){startDelimiter}(?<TicketNumber>.*){endDelimiter}(.*)"
        regex = New Regex(patten, RegexOptions.IgnoreCase)
        ticket = regex.Match(testStr).Groups("TicketNumber").Value
        Console.WriteLine($"{subject} - [{ticket}]")

    End Sub


    Private Sub testRegex3()
        Dim values As System.Text.RegularExpressions.MatchCollection
        Dim parten As String

        Dim numberPattern = "([0-9]+)"
        Dim value = System.Text.RegularExpressions.Regex.Matches("something102asdfkj1948948", numberPattern)

        parten = "\(([0-9]+)\)"

        Console.WriteLine("1. {0}", System.Text.RegularExpressions.Regex.IsMatch("file 01.pgp", parten))
        values = System.Text.RegularExpressions.Regex.Matches("file 01.pgp", parten)
        Console.WriteLine("2. {0}", System.Text.RegularExpressions.Regex.IsMatch("file (1).pgp", parten))
        values = System.Text.RegularExpressions.Regex.Matches("file (02).pgp", parten)
        Console.WriteLine("2. {0}", values(0).Value)
        Console.WriteLine("3. {0}", System.Text.RegularExpressions.Regex.IsMatch("file (02).pgp", parten))
        Console.WriteLine("4. {0}", System.Text.RegularExpressions.Regex.IsMatch("file ().pgp", parten))


    End Sub
    Private Sub testRegex2()
        Dim parten As String

        Console.WriteLine("================================")
        parten = "WSI_20180808(.*).txt.pgp"
        Console.WriteLine("1. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_20180808010199.txt.pgp", parten))
        Console.WriteLine("2. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_201808082301.txt1.pgp", parten))
        Console.WriteLine("3. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_20180808.txt.pgp", parten))
        Console.WriteLine("4. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_20180808aaaa.txt.pgp", parten))
        Console.WriteLine("================================")
        parten = "WSI_20180808([0-9]{4}).txt.pgp"
        Console.WriteLine("1. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_20180808010199.txt.pgp", parten))
        Console.WriteLine("2. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_201808082301.txt.pgp", parten))
        Console.WriteLine("3. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_201808081234.txt.pgp", parten))
        Console.WriteLine("4. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_20180808123.txt.pgp", parten))
        Console.WriteLine("================================")
        parten = "WSI_20180808(.{4}).txt.pgp"
        parten = "WSI_20180808(.?)(.?)A(.?)(.?).txt.pgp"
        Console.WriteLine("1. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_20180808010199.txt.pgp", parten))
        Console.WriteLine("2. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_2018080823A01.txt1.pgp", parten))
        Console.WriteLine("3. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_2018080812A3a.txt.pgp", parten))
        Console.WriteLine("4. {0}", System.Text.RegularExpressions.Regex.IsMatch("WSI_2018080812A3.txt.pgp", parten))

    End Sub
End Module
