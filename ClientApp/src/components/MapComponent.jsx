import React, { Component, useState, useEffect } from "react";
import {
    HexGrid,
    Layout,
    Hexagon,
    Text,
    Path,
    HexUtils
} from 'react-hexgrid';
import { Box, Typography, Button } from "@mui/material";
import { generateGrid } from "../backend/mapData";

export function MapComponent() {
    const [hexagons, setHexagons] = useState(generateGrid);

    const handleSelection = (item) => {
        console.log("clicked: " + item.sectorName);
    }

    return (
        <>
            <Typography>Map</Typography>
            <HexGrid viewBox="-50 -50 100 100"
            >
                <Layout
                    flat={true}
                    spacing={1.1}
                    origin={{ x: 0, y: 0 }}
                    size={{ x: 5.25, y: 5.25 }}
                >
                    {
                        hexagons.map((hex, i) => (
                            <Hexagon
                                key={i} q={hex.hex.q} r={hex.hex.r} s={hex.hex.s}
                                onClick={() => {
                                    handleSelection(hex.info)
                                }}

                            >
                                <Text>
                                    {HexUtils.getID(hex.hex)}
                                </Text>
                            </Hexagon>
                        ))
                    }
                </Layout>
            </HexGrid>
        </>
    );
}