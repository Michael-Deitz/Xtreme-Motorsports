const _apiUrl = "/api/workorder"

export const getWorkOrders = () => {
    return fetch(_apiUrl).then((res) => res.json());
}