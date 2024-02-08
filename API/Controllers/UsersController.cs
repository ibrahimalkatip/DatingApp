using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
[Authorize]
public class UsersController : BaseApiController
{
    IUserRepository _userRepository;
    IMapper _mapper;
    public UsersController(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    [AllowAnonymous]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MemberDTOs>>> GetUsers()
    {
        var userToReturn = await _userRepository.GetMemberAsync();
        return Ok(userToReturn);
    }

    [HttpGet("{username}")]
    public async Task<ActionResult<MemberDTOs>> GetUser(string username)
    {
        return await _userRepository.GetMemberDTOs(username);
    }
}