import { useState } from "react";
import { useNavigate } from "react-router-dom";

export default function WorkOrderList({ loggedInUser }) {
    const [workOrders, setWorkOrders] = useState([])

    const navigate = useNavigate()


}