import React, { Component } from "react";
import { HexGrid, Layout, Hexagon, Text, Path, Hex } from 'react-hexgrid';
import { Box, Typography } from "@mui/material";

export class MapComponent extends Component {
    static displayName = MapComponent.name;

    render() {
        return (
            <Box>
                <Typography>Map</Typography>
                <HexGrid >
                    {/* Grid with manually inserted hexagons */}
                    <Layout size={{ x: 10, y: 10 }} flat={true} spacing={1.1} origin={{ x: 0, y: 0 }}>
                        <Hexagon q={0} r={0} s={0} />
                        {/* Using pattern (defined below) to fill the hexagon */}
                        <Hexagon q={0} r={-1} s={1} fill="pat-1" />
                        <Hexagon q={0} r={1} s={-1} />
                        <Hexagon q={1} r={-1} s={0}>
                        </Hexagon>
                        <Hexagon q={1} r={0} s={-1}>
                        </Hexagon>
                        {/* Pattern and text */}
                        <Hexagon q={-1} r={1} s={0} fill="pat-2">
                        </Hexagon>
                        <Hexagon q={-1} r={0} s={1} />
                        <Hexagon q={-2} r={0} s={1} />
                        <Path start={new Hex(0, 0, 0)} end={new Hex(-2, 0, 1)} />
                    </Layout>
                </HexGrid>
            </Box>
        );
    }
}