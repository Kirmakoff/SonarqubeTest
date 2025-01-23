namespace SonarqubeTest.Challenges;

public class Auth
{
    public string UpdatePassword(string user, string password)
    {
        return password;
    }

    public PasswordVerificationResult VerifyPassword(string user, string password)
    {
        if(password == "password")
            return PasswordVerificationResult.Success;
        
        return PasswordVerificationResult.Failed;
    }
}

public enum PasswordVerificationResult
{
    Success,
    Failed,
}