const _apiUrl = "/api/vehicle"

export const getAllVehiclesWithUsers = () => {
    return fetch(_apiUrl + "/withusers").then((res) => res.json())
}