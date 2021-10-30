using Application.Repos;
using Application.UnitOfWork;
using Dоmain.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Behaviour.User.Command.AddUser
{
    /*public class AddUserCommandHandler : IRequestHandler<AddUserCommand>
     {
         private readonly IUnitOfWork _commit_repos;
         private readonly IUserRepos<UserDTO> _repos;
         public AddUserCommandHandler(IUserRepos<UserDTO> repos, IUnitOfWork commit_repos)
         {
             _repos = repos;
             _commit_repos = commit_repos;
         }

         public async Task<Unit> Handle(AddUserCommand request, CancellationToken cancellationToken)
         {
             await _repos.AddUser(request.User);
             await _commit_repos.Commit();

             //return );
         }*/
}
    

