import { useNavigate } from "react-router-dom";
import { createWorkOrder } from "../../managers/workOrderManager";
import PageContainer from "../PageContainer";
import { Button, ButtonToolbar, Card, CardBody, Form, FormGroup, Input, Label } from "reactstrap";

export default function WorkOrderCreate() {
    
    const navigate = useNavigate();

    const handleSubmit = (e) => {
        e.preventDefault();

        const workOrder = {
            description: description,
            vehiclesId: vehiclesId
        };

        createWorkOrder(workOrder).then(() => navigate("/workorders"));
    }

    return (
        <PageContainer>
            <h4>Create A Work Order</h4>
            <Card>
                <CardBody>
                    
                </CardBody>
            </Card>
        </PageContainer>
    )

} 