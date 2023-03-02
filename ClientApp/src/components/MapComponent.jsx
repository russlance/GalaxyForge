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
    const [mapData, setMapData] = useState([]);
    const [hexSize, setHexSize] = useState(12);
    const [currentHexTitle, setCurrentHexTitle] = useState(TitleEnums[1]);
    const [prevHexTitle, setPrevHexTitle] = useState("");
    const [currentHex, setCurrentHex] = useState(1);
    const [prevHex, setPrevHex] = useState(0);
    const [nextHex, setNextHex] = useState(2);
    const [hexTextSize, setHexTextSize] = useState("0.1em")
    const [isLoading, setIsLoading] = useState(false);

    const getData = async () => {
        console.log("fetching");
        await fetch("api/GalacticSector/GetAllGalacticSectors")
            .then(response => {
                console.log("response: ");
                console.log(response.json());
                response.json();
            })
            .then((data) => {
                console.log("mapping: " + data);
                setIsLoading(true);
                setMapData(data);
            })
            .then(Promise.resolve(1))
            .catch(error => {
                console.error("error fetching data: " + error.message);
                setIsLoading(false);
            })
            .finally(setIsLoading(false));
    }

    const generateMap = async (gridSize) => {
        await getData();
        var temp;
        switch (gridSize) {
            case 0:
                temp = 50;
                setHexTextSize("0.5em");
                break;
            case 1:
                temp = 15;
                setHexTextSize("0.1em")
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
                temp = 3.5;
                setHexTextSize("0.05em");
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
        joinMapToData();
    }

    const joinMapToData = () => {
        console.log("mapping to grid");
        console.log("mapData: " + mapData.length);
        mapData.map((hex, i) => {
            console.log("inside: " + hex.q);
            if (hex.Q === null) {
                hex.Q = displayMap[i].q;
                hex.R = displayMap[i].r;
                hex.S = displayMap[i].s;
                displayMap[i].name = hex.Name;
            }
        })
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
            console.log("clicked: " + item.name);
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
                                q={hex.q}
                                r={hex.r}
                                s={hex.s}
                                onClick={() => {
                                    handleSelection(hex, nextHex);
                                }}
                            >
                                <Text fontSize={hexTextSize}>
                                    {hex.name}
                                </Text>
                            </Hexagon>
                        ))
                    }
                </Layout>
            </HexGrid>
        </>
    );
}