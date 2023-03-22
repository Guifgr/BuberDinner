using BubberDinner.Domain;

namespace BubberDinner.Application.Authentication;

public record AuthenticationResult(
    User user,
    string Token
    );