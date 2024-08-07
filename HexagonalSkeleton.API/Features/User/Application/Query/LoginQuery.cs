﻿using HexagonalSkeleton.API.Features.User.Domain;
using MediatR;

namespace HexagonalSkeleton.API.Features.User.Application.Query
{
    /// <summary>
    /// This class represents a command for logging in a user.
    /// </summary>
    public class LoginQuery(string email, string password) : IRequest<IResult>
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; } = email;

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; } = password;

        /// <summary>
        /// Method to convert the DTO to a domain entity
        /// </summary>
        /// <returns></returns>
        public UserEntity ToDomainEntity()
        {
            return new UserEntity(Email/*, Password*/);
        }
    }
}
