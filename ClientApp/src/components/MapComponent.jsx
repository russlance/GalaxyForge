import React, { Component } from "react";
import {
    HexGrid,
    Layout,
    Hexagon,
    Text,
    Path,
    Hex
} from 'react-hexgrid';
import { Box, Typography } from "@mui/material";
import { css, jsx } from "@emotion/react"

export class MapComponent extends Component {
    static displayName = MapComponent.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <Box>
                <Typography>Map</Typography>
                <HexGrid
                    style={{
                        border: `2px solid "#868e96}`,
                        background: "#212121",
                    }}
                >
                    {/* Grid with manually inserted hexagons */}
                    <Layout
                        flat={true}
                        spacing={1.1}
                        origin={{ x: 0, y: 0 }}
                    >
                        <Hexagon q={0} r={0} s={0} />
                        <Hexagon q={0} r={-1} s={1} />
                        <Hexagon q={0} r={1} s={-1} />
                        <Hexagon q={1} r={-1} s={0}>
                            <Text css={css`
                                font-size: 0.17em;
                                fill: white;
                                fill-opacity: 0.7;
                                transition: fill-opacity 0.5s;
                                &:hover {
                                  fill-opacity: 1;
                                }
                  `}>1, -1, 0</Text>
                        </Hexagon>
                        <Hexagon q={1} r={0} s={-1} />
                        <Hexagon q={-1} r={1} s={0} />
                        <Hexagon q={-1} r={0} s={1} />
                        <Hexagon q={-2} r={0} s={1} />
                    </Layout>
                </HexGrid>
            </Box>
        );
    }
}