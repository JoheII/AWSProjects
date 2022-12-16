using ChristmasGiftSelector.Helpers;
using ChristmasGiftSelector.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChristmasGiftSelector.Controllers;

[ApiController]
[Route("[controller]")]
public class ChristmasGift : ControllerBase
{
    private readonly ILogger<ChristmasGift> _logger;
    private readonly ChristmasGiftHelper _christmasGiftHelper;

    public ChristmasGift(ILogger<ChristmasGift> logger, ChristmasGiftHelper christmasGiftHelper)
    {
        _logger = logger;
        _christmasGiftHelper = christmasGiftHelper;
    }


    [HttpGet("GetGiftPerson")]
    public Task<Recipient> GetGiftPerson()
    {
        return _christmasGiftHelper.GetGiftPerson();
    }
    
    [HttpPost("PostNameAndEpost")]
    public async Task PostNameAndEpost(User user)
    {
        await _christmasGiftHelper.PostNameAndEpost(user);
    }
    
    [HttpPost("CreateNewGiftGroup")]
    public async Task CreateNewGiftGroup(GiftGroup giftGroup)
    {
        await _christmasGiftHelper.CreateNewGiftGroup(giftGroup);
    }
}