using Application.Mappers;
using Application.Repos;
using Dоmain.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Behaviour.User.Query.GetUsers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IList<UsersResponseQuery>>
    {
        private readonly IUserRepos _repository;

        public GetUsersQueryHandler(IUserRepos repo)
        {
            _repository = repo;
        }

        public async Task<IList<UsersResponseQuery>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _repository.GetAllUsers();
            return users.Select(x => new UsersResponseQuery(UserMapper.MappingDTO(x))).ToArray();
        }
    }
}
