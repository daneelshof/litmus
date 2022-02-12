using System.Collections.Generic;
using Litmus.Core.ProjectAggregate;

namespace Litmus.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
