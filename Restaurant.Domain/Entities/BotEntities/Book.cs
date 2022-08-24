using System.ComponentModel.DataAnnotations;

namespace Restaurant.Domain.Entities.BotEntities;

public class Book
{
    [Key]
    public Guid Id { get; set; }
    public long UserChatId { get; set; }
    public DateTime BookedTime { get; set; }
    public int Total { get; set; }
    public int BookNumber { get; set; }
}