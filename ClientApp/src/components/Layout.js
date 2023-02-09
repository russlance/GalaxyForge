import React, { Component } from 'react';
import { Container, Box, Typography, Grid, Button } from "@mui/material";
import { NavMenu } from './NavMenu';

export class Layout extends Component {
    static displayName = Layout.name;

    render() {
        return (
            <Box sx={{
                overflowy: "hidden",
                width: "100%",
            }}>
                <NavMenu />
                <Box>
                    {this.props.children}
                </Box>
            </Box>
        );
    }
}