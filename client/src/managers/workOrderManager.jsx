const _apiUrl = "/api/workorder"

export const getWorkOrders = () => {
    return fetch(_apiUrl).then((res) => res.json());
}

export const createWorkOrder = (workOrder) => {
    return fetch(`${_apiUrl}/create`, {
        method: "POST",
        headers: {
            'Content-Type' : 'application.json'
        },
        body: JSON.stringify(workOrder)
    });
}