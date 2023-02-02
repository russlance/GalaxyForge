import React, { Component } from 'react';
import { Box, Typography, Grid, Button } from "@mui/material";
import { Info } from "./Info";
import { MapComponent } from "./MapComponent";
import RelationalGraph from "./RelationalGraph";

export class Home extends Component {
    static displayName = Home.name;
    constructor(props) {
        super(props);
        this.state = {
            displayMap: true,
            displayGraph: false,
            displayText: "Galactic Map",
        };
        this.changeDisplay = this.changeDisplay.bind(this);
    }

    changeDisplay() {
        if (displayMap) {
            this.setState({
                displayMap: false,
                displayGraph: true,
                displayText: "Relational Graph",
            })
        }
        else {
            this.setState({
                displayMap: true,
                displayGraph: false,
                displayText: "Galactic Map",
            })
        }
    }

    render() {
        return (
            <Grid
                container
                spacing={2}
                justifyContent="center"
            >
                <Grid
                    item
                    xs={8}
                    sx=
                    {{
                        backgroundColor: "#212121",
                    }}
                >
                    <Box >
                        <MapComponent />
                    </Box>
                </Grid>
                <Grid item xs={4} alignItems="right">
                    <Info />
                    <RelationalGraph />
                </Grid>
            </Grid>
        );
    }
}