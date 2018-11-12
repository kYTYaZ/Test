public void test()
{
    Newtonsoft.Json.Linq.JObject Jobject = Newtonsoft.Json.Linq.JObject.Parse(apiLog.apiResponse);

    apiLog.token = Jobject.Item["access_token"];
}
