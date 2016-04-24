
using System.IO;
using System.Net;
using System;

public class GetRequest
{



public static string GetResp(string message)
{
  var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080");
  httpWebRequest.ContentType = "text/json";
  httpWebRequest.Method = "GET";
 /* using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
  {
    string json = "{ \"method\": \"send\", " +
                      "  \"params\": [ " +
                      "             \"IPutAGuidHere\", " +
                      "             \"msg@MyCompany.com\", " +
                      "             \"MyTenDigitNumberWasHere\", " +
                      "             \"" + message + "\" " +
                      "             ] " +
                      "}";

    streamWriter.Write(json);
  }*/
  var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
  using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
  {
    var responseText = streamReader.ReadToEnd();
    //Now you have your response.
    //or false depending on information in the response
    return responseText;        
  }
}
}