import React, { Component, useState, useEffect } from 'react';
import { Box, Typography, Grid, Button } from "@mui/material";
import Info from "./Info";
import MapComponent from "./MapComponent";
import RelationalGraph from "./RelationalGraph";

export class Home extends Component {
    //export function Home() {
    static displayName = Home.name;
    constructor(props) {
        super(props);
    }
    //const[data, setData] = useState();

    /**    useEffect(() => {
            fetch("api/files")
                .then((response) => response.json())
                .then((json) => setData(json))
    }); */

    render() {
        return (
            <Box
                sx=
                {{
                    display: "flex",
                    flexDirection: "row",
                    backgroundColor: "#212121",
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
                            height: "50%",
                        }}
                    />
                    <RelationalGraph
                        sx={{
                            height: "40%",
                        }}
                    />
                </Box>
            </Box>
        );
    }
}