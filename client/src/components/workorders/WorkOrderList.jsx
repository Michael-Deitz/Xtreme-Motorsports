import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { Badge, Button, Card, CardBody, CardTitle, Input, ListGroup, ListGroupItem } from "reactstrap";
import { getWorkOrders } from "../../managers/workOrderManager";
import PageContainer from "../PageContainer";

export default function WorkOrderList({ loggedInUser }) {
    const [workOrders, setWorkOrders] = useState([])

    const navigate = useNavigate()

    useEffect(() => {
        getWorkOrders().then(setWorkOrders)
    }, [])

    return( 
        <PageContainer>
            <div>
                <h1>Work Orders</h1>
            </div>
            <div>
                {workOrders.map((wo) => (
                   <Card key={wo.id}>
                    <CardBody>
                        <CardTitle></CardTitle>
                    </CardBody>
                   </Card> 
                ))}
            </div>
        </PageContainer>
    )
}