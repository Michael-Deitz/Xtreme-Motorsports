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
                        <CardTitle className="d-flex justify-content-center">{wo.vehicles.brand.make} {wo.vehicles.size.cubicCentimeters}cc</CardTitle>
                        <div className="d-flex justify-content-center">{wo.vehicles.typeOfVehicle.type}</div>
                        <ListGroup className="m-2">
                            <ListGroupItem>
                                <Badge>Work To Do :</Badge> {wo.description}
                            </ListGroupItem>
                        </ListGroup>
                    </CardBody>
                   </Card> 
                ))}
            </div>
        </PageContainer>
    )
}