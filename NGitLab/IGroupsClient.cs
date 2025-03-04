﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NGitLab.Models;

namespace NGitLab
{
    public interface IGroupsClient
    {
        /// <summary>
        /// Get a list of projects accessible by the authenticated user.
        /// </summary>
        IEnumerable<Group> Accessible { get; }

        IEnumerable<Group> Search(string search);

        GitLabCollectionResponse<Group> SearchAsync(string search);

        /// <summary>
        /// Get a list of GitLab groups.
        /// </summary>
        IEnumerable<Group> Get(GroupQuery query);

        GitLabCollectionResponse<Group> GetAsync(GroupQuery query);

        Group this[int id] { get; }

        /// <summary>
        /// Returns the project with the provided full path in the form Namespace/Name.
        /// </summary>
        /// <remarks>https://github.com/gitlabhq/gitlabhq/blob/master/doc/api/groups.md#details-of-a-group</remarks>
        Group this[string fullPath] { get; }

        Task<Group> GetByIdAsync(int id, CancellationToken cancellationToken = default);

        Task<Group> GetByFullPathAsync(string fullPath, CancellationToken cancellationToken = default);

        GitLabCollectionResponse<Group> GetSubgroupsByIdAsync(int id, SubgroupQuery query = null);

        GitLabCollectionResponse<Group> GetSubgroupsByFullPathAsync(string fullPath, SubgroupQuery query = null);

        Group Create(GroupCreate group);

        Task<Group> CreateAsync(GroupCreate group, CancellationToken cancellationToken = default);

        [Obsolete("Use GetProjectsAsync instead")]
        IEnumerable<Project> SearchProjects(int groupId, string search);

        GitLabCollectionResponse<Project> GetProjectsAsync(int groupId, GroupProjectsQuery query);

        void Delete(int id);

        Task DeleteAsync(int id, CancellationToken cancellationToken = default);

        Group Update(int id, GroupUpdate groupUpdate);

        Task<Group> UpdateAsync(int id, GroupUpdate groupUpdate, CancellationToken cancellationToken = default);

        void Restore(int id);
    }
}
