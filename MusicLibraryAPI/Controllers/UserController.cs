using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryAPI.ApiModels.User;

namespace MusicLibraryAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserController(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetUserModel>>> GetAll()
    {
        var users = await _userService.GetAll();
        var result = users.Select(x => _mapper.Map<GetUserModel>(x)).ToList();
        return result;
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<GetByIdUserModel>> GetById(int id)
    {
        var user = await _userService.GetById(id);
        if (user is null) return NotFound();
        var result = _mapper.Map<GetByIdUserModel>(user);
        return result;
    }

    [HttpPost]
    public async Task<ActionResult<GetByIdUserModel>> Add(CreateUserModel userModel)
    {
        var user = _mapper.Map<User>(userModel);
        var newUser = await _userService.Add(user);
        var result = _mapper.Map<GetByIdUserModel>(newUser);
        return result;
    }

    [HttpPut]
    public async Task<ActionResult<GetByIdUserModel>> Update(UpdateUserModel updateUserModel)
    {
        var user = _mapper.Map<User>(updateUserModel);
        var updatedUserModel = await _userService.Update(user);
        if (updatedUserModel is null) return NotFound();
        var result = _mapper.Map<GetByIdUserModel>(user);
        return result;
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _userService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return NoContent();
    }
}