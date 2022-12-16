using ChristmasGiftSelector.Models;

namespace ChristmasGiftSelector.Helpers;

public class ChristmasGiftHelper : IChristmasGiftHelper
{
    public Task<Recipient> GetGiftPerson()
    {
        var recipient = new Recipient
        {
            Name = "Name",
            Email = "Email"
        };

        return Task.FromResult(recipient);
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