﻿using LeafletClient.Components;
using LeafletClient.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using TabiSaki.Application.Services;
using TabiSaki.Domain.Models;
using TabiSaki.Services.Interfaces.Web;

namespace TabiSaki.WebApp.Components.Pages;

public partial class Home : ComponentBase, IDisposable
{
    [Inject]
    private IOptions<AppSettings> Settings { get; init; } = default!;

    [Inject]
    private ILocationService LocationService { get; init; } = default!;

    [Inject]
    private IGeolocationService Geolocation { get; init; } = default!;

    private MapViewport? MapViewport { get; set; }

    private string MapTilerApiKey => Settings.Value.MapTilerApiKey;

    private IEnumerable<Location>? _locations;


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (MapViewport is not null)
            {
                MapViewport.OnMapInitializedAsync += OnMapInitializedAsync;
            }

            _locations = await LocationService.GetAll();
            StateHasChanged();
        }
    }

    private async Task OnMapInitializedAsync()
    {
        if (_locations is not null)
        {
            foreach (var location in _locations)
            {
                var marker = new Marker(location.Id, new LatLng(location.Latitude, location.Longitude), cssClassName: "test-marker");
                await MapViewport!.SetMarkerAsync(marker);
            }
        }

        var deviceLatLng = new LatLng(35.8, 139.6);
        if (await Geolocation.IsSupported())
        {
            var result = await Geolocation.GetDeviceLocation();
            if (result.IsSuccess)
            {
                deviceLatLng = new LatLng(result.Latitude, result.Longitude);

                var marker = new Marker(-1, deviceLatLng, cssClassName: "test-marker");
                await MapViewport!.SetMarkerAsync(marker);
            }
        }

        await MapViewport!.SetViewAsync(deviceLatLng, 9);
    }

    private async Task OnMarkerClicked(Location location)
    {
        if (MapViewport is not null)
        {
            var latLng = new LatLng(location.Latitude, location.Longitude);
            await MapViewport.SetViewAsync(latLng, 13);
        }
    }

    public void Dispose()
    {
        if (MapViewport is not null)
        {
            MapViewport.OnMapInitializedAsync -= OnMapInitializedAsync;
        }
    }
}
