namespace Tasks;
public static class TruncateString
{
  public static string Solution(string message, int K)
  {
    if (message.Length <= K)
    {
      return message;
    }
    string[] words = message.Split(" ");
    string truncatedMessage = "";
    foreach (string word in words)
    {
      int addingWordLength = truncatedMessage.Length + word.Length + 4;
      if (addingWordLength > K)
      {
        break;
      }
      if (addingWordLength <= K)
      {
        truncatedMessage += word + " ";
      }
    }
    return truncatedMessage + "...";
  }
  public static string Solution1(string message, int K)
  {
    if (message.Length <= K)
    {
      return message;
    }
    int firstSpace = message.IndexOf(" ");
    if (firstSpace > K - 4 || firstSpace == -1)
    {
      return "...";
    }
    string truncatedMessage = message.Substring(0, K);
    int lastSpaceIndex = truncatedMessage.LastIndexOf(" ");
    if (lastSpaceIndex > 0)
    {
      truncatedMessage = truncatedMessage.Substring(0, lastSpaceIndex);
    }
    if (lastSpaceIndex > K - 4)
    {
      truncatedMessage = truncatedMessage.Substring(0, K - 4);
      lastSpaceIndex = truncatedMessage.LastIndexOf(" ");
      if (lastSpaceIndex > 0)
      {
        truncatedMessage = truncatedMessage.Substring(0, lastSpaceIndex);
      }
    }
    return truncatedMessage + " ...";
  }
}
