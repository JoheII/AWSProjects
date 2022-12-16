using ChristmasGiftSelector.Models;

namespace ChristmasGiftSelector.Helpers;

public interface IChristmasGiftSelectorHelper
{
    public Task<Recipient> GetGiftPerson();
    public Task PostNameAndEpost(User user);
    public Task CreateNewGiftGroup(GiftGroup giftGroup);
}


public class ChristmasGiftHelper : IChristmasGiftSelectorHelper
{
    public async Task<Recipient> GetGiftPerson()
    {
        var recipient = new Recipient
        {
            Name = "Name",
            Email = "Email"
        };

        return recipient;
    }

    public Task PostNameAndEpost(User user)
    {
        throw new NotImplementedException();
    }

    public Task CreateNewGiftGroup(GiftGroup giftGroup)
    {
        throw new NotImplementedException();
    }
}