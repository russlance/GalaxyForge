import React, { Component } from 'react';
import { Box, Typography, Grid, Button } from "@mui/material";
import { Info } from "./Info";
import { MapComponent } from "./MapComponent";
import RelationalGraph from "./RelationalGraph";

export class Home extends Component {
    static displayName = Home.name;
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <Box
                sx=
                {{
                    display: "flex",
                    flexDirection: "row",
                    backgroundColor: "#212121",
                    height: "90vh",
                    justifyContent: "center",
                    p: "3px",
                }}
            >
                <Box
                    sx={{
                        maxWidth: "60%",
                    }}
                >
                    <MapComponent />
                </Box>
                <Box
                    sx={{
                        maxWidth: "40%",
                    }}
                >
                    <Info
                        sx={{
                            height: "50vh",
                        }}
                    />
                    <RelationalGraph
                        sx={{
                            height: "40vh",
                        }}
                    />
                </Box>
            </Box>
        );
    }
}