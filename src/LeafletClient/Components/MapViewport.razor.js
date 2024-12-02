export function createContext(options) {
    const ctx = {
        map: null,
        markers: { },
        options: options
    }

    return ctx;
}

export function initialize(ctx, containerElement, apiKey, styleId) {
    const initialized = ctx.map !== null;
    if (!initialized) {
        ctx.map = L.map(containerElement).setView([0, 0], 0);

        L.maptilerLayer({
            apiKey: apiKey,
            style: styleId
        }).addTo(ctx.map);

        function throttle(f, delay) {
            var timer = 0;
            return function (...args) {
                clearTimeout(timer);
                timer = setTimeout(() => f.apply(this, args), delay);
            }
        }

        const resizeObserver = new window.ResizeObserver(throttle(() => {
            ctx.map.invalidateSize();
        }, 50));
        resizeObserver.observe(containerElement);
    }
}

export function setView(ctx, latLng, zoom) {
    ctx.map.setView(latLng, zoom);
}

export function setMarker(ctx, marker) {
    removeMarker(ctx, marker);

    const icon = L.divIcon({ className: marker.class });
    const markerLayer = L.marker(marker.latLng, { icon: icon }).addTo(ctx.map);
    markerLayer.on("click", () => { window.alert(marker.id) });

    ctx.markers[marker.id] = markerLayer;
}

export function removeMarker(ctx, marker) {
    const id = marker.id;
    if (id in ctx.markers) {
        const markerLayer = ctx.markers[id];
        ctx.map.removeLayer(markerLayer);

        delete ctx.markers[id];
    }
}
