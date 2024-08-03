import { useNavigate } from "react-router-dom";
import { createWorkOrder } from "../../managers/workOrderManager";
import PageContainer from "../PageContainer";
import { Button, Card, CardBody, Dropdown, DropdownItem, DropdownMenu, DropdownToggle, Form, FormGroup, Input, Label } from "reactstrap";
import { useEffect, useState } from "react";
import { getAllVehiclesWithUsers } from "../../managers/vehicleManager";

export default function WorkOrderCreate() {
    const [vehicles, setVehicles] = useState([]);
    const [dropdownOpen, setDropdownOpen] = useState(false);
    const [selectedVehicle, setSelectedVehicle] = useState(null);
    const [description, setDescription] = useState("");

    const navigate = useNavigate();
    const toggleDropdown = () => setDropdownOpen(!dropdownOpen);

    useEffect(() => {
        getAllVehiclesWithUsers().then(setVehicles);
    }, []);

    const handleVehicleSelect = (vehicle) => {
        setSelectedVehicle(vehicle);
        setDropdownOpen(false);
    };

    const handleSubmit = (e) => {
        e.preventDefault();

        if (!selectedVehicle) {
            alert("Please select a vehicle");
            return;
        }

        const workOrder = {
            description: description,
            vehiclesId: selectedVehicle.id
        };

        createWorkOrder(workOrder).then(() => navigate("/workorder"));
    };

    return (
        <PageContainer>
            <h4>Create A Work Order</h4>
            <Card>
                <CardBody>
                    <Form onSubmit={handleSubmit}>
                        <FormGroup>
                            <Label for="description">Description</Label>
                            <Input
                                type="text"
                                name="description"
                                id="description"
                                value={description}
                                onChange={(e) => setDescription(e.target.value)}
                                required
                            />
                        </FormGroup>
                        <FormGroup>
                            <Label for="vehicle">Vehicle</Label>
                            <Dropdown isOpen={dropdownOpen} toggle={toggleDropdown}>
                                <DropdownToggle caret>
                                    {selectedVehicle ? `${selectedVehicle.brand.make} ${selectedVehicle.size.cubicCentimeters}cc` : "Select a Vehicle"}
                                </DropdownToggle>
                                <DropdownMenu>
                                    <DropdownItem header>Select a Vehicle</DropdownItem>
                                    <DropdownItem divider />
                                    {vehicles.map((vehicle) => (
                                        <DropdownItem
                                            key={vehicle.id}
                                            onClick={() => handleVehicleSelect(vehicle)}
                                        >
                                            {`${vehicle.brand.make} ${vehicle.size.cubicCentimeters}cc`}
                                        </DropdownItem>
                                    ))}
                                </DropdownMenu>
                            </Dropdown>
                        </FormGroup>
                        <Button type="submit" color="success">Create WorkOrder</Button>
                    </Form>
                </CardBody>
            </Card>
        </PageContainer>
    );
}
