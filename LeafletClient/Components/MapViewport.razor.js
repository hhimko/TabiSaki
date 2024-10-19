export function initialize(containerElement, apiKey, styleId) {
    const map = L.map(containerElement).setView([0, 0], 0);

    const layer = L.maptilerLayer({
        apiKey: apiKey,
        style: styleId
    }).addTo(map);

    return map;
}

export function setView(map, lat, lng, zoom) {
    map.setView([lat, lng], zoom);
}