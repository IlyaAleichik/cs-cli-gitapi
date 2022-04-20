using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace cs_cli_gitapi.Models
{
    public class Namespace
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("full_path")]
        public string FullPath { get; set; }

        [JsonPropertyName("parent_id")]
        public object ParentId { get; set; }

        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonPropertyName("web_url")]
        public string WebUrl { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonPropertyName("issues")]
        public string Issues { get; set; }

        [JsonPropertyName("merge_requests")]
        public string MergeRequests { get; set; }

        [JsonPropertyName("repo_branches")]
        public string RepoBranches { get; set; }

        [JsonPropertyName("labels")]
        public string Labels { get; set; }

        [JsonPropertyName("events")]
        public string Events { get; set; }

        [JsonPropertyName("members")]
        public string Members { get; set; }
    }

    public class OwnerLab
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonPropertyName("web_url")]
        public string WebUrl { get; set; }
    }

    public class ContainerExpirationPolicy
    {
        [JsonPropertyName("cadence")]
        public string Cadence { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("keep_n")]
        public int KeepN { get; set; }

        [JsonPropertyName("older_than")]
        public string OlderThan { get; set; }

        [JsonPropertyName("name_regex")]
        public string NameRegex { get; set; }

        [JsonPropertyName("name_regex_keep")]
        public object NameRegexKeep { get; set; }

        [JsonPropertyName("next_run_at")]
        public DateTime NextRunAt { get; set; }
    }

    public class ProjectAccess
    {
        [JsonPropertyName("access_level")]
        public int AccessLevel { get; set; }

        [JsonPropertyName("notification_level")]
        public int NotificationLevel { get; set; }
    }

    public class PermissionsLab
    {
        [JsonPropertyName("project_access")]
        public ProjectAccess ProjectAccess { get; set; }

        [JsonPropertyName("group_access")]
        public object GroupAccess { get; set; }
    }

    public class RepositoriesGitLab
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("name_with_namespace")]
        public string NameWithNamespace { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("path_with_namespace")]
        public string PathWithNamespace { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("default_branch")]
        public string DefaultBranch { get; set; }

        [JsonPropertyName("tag_list")]
        public List<object> TagList { get; set; }

        [JsonPropertyName("topics")]
        public List<object> Topics { get; set; }

        [JsonPropertyName("ssh_url_to_repo")]
        public string SshUrlToRepo { get; set; }

        [JsonPropertyName("http_url_to_repo")]
        public string HttpUrlToRepo { get; set; }

        [JsonPropertyName("web_url")]
        public string WebUrl { get; set; }

        [JsonPropertyName("readme_url")]
        public string ReadmeUrl { get; set; }

        [JsonPropertyName("avatar_url")]
        public object AvatarUrl { get; set; }

        [JsonPropertyName("forks_count")]
        public int ForksCount { get; set; }

        [JsonPropertyName("star_count")]
        public int StarCount { get; set; }

        [JsonPropertyName("last_activity_at")]
        public DateTime LastActivityAt { get; set; }

        [JsonPropertyName("namespace")]
        public Namespace Namespace { get; set; }

        [JsonPropertyName("container_registry_image_prefix")]
        public string ContainerRegistryImagePrefix { get; set; }

        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        [JsonPropertyName("packages_enabled")]
        public bool PackagesEnabled { get; set; }

        [JsonPropertyName("empty_repo")]
        public bool EmptyRepo { get; set; }

        [JsonPropertyName("archived")]
        public bool Archived { get; set; }

        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }

        [JsonPropertyName("owner")]
        public OwnerLab Owner { get; set; }

        [JsonPropertyName("resolve_outdated_diff_discussions")]
        public bool ResolveOutdatedDiffDiscussions { get; set; }

        [JsonPropertyName("container_expiration_policy")]
        public ContainerExpirationPolicy ContainerExpirationPolicy { get; set; }

        [JsonPropertyName("issues_enabled")]
        public bool IssuesEnabled { get; set; }

        [JsonPropertyName("merge_requests_enabled")]
        public bool MergeRequestsEnabled { get; set; }

        [JsonPropertyName("wiki_enabled")]
        public bool WikiEnabled { get; set; }

        [JsonPropertyName("jobs_enabled")]
        public bool JobsEnabled { get; set; }

        [JsonPropertyName("snippets_enabled")]
        public bool SnippetsEnabled { get; set; }

        [JsonPropertyName("container_registry_enabled")]
        public bool ContainerRegistryEnabled { get; set; }

        [JsonPropertyName("service_desk_enabled")]
        public bool ServiceDeskEnabled { get; set; }

        [JsonPropertyName("service_desk_address")]
        public string ServiceDeskAddress { get; set; }

        [JsonPropertyName("can_create_merge_request_in")]
        public bool CanCreateMergeRequestIn { get; set; }

        [JsonPropertyName("issues_access_level")]
        public string IssuesAccessLevel { get; set; }

        [JsonPropertyName("repository_access_level")]
        public string RepositoryAccessLevel { get; set; }

        [JsonPropertyName("merge_requests_access_level")]
        public string MergeRequestsAccessLevel { get; set; }

        [JsonPropertyName("forking_access_level")]
        public string ForkingAccessLevel { get; set; }

        [JsonPropertyName("wiki_access_level")]
        public string WikiAccessLevel { get; set; }

        [JsonPropertyName("builds_access_level")]
        public string BuildsAccessLevel { get; set; }

        [JsonPropertyName("snippets_access_level")]
        public string SnippetsAccessLevel { get; set; }

        [JsonPropertyName("pages_access_level")]
        public string PagesAccessLevel { get; set; }

        [JsonPropertyName("operations_access_level")]
        public string OperationsAccessLevel { get; set; }

        [JsonPropertyName("analytics_access_level")]
        public string AnalyticsAccessLevel { get; set; }

        [JsonPropertyName("container_registry_access_level")]
        public string ContainerRegistryAccessLevel { get; set; }

        [JsonPropertyName("security_and_compliance_access_level")]
        public string SecurityAndComplianceAccessLevel { get; set; }

        [JsonPropertyName("emails_disabled")]
        public object EmailsDisabled { get; set; }

        [JsonPropertyName("shared_runners_enabled")]
        public bool SharedRunnersEnabled { get; set; }

        [JsonPropertyName("lfs_enabled")]
        public bool LfsEnabled { get; set; }

        [JsonPropertyName("creator_id")]
        public int CreatorId { get; set; }

        [JsonPropertyName("import_status")]
        public string ImportStatus { get; set; }

        [JsonPropertyName("open_issues_count")]
        public int OpenIssuesCount { get; set; }

        [JsonPropertyName("ci_default_git_depth")]
        public int CiDefaultGitDepth { get; set; }

        [JsonPropertyName("ci_forward_deployment_enabled")]
        public bool CiForwardDeploymentEnabled { get; set; }

        [JsonPropertyName("ci_job_token_scope_enabled")]
        public bool CiJobTokenScopeEnabled { get; set; }

        [JsonPropertyName("public_jobs")]
        public bool PublicJobs { get; set; }

        [JsonPropertyName("build_timeout")]
        public int BuildTimeout { get; set; }

        [JsonPropertyName("auto_cancel_pending_pipelines")]
        public string AutoCancelPendingPipelines { get; set; }

        [JsonPropertyName("build_coverage_regex")]
        public object BuildCoverageRegex { get; set; }

        [JsonPropertyName("ci_config_path")]
        public string CiConfigPath { get; set; }

        [JsonPropertyName("shared_with_groups")]
        public List<object> SharedWithGroups { get; set; }

        [JsonPropertyName("only_allow_merge_if_pipeline_succeeds")]
        public bool OnlyAllowMergeIfPipelineSucceeds { get; set; }

        [JsonPropertyName("allow_merge_on_skipped_pipeline")]
        public object AllowMergeOnSkippedPipeline { get; set; }

        [JsonPropertyName("restrict_user_defined_variables")]
        public bool RestrictUserDefinedVariables { get; set; }

        [JsonPropertyName("request_access_enabled")]
        public bool RequestAccessEnabled { get; set; }

        [JsonPropertyName("only_allow_merge_if_all_discussions_are_resolved")]
        public bool OnlyAllowMergeIfAllDiscussionsAreResolved { get; set; }

        [JsonPropertyName("remove_source_branch_after_merge")]
        public bool RemoveSourceBranchAfterMerge { get; set; }

        [JsonPropertyName("printing_merge_request_link_enabled")]
        public bool PrintingMergeRequestLinkEnabled { get; set; }

        [JsonPropertyName("merge_method")]
        public string MergeMethod { get; set; }

        [JsonPropertyName("squash_option")]
        public string SquashOption { get; set; }

        [JsonPropertyName("suggestion_commit_message")]
        public object SuggestionCommitMessage { get; set; }

        [JsonPropertyName("merge_commit_template")]
        public object MergeCommitTemplate { get; set; }

        [JsonPropertyName("squash_commit_template")]
        public object SquashCommitTemplate { get; set; }

        [JsonPropertyName("auto_devops_enabled")]
        public bool AutoDevopsEnabled { get; set; }

        [JsonPropertyName("auto_devops_deploy_strategy")]
        public string AutoDevopsDeployStrategy { get; set; }

        [JsonPropertyName("autoclose_referenced_issues")]
        public bool AutocloseReferencedIssues { get; set; }

        [JsonPropertyName("keep_latest_artifact")]
        public bool KeepLatestArtifact { get; set; }

        [JsonPropertyName("runner_token_expiration_interval")]
        public object RunnerTokenExpirationInterval { get; set; }

        [JsonPropertyName("external_authorization_classification_label")]
        public string ExternalAuthorizationClassificationLabel { get; set; }

        [JsonPropertyName("requirements_enabled")]
        public bool RequirementsEnabled { get; set; }

        [JsonPropertyName("requirements_access_level")]
        public string RequirementsAccessLevel { get; set; }

        [JsonPropertyName("security_and_compliance_enabled")]
        public bool SecurityAndComplianceEnabled { get; set; }

        [JsonPropertyName("compliance_frameworks")]
        public List<object> ComplianceFrameworks { get; set; }

        [JsonPropertyName("permissions")]
        public PermissionsLab Permissions { get; set; }
    }
}