using ChristmasGiftSelector.Helpers;
using ChristmasGiftSelector.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChristmasGiftSelector.Controllers;

[ApiController]
[Route("[controller]")]
public class ChristmasGift : ControllerBase
{
    private readonly ILogger<ChristmasGift> _logger;
    private readonly IChristmasGiftHelper _christmasGiftHelper;

    public ChristmasGift(ILogger<ChristmasGift> logger, IChristmasGiftHelper christmasGiftHelper)
    {
        _logger = logger;
        _christmasGiftHelper = christmasGiftHelper;
    }

    [HttpGet("GetGiftPerson")]
    public Task<Recipient> GetGiftPerson()
    {
        return _christmasGiftHelper.GetGiftPerson();
    }
    
    [HttpPost("AddUser")]
    public async Task AddUser(User user)
    {
        await _christmasGiftHelper.AddUser(user);
    }
    
    [HttpPost("DeleteUser")]
    public async Task DeleteUser(User user)
    {
        await _christmasGiftHelper.DeleteUser(user);
    }    
    
    [HttpPost("EditUser")]
    public async Task EditUser(User user)
    {
        await _christmasGiftHelper.EditUser(user);
    }

    [HttpPost("CreateNewGiftGroup")]
    public async Task CreateNewGiftGroup(GiftGroup giftGroup)
    {
        await _christmasGiftHelper.CreateNewGiftGroup(giftGroup);
    }
}