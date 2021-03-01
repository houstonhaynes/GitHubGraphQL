namespace rec GitHubGQL

///Properties by which Audit Log connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AuditLogOrderField = /// Order audit log entries by timestamp
    | [<CompiledName "CREATED_AT">] CreatedAt

///Represents an annotation's information level.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CheckAnnotationLevel =
    /// An annotation indicating an inescapable error.
    | [<CompiledName "FAILURE">] Failure
    /// An annotation indicating some information.
    | [<CompiledName "NOTICE">] Notice
    /// An annotation indicating an ignorable error.
    | [<CompiledName "WARNING">] Warning

///The possible states for a check suite or run conclusion.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CheckConclusionState =
    /// The check suite or run requires action.
    | [<CompiledName "ACTION_REQUIRED">] ActionRequired
    /// The check suite or run has timed out.
    | [<CompiledName "TIMED_OUT">] TimedOut
    /// The check suite or run has been cancelled.
    | [<CompiledName "CANCELLED">] Cancelled
    /// The check suite or run has failed.
    | [<CompiledName "FAILURE">] Failure
    /// The check suite or run has succeeded.
    | [<CompiledName "SUCCESS">] Success
    /// The check suite or run was neutral.
    | [<CompiledName "NEUTRAL">] Neutral
    /// The check suite or run was skipped.
    | [<CompiledName "SKIPPED">] Skipped
    /// The check suite or run has failed at startup.
    | [<CompiledName "STARTUP_FAILURE">] StartupFailure
    /// The check suite or run was marked stale by GitHub. Only GitHub can use this conclusion.
    | [<CompiledName "STALE">] Stale

///The possible types of check runs.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CheckRunType =
    /// Every check run available.
    | [<CompiledName "ALL">] All
    /// The latest check run.
    | [<CompiledName "LATEST">] Latest

///The possible states for a check suite or run status.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CheckStatusState =
    /// The check suite or run has been queued.
    | [<CompiledName "QUEUED">] Queued
    /// The check suite or run is in progress.
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The check suite or run has been completed.
    | [<CompiledName "COMPLETED">] Completed
    /// The check suite or run is in waiting state.
    | [<CompiledName "WAITING">] Waiting
    /// The check suite or run has been requested.
    | [<CompiledName "REQUESTED">] Requested

///Collaborators affiliation level with a subject.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CollaboratorAffiliation =
    /// All outside collaborators of an organization-owned subject.
    | [<CompiledName "OUTSIDE">] Outside
    /// All collaborators with permissions to an organization-owned subject, regardless of organization membership status.
    | [<CompiledName "DIRECT">] Direct
    /// All collaborators the authenticated user can see.
    | [<CompiledName "ALL">] All

///A comment author association with repository.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CommentAuthorAssociation =
    /// Author is a member of the organization that owns the repository.
    | [<CompiledName "MEMBER">] Member
    /// Author is the owner of the repository.
    | [<CompiledName "OWNER">] Owner
    /// Author is a placeholder for an unclaimed user.
    | [<CompiledName "MANNEQUIN">] Mannequin
    /// Author has been invited to collaborate on the repository.
    | [<CompiledName "COLLABORATOR">] Collaborator
    /// Author has previously committed to the repository.
    | [<CompiledName "CONTRIBUTOR">] Contributor
    /// Author has not previously committed to the repository.
    | [<CompiledName "FIRST_TIME_CONTRIBUTOR">] FirstTimeContributor
    /// Author has not previously committed to GitHub.
    | [<CompiledName "FIRST_TIMER">] FirstTimer
    /// Author has no association with the repository.
    | [<CompiledName "NONE">] None

///The possible errors that will prevent a user from updating a comment.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CommentCannotUpdateReason =
    /// Unable to create comment because repository is archived.
    | [<CompiledName "ARCHIVED">] Archived
    /// You must be the author or have write access to this repository to update this comment.
    | [<CompiledName "INSUFFICIENT_ACCESS">] InsufficientAccess
    /// Unable to create comment because issue is locked.
    | [<CompiledName "LOCKED">] Locked
    /// You must be logged in to update this comment.
    | [<CompiledName "LOGIN_REQUIRED">] LoginRequired
    /// Repository is under maintenance.
    | [<CompiledName "MAINTENANCE">] Maintenance
    /// At least one email address must be verified to update this comment.
    | [<CompiledName "VERIFIED_EMAIL_REQUIRED">] VerifiedEmailRequired
    /// You cannot update this comment
    | [<CompiledName "DENIED">] Denied

///Properties by which commit contribution connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CommitContributionOrderField =
    /// Order commit contributions by when they were made.
    | [<CompiledName "OCCURRED_AT">] OccurredAt
    /// Order commit contributions by how many commits they represent.
    | [<CompiledName "COMMIT_COUNT">] CommitCount

///Varying levels of contributions from none to many.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ContributionLevel =
    /// No contributions occurred.
    | [<CompiledName "NONE">] None
    /// Lowest 25% of days of contributions.
    | [<CompiledName "FIRST_QUARTILE">] FirstQuartile
    /// Second lowest 25% of days of contributions. More contributions than the first quartile.
    | [<CompiledName "SECOND_QUARTILE">] SecondQuartile
    /// Second highest 25% of days of contributions. More contributions than second quartile, less than the fourth quartile.
    | [<CompiledName "THIRD_QUARTILE">] ThirdQuartile
    /// Highest 25% of days of contributions. More contributions than the third quartile.
    | [<CompiledName "FOURTH_QUARTILE">] FourthQuartile

///The possible default permissions for repositories.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DefaultRepositoryPermissionField =
    /// No access
    | [<CompiledName "NONE">] None
    /// Can read repos by default
    | [<CompiledName "READ">] Read
    /// Can read and write repos by default
    | [<CompiledName "WRITE">] Write
    /// Can read, write, and administrate repos by default
    | [<CompiledName "ADMIN">] Admin

///Properties by which deployment connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentOrderField = /// Order collection by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

///The possible states in which a deployment can be.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentState =
    /// The pending deployment was not updated after 30 minutes.
    | [<CompiledName "ABANDONED">] Abandoned
    /// The deployment is currently active.
    | [<CompiledName "ACTIVE">] Active
    /// An inactive transient deployment.
    | [<CompiledName "DESTROYED">] Destroyed
    /// The deployment experienced an error.
    | [<CompiledName "ERROR">] Error
    /// The deployment has failed.
    | [<CompiledName "FAILURE">] Failure
    /// The deployment is inactive.
    | [<CompiledName "INACTIVE">] Inactive
    /// The deployment is pending.
    | [<CompiledName "PENDING">] Pending
    /// The deployment has queued
    | [<CompiledName "QUEUED">] Queued
    /// The deployment is in progress.
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The deployment is waiting.
    | [<CompiledName "WAITING">] Waiting

///The possible states for a deployment status.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentStatusState =
    /// The deployment is pending.
    | [<CompiledName "PENDING">] Pending
    /// The deployment was successful.
    | [<CompiledName "SUCCESS">] Success
    /// The deployment has failed.
    | [<CompiledName "FAILURE">] Failure
    /// The deployment is inactive.
    | [<CompiledName "INACTIVE">] Inactive
    /// The deployment experienced an error.
    | [<CompiledName "ERROR">] Error
    /// The deployment is queued
    | [<CompiledName "QUEUED">] Queued
    /// The deployment is in progress.
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The deployment is waiting.
    | [<CompiledName "WAITING">] Waiting

///The possible sides of a diff.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DiffSide =
    /// The left side of the diff.
    | [<CompiledName "LEFT">] Left
    /// The right side of the diff.
    | [<CompiledName "RIGHT">] Right

///Properties by which enterprise administrator invitation connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseAdministratorInvitationOrderField = /// Order enterprise administrator member invitations by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

///The possible administrator roles in an enterprise account.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseAdministratorRole =
    /// Represents an owner of the enterprise account.
    | [<CompiledName "OWNER">] Owner
    /// Represents a billing manager of the enterprise account.
    | [<CompiledName "BILLING_MANAGER">] BillingManager

///The possible values for the enterprise default repository permission setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseDefaultRepositoryPermissionSettingValue =
    /// Organizations in the enterprise choose default repository permissions for their members.
    | [<CompiledName "NO_POLICY">] NoPolicy
    /// Organization members will be able to clone, pull, push, and add new collaborators to all organization repositories.
    | [<CompiledName "ADMIN">] Admin
    /// Organization members will be able to clone, pull, and push all organization repositories.
    | [<CompiledName "WRITE">] Write
    /// Organization members will be able to clone and pull all organization repositories.
    | [<CompiledName "READ">] Read
    /// Organization members will only be able to clone and pull public repositories.
    | [<CompiledName "NONE">] None

///The possible values for an enabled/disabled enterprise setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseEnabledDisabledSettingValue =
    /// The setting is enabled for organizations in the enterprise.
    | [<CompiledName "ENABLED">] Enabled
    /// The setting is disabled for organizations in the enterprise.
    | [<CompiledName "DISABLED">] Disabled
    /// There is no policy set for organizations in the enterprise.
    | [<CompiledName "NO_POLICY">] NoPolicy

///The possible values for an enabled/no policy enterprise setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseEnabledSettingValue =
    /// The setting is enabled for organizations in the enterprise.
    | [<CompiledName "ENABLED">] Enabled
    /// There is no policy set for organizations in the enterprise.
    | [<CompiledName "NO_POLICY">] NoPolicy

///Properties by which enterprise member connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseMemberOrderField =
    /// Order enterprise members by login
    | [<CompiledName "LOGIN">] Login
    /// Order enterprise members by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

///The possible values for the enterprise members can create repositories setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseMembersCanCreateRepositoriesSettingValue =
    /// Organization administrators choose whether to allow members to create repositories.
    | [<CompiledName "NO_POLICY">] NoPolicy
    /// Members will be able to create public and private repositories.
    | [<CompiledName "ALL">] All
    /// Members will be able to create only public repositories.
    | [<CompiledName "PUBLIC">] Public
    /// Members will be able to create only private repositories.
    | [<CompiledName "PRIVATE">] Private
    /// Members will not be able to create public or private repositories.
    | [<CompiledName "DISABLED">] Disabled

///The possible values for the members can make purchases setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseMembersCanMakePurchasesSettingValue =
    /// The setting is enabled for organizations in the enterprise.
    | [<CompiledName "ENABLED">] Enabled
    /// The setting is disabled for organizations in the enterprise.
    | [<CompiledName "DISABLED">] Disabled

///Properties by which Enterprise Server installation connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseServerInstallationOrderField =
    /// Order Enterprise Server installations by host name
    | [<CompiledName "HOST_NAME">] HostName
    /// Order Enterprise Server installations by customer name
    | [<CompiledName "CUSTOMER_NAME">] CustomerName
    /// Order Enterprise Server installations by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

///Properties by which Enterprise Server user account email connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseServerUserAccountEmailOrderField = /// Order emails by email
    | [<CompiledName "EMAIL">] Email

///Properties by which Enterprise Server user account connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseServerUserAccountOrderField =
    /// Order user accounts by login
    | [<CompiledName "LOGIN">] Login
    /// Order user accounts by creation time on the Enterprise Server installation
    | [<CompiledName "REMOTE_CREATED_AT">] RemoteCreatedAt

///Properties by which Enterprise Server user accounts upload connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseServerUserAccountsUploadOrderField = /// Order user accounts uploads by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

///Synchronization state of the Enterprise Server user accounts upload
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseServerUserAccountsUploadSyncState =
    /// The synchronization of the upload is pending.
    | [<CompiledName "PENDING">] Pending
    /// The synchronization of the upload succeeded.
    | [<CompiledName "SUCCESS">] Success
    /// The synchronization of the upload failed.
    | [<CompiledName "FAILURE">] Failure

///The possible roles for enterprise membership.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseUserAccountMembershipRole =
    /// The user is a member of the enterprise membership.
    | [<CompiledName "MEMBER">] Member
    /// The user is an owner of the enterprise membership.
    | [<CompiledName "OWNER">] Owner

///The possible GitHub Enterprise deployments where this user can exist.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseUserDeployment =
    /// The user is part of a GitHub Enterprise Cloud deployment.
    | [<CompiledName "CLOUD">] Cloud
    /// The user is part of a GitHub Enterprise Server deployment.
    | [<CompiledName "SERVER">] Server

///The possible viewed states of a file .
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type FileViewedState =
    /// The file has new changes since last viewed.
    | [<CompiledName "DISMISSED">] Dismissed
    /// The file has been marked as viewed.
    | [<CompiledName "VIEWED">] Viewed
    /// The file has not been marked as viewed.
    | [<CompiledName "UNVIEWED">] Unviewed

///The possible funding platforms for repository funding links.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type FundingPlatform =
    /// GitHub funding platform.
    | [<CompiledName "GITHUB">] Github
    /// Patreon funding platform.
    | [<CompiledName "PATREON">] Patreon
    /// Open Collective funding platform.
    | [<CompiledName "OPEN_COLLECTIVE">] OpenCollective
    /// Ko-fi funding platform.
    | [<CompiledName "KO_FI">] KoFi
    /// Tidelift funding platform.
    | [<CompiledName "TIDELIFT">] Tidelift
    /// Community Bridge funding platform.
    | [<CompiledName "COMMUNITY_BRIDGE">] CommunityBridge
    /// Liberapay funding platform.
    | [<CompiledName "LIBERAPAY">] Liberapay
    /// IssueHunt funding platform.
    | [<CompiledName "ISSUEHUNT">] Issuehunt
    /// Otechie funding platform.
    | [<CompiledName "OTECHIE">] Otechie
    /// Custom funding platform.
    | [<CompiledName "CUSTOM">] Custom

///Properties by which gist connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GistOrderField =
    /// Order gists by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order gists by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order gists by push time
    | [<CompiledName "PUSHED_AT">] PushedAt

///The privacy of a Gist
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GistPrivacy =
    /// Public
    | [<CompiledName "PUBLIC">] Public
    /// Secret
    | [<CompiledName "SECRET">] Secret
    /// Gists that are public and secret
    | [<CompiledName "ALL">] All

///The state of a Git signature.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GitSignatureState =
    /// Valid signature and verified by GitHub
    | [<CompiledName "VALID">] Valid
    /// Invalid signature
    | [<CompiledName "INVALID">] Invalid
    /// Malformed signature
    | [<CompiledName "MALFORMED_SIG">] MalformedSig
    /// Key used for signing not known to GitHub
    | [<CompiledName "UNKNOWN_KEY">] UnknownKey
    /// Invalid email used for signing
    | [<CompiledName "BAD_EMAIL">] BadEmail
    /// Email used for signing unverified on GitHub
    | [<CompiledName "UNVERIFIED_EMAIL">] UnverifiedEmail
    /// Email used for signing not known to GitHub
    | [<CompiledName "NO_USER">] NoUser
    /// Unknown signature type
    | [<CompiledName "UNKNOWN_SIG_TYPE">] UnknownSigType
    /// Unsigned
    | [<CompiledName "UNSIGNED">] Unsigned
    /// Internal error - the GPG verification service is unavailable at the moment
    | [<CompiledName "GPGVERIFY_UNAVAILABLE">] GpgverifyUnavailable
    /// Internal error - the GPG verification service misbehaved
    | [<CompiledName "GPGVERIFY_ERROR">] GpgverifyError
    /// The usage flags for the key that signed this don't allow signing
    | [<CompiledName "NOT_SIGNING_KEY">] NotSigningKey
    /// Signing key expired
    | [<CompiledName "EXPIRED_KEY">] ExpiredKey
    /// Valid signature, pending certificate revocation checking
    | [<CompiledName "OCSP_PENDING">] OcspPending
    /// Valid signature, though certificate revocation check failed
    | [<CompiledName "OCSP_ERROR">] OcspError
    /// The signing certificate or its chain could not be verified
    | [<CompiledName "BAD_CERT">] BadCert
    /// One or more certificates in chain has been revoked
    | [<CompiledName "OCSP_REVOKED">] OcspRevoked

///The possible states in which authentication can be configured with an identity provider.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IdentityProviderConfigurationState =
    /// Authentication with an identity provider is configured and enforced.
    | [<CompiledName "ENFORCED">] Enforced
    /// Authentication with an identity provider is configured but not enforced.
    | [<CompiledName "CONFIGURED">] Configured
    /// Authentication with an identity provider is not configured.
    | [<CompiledName "UNCONFIGURED">] Unconfigured

///The possible values for the IP allow list enabled setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IpAllowListEnabledSettingValue =
    /// The setting is enabled for the owner.
    | [<CompiledName "ENABLED">] Enabled
    /// The setting is disabled for the owner.
    | [<CompiledName "DISABLED">] Disabled

///Properties by which IP allow list entry connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IpAllowListEntryOrderField =
    /// Order IP allow list entries by creation time.
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order IP allow list entries by the allow list value.
    | [<CompiledName "ALLOW_LIST_VALUE">] AllowListValue

///Properties by which issue comment connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueCommentOrderField = /// Order issue comments by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt

///Properties by which issue connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueOrderField =
    /// Order issues by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order issues by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order issues by comment count
    | [<CompiledName "COMMENTS">] Comments

///The possible states of an issue.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueState =
    /// An issue that is still open
    | [<CompiledName "OPEN">] Open
    /// An issue that has been closed
    | [<CompiledName "CLOSED">] Closed

///The possible item types found in a timeline.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueTimelineItemsItemType =
    /// Represents a comment on an Issue.
    | [<CompiledName "ISSUE_COMMENT">] IssueComment
    /// Represents a mention made by one issue or pull request to another.
    | [<CompiledName "CROSS_REFERENCED_EVENT">] CrossReferencedEvent
    /// Represents a 'added_to_project' event on a given issue or pull request.
    | [<CompiledName "ADDED_TO_PROJECT_EVENT">] AddedToProjectEvent
    /// Represents an 'assigned' event on any assignable object.
    | [<CompiledName "ASSIGNED_EVENT">] AssignedEvent
    /// Represents a 'closed' event on any `Closable`.
    | [<CompiledName "CLOSED_EVENT">] ClosedEvent
    /// Represents a 'comment_deleted' event on a given issue or pull request.
    | [<CompiledName "COMMENT_DELETED_EVENT">] CommentDeletedEvent
    /// Represents a 'connected' event on a given issue or pull request.
    | [<CompiledName "CONNECTED_EVENT">] ConnectedEvent
    /// Represents a 'converted_note_to_issue' event on a given issue or pull request.
    | [<CompiledName "CONVERTED_NOTE_TO_ISSUE_EVENT">] ConvertedNoteToIssueEvent
    /// Represents a 'demilestoned' event on a given issue or pull request.
    | [<CompiledName "DEMILESTONED_EVENT">] DemilestonedEvent
    /// Represents a 'disconnected' event on a given issue or pull request.
    | [<CompiledName "DISCONNECTED_EVENT">] DisconnectedEvent
    /// Represents a 'labeled' event on a given issue or pull request.
    | [<CompiledName "LABELED_EVENT">] LabeledEvent
    /// Represents a 'locked' event on a given issue or pull request.
    | [<CompiledName "LOCKED_EVENT">] LockedEvent
    /// Represents a 'marked_as_duplicate' event on a given issue or pull request.
    | [<CompiledName "MARKED_AS_DUPLICATE_EVENT">] MarkedAsDuplicateEvent
    /// Represents a 'mentioned' event on a given issue or pull request.
    | [<CompiledName "MENTIONED_EVENT">] MentionedEvent
    /// Represents a 'milestoned' event on a given issue or pull request.
    | [<CompiledName "MILESTONED_EVENT">] MilestonedEvent
    /// Represents a 'moved_columns_in_project' event on a given issue or pull request.
    | [<CompiledName "MOVED_COLUMNS_IN_PROJECT_EVENT">] MovedColumnsInProjectEvent
    /// Represents a 'pinned' event on a given issue or pull request.
    | [<CompiledName "PINNED_EVENT">] PinnedEvent
    /// Represents a 'referenced' event on a given `ReferencedSubject`.
    | [<CompiledName "REFERENCED_EVENT">] ReferencedEvent
    /// Represents a 'removed_from_project' event on a given issue or pull request.
    | [<CompiledName "REMOVED_FROM_PROJECT_EVENT">] RemovedFromProjectEvent
    /// Represents a 'renamed' event on a given issue or pull request
    | [<CompiledName "RENAMED_TITLE_EVENT">] RenamedTitleEvent
    /// Represents a 'reopened' event on any `Closable`.
    | [<CompiledName "REOPENED_EVENT">] ReopenedEvent
    /// Represents a 'subscribed' event on a given `Subscribable`.
    | [<CompiledName "SUBSCRIBED_EVENT">] SubscribedEvent
    /// Represents a 'transferred' event on a given issue or pull request.
    | [<CompiledName "TRANSFERRED_EVENT">] TransferredEvent
    /// Represents an 'unassigned' event on any assignable object.
    | [<CompiledName "UNASSIGNED_EVENT">] UnassignedEvent
    /// Represents an 'unlabeled' event on a given issue or pull request.
    | [<CompiledName "UNLABELED_EVENT">] UnlabeledEvent
    /// Represents an 'unlocked' event on a given issue or pull request.
    | [<CompiledName "UNLOCKED_EVENT">] UnlockedEvent
    /// Represents a 'user_blocked' event on a given user.
    | [<CompiledName "USER_BLOCKED_EVENT">] UserBlockedEvent
    /// Represents an 'unmarked_as_duplicate' event on a given issue or pull request.
    | [<CompiledName "UNMARKED_AS_DUPLICATE_EVENT">] UnmarkedAsDuplicateEvent
    /// Represents an 'unpinned' event on a given issue or pull request.
    | [<CompiledName "UNPINNED_EVENT">] UnpinnedEvent
    /// Represents an 'unsubscribed' event on a given `Subscribable`.
    | [<CompiledName "UNSUBSCRIBED_EVENT">] UnsubscribedEvent

///Properties by which label connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type LabelOrderField =
    /// Order labels by name
    | [<CompiledName "NAME">] Name
    /// Order labels by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

///Properties by which language connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type LanguageOrderField = /// Order languages by the size of all files containing the language
    | [<CompiledName "SIZE">] Size

///The possible reasons that an issue or pull request was locked.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type LockReason =
    /// The issue or pull request was locked because the conversation was off-topic.
    | [<CompiledName "OFF_TOPIC">] OffTopic
    /// The issue or pull request was locked because the conversation was too heated.
    | [<CompiledName "TOO_HEATED">] TooHeated
    /// The issue or pull request was locked because the conversation was resolved.
    | [<CompiledName "RESOLVED">] Resolved
    /// The issue or pull request was locked because the conversation was spam.
    | [<CompiledName "SPAM">] Spam

///Whether or not a PullRequest can be merged.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeableState =
    /// The pull request can be merged.
    | [<CompiledName "MERGEABLE">] Mergeable
    /// The pull request cannot be merged due to merge conflicts.
    | [<CompiledName "CONFLICTING">] Conflicting
    /// The mergeability of the pull request is still being calculated.
    | [<CompiledName "UNKNOWN">] Unknown

///Properties by which milestone connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MilestoneOrderField =
    /// Order milestones by when they are due.
    | [<CompiledName "DUE_DATE">] DueDate
    /// Order milestones by when they were created.
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order milestones by when they were last updated.
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order milestones by their number.
    | [<CompiledName "NUMBER">] Number

///The possible states of a milestone.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MilestoneState =
    /// A milestone that is still open.
    | [<CompiledName "OPEN">] Open
    /// A milestone that has been closed.
    | [<CompiledName "CLOSED">] Closed

///The possible values for the notification restriction setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type NotificationRestrictionSettingValue =
    /// The setting is enabled for the owner.
    | [<CompiledName "ENABLED">] Enabled
    /// The setting is disabled for the owner.
    | [<CompiledName "DISABLED">] Disabled

///The state of an OAuth Application when it was created.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OauthApplicationCreateAuditEntryState =
    /// The OAuth Application was active and allowed to have OAuth Accesses.
    | [<CompiledName "ACTIVE">] Active
    /// The OAuth Application was suspended from generating OAuth Accesses due to abuse or security concerns.
    | [<CompiledName "SUSPENDED">] Suspended
    /// The OAuth Application was in the process of being deleted.
    | [<CompiledName "PENDING_DELETION">] PendingDeletion

///The corresponding operation type for the action
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OperationType =
    /// An existing resource was accessed
    | [<CompiledName "ACCESS">] Access
    /// A resource performed an authentication event
    | [<CompiledName "AUTHENTICATION">] Authentication
    /// A new resource was created
    | [<CompiledName "CREATE">] Create
    /// An existing resource was modified
    | [<CompiledName "MODIFY">] Modify
    /// An existing resource was removed
    | [<CompiledName "REMOVE">] Remove
    /// An existing resource was restored
    | [<CompiledName "RESTORE">] Restore
    /// An existing resource was transferred between multiple resources
    | [<CompiledName "TRANSFER">] Transfer

///Possible directions in which to order a list of items when provided an `orderBy` argument.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrderDirection =
    /// Specifies an ascending order for a given `orderBy` argument.
    | [<CompiledName "ASC">] Asc
    /// Specifies a descending order for a given `orderBy` argument.
    | [<CompiledName "DESC">] Desc

///The permissions available to members on an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgAddMemberAuditEntryPermission =
    /// Can read and clone repositories.
    | [<CompiledName "READ">] Read
    /// Can read, clone, push, and add collaborators to repositories.
    | [<CompiledName "ADMIN">] Admin

///The billing plans available for organizations.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgCreateAuditEntryBillingPlan =
    /// Free Plan
    | [<CompiledName "FREE">] Free
    /// Team Plan
    | [<CompiledName "BUSINESS">] Business
    /// Enterprise Cloud Plan
    | [<CompiledName "BUSINESS_PLUS">] BusinessPlus
    /// Legacy Unlimited Plan
    | [<CompiledName "UNLIMITED">] Unlimited
    /// Tiered Per Seat Plan
    | [<CompiledName "TIERED_PER_SEAT">] TieredPerSeat

///The reason a billing manager was removed from an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgRemoveBillingManagerAuditEntryReason =
    /// The organization required 2FA of its billing managers and this user did not have 2FA enabled.
    | [<CompiledName "TWO_FACTOR_REQUIREMENT_NON_COMPLIANCE">] TwoFactorRequirementNonCompliance
    /// SAML external identity missing
    | [<CompiledName "SAML_EXTERNAL_IDENTITY_MISSING">] SamlExternalIdentityMissing
    /// SAML SSO enforcement requires an external identity
    | [<CompiledName "SAML_SSO_ENFORCEMENT_REQUIRES_EXTERNAL_IDENTITY">] SamlSsoEnforcementRequiresExternalIdentity

///The type of membership a user has with an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgRemoveMemberAuditEntryMembershipType =
    /// A direct member is a user that is a member of the Organization.
    | [<CompiledName "DIRECT_MEMBER">] DirectMember
    /// Organization administrators have full access and can change several settings, including the names of repositories that belong to the Organization and Owners team membership. In addition, organization admins can delete the organization and all of its repositories.
    | [<CompiledName "ADMIN">] Admin
    /// A billing manager is a user who manages the billing settings for the Organization, such as updating payment information.
    | [<CompiledName "BILLING_MANAGER">] BillingManager
    /// An unaffiliated collaborator is a person who is not a member of the Organization and does not have access to any repositories in the Organization.
    | [<CompiledName "UNAFFILIATED">] Unaffiliated
    /// An outside collaborator is a person who isn't explicitly a member of the Organization, but who has Read, Write, or Admin permissions to one or more repositories in the organization.
    | [<CompiledName "OUTSIDE_COLLABORATOR">] OutsideCollaborator

///The reason a member was removed from an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgRemoveMemberAuditEntryReason =
    /// The organization required 2FA of its billing managers and this user did not have 2FA enabled.
    | [<CompiledName "TWO_FACTOR_REQUIREMENT_NON_COMPLIANCE">] TwoFactorRequirementNonCompliance
    /// SAML external identity missing
    | [<CompiledName "SAML_EXTERNAL_IDENTITY_MISSING">] SamlExternalIdentityMissing
    /// SAML SSO enforcement requires an external identity
    | [<CompiledName "SAML_SSO_ENFORCEMENT_REQUIRES_EXTERNAL_IDENTITY">] SamlSsoEnforcementRequiresExternalIdentity
    /// User account has been deleted
    | [<CompiledName "USER_ACCOUNT_DELETED">] UserAccountDeleted
    /// User was removed from organization during account recovery
    | [<CompiledName "TWO_FACTOR_ACCOUNT_RECOVERY">] TwoFactorAccountRecovery

///The type of membership a user has with an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgRemoveOutsideCollaboratorAuditEntryMembershipType =
    /// An outside collaborator is a person who isn't explicitly a member of the Organization, but who has Read, Write, or Admin permissions to one or more repositories in the organization.
    | [<CompiledName "OUTSIDE_COLLABORATOR">] OutsideCollaborator
    /// An unaffiliated collaborator is a person who is not a member of the Organization and does not have access to any repositories in the organization.
    | [<CompiledName "UNAFFILIATED">] Unaffiliated
    /// A billing manager is a user who manages the billing settings for the Organization, such as updating payment information.
    | [<CompiledName "BILLING_MANAGER">] BillingManager

///The reason an outside collaborator was removed from an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgRemoveOutsideCollaboratorAuditEntryReason =
    /// The organization required 2FA of its billing managers and this user did not have 2FA enabled.
    | [<CompiledName "TWO_FACTOR_REQUIREMENT_NON_COMPLIANCE">] TwoFactorRequirementNonCompliance
    /// SAML external identity missing
    | [<CompiledName "SAML_EXTERNAL_IDENTITY_MISSING">] SamlExternalIdentityMissing

///The default permission a repository can have in an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgUpdateDefaultRepositoryPermissionAuditEntryPermission =
    /// Can read and clone repositories.
    | [<CompiledName "READ">] Read
    /// Can read, clone and push to repositories.
    | [<CompiledName "WRITE">] Write
    /// Can read, clone, push, and add collaborators to repositories.
    | [<CompiledName "ADMIN">] Admin
    /// No default permission value.
    | [<CompiledName "NONE">] None

///The permissions available to members on an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgUpdateMemberAuditEntryPermission =
    /// Can read and clone repositories.
    | [<CompiledName "READ">] Read
    /// Can read, clone, push, and add collaborators to repositories.
    | [<CompiledName "ADMIN">] Admin

///The permissions available for repository creation on an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgUpdateMemberRepositoryCreationPermissionAuditEntryVisibility =
    /// All organization members are restricted from creating any repositories.
    | [<CompiledName "ALL">] All
    /// All organization members are restricted from creating public repositories.
    | [<CompiledName "PUBLIC">] Public
    /// All organization members are allowed to create any repositories.
    | [<CompiledName "NONE">] None
    /// All organization members are restricted from creating private repositories.
    | [<CompiledName "PRIVATE">] Private
    /// All organization members are restricted from creating internal repositories.
    | [<CompiledName "INTERNAL">] Internal
    /// All organization members are restricted from creating public or internal repositories.
    | [<CompiledName "PUBLIC_INTERNAL">] PublicInternal
    /// All organization members are restricted from creating private or internal repositories.
    | [<CompiledName "PRIVATE_INTERNAL">] PrivateInternal
    /// All organization members are restricted from creating public or private repositories.
    | [<CompiledName "PUBLIC_PRIVATE">] PublicPrivate

///The possible organization invitation roles.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationInvitationRole =
    /// The user is invited to be a direct member of the organization.
    | [<CompiledName "DIRECT_MEMBER">] DirectMember
    /// The user is invited to be an admin of the organization.
    | [<CompiledName "ADMIN">] Admin
    /// The user is invited to be a billing manager of the organization.
    | [<CompiledName "BILLING_MANAGER">] BillingManager
    /// The user's previous role will be reinstated.
    | [<CompiledName "REINSTATE">] Reinstate

///The possible organization invitation types.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationInvitationType =
    /// The invitation was to an existing user.
    | [<CompiledName "USER">] User
    /// The invitation was to an email address.
    | [<CompiledName "EMAIL">] Email

///The possible roles within an organization for its members.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationMemberRole =
    /// The user is a member of the organization.
    | [<CompiledName "MEMBER">] Member
    /// The user is an administrator of the organization.
    | [<CompiledName "ADMIN">] Admin

///The possible values for the members can create repositories setting on an organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationMembersCanCreateRepositoriesSettingValue =
    /// Members will be able to create public and private repositories.
    | [<CompiledName "ALL">] All
    /// Members will be able to create only private repositories.
    | [<CompiledName "PRIVATE">] Private
    /// Members will not be able to create public or private repositories.
    | [<CompiledName "DISABLED">] Disabled

///Properties by which organization connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationOrderField =
    /// Order organizations by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order organizations by login
    | [<CompiledName "LOGIN">] Login

///Properties by which package file connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageFileOrderField = /// Order package files by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

///Properties by which package connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageOrderField = /// Order packages by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

///The possible types of a package.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageType =
    /// An npm package.
    | [<CompiledName "NPM">] Npm
    /// A rubygems package.
    | [<CompiledName "RUBYGEMS">] Rubygems
    /// A maven package.
    | [<CompiledName "MAVEN">] Maven
    /// A docker image.
    | [<CompiledName "DOCKER">] Docker
    /// A debian package.
    | [<CompiledName "DEBIAN">] Debian
    /// A nuget package.
    | [<CompiledName "NUGET">] Nuget
    /// A python package.
    | [<CompiledName "PYPI">] Pypi

///Properties by which package version connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageVersionOrderField = /// Order package versions by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

///Represents items that can be pinned to a profile page or dashboard.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PinnableItemType =
    /// A repository.
    | [<CompiledName "REPOSITORY">] Repository
    /// A gist.
    | [<CompiledName "GIST">] Gist
    /// An issue.
    | [<CompiledName "ISSUE">] Issue
    /// A project.
    | [<CompiledName "PROJECT">] Project
    /// A pull request.
    | [<CompiledName "PULL_REQUEST">] PullRequest
    /// A user.
    | [<CompiledName "USER">] User
    /// An organization.
    | [<CompiledName "ORGANIZATION">] Organization
    /// A team.
    | [<CompiledName "TEAM">] Team

///The possible archived states of a project card.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectCardArchivedState =
    /// A project card that is archived
    | [<CompiledName "ARCHIVED">] Archived
    /// A project card that is not archived
    | [<CompiledName "NOT_ARCHIVED">] NotArchived

///Various content states of a ProjectCard
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectCardState =
    /// The card has content only.
    | [<CompiledName "CONTENT_ONLY">] ContentOnly
    /// The card has a note only.
    | [<CompiledName "NOTE_ONLY">] NoteOnly
    /// The card is redacted.
    | [<CompiledName "REDACTED">] Redacted

///The semantic purpose of the column - todo, in progress, or done.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectColumnPurpose =
    /// The column contains cards still to be worked on
    | [<CompiledName "TODO">] Todo
    /// The column contains cards which are currently being worked on
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The column contains cards which are complete
    | [<CompiledName "DONE">] Done

///Properties by which project connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectOrderField =
    /// Order projects by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order projects by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order projects by name
    | [<CompiledName "NAME">] Name

///State of the project; either 'open' or 'closed'
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectState =
    /// The project is open.
    | [<CompiledName "OPEN">] Open
    /// The project is closed.
    | [<CompiledName "CLOSED">] Closed

///GitHub-provided templates for Projects
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectTemplate =
    /// Create a board with columns for To do, In progress and Done.
    | [<CompiledName "BASIC_KANBAN">] BasicKanban
    /// Create a board with v2 triggers to automatically move cards across To do, In progress and Done columns.
    | [<CompiledName "AUTOMATED_KANBAN_V2">] AutomatedKanbanV2
    /// Create a board with triggers to automatically move cards across columns with review automation.
    | [<CompiledName "AUTOMATED_REVIEWS_KANBAN">] AutomatedReviewsKanban
    /// Create a board to triage and prioritize bugs with To do, priority, and Done columns.
    | [<CompiledName "BUG_TRIAGE">] BugTriage

///Represents available types of methods to use when merging a pull request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestMergeMethod =
    /// Add all commits from the head branch to the base branch with a merge commit.
    | [<CompiledName "MERGE">] Merge
    /// Combine all commits from the head branch into a single commit in the base branch.
    | [<CompiledName "SQUASH">] Squash
    /// Add all commits from the head branch onto the base branch individually.
    | [<CompiledName "REBASE">] Rebase

///Properties by which pull_requests connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestOrderField =
    /// Order pull_requests by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order pull_requests by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt

///The possible states of a pull request review comment.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestReviewCommentState =
    /// A comment that is part of a pending review
    | [<CompiledName "PENDING">] Pending
    /// A comment that is part of a submitted review
    | [<CompiledName "SUBMITTED">] Submitted

///The review status of a pull request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestReviewDecision =
    /// Changes have been requested on the pull request.
    | [<CompiledName "CHANGES_REQUESTED">] ChangesRequested
    /// The pull request has received an approving review.
    | [<CompiledName "APPROVED">] Approved
    /// A review is required before the pull request can be merged.
    | [<CompiledName "REVIEW_REQUIRED">] ReviewRequired

///The possible events to perform on a pull request review.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestReviewEvent =
    /// Submit general feedback without explicit approval.
    | [<CompiledName "COMMENT">] Comment
    /// Submit feedback and approve merging these changes.
    | [<CompiledName "APPROVE">] Approve
    /// Submit feedback that must be addressed before merging.
    | [<CompiledName "REQUEST_CHANGES">] RequestChanges
    /// Dismiss review so it now longer effects merging.
    | [<CompiledName "DISMISS">] Dismiss

///The possible states of a pull request review.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestReviewState =
    /// A review that has not yet been submitted.
    | [<CompiledName "PENDING">] Pending
    /// An informational review.
    | [<CompiledName "COMMENTED">] Commented
    /// A review allowing the pull request to merge.
    | [<CompiledName "APPROVED">] Approved
    /// A review blocking the pull request from merging.
    | [<CompiledName "CHANGES_REQUESTED">] ChangesRequested
    /// A review that has been dismissed.
    | [<CompiledName "DISMISSED">] Dismissed

///The possible states of a pull request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestState =
    /// A pull request that is still open.
    | [<CompiledName "OPEN">] Open
    /// A pull request that has been closed without being merged.
    | [<CompiledName "CLOSED">] Closed
    /// A pull request that has been closed by being merged.
    | [<CompiledName "MERGED">] Merged

///The possible item types found in a timeline.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestTimelineItemsItemType =
    /// Represents a Git commit part of a pull request.
    | [<CompiledName "PULL_REQUEST_COMMIT">] PullRequestCommit
    /// Represents a commit comment thread part of a pull request.
    | [<CompiledName "PULL_REQUEST_COMMIT_COMMENT_THREAD">] PullRequestCommitCommentThread
    /// A review object for a given pull request.
    | [<CompiledName "PULL_REQUEST_REVIEW">] PullRequestReview
    /// A threaded list of comments for a given pull request.
    | [<CompiledName "PULL_REQUEST_REVIEW_THREAD">] PullRequestReviewThread
    /// Represents the latest point in the pull request timeline for which the viewer has seen the pull request's commits.
    | [<CompiledName "PULL_REQUEST_REVISION_MARKER">] PullRequestRevisionMarker
    /// Represents a 'automatic_base_change_failed' event on a given pull request.
    | [<CompiledName "AUTOMATIC_BASE_CHANGE_FAILED_EVENT">] AutomaticBaseChangeFailedEvent
    /// Represents a 'automatic_base_change_succeeded' event on a given pull request.
    | [<CompiledName "AUTOMATIC_BASE_CHANGE_SUCCEEDED_EVENT">] AutomaticBaseChangeSucceededEvent
    /// Represents a 'auto_merge_disabled' event on a given pull request.
    | [<CompiledName "AUTO_MERGE_DISABLED_EVENT">] AutoMergeDisabledEvent
    /// Represents a 'auto_merge_enabled' event on a given pull request.
    | [<CompiledName "AUTO_MERGE_ENABLED_EVENT">] AutoMergeEnabledEvent
    /// Represents a 'auto_rebase_enabled' event on a given pull request.
    | [<CompiledName "AUTO_REBASE_ENABLED_EVENT">] AutoRebaseEnabledEvent
    /// Represents a 'auto_squash_enabled' event on a given pull request.
    | [<CompiledName "AUTO_SQUASH_ENABLED_EVENT">] AutoSquashEnabledEvent
    /// Represents a 'base_ref_changed' event on a given issue or pull request.
    | [<CompiledName "BASE_REF_CHANGED_EVENT">] BaseRefChangedEvent
    /// Represents a 'base_ref_force_pushed' event on a given pull request.
    | [<CompiledName "BASE_REF_FORCE_PUSHED_EVENT">] BaseRefForcePushedEvent
    /// Represents a 'base_ref_deleted' event on a given pull request.
    | [<CompiledName "BASE_REF_DELETED_EVENT">] BaseRefDeletedEvent
    /// Represents a 'deployed' event on a given pull request.
    | [<CompiledName "DEPLOYED_EVENT">] DeployedEvent
    /// Represents a 'deployment_environment_changed' event on a given pull request.
    | [<CompiledName "DEPLOYMENT_ENVIRONMENT_CHANGED_EVENT">] DeploymentEnvironmentChangedEvent
    /// Represents a 'head_ref_deleted' event on a given pull request.
    | [<CompiledName "HEAD_REF_DELETED_EVENT">] HeadRefDeletedEvent
    /// Represents a 'head_ref_force_pushed' event on a given pull request.
    | [<CompiledName "HEAD_REF_FORCE_PUSHED_EVENT">] HeadRefForcePushedEvent
    /// Represents a 'head_ref_restored' event on a given pull request.
    | [<CompiledName "HEAD_REF_RESTORED_EVENT">] HeadRefRestoredEvent
    /// Represents a 'merged' event on a given pull request.
    | [<CompiledName "MERGED_EVENT">] MergedEvent
    /// Represents a 'review_dismissed' event on a given issue or pull request.
    | [<CompiledName "REVIEW_DISMISSED_EVENT">] ReviewDismissedEvent
    /// Represents an 'review_requested' event on a given pull request.
    | [<CompiledName "REVIEW_REQUESTED_EVENT">] ReviewRequestedEvent
    /// Represents an 'review_request_removed' event on a given pull request.
    | [<CompiledName "REVIEW_REQUEST_REMOVED_EVENT">] ReviewRequestRemovedEvent
    /// Represents a 'ready_for_review' event on a given pull request.
    | [<CompiledName "READY_FOR_REVIEW_EVENT">] ReadyForReviewEvent
    /// Represents a 'convert_to_draft' event on a given pull request.
    | [<CompiledName "CONVERT_TO_DRAFT_EVENT">] ConvertToDraftEvent
    /// Represents a comment on an Issue.
    | [<CompiledName "ISSUE_COMMENT">] IssueComment
    /// Represents a mention made by one issue or pull request to another.
    | [<CompiledName "CROSS_REFERENCED_EVENT">] CrossReferencedEvent
    /// Represents a 'added_to_project' event on a given issue or pull request.
    | [<CompiledName "ADDED_TO_PROJECT_EVENT">] AddedToProjectEvent
    /// Represents an 'assigned' event on any assignable object.
    | [<CompiledName "ASSIGNED_EVENT">] AssignedEvent
    /// Represents a 'closed' event on any `Closable`.
    | [<CompiledName "CLOSED_EVENT">] ClosedEvent
    /// Represents a 'comment_deleted' event on a given issue or pull request.
    | [<CompiledName "COMMENT_DELETED_EVENT">] CommentDeletedEvent
    /// Represents a 'connected' event on a given issue or pull request.
    | [<CompiledName "CONNECTED_EVENT">] ConnectedEvent
    /// Represents a 'converted_note_to_issue' event on a given issue or pull request.
    | [<CompiledName "CONVERTED_NOTE_TO_ISSUE_EVENT">] ConvertedNoteToIssueEvent
    /// Represents a 'demilestoned' event on a given issue or pull request.
    | [<CompiledName "DEMILESTONED_EVENT">] DemilestonedEvent
    /// Represents a 'disconnected' event on a given issue or pull request.
    | [<CompiledName "DISCONNECTED_EVENT">] DisconnectedEvent
    /// Represents a 'labeled' event on a given issue or pull request.
    | [<CompiledName "LABELED_EVENT">] LabeledEvent
    /// Represents a 'locked' event on a given issue or pull request.
    | [<CompiledName "LOCKED_EVENT">] LockedEvent
    /// Represents a 'marked_as_duplicate' event on a given issue or pull request.
    | [<CompiledName "MARKED_AS_DUPLICATE_EVENT">] MarkedAsDuplicateEvent
    /// Represents a 'mentioned' event on a given issue or pull request.
    | [<CompiledName "MENTIONED_EVENT">] MentionedEvent
    /// Represents a 'milestoned' event on a given issue or pull request.
    | [<CompiledName "MILESTONED_EVENT">] MilestonedEvent
    /// Represents a 'moved_columns_in_project' event on a given issue or pull request.
    | [<CompiledName "MOVED_COLUMNS_IN_PROJECT_EVENT">] MovedColumnsInProjectEvent
    /// Represents a 'pinned' event on a given issue or pull request.
    | [<CompiledName "PINNED_EVENT">] PinnedEvent
    /// Represents a 'referenced' event on a given `ReferencedSubject`.
    | [<CompiledName "REFERENCED_EVENT">] ReferencedEvent
    /// Represents a 'removed_from_project' event on a given issue or pull request.
    | [<CompiledName "REMOVED_FROM_PROJECT_EVENT">] RemovedFromProjectEvent
    /// Represents a 'renamed' event on a given issue or pull request
    | [<CompiledName "RENAMED_TITLE_EVENT">] RenamedTitleEvent
    /// Represents a 'reopened' event on any `Closable`.
    | [<CompiledName "REOPENED_EVENT">] ReopenedEvent
    /// Represents a 'subscribed' event on a given `Subscribable`.
    | [<CompiledName "SUBSCRIBED_EVENT">] SubscribedEvent
    /// Represents a 'transferred' event on a given issue or pull request.
    | [<CompiledName "TRANSFERRED_EVENT">] TransferredEvent
    /// Represents an 'unassigned' event on any assignable object.
    | [<CompiledName "UNASSIGNED_EVENT">] UnassignedEvent
    /// Represents an 'unlabeled' event on a given issue or pull request.
    | [<CompiledName "UNLABELED_EVENT">] UnlabeledEvent
    /// Represents an 'unlocked' event on a given issue or pull request.
    | [<CompiledName "UNLOCKED_EVENT">] UnlockedEvent
    /// Represents a 'user_blocked' event on a given user.
    | [<CompiledName "USER_BLOCKED_EVENT">] UserBlockedEvent
    /// Represents an 'unmarked_as_duplicate' event on a given issue or pull request.
    | [<CompiledName "UNMARKED_AS_DUPLICATE_EVENT">] UnmarkedAsDuplicateEvent
    /// Represents an 'unpinned' event on a given issue or pull request.
    | [<CompiledName "UNPINNED_EVENT">] UnpinnedEvent
    /// Represents an 'unsubscribed' event on a given `Subscribable`.
    | [<CompiledName "UNSUBSCRIBED_EVENT">] UnsubscribedEvent

///The possible target states when updating a pull request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestUpdateState =
    /// A pull request that is still open.
    | [<CompiledName "OPEN">] Open
    /// A pull request that has been closed without being merged.
    | [<CompiledName "CLOSED">] Closed

///Emojis that can be attached to Issues, Pull Requests and Comments.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReactionContent =
    /// Represents the `:+1:` emoji.
    | [<CompiledName "THUMBS_UP">] ThumbsUp
    /// Represents the `:-1:` emoji.
    | [<CompiledName "THUMBS_DOWN">] ThumbsDown
    /// Represents the `:laugh:` emoji.
    | [<CompiledName "LAUGH">] Laugh
    /// Represents the `:hooray:` emoji.
    | [<CompiledName "HOORAY">] Hooray
    /// Represents the `:confused:` emoji.
    | [<CompiledName "CONFUSED">] Confused
    /// Represents the `:heart:` emoji.
    | [<CompiledName "HEART">] Heart
    /// Represents the `:rocket:` emoji.
    | [<CompiledName "ROCKET">] Rocket
    /// Represents the `:eyes:` emoji.
    | [<CompiledName "EYES">] Eyes

///A list of fields that reactions can be ordered by.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReactionOrderField = /// Allows ordering a list of reactions by when they were created.
    | [<CompiledName "CREATED_AT">] CreatedAt

///Properties by which ref connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RefOrderField =
    /// Order refs by underlying commit date if the ref prefix is refs/tags/
    | [<CompiledName "TAG_COMMIT_DATE">] TagCommitDate
    /// Order refs by their alphanumeric name
    | [<CompiledName "ALPHABETICAL">] Alphabetical

///Properties by which release connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReleaseOrderField =
    /// Order releases by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order releases alphabetically by name
    | [<CompiledName "NAME">] Name

///The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoAccessAuditEntryVisibility =
    /// The repository is visible only to users in the same business.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

///The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoAddMemberAuditEntryVisibility =
    /// The repository is visible only to users in the same business.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

///The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoArchivedAuditEntryVisibility =
    /// The repository is visible only to users in the same business.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

///The merge options available for pull requests to this repository.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoChangeMergeSettingAuditEntryMergeType =
    /// The pull request is added to the base branch in a merge commit.
    | [<CompiledName "MERGE">] Merge
    /// Commits from the pull request are added onto the base branch individually without a merge commit.
    | [<CompiledName "REBASE">] Rebase
    /// The pull request's commits are squashed into a single commit before they are merged to the base branch.
    | [<CompiledName "SQUASH">] Squash

///The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoCreateAuditEntryVisibility =
    /// The repository is visible only to users in the same business.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

///The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoDestroyAuditEntryVisibility =
    /// The repository is visible only to users in the same business.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

///The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoRemoveMemberAuditEntryVisibility =
    /// The repository is visible only to users in the same business.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

///The reasons a piece of content can be reported or minimized.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReportedContentClassifiers =
    /// A spammy piece of content
    | [<CompiledName "SPAM">] Spam
    /// An abusive or harassing piece of content
    | [<CompiledName "ABUSE">] Abuse
    /// An irrelevant piece of content
    | [<CompiledName "OFF_TOPIC">] OffTopic
    /// An outdated piece of content
    | [<CompiledName "OUTDATED">] Outdated
    /// A duplicated piece of content
    | [<CompiledName "DUPLICATE">] Duplicate
    /// The content has been resolved
    | [<CompiledName "RESOLVED">] Resolved

///The affiliation of a user to a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryAffiliation =
    /// Repositories that are owned by the authenticated user.
    | [<CompiledName "OWNER">] Owner
    /// Repositories that the user has been added to as a collaborator.
    | [<CompiledName "COLLABORATOR">] Collaborator
    /// Repositories that the user has access to through being a member of an organization. This includes every repository on every team that the user is on.
    | [<CompiledName "ORGANIZATION_MEMBER">] OrganizationMember

///The reason a repository is listed as 'contributed'.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryContributionType =
    /// Created a commit
    | [<CompiledName "COMMIT">] Commit
    /// Created an issue
    | [<CompiledName "ISSUE">] Issue
    /// Created a pull request
    | [<CompiledName "PULL_REQUEST">] PullRequest
    /// Created the repository
    | [<CompiledName "REPOSITORY">] Repository
    /// Reviewed a pull request
    | [<CompiledName "PULL_REQUEST_REVIEW">] PullRequestReview

///A repository interaction limit.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryInteractionLimit =
    /// Users that have recently created their account will be unable to interact with the repository.
    | [<CompiledName "EXISTING_USERS">] ExistingUsers
    /// Users that have not previously committed to a repository’s default branch will be unable to interact with the repository.
    | [<CompiledName "CONTRIBUTORS_ONLY">] ContributorsOnly
    /// Users that are not collaborators will not be able to interact with the repository.
    | [<CompiledName "COLLABORATORS_ONLY">] CollaboratorsOnly
    /// No interaction limits are enabled.
    | [<CompiledName "NO_LIMIT">] NoLimit

///The length for a repository interaction limit to be enabled for.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryInteractionLimitExpiry =
    /// The interaction limit will expire after 1 day.
    | [<CompiledName "ONE_DAY">] OneDay
    /// The interaction limit will expire after 3 days.
    | [<CompiledName "THREE_DAYS">] ThreeDays
    /// The interaction limit will expire after 1 week.
    | [<CompiledName "ONE_WEEK">] OneWeek
    /// The interaction limit will expire after 1 month.
    | [<CompiledName "ONE_MONTH">] OneMonth
    /// The interaction limit will expire after 6 months.
    | [<CompiledName "SIX_MONTHS">] SixMonths

///Indicates where an interaction limit is configured.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryInteractionLimitOrigin =
    /// A limit that is configured at the repository level.
    | [<CompiledName "REPOSITORY">] Repository
    /// A limit that is configured at the organization level.
    | [<CompiledName "ORGANIZATION">] Organization
    /// A limit that is configured at the user-wide level.
    | [<CompiledName "USER">] User

///Properties by which repository invitation connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryInvitationOrderField = /// Order repository invitations by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

///The possible reasons a given repository could be in a locked state.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryLockReason =
    /// The repository is locked due to a move.
    | [<CompiledName "MOVING">] Moving
    /// The repository is locked due to a billing related reason.
    | [<CompiledName "BILLING">] Billing
    /// The repository is locked due to a rename.
    | [<CompiledName "RENAME">] Rename
    /// The repository is locked due to a migration.
    | [<CompiledName "MIGRATING">] Migrating

///Properties by which repository connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryOrderField =
    /// Order repositories by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order repositories by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order repositories by push time
    | [<CompiledName "PUSHED_AT">] PushedAt
    /// Order repositories by name
    | [<CompiledName "NAME">] Name
    /// Order repositories by number of stargazers
    | [<CompiledName "STARGAZERS">] Stargazers

///The access level to a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryPermission =
    /// Can read, clone, and push to this repository. Can also manage issues, pull requests, and repository settings, including adding collaborators
    | [<CompiledName "ADMIN">] Admin
    /// Can read, clone, and push to this repository. They can also manage issues, pull requests, and some repository settings
    | [<CompiledName "MAINTAIN">] Maintain
    /// Can read, clone, and push to this repository. Can also manage issues and pull requests
    | [<CompiledName "WRITE">] Write
    /// Can read and clone this repository. Can also manage issues and pull requests
    | [<CompiledName "TRIAGE">] Triage
    /// Can read and clone this repository. Can also open and comment on issues and pull requests
    | [<CompiledName "READ">] Read

///The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryPrivacy =
    /// Public
    | [<CompiledName "PUBLIC">] Public
    /// Private
    | [<CompiledName "PRIVATE">] Private

///The repository's visibility level.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryVisibility =
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public
    /// The repository is visible only to users in the same business.
    | [<CompiledName "INTERNAL">] Internal

///The possible states that can be requested when creating a check run.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RequestableCheckStatusState =
    /// The check suite or run has been queued.
    | [<CompiledName "QUEUED">] Queued
    /// The check suite or run is in progress.
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The check suite or run has been completed.
    | [<CompiledName "COMPLETED">] Completed
    /// The check suite or run is in waiting state.
    | [<CompiledName "WAITING">] Waiting

///The possible digest algorithms used to sign SAML requests for an identity provider.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SamlDigestAlgorithm =
    /// SHA1
    | [<CompiledName "SHA1">] Sha1
    /// SHA256
    | [<CompiledName "SHA256">] Sha256
    /// SHA384
    | [<CompiledName "SHA384">] Sha384
    /// SHA512
    | [<CompiledName "SHA512">] Sha512

///The possible signature algorithms used to sign SAML requests for a Identity Provider.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SamlSignatureAlgorithm =
    /// RSA-SHA1
    | [<CompiledName "RSA_SHA1">] RsaSha1
    /// RSA-SHA256
    | [<CompiledName "RSA_SHA256">] RsaSha256
    /// RSA-SHA384
    | [<CompiledName "RSA_SHA384">] RsaSha384
    /// RSA-SHA512
    | [<CompiledName "RSA_SHA512">] RsaSha512

///Properties by which saved reply connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SavedReplyOrderField = /// Order saved reply by when they were updated.
    | [<CompiledName "UPDATED_AT">] UpdatedAt

///Represents the individual results of a search.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SearchType =
    /// Returns results matching issues in repositories.
    | [<CompiledName "ISSUE">] Issue
    /// Returns results matching repositories.
    | [<CompiledName "REPOSITORY">] Repository
    /// Returns results matching users and organizations on GitHub.
    | [<CompiledName "USER">] User

///The possible ecosystems of a security vulnerability's package.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityAdvisoryEcosystem =
    /// Ruby gems hosted at RubyGems.org
    | [<CompiledName "RUBYGEMS">] Rubygems
    /// JavaScript packages hosted at npmjs.com
    | [<CompiledName "NPM">] Npm
    /// Python packages hosted at PyPI.org
    | [<CompiledName "PIP">] Pip
    /// Java artifacts hosted at the Maven central repository
    | [<CompiledName "MAVEN">] Maven
    /// .NET packages hosted at the NuGet Gallery
    | [<CompiledName "NUGET">] Nuget
    /// PHP packages hosted at packagist.org
    | [<CompiledName "COMPOSER">] Composer

///Identifier formats available for advisories.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityAdvisoryIdentifierType =
    /// Common Vulnerabilities and Exposures Identifier.
    | [<CompiledName "CVE">] Cve
    /// GitHub Security Advisory ID.
    | [<CompiledName "GHSA">] Ghsa

///Properties by which security advisory connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityAdvisoryOrderField =
    /// Order advisories by publication time
    | [<CompiledName "PUBLISHED_AT">] PublishedAt
    /// Order advisories by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt

///Severity of the vulnerability.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityAdvisorySeverity =
    /// Low.
    | [<CompiledName "LOW">] Low
    /// Moderate.
    | [<CompiledName "MODERATE">] Moderate
    /// High.
    | [<CompiledName "HIGH">] High
    /// Critical.
    | [<CompiledName "CRITICAL">] Critical

///Properties by which security vulnerability connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityVulnerabilityOrderField = /// Order vulnerability by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt

///Properties by which sponsorable connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorableOrderField = /// Order sponsorable entities by login (username).
    | [<CompiledName "LOGIN">] Login

///The different kinds of goals a GitHub Sponsors member can have.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorsGoalKind =
    /// The goal is about reaching a certain number of sponsors.
    | [<CompiledName "TOTAL_SPONSORS_COUNT">] TotalSponsorsCount
    /// The goal is about getting a certain dollar amount from sponsorships each month.
    | [<CompiledName "MONTHLY_SPONSORSHIP_AMOUNT">] MonthlySponsorshipAmount

///Properties by which Sponsors tiers connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorsTierOrderField =
    /// Order tiers by creation time.
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order tiers by their monthly price in cents
    | [<CompiledName "MONTHLY_PRICE_IN_CENTS">] MonthlyPriceInCents

///Properties by which sponsorship connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorshipOrderField = /// Order sponsorship by creation time.
    | [<CompiledName "CREATED_AT">] CreatedAt

///The privacy of a sponsorship
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorshipPrivacy =
    /// Public
    | [<CompiledName "PUBLIC">] Public
    /// Private
    | [<CompiledName "PRIVATE">] Private

///Properties by which star connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type StarOrderField = /// Allows ordering a list of stars by when they were created.
    | [<CompiledName "STARRED_AT">] StarredAt

///The possible commit status states.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type StatusState =
    /// Status is expected.
    | [<CompiledName "EXPECTED">] Expected
    /// Status is errored.
    | [<CompiledName "ERROR">] Error
    /// Status is failing.
    | [<CompiledName "FAILURE">] Failure
    /// Status is pending.
    | [<CompiledName "PENDING">] Pending
    /// Status is successful.
    | [<CompiledName "SUCCESS">] Success

///The possible states of a subscription.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SubscriptionState =
    /// The User is only notified when participating or @mentioned.
    | [<CompiledName "UNSUBSCRIBED">] Unsubscribed
    /// The User is notified of all conversations.
    | [<CompiledName "SUBSCRIBED">] Subscribed
    /// The User is never notified.
    | [<CompiledName "IGNORED">] Ignored

///Properties by which team discussion comment connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamDiscussionCommentOrderField = /// Allows sequential ordering of team discussion comments (which is equivalent to chronological ordering).
    | [<CompiledName "NUMBER">] Number

///Properties by which team discussion connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamDiscussionOrderField = /// Allows chronological ordering of team discussions.
    | [<CompiledName "CREATED_AT">] CreatedAt

///Properties by which team member connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamMemberOrderField =
    /// Order team members by login
    | [<CompiledName "LOGIN">] Login
    /// Order team members by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

///The possible team member roles; either 'maintainer' or 'member'.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamMemberRole =
    /// A team maintainer has permission to add and remove team members.
    | [<CompiledName "MAINTAINER">] Maintainer
    /// A team member has no administrative permissions on the team.
    | [<CompiledName "MEMBER">] Member

///Defines which types of team members are included in the returned list. Can be one of IMMEDIATE, CHILD_TEAM or ALL.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamMembershipType =
    /// Includes only immediate members of the team.
    | [<CompiledName "IMMEDIATE">] Immediate
    /// Includes only child team members for the team.
    | [<CompiledName "CHILD_TEAM">] ChildTeam
    /// Includes immediate and child team members for the team.
    | [<CompiledName "ALL">] All

///Properties by which team connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamOrderField = /// Allows ordering a list of teams by name.
    | [<CompiledName "NAME">] Name

///The possible team privacy values.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamPrivacy =
    /// A secret team can only be seen by its members.
    | [<CompiledName "SECRET">] Secret
    /// A visible team can be seen and @mentioned by every member of the organization.
    | [<CompiledName "VISIBLE">] Visible

///Properties by which team repository connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamRepositoryOrderField =
    /// Order repositories by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order repositories by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order repositories by push time
    | [<CompiledName "PUSHED_AT">] PushedAt
    /// Order repositories by name
    | [<CompiledName "NAME">] Name
    /// Order repositories by permission
    | [<CompiledName "PERMISSION">] Permission
    /// Order repositories by number of stargazers
    | [<CompiledName "STARGAZERS">] Stargazers

///The role of a user on a team.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamRole =
    /// User has admin rights on the team.
    | [<CompiledName "ADMIN">] Admin
    /// User is a member of the team.
    | [<CompiledName "MEMBER">] Member

///Reason that the suggested topic is declined.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TopicSuggestionDeclineReason =
    /// The suggested topic is not relevant to the repository.
    | [<CompiledName "NOT_RELEVANT">] NotRelevant
    /// The suggested topic is too specific for the repository (e.g. #ruby-on-rails-version-4-2-1).
    | [<CompiledName "TOO_SPECIFIC">] TooSpecific
    /// The viewer does not like the suggested topic.
    | [<CompiledName "PERSONAL_PREFERENCE">] PersonalPreference
    /// The suggested topic is too general for the repository.
    | [<CompiledName "TOO_GENERAL">] TooGeneral

///The possible durations that a user can be blocked for.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type UserBlockDuration =
    /// The user was blocked for 1 day
    | [<CompiledName "ONE_DAY">] OneDay
    /// The user was blocked for 3 days
    | [<CompiledName "THREE_DAYS">] ThreeDays
    /// The user was blocked for 7 days
    | [<CompiledName "ONE_WEEK">] OneWeek
    /// The user was blocked for 30 days
    | [<CompiledName "ONE_MONTH">] OneMonth
    /// The user was blocked permanently
    | [<CompiledName "PERMANENT">] Permanent

///Properties by which user status connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type UserStatusOrderField = /// Order user statuses by when they were updated.
    | [<CompiledName "UPDATED_AT">] UpdatedAt

///Properties by which verifiable domain connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VerifiableDomainOrderField = /// Order verifiable domains by the domain name.
    | [<CompiledName "DOMAIN">] Domain

/// Autogenerated input type of AcceptEnterpriseAdministratorInvitation
type AcceptEnterpriseAdministratorInvitationInput =
    { /// The id of the invitation being accepted
      invitationId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AcceptTopicSuggestion
type AcceptTopicSuggestionInput =
    { /// The Node ID of the repository.
      repositoryId: string
      /// The name of the suggested topic.
      name: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddAssigneesToAssignable
type AddAssigneesToAssignableInput =
    { /// The id of the assignable object to add assignees to.
      assignableId: string
      /// The id of users to add as assignees.
      assigneeIds: list<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddComment
type AddCommentInput =
    { /// The Node ID of the subject to modify.
      subjectId: string
      /// The contents of the comment.
      body: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddEnterpriseSupportEntitlement
type AddEnterpriseSupportEntitlementInput =
    { /// The ID of the Enterprise which the admin belongs to.
      enterpriseId: string
      /// The login of a member who will receive the support entitlement.
      login: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddLabelsToLabelable
type AddLabelsToLabelableInput =
    { /// The id of the labelable object to add labels to.
      labelableId: string
      /// The ids of the labels to add.
      labelIds: list<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddProjectCard
type AddProjectCardInput =
    { /// The Node ID of the ProjectColumn.
      projectColumnId: string
      /// The content of the card. Must be a member of the ProjectCardItem union
      contentId: Option<string>
      /// The note on the card.
      note: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddProjectColumn
type AddProjectColumnInput =
    { /// The Node ID of the project.
      projectId: string
      /// The name of the column.
      name: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddPullRequestReviewComment
type AddPullRequestReviewCommentInput =
    { /// The node ID of the pull request reviewing
      pullRequestId: Option<string>
      /// The Node ID of the review to modify.
      pullRequestReviewId: Option<string>
      /// The SHA of the commit to comment on.
      commitOID: Option<string>
      /// The text of the comment.
      body: string
      /// The relative path of the file to comment on.
      path: Option<string>
      /// The line index in the diff to comment on.
      position: Option<int>
      /// The comment id to reply to.
      inReplyTo: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddPullRequestReview
type AddPullRequestReviewInput =
    { /// The Node ID of the pull request to modify.
      pullRequestId: string
      /// The commit OID the review pertains to.
      commitOID: Option<string>
      /// The contents of the review body comment.
      body: Option<string>
      /// The event to perform on the pull request review.
      event: Option<PullRequestReviewEvent>
      /// The review line comments.
      comments: Option<list<Option<DraftPullRequestReviewComment>>>
      /// The review line comment threads.
      threads: Option<list<Option<DraftPullRequestReviewThread>>>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddPullRequestReviewThread
type AddPullRequestReviewThreadInput =
    { /// Path to the file being commented on.
      path: string
      /// Body of the thread's first comment.
      body: string
      /// The node ID of the pull request reviewing
      pullRequestId: Option<string>
      /// The Node ID of the review to modify.
      pullRequestReviewId: Option<string>
      /// The line of the blob to which the thread refers. The end of the line range for multi-line comments.
      line: int
      /// The side of the diff on which the line resides. For multi-line comments, this is the side for the end of the line range.
      side: Option<DiffSide>
      /// The first line of the range to which the comment refers.
      startLine: Option<int>
      /// The side of the diff on which the start line resides.
      startSide: Option<DiffSide>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddReaction
type AddReactionInput =
    { /// The Node ID of the subject to modify.
      subjectId: string
      /// The name of the emoji to react with.
      content: ReactionContent
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddStar
type AddStarInput =
    { /// The Starrable ID to star.
      starrableId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of AddVerifiableDomain
type AddVerifiableDomainInput =
    { /// The ID of the owner to add the domain to
      ownerId: string
      /// The URL of the domain
      domain: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of ApproveVerifiableDomain
type ApproveVerifiableDomainInput =
    { /// The ID of the verifiable domain to approve.
      id: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of ArchiveRepository
type ArchiveRepositoryInput =
    { /// The ID of the repository to mark as archived.
      repositoryId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ordering options for Audit Log connections.
type AuditLogOrder =
    { /// The field to order Audit Logs by.
      field: Option<AuditLogOrderField>
      /// The ordering direction.
      direction: Option<OrderDirection> }

/// Autogenerated input type of CancelEnterpriseAdminInvitation
type CancelEnterpriseAdminInvitationInput =
    { /// The Node ID of the pending enterprise administrator invitation.
      invitationId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of ChangeUserStatus
type ChangeUserStatusInput =
    { /// The emoji to represent your status. Can either be a native Unicode emoji or an emoji name with colons, e.g., :grinning:.
      emoji: Option<string>
      /// A short description of your current status.
      message: Option<string>
      /// The ID of the organization whose members will be allowed to see the status. If omitted, the status will be publicly visible.
      organizationId: Option<string>
      /// Whether this status should indicate you are not fully available on GitHub, e.g., you are away.
      limitedAvailability: Option<bool>
      /// If set, the user status will not be shown after this date.
      expiresAt: Option<System.DateTime>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Information from a check run analysis to specific lines of code.
type CheckAnnotationData =
    { /// The path of the file to add an annotation to.
      path: string
      /// The location of the annotation
      location: CheckAnnotationRange
      /// Represents an annotation's information level
      annotationLevel: CheckAnnotationLevel
      /// A short description of the feedback for these lines of code.
      message: string
      /// The title that represents the annotation.
      title: Option<string>
      /// Details about this annotation.
      rawDetails: Option<string> }

/// Information from a check run analysis to specific lines of code.
type CheckAnnotationRange =
    { /// The starting line of the range.
      startLine: int
      /// The starting column of the range.
      startColumn: Option<int>
      /// The ending line of the range.
      endLine: int
      /// The ending column of the range.
      endColumn: Option<int> }

/// Possible further actions the integrator can perform.
type CheckRunAction =
    { /// The text to be displayed on a button in the web UI.
      label: string
      /// A short explanation of what this action would do.
      description: string
      /// A reference for the action on the integrator's system.
      identifier: string }

/// The filters that are available when fetching check runs.
type CheckRunFilter =
    { /// Filters the check runs by this type.
      checkType: Option<CheckRunType>
      /// Filters the check runs created by this application ID.
      appId: Option<int>
      /// Filters the check runs by this name.
      checkName: Option<string>
      /// Filters the check runs by this status.
      status: Option<CheckStatusState> }

/// Descriptive details about the check run.
type CheckRunOutput =
    { /// A title to provide for this check run.
      title: string
      /// The summary of the check run (supports Commonmark).
      summary: string
      /// The details of the check run (supports Commonmark).
      text: Option<string>
      /// The annotations that are made as part of the check run.
      annotations: Option<list<CheckAnnotationData>>
      /// Images attached to the check run output displayed in the GitHub pull request UI.
      images: Option<list<CheckRunOutputImage>> }

/// Images attached to the check run output displayed in the GitHub pull request UI.
type CheckRunOutputImage =
    { /// The alternative text for the image.
      alt: string
      /// The full URL of the image.
      imageUrl: string
      /// A short image description.
      caption: Option<string> }

/// The auto-trigger preferences that are available for check suites.
type CheckSuiteAutoTriggerPreference =
    { /// The node ID of the application that owns the check suite.
      appId: string
      /// Set to `true` to enable automatic creation of CheckSuite events upon pushes to the repository.
      setting: bool }

/// The filters that are available when fetching check suites.
type CheckSuiteFilter =
    { /// Filters the check suites created by this application ID.
      appId: Option<int>
      /// Filters the check suites by this name.
      checkName: Option<string> }

/// Autogenerated input type of ClearLabelsFromLabelable
type ClearLabelsFromLabelableInput =
    { /// The id of the labelable object to clear the labels from.
      labelableId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CloneProject
type CloneProjectInput =
    { /// The owner ID to create the project under.
      targetOwnerId: string
      /// The source project to clone.
      sourceId: string
      /// Whether or not to clone the source project's workflows.
      includeWorkflows: bool
      /// The name of the project.
      name: string
      /// The description of the project.
      body: Option<string>
      /// The visibility of the project, defaults to false (private).
      ``public``: Option<bool>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CloneTemplateRepository
type CloneTemplateRepositoryInput =
    { /// The Node ID of the template repository.
      repositoryId: string
      /// The name of the new repository.
      name: string
      /// The ID of the owner for the new repository.
      ownerId: string
      /// A short description of the new repository.
      description: Option<string>
      /// Indicates the repository's visibility level.
      visibility: RepositoryVisibility
      /// Whether to copy all branches from the template to the new repository. Defaults to copying only the default branch of the template.
      includeAllBranches: Option<bool>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CloseIssue
type CloseIssueInput =
    { /// ID of the issue to be closed.
      issueId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of ClosePullRequest
type ClosePullRequestInput =
    { /// ID of the pull request to be closed.
      pullRequestId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Specifies an author for filtering Git commits.
type CommitAuthor =
    { /// ID of a User to filter by. If non-null, only commits authored by this user will be returned. This field takes precedence over emails.
      id: Option<string>
      /// Email addresses to filter by. Commits authored by any of the specified email addresses will be returned.
      emails: Option<list<string>> }

/// Ordering options for commit contribution connections.
type CommitContributionOrder =
    { /// The field by which to order commit contributions.
      field: CommitContributionOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ordering options for contribution connections.
type ContributionOrder =
    { /// The ordering direction.
      direction: OrderDirection }

/// Autogenerated input type of ConvertProjectCardNoteToIssue
type ConvertProjectCardNoteToIssueInput =
    { /// The ProjectCard ID to convert.
      projectCardId: string
      /// The ID of the repository to create the issue in.
      repositoryId: string
      /// The title of the newly created issue. Defaults to the card's note text.
      title: Option<string>
      /// The body of the newly created issue.
      body: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreateBranchProtectionRule
type CreateBranchProtectionRuleInput =
    { /// The global relay id of the repository in which a new branch protection rule should be created in.
      repositoryId: string
      /// The glob-like pattern used to determine matching branches.
      pattern: string
      /// Are approving reviews required to update matching branches.
      requiresApprovingReviews: Option<bool>
      /// Number of approving reviews required to update matching branches.
      requiredApprovingReviewCount: Option<int>
      /// Are commits required to be signed.
      requiresCommitSignatures: Option<bool>
      /// Are merge commits prohibited from being pushed to this branch.
      requiresLinearHistory: Option<bool>
      /// Are force pushes allowed on this branch.
      allowsForcePushes: Option<bool>
      /// Can this branch be deleted.
      allowsDeletions: Option<bool>
      /// Can admins overwrite branch protection.
      isAdminEnforced: Option<bool>
      /// Are status checks required to update matching branches.
      requiresStatusChecks: Option<bool>
      /// Are branches required to be up to date before merging.
      requiresStrictStatusChecks: Option<bool>
      /// Are reviews from code owners required to update matching branches.
      requiresCodeOwnerReviews: Option<bool>
      /// Will new commits pushed to matching branches dismiss pull request review approvals.
      dismissesStaleReviews: Option<bool>
      /// Is dismissal of pull request reviews restricted.
      restrictsReviewDismissals: Option<bool>
      /// A list of User or Team IDs allowed to dismiss reviews on pull requests targeting matching branches.
      reviewDismissalActorIds: Option<list<string>>
      /// Is pushing to matching branches restricted.
      restrictsPushes: Option<bool>
      /// A list of User, Team or App IDs allowed to push to matching branches.
      pushActorIds: Option<list<string>>
      /// List of required status check contexts that must pass for commits to be accepted to matching branches.
      requiredStatusCheckContexts: Option<list<string>>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreateCheckRun
type CreateCheckRunInput =
    { /// The node ID of the repository.
      repositoryId: string
      /// The name of the check.
      name: string
      /// The SHA of the head commit.
      headSha: string
      /// The URL of the integrator's site that has the full details of the check.
      detailsUrl: Option<string>
      /// A reference for the run on the integrator's system.
      externalId: Option<string>
      /// The current status.
      status: Option<RequestableCheckStatusState>
      /// The time that the check run began.
      startedAt: Option<System.DateTime>
      /// The final conclusion of the check.
      conclusion: Option<CheckConclusionState>
      /// The time that the check run finished.
      completedAt: Option<System.DateTime>
      /// Descriptive details about the run.
      output: Option<CheckRunOutput>
      /// Possible further actions the integrator can perform, which a user may trigger.
      actions: Option<list<CheckRunAction>>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreateCheckSuite
type CreateCheckSuiteInput =
    { /// The Node ID of the repository.
      repositoryId: string
      /// The SHA of the head commit.
      headSha: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreateEnterpriseOrganization
type CreateEnterpriseOrganizationInput =
    { /// The ID of the enterprise owning the new organization.
      enterpriseId: string
      /// The login of the new organization.
      login: string
      /// The profile name of the new organization.
      profileName: string
      /// The email used for sending billing receipts.
      billingEmail: string
      /// The logins for the administrators of the new organization.
      adminLogins: list<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreateIpAllowListEntry
type CreateIpAllowListEntryInput =
    { /// The ID of the owner for which to create the new IP allow list entry.
      ownerId: string
      /// An IP address or range of addresses in CIDR notation.
      allowListValue: string
      /// An optional name for the IP allow list entry.
      name: Option<string>
      /// Whether the IP allow list entry is active when an IP allow list is enabled.
      isActive: bool
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreateIssue
type CreateIssueInput =
    { /// The Node ID of the repository.
      repositoryId: string
      /// The title for the issue.
      title: string
      /// The body for the issue description.
      body: Option<string>
      /// The Node ID for the user assignee for this issue.
      assigneeIds: Option<list<string>>
      /// The Node ID of the milestone for this issue.
      milestoneId: Option<string>
      /// An array of Node IDs of labels for this issue.
      labelIds: Option<list<string>>
      /// An array of Node IDs for projects associated with this issue.
      projectIds: Option<list<string>>
      /// The name of an issue template in the repository, assigns labels and assignees from the template to the issue
      issueTemplate: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreateProject
type CreateProjectInput =
    { /// The owner ID to create the project under.
      ownerId: string
      /// The name of project.
      name: string
      /// The description of project.
      body: Option<string>
      /// The name of the GitHub-provided template.
      template: Option<ProjectTemplate>
      /// A list of repository IDs to create as linked repositories for the project
      repositoryIds: Option<list<string>>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreatePullRequest
type CreatePullRequestInput =
    { /// The Node ID of the repository.
      repositoryId: string
      /// The name of the branch you want your changes pulled into. This should be an existing branchon the current repository. You cannot update the base branch on a pull request to pointto another repository.
      baseRefName: string
      /// The name of the branch where your changes are implemented. For cross-repository pull requestsin the same network, namespace `head_ref_name` with a user like this: `username:branch`.
      headRefName: string
      /// The title of the pull request.
      title: string
      /// The contents of the pull request.
      body: Option<string>
      /// Indicates whether maintainers can modify the pull request.
      maintainerCanModify: Option<bool>
      /// Indicates whether this pull request should be a draft.
      draft: Option<bool>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreateRef
type CreateRefInput =
    { /// The Node ID of the Repository to create the Ref in.
      repositoryId: string
      /// The fully qualified name of the new Ref (ie: `refs/heads/my_new_branch`).
      name: string
      /// The GitObjectID that the new Ref shall target. Must point to a commit.
      oid: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreateRepository
type CreateRepositoryInput =
    { /// The name of the new repository.
      name: string
      /// The ID of the owner for the new repository.
      ownerId: Option<string>
      /// A short description of the new repository.
      description: Option<string>
      /// Indicates the repository's visibility level.
      visibility: RepositoryVisibility
      /// Whether this repository should be marked as a template such that anyone who can access it can create new repositories with the same files and directory structure.
      template: Option<bool>
      /// The URL for a web page about this repository.
      homepageUrl: Option<string>
      /// Indicates if the repository should have the wiki feature enabled.
      hasWikiEnabled: Option<bool>
      /// Indicates if the repository should have the issues feature enabled.
      hasIssuesEnabled: Option<bool>
      /// When an organization is specified as the owner, this ID identifies the team that should be granted access to the new repository.
      teamId: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreateTeamDiscussionComment
type CreateTeamDiscussionCommentInput =
    { /// The ID of the discussion to which the comment belongs.
      discussionId: string
      /// The content of the comment.
      body: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of CreateTeamDiscussion
type CreateTeamDiscussionInput =
    { /// The ID of the team to which the discussion belongs.
      teamId: string
      /// The title of the discussion.
      title: string
      /// The content of the discussion.
      body: string
      /// If true, restricts the visibility of this discussion to team members and organization admins. If false or not specified, allows any organization member to view this discussion.
      ``private``: Option<bool>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeclineTopicSuggestion
type DeclineTopicSuggestionInput =
    { /// The Node ID of the repository.
      repositoryId: string
      /// The name of the suggested topic.
      name: string
      /// The reason why the suggested topic is declined.
      reason: TopicSuggestionDeclineReason
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteBranchProtectionRule
type DeleteBranchProtectionRuleInput =
    { /// The global relay id of the branch protection rule to be deleted.
      branchProtectionRuleId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteDeployment
type DeleteDeploymentInput =
    { /// The Node ID of the deployment to be deleted.
      id: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteIpAllowListEntry
type DeleteIpAllowListEntryInput =
    { /// The ID of the IP allow list entry to delete.
      ipAllowListEntryId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteIssueComment
type DeleteIssueCommentInput =
    { /// The ID of the comment to delete.
      id: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteIssue
type DeleteIssueInput =
    { /// The ID of the issue to delete.
      issueId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteProjectCard
type DeleteProjectCardInput =
    { /// The id of the card to delete.
      cardId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteProjectColumn
type DeleteProjectColumnInput =
    { /// The id of the column to delete.
      columnId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteProject
type DeleteProjectInput =
    { /// The Project ID to update.
      projectId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeletePullRequestReviewComment
type DeletePullRequestReviewCommentInput =
    { /// The ID of the comment to delete.
      id: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeletePullRequestReview
type DeletePullRequestReviewInput =
    { /// The Node ID of the pull request review to delete.
      pullRequestReviewId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteRef
type DeleteRefInput =
    { /// The Node ID of the Ref to be deleted.
      refId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteTeamDiscussionComment
type DeleteTeamDiscussionCommentInput =
    { /// The ID of the comment to delete.
      id: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteTeamDiscussion
type DeleteTeamDiscussionInput =
    { /// The discussion ID to delete.
      id: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DeleteVerifiableDomain
type DeleteVerifiableDomainInput =
    { /// The ID of the verifiable domain to delete.
      id: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ordering options for deployment connections
type DeploymentOrder =
    { /// The field to order deployments by.
      field: DeploymentOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Autogenerated input type of DisablePullRequestAutoMerge
type DisablePullRequestAutoMergeInput =
    { /// ID of the pull request to disable auto merge on.
      pullRequestId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of DismissPullRequestReview
type DismissPullRequestReviewInput =
    { /// The Node ID of the pull request review to modify.
      pullRequestReviewId: string
      /// The contents of the pull request review dismissal message.
      message: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Specifies a review comment to be left with a Pull Request Review.
type DraftPullRequestReviewComment =
    { /// Path to the file being commented on.
      path: string
      /// Position in the file to leave a comment on.
      position: int
      /// Body of the comment to leave.
      body: string }

/// Specifies a review comment thread to be left with a Pull Request Review.
type DraftPullRequestReviewThread =
    { /// Path to the file being commented on.
      path: string
      /// The line of the blob to which the thread refers. The end of the line range for multi-line comments.
      line: int
      /// The side of the diff on which the line resides. For multi-line comments, this is the side for the end of the line range.
      side: Option<DiffSide>
      /// The first line of the range to which the comment refers.
      startLine: Option<int>
      /// The side of the diff on which the start line resides.
      startSide: Option<DiffSide>
      /// Body of the comment to leave.
      body: string }

/// Autogenerated input type of EnablePullRequestAutoMerge
type EnablePullRequestAutoMergeInput =
    { /// ID of the pull request to enable auto-merge on.
      pullRequestId: string
      /// Commit headline to use for the commit when the PR is mergable; if omitted, a default message will be used.
      commitHeadline: Option<string>
      /// Commit body to use for the commit when the PR is mergable; if omitted, a default message will be used.
      commitBody: Option<string>
      /// The merge method to use. If omitted, defaults to 'MERGE'
      mergeMethod: Option<PullRequestMergeMethod>
      /// The email address to associate with this merge.
      authorEmail: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ordering options for enterprise administrator invitation connections
type EnterpriseAdministratorInvitationOrder =
    { /// The field to order enterprise administrator invitations by.
      field: EnterpriseAdministratorInvitationOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ordering options for enterprise member connections.
type EnterpriseMemberOrder =
    { /// The field to order enterprise members by.
      field: EnterpriseMemberOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ordering options for Enterprise Server installation connections.
type EnterpriseServerInstallationOrder =
    { /// The field to order Enterprise Server installations by.
      field: EnterpriseServerInstallationOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ordering options for Enterprise Server user account email connections.
type EnterpriseServerUserAccountEmailOrder =
    { /// The field to order emails by.
      field: EnterpriseServerUserAccountEmailOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ordering options for Enterprise Server user account connections.
type EnterpriseServerUserAccountOrder =
    { /// The field to order user accounts by.
      field: EnterpriseServerUserAccountOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ordering options for Enterprise Server user accounts upload connections.
type EnterpriseServerUserAccountsUploadOrder =
    { /// The field to order user accounts uploads by.
      field: EnterpriseServerUserAccountsUploadOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Autogenerated input type of FollowUser
type FollowUserInput =
    { /// ID of the user to follow.
      userId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ordering options for gist connections
type GistOrder =
    { /// The field to order repositories by.
      field: GistOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Autogenerated input type of InviteEnterpriseAdmin
type InviteEnterpriseAdminInput =
    { /// The ID of the enterprise to which you want to invite an administrator.
      enterpriseId: string
      /// The login of a user to invite as an administrator.
      invitee: Option<string>
      /// The email of the person to invite as an administrator.
      email: Option<string>
      /// The role of the administrator.
      role: Option<EnterpriseAdministratorRole>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ordering options for IP allow list entry connections.
type IpAllowListEntryOrder =
    { /// The field to order IP allow list entries by.
      field: IpAllowListEntryOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ways in which lists of issue comments can be ordered upon return.
type IssueCommentOrder =
    { /// The field in which to order issue comments by.
      field: IssueCommentOrderField
      /// The direction in which to order issue comments by the specified field.
      direction: OrderDirection }

/// Ways in which to filter lists of issues.
type IssueFilters =
    { /// List issues assigned to given name. Pass in `null` for issues with no assigned user, and `*` for issues assigned to any user.
      assignee: Option<string>
      /// List issues created by given name.
      createdBy: Option<string>
      /// List issues where the list of label names exist on the issue.
      labels: Option<list<string>>
      /// List issues where the given name is mentioned in the issue.
      mentioned: Option<string>
      /// List issues by given milestone argument. If an string representation of an integer is passed, it should refer to a milestone by its number field. Pass in `null` for issues with no milestone, and `*` for issues that are assigned to any milestone.
      milestone: Option<string>
      /// List issues that have been updated at or after the given date.
      since: Option<System.DateTime>
      /// List issues filtered by the list of states given.
      states: Option<list<IssueState>>
      /// List issues subscribed to by viewer.
      viewerSubscribed: Option<bool> }

/// Ways in which lists of issues can be ordered upon return.
type IssueOrder =
    { /// The field in which to order issues by.
      field: IssueOrderField
      /// The direction in which to order issues by the specified field.
      direction: OrderDirection }

/// Ways in which lists of labels can be ordered upon return.
type LabelOrder =
    { /// The field in which to order labels by.
      field: LabelOrderField
      /// The direction in which to order labels by the specified field.
      direction: OrderDirection }

/// Ordering options for language connections.
type LanguageOrder =
    { /// The field to order languages by.
      field: LanguageOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Autogenerated input type of LinkRepositoryToProject
type LinkRepositoryToProjectInput =
    { /// The ID of the Project to link to a Repository
      projectId: string
      /// The ID of the Repository to link to a Project.
      repositoryId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of LockLockable
type LockLockableInput =
    { /// ID of the item to be locked.
      lockableId: string
      /// A reason for why the item will be locked.
      lockReason: Option<LockReason>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of MarkFileAsViewed
type MarkFileAsViewedInput =
    { /// The Node ID of the pull request.
      pullRequestId: string
      /// The path of the file to mark as viewed
      path: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of MarkPullRequestReadyForReview
type MarkPullRequestReadyForReviewInput =
    { /// ID of the pull request to be marked as ready for review.
      pullRequestId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of MergeBranch
type MergeBranchInput =
    { /// The Node ID of the Repository containing the base branch that will be modified.
      repositoryId: string
      /// The name of the base branch that the provided head will be merged into.
      ``base``: string
      /// The head to merge into the base branch. This can be a branch name or a commit GitObjectID.
      head: string
      /// Message to use for the merge commit. If omitted, a default will be used.
      commitMessage: Option<string>
      /// The email address to associate with this commit.
      authorEmail: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of MergePullRequest
type MergePullRequestInput =
    { /// ID of the pull request to be merged.
      pullRequestId: string
      /// Commit headline to use for the merge commit; if omitted, a default message will be used.
      commitHeadline: Option<string>
      /// Commit body to use for the merge commit; if omitted, a default message will be used
      commitBody: Option<string>
      /// OID that the pull request head ref must match to allow merge; if omitted, no check is performed.
      expectedHeadOid: Option<string>
      /// The merge method to use. If omitted, defaults to 'MERGE'
      mergeMethod: Option<PullRequestMergeMethod>
      /// The email address to associate with this merge.
      authorEmail: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ordering options for milestone connections.
type MilestoneOrder =
    { /// The field to order milestones by.
      field: MilestoneOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Autogenerated input type of MinimizeComment
type MinimizeCommentInput =
    { /// The Node ID of the subject to modify.
      subjectId: string
      /// The classification of comment
      classifier: ReportedContentClassifiers
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of MoveProjectCard
type MoveProjectCardInput =
    { /// The id of the card to move.
      cardId: string
      /// The id of the column to move it into.
      columnId: string
      /// Place the new card after the card with this id. Pass null to place it at the top.
      afterCardId: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of MoveProjectColumn
type MoveProjectColumnInput =
    { /// The id of the column to move.
      columnId: string
      /// Place the new column after the column with this id. Pass null to place it at the front.
      afterColumnId: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ordering options for organization connections.
type OrganizationOrder =
    { /// The field to order organizations by.
      field: OrganizationOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ways in which lists of package files can be ordered upon return.
type PackageFileOrder =
    { /// The field in which to order package files by.
      field: Option<PackageFileOrderField>
      /// The direction in which to order package files by the specified field.
      direction: Option<OrderDirection> }

/// Ways in which lists of packages can be ordered upon return.
type PackageOrder =
    { /// The field in which to order packages by.
      field: Option<PackageOrderField>
      /// The direction in which to order packages by the specified field.
      direction: Option<OrderDirection> }

/// Ways in which lists of package versions can be ordered upon return.
type PackageVersionOrder =
    { /// The field in which to order package versions by.
      field: Option<PackageVersionOrderField>
      /// The direction in which to order package versions by the specified field.
      direction: Option<OrderDirection> }

/// Ways in which lists of projects can be ordered upon return.
type ProjectOrder =
    { /// The field in which to order projects by.
      field: ProjectOrderField
      /// The direction in which to order projects by the specified field.
      direction: OrderDirection }

/// Ways in which lists of issues can be ordered upon return.
type PullRequestOrder =
    { /// The field in which to order pull requests by.
      field: PullRequestOrderField
      /// The direction in which to order pull requests by the specified field.
      direction: OrderDirection }

/// Ways in which lists of reactions can be ordered upon return.
type ReactionOrder =
    { /// The field in which to order reactions by.
      field: ReactionOrderField
      /// The direction in which to order reactions by the specified field.
      direction: OrderDirection }

/// Ways in which lists of git refs can be ordered upon return.
type RefOrder =
    { /// The field in which to order refs by.
      field: RefOrderField
      /// The direction in which to order refs by the specified field.
      direction: OrderDirection }

/// Autogenerated input type of RegenerateEnterpriseIdentityProviderRecoveryCodes
type RegenerateEnterpriseIdentityProviderRecoveryCodesInput =
    { /// The ID of the enterprise on which to set an identity provider.
      enterpriseId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of RegenerateVerifiableDomainToken
type RegenerateVerifiableDomainTokenInput =
    { /// The ID of the verifiable domain to regenerate the verification token of.
      id: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ways in which lists of releases can be ordered upon return.
type ReleaseOrder =
    { /// The field in which to order releases by.
      field: ReleaseOrderField
      /// The direction in which to order releases by the specified field.
      direction: OrderDirection }

/// Autogenerated input type of RemoveAssigneesFromAssignable
type RemoveAssigneesFromAssignableInput =
    { /// The id of the assignable object to remove assignees from.
      assignableId: string
      /// The id of users to remove as assignees.
      assigneeIds: list<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of RemoveEnterpriseAdmin
type RemoveEnterpriseAdminInput =
    { /// The Enterprise ID from which to remove the administrator.
      enterpriseId: string
      /// The login of the user to remove as an administrator.
      login: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of RemoveEnterpriseIdentityProvider
type RemoveEnterpriseIdentityProviderInput =
    { /// The ID of the enterprise from which to remove the identity provider.
      enterpriseId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of RemoveEnterpriseOrganization
type RemoveEnterpriseOrganizationInput =
    { /// The ID of the enterprise from which the organization should be removed.
      enterpriseId: string
      /// The ID of the organization to remove from the enterprise.
      organizationId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of RemoveEnterpriseSupportEntitlement
type RemoveEnterpriseSupportEntitlementInput =
    { /// The ID of the Enterprise which the admin belongs to.
      enterpriseId: string
      /// The login of a member who will lose the support entitlement.
      login: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of RemoveLabelsFromLabelable
type RemoveLabelsFromLabelableInput =
    { /// The id of the Labelable to remove labels from.
      labelableId: string
      /// The ids of labels to remove.
      labelIds: list<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of RemoveOutsideCollaborator
type RemoveOutsideCollaboratorInput =
    { /// The ID of the outside collaborator to remove.
      userId: string
      /// The ID of the organization to remove the outside collaborator from.
      organizationId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of RemoveReaction
type RemoveReactionInput =
    { /// The Node ID of the subject to modify.
      subjectId: string
      /// The name of the emoji reaction to remove.
      content: ReactionContent
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of RemoveStar
type RemoveStarInput =
    { /// The Starrable ID to unstar.
      starrableId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of ReopenIssue
type ReopenIssueInput =
    { /// ID of the issue to be opened.
      issueId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of ReopenPullRequest
type ReopenPullRequestInput =
    { /// ID of the pull request to be reopened.
      pullRequestId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ordering options for repository invitation connections.
type RepositoryInvitationOrder =
    { /// The field to order repository invitations by.
      field: RepositoryInvitationOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ordering options for repository connections
type RepositoryOrder =
    { /// The field to order repositories by.
      field: RepositoryOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Autogenerated input type of RequestReviews
type RequestReviewsInput =
    { /// The Node ID of the pull request to modify.
      pullRequestId: string
      /// The Node IDs of the user to request.
      userIds: Option<list<string>>
      /// The Node IDs of the team to request.
      teamIds: Option<list<string>>
      /// Add users to the set rather than replace.
      union: Option<bool>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of RerequestCheckSuite
type RerequestCheckSuiteInput =
    { /// The Node ID of the repository.
      repositoryId: string
      /// The Node ID of the check suite.
      checkSuiteId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of ResolveReviewThread
type ResolveReviewThreadInput =
    { /// The ID of the thread to resolve
      threadId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ordering options for saved reply connections.
type SavedReplyOrder =
    { /// The field to order saved replies by.
      field: SavedReplyOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// An advisory identifier to filter results on.
type SecurityAdvisoryIdentifierFilter =
    { /// The identifier type.
      ``type``: SecurityAdvisoryIdentifierType
      /// The identifier string. Supports exact or partial matching.
      value: string }

/// Ordering options for security advisory connections
type SecurityAdvisoryOrder =
    { /// The field to order security advisories by.
      field: SecurityAdvisoryOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ordering options for security vulnerability connections
type SecurityVulnerabilityOrder =
    { /// The field to order security vulnerabilities by.
      field: SecurityVulnerabilityOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Autogenerated input type of SetEnterpriseIdentityProvider
type SetEnterpriseIdentityProviderInput =
    { /// The ID of the enterprise on which to set an identity provider.
      enterpriseId: string
      /// The URL endpoint for the identity provider's SAML SSO.
      ssoUrl: string
      /// The Issuer Entity ID for the SAML identity provider
      issuer: Option<string>
      /// The x509 certificate used by the identity provider to sign assertions and responses.
      idpCertificate: string
      /// The signature algorithm used to sign SAML requests for the identity provider.
      signatureMethod: SamlSignatureAlgorithm
      /// The digest algorithm used to sign SAML requests for the identity provider.
      digestMethod: SamlDigestAlgorithm
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of SetOrganizationInteractionLimit
type SetOrganizationInteractionLimitInput =
    { /// The ID of the organization to set a limit for.
      organizationId: string
      /// The limit to set.
      limit: RepositoryInteractionLimit
      /// When this limit should expire.
      expiry: Option<RepositoryInteractionLimitExpiry>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of SetRepositoryInteractionLimit
type SetRepositoryInteractionLimitInput =
    { /// The ID of the repository to set a limit for.
      repositoryId: string
      /// The limit to set.
      limit: RepositoryInteractionLimit
      /// When this limit should expire.
      expiry: Option<RepositoryInteractionLimitExpiry>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of SetUserInteractionLimit
type SetUserInteractionLimitInput =
    { /// The ID of the user to set a limit for.
      userId: string
      /// The limit to set.
      limit: RepositoryInteractionLimit
      /// When this limit should expire.
      expiry: Option<RepositoryInteractionLimitExpiry>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ordering options for connections to get sponsorable entities for GitHub Sponsors.
type SponsorableOrder =
    { /// The field to order sponsorable entities by.
      field: SponsorableOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ordering options for Sponsors tiers connections.
type SponsorsTierOrder =
    { /// The field to order tiers by.
      field: SponsorsTierOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ordering options for sponsorship connections.
type SponsorshipOrder =
    { /// The field to order sponsorship by.
      field: SponsorshipOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ways in which star connections can be ordered.
type StarOrder =
    { /// The field in which to order nodes by.
      field: StarOrderField
      /// The direction in which to order nodes.
      direction: OrderDirection }

/// Autogenerated input type of SubmitPullRequestReview
type SubmitPullRequestReviewInput =
    { /// The Pull Request ID to submit any pending reviews.
      pullRequestId: Option<string>
      /// The Pull Request Review ID to submit.
      pullRequestReviewId: Option<string>
      /// The event to send to the Pull Request Review.
      event: PullRequestReviewEvent
      /// The text field to set on the Pull Request Review.
      body: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ways in which team discussion comment connections can be ordered.
type TeamDiscussionCommentOrder =
    { /// The field by which to order nodes.
      field: TeamDiscussionCommentOrderField
      /// The direction in which to order nodes.
      direction: OrderDirection }

/// Ways in which team discussion connections can be ordered.
type TeamDiscussionOrder =
    { /// The field by which to order nodes.
      field: TeamDiscussionOrderField
      /// The direction in which to order nodes.
      direction: OrderDirection }

/// Ordering options for team member connections
type TeamMemberOrder =
    { /// The field to order team members by.
      field: TeamMemberOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ways in which team connections can be ordered.
type TeamOrder =
    { /// The field in which to order nodes by.
      field: TeamOrderField
      /// The direction in which to order nodes.
      direction: OrderDirection }

/// Ordering options for team repository connections
type TeamRepositoryOrder =
    { /// The field to order repositories by.
      field: TeamRepositoryOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Autogenerated input type of TransferIssue
type TransferIssueInput =
    { /// The Node ID of the issue to be transferred
      issueId: string
      /// The Node ID of the repository the issue should be transferred to
      repositoryId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UnarchiveRepository
type UnarchiveRepositoryInput =
    { /// The ID of the repository to unarchive.
      repositoryId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UnfollowUser
type UnfollowUserInput =
    { /// ID of the user to unfollow.
      userId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UnlinkRepositoryFromProject
type UnlinkRepositoryFromProjectInput =
    { /// The ID of the Project linked to the Repository.
      projectId: string
      /// The ID of the Repository linked to the Project.
      repositoryId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UnlockLockable
type UnlockLockableInput =
    { /// ID of the item to be unlocked.
      lockableId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UnmarkFileAsViewed
type UnmarkFileAsViewedInput =
    { /// The Node ID of the pull request.
      pullRequestId: string
      /// The path of the file to mark as unviewed
      path: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UnmarkIssueAsDuplicate
type UnmarkIssueAsDuplicateInput =
    { /// ID of the issue or pull request currently marked as a duplicate.
      duplicateId: string
      /// ID of the issue or pull request currently considered canonical/authoritative/original.
      canonicalId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UnminimizeComment
type UnminimizeCommentInput =
    { /// The Node ID of the subject to modify.
      subjectId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UnresolveReviewThread
type UnresolveReviewThreadInput =
    { /// The ID of the thread to unresolve
      threadId: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateBranchProtectionRule
type UpdateBranchProtectionRuleInput =
    { /// The global relay id of the branch protection rule to be updated.
      branchProtectionRuleId: string
      /// The glob-like pattern used to determine matching branches.
      pattern: Option<string>
      /// Are approving reviews required to update matching branches.
      requiresApprovingReviews: Option<bool>
      /// Number of approving reviews required to update matching branches.
      requiredApprovingReviewCount: Option<int>
      /// Are commits required to be signed.
      requiresCommitSignatures: Option<bool>
      /// Are merge commits prohibited from being pushed to this branch.
      requiresLinearHistory: Option<bool>
      /// Are force pushes allowed on this branch.
      allowsForcePushes: Option<bool>
      /// Can this branch be deleted.
      allowsDeletions: Option<bool>
      /// Can admins overwrite branch protection.
      isAdminEnforced: Option<bool>
      /// Are status checks required to update matching branches.
      requiresStatusChecks: Option<bool>
      /// Are branches required to be up to date before merging.
      requiresStrictStatusChecks: Option<bool>
      /// Are reviews from code owners required to update matching branches.
      requiresCodeOwnerReviews: Option<bool>
      /// Will new commits pushed to matching branches dismiss pull request review approvals.
      dismissesStaleReviews: Option<bool>
      /// Is dismissal of pull request reviews restricted.
      restrictsReviewDismissals: Option<bool>
      /// A list of User or Team IDs allowed to dismiss reviews on pull requests targeting matching branches.
      reviewDismissalActorIds: Option<list<string>>
      /// Is pushing to matching branches restricted.
      restrictsPushes: Option<bool>
      /// A list of User, Team or App IDs allowed to push to matching branches.
      pushActorIds: Option<list<string>>
      /// List of required status check contexts that must pass for commits to be accepted to matching branches.
      requiredStatusCheckContexts: Option<list<string>>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateCheckRun
type UpdateCheckRunInput =
    { /// The node ID of the repository.
      repositoryId: string
      /// The node of the check.
      checkRunId: string
      /// The name of the check.
      name: Option<string>
      /// The URL of the integrator's site that has the full details of the check.
      detailsUrl: Option<string>
      /// A reference for the run on the integrator's system.
      externalId: Option<string>
      /// The current status.
      status: Option<RequestableCheckStatusState>
      /// The time that the check run began.
      startedAt: Option<System.DateTime>
      /// The final conclusion of the check.
      conclusion: Option<CheckConclusionState>
      /// The time that the check run finished.
      completedAt: Option<System.DateTime>
      /// Descriptive details about the run.
      output: Option<CheckRunOutput>
      /// Possible further actions the integrator can perform, which a user may trigger.
      actions: Option<list<CheckRunAction>>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateCheckSuitePreferences
type UpdateCheckSuitePreferencesInput =
    { /// The Node ID of the repository.
      repositoryId: string
      /// The check suite preferences to modify.
      autoTriggerPreferences: list<CheckSuiteAutoTriggerPreference>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseAdministratorRole
type UpdateEnterpriseAdministratorRoleInput =
    { /// The ID of the Enterprise which the admin belongs to.
      enterpriseId: string
      /// The login of a administrator whose role is being changed.
      login: string
      /// The new role for the Enterprise administrator.
      role: EnterpriseAdministratorRole
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseAllowPrivateRepositoryForkingSetting
type UpdateEnterpriseAllowPrivateRepositoryForkingSettingInput =
    { /// The ID of the enterprise on which to set the allow private repository forking setting.
      enterpriseId: string
      /// The value for the allow private repository forking setting on the enterprise.
      settingValue: EnterpriseEnabledDisabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseDefaultRepositoryPermissionSetting
type UpdateEnterpriseDefaultRepositoryPermissionSettingInput =
    { /// The ID of the enterprise on which to set the default repository permission setting.
      enterpriseId: string
      /// The value for the default repository permission setting on the enterprise.
      settingValue: EnterpriseDefaultRepositoryPermissionSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseMembersCanChangeRepositoryVisibilitySetting
type UpdateEnterpriseMembersCanChangeRepositoryVisibilitySettingInput =
    { /// The ID of the enterprise on which to set the members can change repository visibility setting.
      enterpriseId: string
      /// The value for the members can change repository visibility setting on the enterprise.
      settingValue: EnterpriseEnabledDisabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseMembersCanCreateRepositoriesSetting
type UpdateEnterpriseMembersCanCreateRepositoriesSettingInput =
    { /// The ID of the enterprise on which to set the members can create repositories setting.
      enterpriseId: string
      /// Value for the members can create repositories setting on the enterprise. This or the granular public/private/internal allowed fields (but not both) must be provided.
      settingValue: Option<EnterpriseMembersCanCreateRepositoriesSettingValue>
      /// When false, allow member organizations to set their own repository creation member privileges.
      membersCanCreateRepositoriesPolicyEnabled: Option<bool>
      /// Allow members to create public repositories. Defaults to current value.
      membersCanCreatePublicRepositories: Option<bool>
      /// Allow members to create private repositories. Defaults to current value.
      membersCanCreatePrivateRepositories: Option<bool>
      /// Allow members to create internal repositories. Defaults to current value.
      membersCanCreateInternalRepositories: Option<bool>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseMembersCanDeleteIssuesSetting
type UpdateEnterpriseMembersCanDeleteIssuesSettingInput =
    { /// The ID of the enterprise on which to set the members can delete issues setting.
      enterpriseId: string
      /// The value for the members can delete issues setting on the enterprise.
      settingValue: EnterpriseEnabledDisabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseMembersCanDeleteRepositoriesSetting
type UpdateEnterpriseMembersCanDeleteRepositoriesSettingInput =
    { /// The ID of the enterprise on which to set the members can delete repositories setting.
      enterpriseId: string
      /// The value for the members can delete repositories setting on the enterprise.
      settingValue: EnterpriseEnabledDisabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseMembersCanInviteCollaboratorsSetting
type UpdateEnterpriseMembersCanInviteCollaboratorsSettingInput =
    { /// The ID of the enterprise on which to set the members can invite collaborators setting.
      enterpriseId: string
      /// The value for the members can invite collaborators setting on the enterprise.
      settingValue: EnterpriseEnabledDisabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseMembersCanMakePurchasesSetting
type UpdateEnterpriseMembersCanMakePurchasesSettingInput =
    { /// The ID of the enterprise on which to set the members can make purchases setting.
      enterpriseId: string
      /// The value for the members can make purchases setting on the enterprise.
      settingValue: EnterpriseMembersCanMakePurchasesSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseMembersCanUpdateProtectedBranchesSetting
type UpdateEnterpriseMembersCanUpdateProtectedBranchesSettingInput =
    { /// The ID of the enterprise on which to set the members can update protected branches setting.
      enterpriseId: string
      /// The value for the members can update protected branches setting on the enterprise.
      settingValue: EnterpriseEnabledDisabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseMembersCanViewDependencyInsightsSetting
type UpdateEnterpriseMembersCanViewDependencyInsightsSettingInput =
    { /// The ID of the enterprise on which to set the members can view dependency insights setting.
      enterpriseId: string
      /// The value for the members can view dependency insights setting on the enterprise.
      settingValue: EnterpriseEnabledDisabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseOrganizationProjectsSetting
type UpdateEnterpriseOrganizationProjectsSettingInput =
    { /// The ID of the enterprise on which to set the organization projects setting.
      enterpriseId: string
      /// The value for the organization projects setting on the enterprise.
      settingValue: EnterpriseEnabledDisabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseProfile
type UpdateEnterpriseProfileInput =
    { /// The Enterprise ID to update.
      enterpriseId: string
      /// The name of the enterprise.
      name: Option<string>
      /// The description of the enterprise.
      description: Option<string>
      /// The URL of the enterprise's website.
      websiteUrl: Option<string>
      /// The location of the enterprise.
      location: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseRepositoryProjectsSetting
type UpdateEnterpriseRepositoryProjectsSettingInput =
    { /// The ID of the enterprise on which to set the repository projects setting.
      enterpriseId: string
      /// The value for the repository projects setting on the enterprise.
      settingValue: EnterpriseEnabledDisabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseTeamDiscussionsSetting
type UpdateEnterpriseTeamDiscussionsSettingInput =
    { /// The ID of the enterprise on which to set the team discussions setting.
      enterpriseId: string
      /// The value for the team discussions setting on the enterprise.
      settingValue: EnterpriseEnabledDisabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateEnterpriseTwoFactorAuthenticationRequiredSetting
type UpdateEnterpriseTwoFactorAuthenticationRequiredSettingInput =
    { /// The ID of the enterprise on which to set the two factor authentication required setting.
      enterpriseId: string
      /// The value for the two factor authentication required setting on the enterprise.
      settingValue: EnterpriseEnabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateIpAllowListEnabledSetting
type UpdateIpAllowListEnabledSettingInput =
    { /// The ID of the owner on which to set the IP allow list enabled setting.
      ownerId: string
      /// The value for the IP allow list enabled setting.
      settingValue: IpAllowListEnabledSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateIpAllowListEntry
type UpdateIpAllowListEntryInput =
    { /// The ID of the IP allow list entry to update.
      ipAllowListEntryId: string
      /// An IP address or range of addresses in CIDR notation.
      allowListValue: string
      /// An optional name for the IP allow list entry.
      name: Option<string>
      /// Whether the IP allow list entry is active when an IP allow list is enabled.
      isActive: bool
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateIssueComment
type UpdateIssueCommentInput =
    { /// The ID of the IssueComment to modify.
      id: string
      /// The updated text of the comment.
      body: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateIssue
type UpdateIssueInput =
    { /// The ID of the Issue to modify.
      id: string
      /// The title for the issue.
      title: Option<string>
      /// The body for the issue description.
      body: Option<string>
      /// An array of Node IDs of users for this issue.
      assigneeIds: Option<list<string>>
      /// The Node ID of the milestone for this issue.
      milestoneId: Option<string>
      /// An array of Node IDs of labels for this issue.
      labelIds: Option<list<string>>
      /// The desired issue state.
      state: Option<IssueState>
      /// An array of Node IDs for projects associated with this issue.
      projectIds: Option<list<string>>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateNotificationRestrictionSetting
type UpdateNotificationRestrictionSettingInput =
    { /// The ID of the owner on which to set the restrict notifications setting.
      ownerId: string
      /// The value for the restrict notifications setting.
      settingValue: NotificationRestrictionSettingValue
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateProjectCard
type UpdateProjectCardInput =
    { /// The ProjectCard ID to update.
      projectCardId: string
      /// Whether or not the ProjectCard should be archived
      isArchived: Option<bool>
      /// The note of ProjectCard.
      note: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateProjectColumn
type UpdateProjectColumnInput =
    { /// The ProjectColumn ID to update.
      projectColumnId: string
      /// The name of project column.
      name: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateProject
type UpdateProjectInput =
    { /// The Project ID to update.
      projectId: string
      /// The name of project.
      name: Option<string>
      /// The description of project.
      body: Option<string>
      /// Whether the project is open or closed.
      state: Option<ProjectState>
      /// Whether the project is public or not.
      ``public``: Option<bool>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdatePullRequest
type UpdatePullRequestInput =
    { /// The Node ID of the pull request.
      pullRequestId: string
      /// The name of the branch you want your changes pulled into. This should be an existing branchon the current repository.
      baseRefName: Option<string>
      /// The title of the pull request.
      title: Option<string>
      /// The contents of the pull request.
      body: Option<string>
      /// The target state of the pull request.
      state: Option<PullRequestUpdateState>
      /// Indicates whether maintainers can modify the pull request.
      maintainerCanModify: Option<bool>
      /// An array of Node IDs of users for this pull request.
      assigneeIds: Option<list<string>>
      /// The Node ID of the milestone for this pull request.
      milestoneId: Option<string>
      /// An array of Node IDs of labels for this pull request.
      labelIds: Option<list<string>>
      /// An array of Node IDs for projects associated with this pull request.
      projectIds: Option<list<string>>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdatePullRequestReviewComment
type UpdatePullRequestReviewCommentInput =
    { /// The Node ID of the comment to modify.
      pullRequestReviewCommentId: string
      /// The text of the comment.
      body: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdatePullRequestReview
type UpdatePullRequestReviewInput =
    { /// The Node ID of the pull request review to modify.
      pullRequestReviewId: string
      /// The contents of the pull request review body.
      body: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateRef
type UpdateRefInput =
    { /// The Node ID of the Ref to be updated.
      refId: string
      /// The GitObjectID that the Ref shall be updated to target.
      oid: string
      /// Permit updates of branch Refs that are not fast-forwards?
      force: Option<bool>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateRepository
type UpdateRepositoryInput =
    { /// The ID of the repository to update.
      repositoryId: string
      /// The new name of the repository.
      name: Option<string>
      /// A new description for the repository. Pass an empty string to erase the existing description.
      description: Option<string>
      /// Whether this repository should be marked as a template such that anyone who can access it can create new repositories with the same files and directory structure.
      template: Option<bool>
      /// The URL for a web page about this repository. Pass an empty string to erase the existing URL.
      homepageUrl: Option<string>
      /// Indicates if the repository should have the wiki feature enabled.
      hasWikiEnabled: Option<bool>
      /// Indicates if the repository should have the issues feature enabled.
      hasIssuesEnabled: Option<bool>
      /// Indicates if the repository should have the project boards feature enabled.
      hasProjectsEnabled: Option<bool>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateSubscription
type UpdateSubscriptionInput =
    { /// The Node ID of the subscribable object to modify.
      subscribableId: string
      /// The new state of the subscription.
      state: SubscriptionState
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateTeamDiscussionComment
type UpdateTeamDiscussionCommentInput =
    { /// The ID of the comment to modify.
      id: string
      /// The updated text of the comment.
      body: string
      /// The current version of the body content.
      bodyVersion: Option<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateTeamDiscussion
type UpdateTeamDiscussionInput =
    { /// The Node ID of the discussion to modify.
      id: string
      /// The updated title of the discussion.
      title: Option<string>
      /// The updated text of the discussion.
      body: Option<string>
      /// The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.
      bodyVersion: Option<string>
      /// If provided, sets the pinned state of the updated discussion.
      pinned: Option<bool>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Autogenerated input type of UpdateTopics
type UpdateTopicsInput =
    { /// The Node ID of the repository.
      repositoryId: string
      /// An array of topic names.
      topicNames: list<string>
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// Ordering options for user status connections.
type UserStatusOrder =
    { /// The field to order user statuses by.
      field: UserStatusOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Ordering options for verifiable domain connections.
type VerifiableDomainOrder =
    { /// The field to order verifiable domains by.
      field: VerifiableDomainOrderField
      /// The ordering direction.
      direction: OrderDirection }

/// Autogenerated input type of VerifyVerifiableDomain
type VerifyVerifiableDomainInput =
    { /// The ID of the verifiable domain to verify.
      id: string
      /// A unique identifier for the client performing the mutation.
      clientMutationId: Option<string> }

/// The error returned by the GraphQL backend
type ErrorType = { message: string }
