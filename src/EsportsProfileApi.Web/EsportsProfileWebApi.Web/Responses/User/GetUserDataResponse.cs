﻿using System.Security.Claims;

namespace EsportsProfileWebApi.Web.Responses.User;

public class GetUserDataResponse
{
    public string Token { get; set; } = string.Empty;

    public int Id { get; set; }

    public string? Name { get; set; }

    public List<Claim> claims { get; set; }
}
