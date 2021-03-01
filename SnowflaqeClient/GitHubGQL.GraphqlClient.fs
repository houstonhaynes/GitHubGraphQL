namespace GitHubGQL

open Fable.Remoting.Json
open Newtonsoft.Json
open Newtonsoft.Json.Linq
open System.Net.Http
open System.Text

type GraphqlInput<'T> = { query: string; variables: Option<'T> }
type GraphqlSuccessResponse<'T> = { data: 'T }
type GraphqlErrorResponse = { errors: ErrorType list }

type GitHubGQLGraphqlClient(url: string, httpClient: HttpClient) =
    let converter = FableJsonConverter() :> JsonConverter
    let settings = JsonSerializerSettings(DateParseHandling=DateParseHandling.None, Converters = [| converter |])

    new(url: string) = GitHubGQLGraphqlClient(url, new HttpClient())

    member _.getRepoCountForDateRangeAsync(input: getRepoCountForDateRange.InputVariables) =
        async {
            let query = """
                query getRepoCountForDateRange ($query: String!) {
                  search(query: $query, type: REPOSITORY, first: 1) {
                    repositoryCount
                  }
                }
            """

            let inputJson = JsonConvert.SerializeObject({ query = query; variables = Some input }, [| converter |])

            let! response =
                httpClient.PostAsync(url, new StringContent(inputJson, Encoding.UTF8, "application/json"))
                |> Async.AwaitTask

            let! responseContent = Async.AwaitTask(response.Content.ReadAsStringAsync())
            let responseJson = JsonConvert.DeserializeObject<JObject>(responseContent, settings)

            match response.IsSuccessStatusCode with
            | true ->
                let errorsReturned =
                    responseJson.ContainsKey "errors"
                    && responseJson.["errors"].Type = JTokenType.Array
                    && responseJson.["errors"].HasValues

                if errorsReturned then
                    let response = responseJson.ToObject<GraphqlErrorResponse>(JsonSerializer.Create(settings))
                    return Error response.errors
                else
                    let response = responseJson.ToObject<GraphqlSuccessResponse<getRepoCountForDateRange.Query>>(JsonSerializer.Create(settings))
                    return Ok response.data

            | errorStatus ->
                let response = responseJson.ToObject<GraphqlErrorResponse>(JsonSerializer.Create(settings))
                return Error response.errors
        }

    member this.getRepoCountForDateRange(input: getRepoCountForDateRange.InputVariables) = Async.RunSynchronously(this.getRepoCountForDateRangeAsync input)
