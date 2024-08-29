const _apiUrl = "/api/vehicle"

export const getAllVehiclesWithUsers = () => {
    return fetch(_apiUrl + "/withusers").then((res) => res.json())
}

export const createVehicle = (vehicle) => {
    return fetch(`${_apiUrl}/create`, {
        method: "POST",
        headers: {
            'Content-Type' : 'application/json'
        },
        body: JSON.stringify(vehicle)
    });
}