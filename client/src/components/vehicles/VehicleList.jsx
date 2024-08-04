import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { getAllVehiclesWithUsers } from "../../managers/vehicleManager";
import PageContainer from "../PageContainer";
import { Card, CardBody, CardTitle } from "reactstrap";
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
                <h1>Vehicles in Shop</h1>
            </div>
            {vehicles.map((v) => (
                <Card>
                    <CardBody>
                        <CardTitle className="d-flex justify-content-center">
                                {v.brand.make} {v.size.cubicCentimeters}cc
                        </CardTitle>
                        <div>
                            <img
                                src={v.imageUrl ? v.imageUrl : DefaultImage} 
                                alt={v.brand.make}
                                style={{ width: '50%', height: 'auto' }} 
                                onError={(e) => { e.target.onerror = null; e.target.src = DefaultImage; }}
                            />
                        </div>
                    </CardBody>
                </Card>
            ))}
        </PageContainer>
    )
}