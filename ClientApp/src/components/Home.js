import React, { Component } from 'react';
import { Box, Typography, Grid } from "@mui/material";
import { Info } from "./Info";
import { MapComponent } from "./MapComponent";

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <Grid container spacing={2} justifyContent="center">
                <Grid item xs={8}>
                    <Box >
                        <MapComponent />
                    </Box>
                </Grid>
                <Grid item xs={4} alignItems="right">
                    <Info />
                </Grid>
            </Grid>
        );
    }
}