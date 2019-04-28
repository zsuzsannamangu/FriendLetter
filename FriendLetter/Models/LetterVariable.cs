namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;

    public string GetRecipient()
    {
      return _recipient;
    }

    // set a new private property to an existing object. We have a setter method for the _recipient property so we may change whose name it displays as necessary.
    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }
  }
}
