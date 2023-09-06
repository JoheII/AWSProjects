using ChristmasGiftSelector.Models;
using ChristmasGiftSelector.Repos;

namespace ChristmasGiftSelector.Helpers;

public class ChristmasGiftHelper : IChristmasGiftHelper
{
    private readonly IChristmasDB _christmasDB;
    
    public ChristmasGiftHelper(IChristmasDB christmasDB)
    {
        _christmasDB = christmasDB;
    }
    public Task<Recipient> GetGiftPerson()
    {
        var recipient = new Recipient
        {
            Name = "Name",
            Email = "Email"
        };

        return Task.FromResult(recipient);
    }

    public async Task AddUser(User user)
    {
        await _christmasDB.AddUser(user);
    }

    public Task DeleteUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task EditUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task CreateNewGiftGroup(GiftGroup giftGroup)
    {
        throw new NotImplementedException();
    }
}