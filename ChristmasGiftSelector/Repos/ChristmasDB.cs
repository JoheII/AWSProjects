using ChristmasGiftSelector.Models;

namespace ChristmasGiftSelector.Repos;

public class ChristmasDB : IChristmasDB
{
    public Task<Recipient> GetGiftPerson()
    {
        throw new NotImplementedException();
    }

    public Task AddUser(User user)
    {
        throw new NotImplementedException();
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