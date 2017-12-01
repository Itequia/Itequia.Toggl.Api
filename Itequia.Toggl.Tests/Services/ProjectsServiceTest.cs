using Itequia.Toggl.Api.Data.Models;
using Itequia.Toggl.Api.Data.Repositories.Interfaces;
using Itequia.Toggl.Api.Services;
using Itequia.Toggl.Api.Services.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itequia.Toggl.Tests.Services
{
    [TestFixture]
    public class ProjectsServiceTest
    {
        private MockProvider _mockProvider;
        private ProjectsService _projectsService;

        [OneTimeSetUp]
        public void Setup()
        {
            _mockProvider = new MockProvider();
            _projectsService = new ProjectsService(_mockProvider.ProjectsRepositoryMock.Object);
        }

        [Test]
        public void Get()
        {
            var projects = _projectsService.Get();
            Assert.IsTrue(projects.All(x => x.Status == Status.Active));
        }
    }
}
