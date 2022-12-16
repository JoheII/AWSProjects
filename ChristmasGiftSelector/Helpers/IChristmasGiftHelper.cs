using ChristmasGiftSelector.Models;

namespace ChristmasGiftSelector.Helpers;

public interface IChristmasGiftHelper
{
    public Task<Recipient> GetGiftPerson();
    public Task AddUser(User user);
    public Task DeleteUser(User user);
    public Task EditUser(User user);
    public Task CreateNewGiftGroup(GiftGroup giftGroup);
}