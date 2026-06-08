namespace AuthDemo.DTOs;

public record RegisterRequest(string Username, string Password);
public record LoginRequest(string Username, string Password);

// token field added - returned after successful login/register
public record AuthResponse(int Id, string Username, DateTime CreatedAt, string Token);