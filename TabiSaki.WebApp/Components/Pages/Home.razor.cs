﻿using LeafletClient.Components;
using LeafletClient.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using TabiSaki.Application.Services;

namespace TabiSaki.WebApp.Components.Pages;

public partial class Home : ComponentBase
{
    [Inject]
    private IOptions<AppSettings> Settings { get; init; } = default!;

    [Inject]
    private ILocationService LocationService { get; init; } = default!;

    private MapViewport MapViewport { get; set; } = default!;

    private string MapTilerApiKey => Settings.Value.MapTilerApiKey;


    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            MapViewport.OnMapInitializedAsync += OnMapInitializedAsync;
        }
    }

    private async Task OnMapInitializedAsync()
    {
        var latLng = new LatLng(35.8, 139.6);
        await MapViewport.SetViewAsync(latLng, 9);

        var locations = await LocationService.GetAll();
        foreach (var location in locations)
        {
            var marker = new Marker(location.Id, new LatLng(location.Latitude, location.Longitude), cssClassName: "test-marker");
            await MapViewport.SetMarkerAsync(marker);
        }
    }
}
