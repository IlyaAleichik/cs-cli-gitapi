using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace cs_cli_gitapi.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Owner
    {
        [JsonPropertyName("login")]
        public string Login;

        [JsonPropertyName("id")]
        public int Id;

        [JsonPropertyName("node_id")]
        public string NodeId;

        [JsonPropertyName("avatar_url")]
        public string AvatarUrl;

        [JsonPropertyName("gravatar_id")]
        public string GravatarId;

        [JsonPropertyName("url")]
        public string Url;

        [JsonPropertyName("html_url")]
        public string HtmlUrl;

        [JsonPropertyName("followers_url")]
        public string FollowersUrl;

        [JsonPropertyName("following_url")]
        public string FollowingUrl;

        [JsonPropertyName("gists_url")]
        public string GistsUrl;

        [JsonPropertyName("starred_url")]
        public string StarredUrl;

        [JsonPropertyName("subscriptions_url")]
        public string SubscriptionsUrl;

        [JsonPropertyName("organizations_url")]
        public string OrganizationsUrl;

        [JsonPropertyName("repos_url")]
        public string ReposUrl;

        [JsonPropertyName("events_url")]
        public string EventsUrl;

        [JsonPropertyName("received_events_url")]
        public string ReceivedEventsUrl;

        [JsonPropertyName("type")]
        public string Type;

        [JsonPropertyName("site_admin")]
        public bool SiteAdmin;
    }

    public class License
    {
        [JsonPropertyName("key")]
        public string Key;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("spdx_id")]
        public string SpdxId;

        [JsonPropertyName("url")]
        public string Url;

        [JsonPropertyName("node_id")]
        public string NodeId;
    }

    public class Permissions
    {
        [JsonPropertyName("admin")]
        public bool Admin;

        [JsonPropertyName("maintain")]
        public bool Maintain;

        [JsonPropertyName("push")]
        public bool Push;

        [JsonPropertyName("triage")]
        public bool Triage;

        [JsonPropertyName("pull")]
        public bool Pull;
    }

    public class Root
    {
        [JsonPropertyName("id")]
        public int Id;

        [JsonPropertyName("node_id")]
        public string NodeId;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("full_name")]
        public string FullName;

        [JsonPropertyName("private")]
        public bool Private;

        [JsonPropertyName("owner")]
        public Owner Owner;

        [JsonPropertyName("html_url")]
        public string HtmlUrl;

        [JsonPropertyName("description")]
        public string Description;

        [JsonPropertyName("fork")]
        public bool Fork;

        [JsonPropertyName("url")]
        public string Url;

        [JsonPropertyName("forks_url")]
        public string ForksUrl;

        [JsonPropertyName("keys_url")]
        public string KeysUrl;

        [JsonPropertyName("collaborators_url")]
        public string CollaboratorsUrl;

        [JsonPropertyName("teams_url")]
        public string TeamsUrl;

        [JsonPropertyName("hooks_url")]
        public string HooksUrl;

        [JsonPropertyName("issue_events_url")]
        public string IssueEventsUrl;

        [JsonPropertyName("events_url")]
        public string EventsUrl;

        [JsonPropertyName("assignees_url")]
        public string AssigneesUrl;

        [JsonPropertyName("branches_url")]
        public string BranchesUrl;

        [JsonPropertyName("tags_url")]
        public string TagsUrl;

        [JsonPropertyName("blobs_url")]
        public string BlobsUrl;

        [JsonPropertyName("git_tags_url")]
        public string GitTagsUrl;

        [JsonPropertyName("git_refs_url")]
        public string GitRefsUrl;

        [JsonPropertyName("trees_url")]
        public string TreesUrl;

        [JsonPropertyName("statuses_url")]
        public string StatusesUrl;

        [JsonPropertyName("languages_url")]
        public string LanguagesUrl;

        [JsonPropertyName("stargazers_url")]
        public string StargazersUrl;

        [JsonPropertyName("contributors_url")]
        public string ContributorsUrl;

        [JsonPropertyName("subscribers_url")]
        public string SubscribersUrl;

        [JsonPropertyName("subscription_url")]
        public string SubscriptionUrl;

        [JsonPropertyName("commits_url")]
        public string CommitsUrl;

        [JsonPropertyName("git_commits_url")]
        public string GitCommitsUrl;

        [JsonPropertyName("comments_url")]
        public string CommentsUrl;

        [JsonPropertyName("issue_comment_url")]
        public string IssueCommentUrl;

        [JsonPropertyName("contents_url")]
        public string ContentsUrl;

        [JsonPropertyName("compare_url")]
        public string CompareUrl;

        [JsonPropertyName("merges_url")]
        public string MergesUrl;

        [JsonPropertyName("archive_url")]
        public string ArchiveUrl;

        [JsonPropertyName("downloads_url")]
        public string DownloadsUrl;

        [JsonPropertyName("issues_url")]
        public string IssuesUrl;

        [JsonPropertyName("pulls_url")]
        public string PullsUrl;

        [JsonPropertyName("milestones_url")]
        public string MilestonesUrl;

        [JsonPropertyName("notifications_url")]
        public string NotificationsUrl;

        [JsonPropertyName("labels_url")]
        public string LabelsUrl;

        [JsonPropertyName("releases_url")]
        public string ReleasesUrl;

        [JsonPropertyName("deployments_url")]
        public string DeploymentsUrl;

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt;

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt;

        [JsonPropertyName("pushed_at")]
        public DateTime PushedAt;

        [JsonPropertyName("git_url")]
        public string GitUrl;

        [JsonPropertyName("ssh_url")]
        public string SshUrl;

        [JsonPropertyName("clone_url")]
        public string CloneUrl;

        [JsonPropertyName("svn_url")]
        public string SvnUrl;

        [JsonPropertyName("homepage")]
        public string Homepage;

        [JsonPropertyName("size")]
        public int Size;

        [JsonPropertyName("stargazers_count")]
        public int StargazersCount;

        [JsonPropertyName("watchers_count")]
        public int WatchersCount;

        [JsonPropertyName("language")]
        public string Language;

        [JsonPropertyName("has_issues")]
        public bool HasIssues;

        [JsonPropertyName("has_projects")]
        public bool HasProjects;

        [JsonPropertyName("has_downloads")]
        public bool HasDownloads;

        [JsonPropertyName("has_wiki")]
        public bool HasWiki;

        [JsonPropertyName("has_pages")]
        public bool HasPages;

        [JsonPropertyName("forks_count")]
        public int ForksCount;

        [JsonPropertyName("mirror_url")]
        public object MirrorUrl;

        [JsonPropertyName("archived")]
        public bool Archived;

        [JsonPropertyName("disabled")]
        public bool Disabled;

        [JsonPropertyName("open_issues_count")]
        public int OpenIssuesCount;

        [JsonPropertyName("license")]
        public License License;

        [JsonPropertyName("allow_forking")]
        public bool AllowForking;

        [JsonPropertyName("is_template")]
        public bool IsTemplate;

        [JsonPropertyName("topics")]
        public List<object> Topics;

        [JsonPropertyName("visibility")]
        public string Visibility;

        [JsonPropertyName("forks")]
        public int Forks;

        [JsonPropertyName("open_issues")]
        public int OpenIssues;

        [JsonPropertyName("watchers")]
        public int Watchers;

        [JsonPropertyName("default_branch")]
        public string DefaultBranch;

        [JsonPropertyName("permissions")]
        public Permissions Permissions;
    }


}