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

const TitleEnums = {
    1: "Galactic Sector",
    2: "Galactic Zone",
    3: "Region",
    4: "Sector",
    5: "Solar System",
};

export default function MapComponent() {
    const [galaxySize, setGalaxySize] = useState(7);
    const [displayMap, setDisplayMap] = useState(generateGrid(0));
    const [hexSize, setHexSize] = useState(12);
    const [currentHexTitle, setCurrentHexTitle] = useState(TitleEnums[1]);
    const [prevHexTitle, setPrevHexTitle] = useState("");
    const [currentHex, setCurrentHex] = useState(1);
    const [prevHex, setPrevHex] = useState(0);
    const [nextHex, setNextHex] = useState(2);

    const generateMap = (gridSize) => {
        var temp;
        switch (gridSize) {
            case 0:
                temp = 50;
                break;
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
                temp = 3.2;
                break;
            case 8:
                temp = 2.8;
                break;
            case 9:
                temp = 2.5;
                break;
            default:
                temp = 5;
                break;
        }

        setHexSize(temp);
        setDisplayMap(generateGrid(gridSize));
    }

    const handleSelection = (item, mSize) => {
        switch (mSize) {
            case 1:
                setPrevHex(0);
                setCurrentHex(1);
                setNextHex(2);
                setCurrentHexTitle(TitleEnums[1]);
                setPrevHexTitle("");
                generateMap(1);
                break;
            case 2:
                setPrevHex(1);
                setCurrentHex(2);
                setNextHex(3);
                setCurrentHexTitle(TitleEnums[2]);
                setPrevHexTitle(TitleEnums[1]);
                generateMap(galaxySize);
                break;
            case 3:
                setPrevHex(2);
                setCurrentHex(3);
                setNextHex(4);
                setCurrentHexTitle(TitleEnums[3]);
                setPrevHexTitle(TitleEnums[2]);
                generateMap(galaxySize);
                break;
            case 4:
                setPrevHex(3);
                setCurrentHex(4);
                setNextHex(5);
                setCurrentHexTitle(TitleEnums[4]);
                setPrevHexTitle(TitleEnums[3]);
                generateMap(galaxySize);
                break;
            case 5:
                setPrevHex(4);
                setCurrentHex(5);
                setNextHex(0);
                setCurrentHexTitle(TitleEnums[5]);
                setPrevHexTitle(TitleEnums[4]);
                generateMap(0);
                break;
            default: break;
        };
        if (item != null) {
            console.log("clicked: " + item.info.sectorName);
        };
    };

    useEffect(() => {
        generateMap(1);
    }, [])

    return (
        <>
            <Box>
                <Typography>Current View: {currentHexTitle}</Typography>
                <Button onClick={() => {
                    handleSelection(null, prevHex);
                }}
                >
                    {prevHexTitle}
                </Button>
            </Box>

            <HexGrid>
                <Layout
                    flat={true}
                    spacing={1.1}
                    origin={{ x: 0, y: 0 }}
                    size={{ x: hexSize, y: hexSize }}
                >
                    {
                        displayMap.map((hex, i) => (
                            <Hexagon
                                key={i}
                                q={hex.sectorAddress.q}
                                r={hex.sectorAddress.r}
                                s={hex.sectorAddress.s}
                                onClick={() => {
                                    handleSelection(hex, nextHex);
                                }}
                            >
                                <Text>
                                    {currentHexTitle}
                                </Text>
                            </Hexagon>
                        ))
                    }
                </Layout>
            </HexGrid>
        </>
    );
}