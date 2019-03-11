using Moq;
using System.Collections.Generic;
using System.Linq;
using UruIT.Game.Bll.Dao.users;
using UruIT.Game.Model;
using UruIT.Game.Service.Layers.Users;
using Xunit;

namespace UruIT.Game.Test
{
    public class ServiceUnitTest
    {
        private readonly Mock<IUsersBll> _userBllMock;
        private IUserService Bll => new UserService(_userBllMock.Object);

        private new List<User> internalModels = new List<User>()
            {
                new User()
                {
                    Id=0,
                    Name="Player 1"
                }
            };

        private new User userAdd = new User()
        {
            Name = "Testing",
            Id = 1
        };
        public ServiceUnitTest()
        {
            _userBllMock = new Mock<IUsersBll>();
        }

        private void SetupGet()
        {
            _userBllMock.Setup(a => a.Get()).Returns(internalModels.AsQueryable());
        }
        private void SetupCreate()
        {
            _userBllMock.Setup(a => a.Add(It.IsAny<User>())).Returns(userAdd);
        }

        [Fact]
        [Trait("Service", "User")]
        public void Get_Successful()
        {
            //Assemble
            SetupGet();

            //Action
            var actual = Bll.Get();

            //Assert
            Assert.Equal(internalModels.AsQueryable(), actual);
        }

        [Fact]
        [Trait("Service", "User")]
        public void Post_Successful()
        {
            //Assemble
            SetupCreate();
            var user = new User()
            {
                Name = "Testing"
            };
         

            //Action
            var result = Bll.Add(user);

            //Assert
            Assert.Equal(userAdd, result);
        }
    }
}
