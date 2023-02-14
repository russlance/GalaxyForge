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
    const [hexagons, setHexagons] = useState(generateGrid(1));
    const [hexSize, setHexSize] = useState(12);

    const generateMap = (gridSize) => {
        var temp;
        switch (gridSize) {
            case 1:
                temp = 12;
                break;
            case 2:
                temp = 10;
                break;
            case 3:
                temp = 7;
                break;
            case 4:
                temp = 5.5;
                break;
            case 5:
                temp = 4.5;
                break;
            case 6:
                temp = 4;
                break;
            case 7:
                temp = 3.4;
                break;
            case 8:
                temp = 3;
                break;
            case 9:
                temp = 2.7;
                break;
            default:
                temp = 5;
                break;
        }

        setHexSize(temp);
        setHexagons(generateGrid(gridSize));
    }

    const handleSelection = (item) => {
        generateMap(7);
        console.log("clicked: " + item.info.sectorName);
    }

    useEffect(() => {
        generateMap(1);
    }, [])

    return (
        <>
            <Typography>Map</Typography>
            <HexGrid>
                <Layout
                    flat={true}
                    spacing={1.1}
                    origin={{ x: 0, y: 0 }}
                    size={{ x: hexSize, y: hexSize }}
                >
                    {
                        hexagons.map((hex, i) => (
                            <Hexagon
                                key={i}
                                q={hex.sectorAddress.q}
                                r={hex.sectorAddress.r}
                                s={hex.sectorAddress.s}
                                onClick={() => {
                                    handleSelection(hex)
                                }}
                            >
                                <Text>
                                    {hex.info.sectorName}
                                </Text>
                            </Hexagon>
                        ))
                    }
                </Layout>
            </HexGrid>
        </>
    );
}