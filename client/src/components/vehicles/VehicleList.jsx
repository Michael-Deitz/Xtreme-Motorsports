import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { getAllVehiclesWithUsers } from "../../managers/vehicleManager";
import PageContainer from "../PageContainer";
import { Badge, Button, Card, CardBody, CardTitle, ListGroup, ListGroupItem } from "reactstrap";
import DefaultImage from "../../resources/DefaultImage.jpg";

export default function VehicleList() {
    const [vehicles, setVehicles] = useState([])

    const navigate = useNavigate();

    useEffect(() => {
        getAllVehiclesWithUsers().then(setVehicles)
    }, [])

    return (
        <PageContainer>
            <div>
            <Badge color="black"><h1 style={{ color: "white", textShadow: "1.6px 1.6px 0 red, -1.6px -1.6px 0 red, 1.6px -1.6px 0 red, -1.6px 1.6px 0 red" }}>Vehicles in Shop</h1></Badge>
            </div>
            {vehicles.map((v) => (
                <Card style={{ width: '25rem'}}>
                    <CardBody>
                        <CardTitle className="d-flex justify-content-center">
                                {v.brand.make} {v.size.cubicCentimeters}cc
                        </CardTitle>
                        <div className="d-flex justify-content-center">
                            <img
                                src={v.imageUrl ? v.imageUrl : DefaultImage} 
                                alt={v.brand.make}
                                style={{ width: '50%', height: 'auto'}} 
                                onError={(e) => { e.target.onerror = null; e.target.src = DefaultImage; }}
                            />
                        </div>
                        <div className="row">
                            <div className="col">
                                <ListGroup>
                                    <ListGroupItem>
                                        <Badge>Height :</Badge> 
                                    </ListGroupItem>
                                    <ListGroupItem>
                                        <Badge>Width :</Badge> 
                                    </ListGroupItem>
                                </ListGroup>
                            </div>
                            <div className="col">
                                <ListGroup>
                                    <ListGroupItem>
                                    <Badge>Description :</Badge> 
                                    </ListGroupItem>
                                        <Button className="m-5" style={{width: "5rem"}} color="primary" onClick={() => navigate(`/vehicle/${v.id}`)}>Edit</Button> 
                                </ListGroup>
                            </div>
                        </div>
                    </CardBody>
                </Card>
            ))}
        </PageContainer>
    )
}