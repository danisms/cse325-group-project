using System.Security.Claims;

namespace ddiscourse.Components.Layout;   //

/// <summary>Small helpers so the layout components don't repeat claim logic.</summary>
public static class UserDisplay
{
    public static string Name(ClaimsPrincipal user) => user.Identity?.Name ?? "";

    /// <summary>"daniel.opute@x.com" -> "DO", "daniel@x.com" -> "DA".</summary>
    public static string Initials(ClaimsPrincipal user)
    {
        var local = Name(user).Split('@')[0];
        var parts = local.Split(new[] { ' ', '.', '_', '-' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length >= 2) return $"{parts[0][0]}{parts[1][0]}".ToUpperInvariant();
        return local.Length >= 2 ? local[..2].ToUpperInvariant() : local.ToUpperInvariant();
    }

    public static string Role(ClaimsPrincipal user) =>
        user.IsInRole("Admin") ? "Admin" :
        user.IsInRole("Moderator") ? "Moderator" : "Contributor";
}
