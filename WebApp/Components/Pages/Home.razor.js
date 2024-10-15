export function initializeMap(apiKey) {
    const map = L.map("leaflet-viewport").setView([0, 0], 4);
    const layer = L.maptilerLayer({
        apiKey: apiKey,
        style: "66e6da85-1e0d-40c5-a498-f5f9ff323a5a"
    }).addTo(map);
}
