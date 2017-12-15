using System;
using Moq;
using Itequia.Toggl.Api.Data.Repositories.Interfaces;
using Itequia.Toggl.Api.Data.Models;
using System.Linq;
using System.Collections.Generic;

namespace Itequia.Toggl.Tests
{
    public class MockProvider
    {
        public Mock<IBaseRepository<Project>> ProjectsRepositoryMock { get; set; }

        private List<Project> _projectsMock = new List<Project>() {
            new Project()
            {
                Id = 1,
                Name = "Active project 1",
                Status = Status.Active
            },
             new Project()
            {
                Id = 2,
                Name = "Active project 2",
                Status = Status.Active
            },
              new Project()
            {
                Id = 3,
                Name = "Inactive project 3",
                Status = Status.Inactive
            },
               new Project()
            {
                Id = 4,
                Name = "Inactive project 4",
                Status = Status.Inactive
            }
        };

        public MockProvider()
        {
            ProjectsRepositoryMock = new Mock<IBaseRepository<Project>>();
            ProjectsRepositoryMock.Setup(x => x.GetAll()).Returns(_projectsMock.AsQueryable());
        }
    }
}
