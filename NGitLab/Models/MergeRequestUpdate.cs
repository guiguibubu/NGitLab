﻿using System.Text.Json.Serialization;

namespace NGitLab.Models
{
    public class MergeRequestUpdate
    {
        [JsonPropertyName("source_branch")]
        public string SourceBranch;

        [JsonPropertyName("target_branch")]
        public string TargetBranch;

        [JsonPropertyName("assignee_id")]
        public int? AssigneeId;

        [JsonPropertyName("assignee_ids")]
        public int[] AssigneeIds;

        [JsonPropertyName("reviewer_ids")]
        public int[] ReviewerIds;

        [JsonPropertyName("title")]
        public string Title;

        [JsonPropertyName("description")]
        public string Description;

        [JsonPropertyName("state_event")]
        public string NewState;

        [JsonPropertyName("labels")]
        public string Labels;

        [JsonPropertyName("milestone_id")]
        public int? MilestoneId;

        [JsonPropertyName("allow_collaboration")]
        public bool? AllowCollaboration;
    }

    public class MergeRequestUpdateState
    {
        [JsonPropertyName("state_event")]
        public string NewState;
    }

    // ReSharper disable InconsistentNaming
    public enum MergeRequestStateEvent
    {
        close,
        reopen,
        merge,
    }
}
