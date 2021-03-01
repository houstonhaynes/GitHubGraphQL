[<RequireQualifiedAccess>]
module rec GitHubGQL.getRepoCountForDateRange

type InputVariables = { query: string }

/// Perform a search across resources.
type SearchResultItemConnection =
    { /// The number of repositories that matched the search query.
      repositoryCount: int }

/// The query root of GitHub's GraphQL interface.
type Query =
    { /// Perform a search across resources.
      search: SearchResultItemConnection }
