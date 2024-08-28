import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { Badge, Button, ButtonGroup, Card, CardBody, CardTitle, ListGroup, ListGroupItem } from "reactstrap";
import { getWorkOrders } from "../../managers/workOrderManager";
import PageContainer from "../PageContainer";
import DefaultImage from "../../resources/DefaultImage.jpg";

export default function WorkOrderList({ loggedInUser }) {
    const [workOrders, setWorkOrders] = useState([]);

    const navigate = useNavigate();

    useEffect(() => {
        getWorkOrders().then(setWorkOrders);
    }, []);

    return (
        <PageContainer>
            <div>
            <Badge color="black"><h1 style={{ color: "white", textShadow: "1.6px 1.6px 0 red, -1.6px -1.6px 0 red, 1.6px -1.6px 0 red, -1.6px 1.6px 0 red" }}>Work Orders</h1></Badge>
            </div>
            <div>
                <ButtonGroup>
                    <Button color="success" onClick={() => navigate("create")}>Add WorkOrder</Button>
                </ButtonGroup>
            </div>
            <div>
                {workOrders.map((wo) => (
                    <Card key={wo.id} style={{ width: "20rem", marginBottom: '20px'}} className="shadow-sm">
                        <CardBody>
                            <CardTitle className="d-flex justify-content-center">
                                {wo.vehicles.brand.make} {wo.vehicles.size.cubicCentimeters}cc
                            </CardTitle>
                            <div className="d-flex justify-content-center">
                                <img 
                                    src={wo.vehicles.imageUrl ? wo.vehicles.imageUrl : DefaultImage} 
                                    alt={wo.vehicles.typeOfVehicle.type}
                                    style={{ width: '50%', height: 'auto' }} 
                                    onError={(e) => { e.target.onerror = null; e.target.src = DefaultImage; }}
                                />
                            </div>
                            <ListGroup className="m-2">
                                <ListGroupItem>
                                    <Badge>Work To Do :</Badge> {wo.description}
                                </ListGroupItem>
                            </ListGroup>
                            <div className="d-flex justify-content-center">
                            <Button color="primary" onClick={() => navigate("View")}>View WorkOrder</Button>
                            </div>
                        </CardBody>
                    </Card>
                ))}
            </div>
        </PageContainer>
    );
}

