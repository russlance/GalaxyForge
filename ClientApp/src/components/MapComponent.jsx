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

export default function MapComponent() {
    const [hexagons, setHexagons] = useState(generateGrid);

    const handleSelection = (item) => {
        console.log("clicked: " + item.q + " " + item.r + " " + item.s);
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
                    size={{ x: 3, y: 3 }}
                >
                    {
                        hexagons.map((hex, i) => (
                            <Hexagon
                                key={i}
                                q={hex.sectorAddress.q}
                                r={hex.sectorAddress.r}
                                s={hex.sectorAddress.s}
                                onClick={() => {
                                    handleSelection(hex.sectorAddress)
                                }}

                            >
                                <Text >
                                    {hex.sectorName}
                                    {/*{HexUtils.getID(hex.hex)}*/}
                                </Text>
                            </Hexagon>
                        ))
                    }
                </Layout>
            </HexGrid>
        </>
    );
}