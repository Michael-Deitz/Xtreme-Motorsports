import { useState } from "react";
import { NavLink as RRNavLink } from "react-router-dom";
import {
  Button,
  Collapse,
  Nav,
  NavLink,
  NavItem,
  Navbar,
  NavbarBrand,
  NavbarToggler,
  Modal,
  ModalHeader,
  ModalBody,
  ModalFooter,
} from "reactstrap";
import { logout } from "../managers/authManager";
import DefaultUser from "../resources/DefaultUser.png";

export default function NavBar({ loggedInUser, setLoggedInUser }) {
  const [open, setOpen] = useState(false);
  const [modal, setModal] = useState(false);

  const toggleNavbar = () => setOpen(!open);
  const toggleModal = () => setModal(!modal);

  const handleLogout = () => {
    logout().then(() => {
      setLoggedInUser(null);
      setOpen(false);
      setModal(false);
    });
  };

  return (
    <div>
      <Navbar color="light" light fixed="true" expand="lg">
        <NavbarBrand className="mr-auto" tag={RRNavLink} to="/">
          Xtreme Motorsports
        </NavbarBrand>
        {loggedInUser ? (
          <>
            <NavbarToggler onClick={toggleNavbar} />
            <Collapse isOpen={open} navbar>
              <Nav navbar>
                <NavItem>
                  <NavLink tag={RRNavLink} to="forsale">
                    For Sale
                  </NavLink>
                </NavItem>
                <NavItem>
                  <NavLink tag={RRNavLink} to="items">
                    Items
                  </NavLink>
                </NavItem>
              </Nav>
            </Collapse>
            <img
              src={DefaultUser}
              alt="User Avatar"
              style={{ cursor: 'pointer', width: '40px', borderRadius: '50%' }}
              onClick={toggleModal}
            />
            <Modal isOpen={modal} toggle={toggleModal}>
              <ModalHeader toggle={toggleModal}>Logout</ModalHeader>
              <ModalBody>
                Are you sure you want to logout?
              </ModalBody>
              <ModalFooter>
                <Button color="secondary" onClick={toggleModal}>Cancel</Button>
                <Button color="primary" onClick={handleLogout}>Logout</Button>
              </ModalFooter>
            </Modal>
          </>
        ) : (
          <Nav navbar>
            <NavItem>
              <NavLink tag={RRNavLink} to="/login">
                <Button color="primary">Login</Button>
              </NavLink>
            </NavItem>
          </Nav>
        )}
      </Navbar>
    </div>
  );
}
