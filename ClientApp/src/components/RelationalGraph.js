import React from "react";
import Graph from "react-vis-network-graph";
import { nodes, edges } from "./RelationalGraphBackend";
import { Box, Typography } from "@mui/material";

export default function RelationalGraph() {
    const graph = {
        nodes: nodes,
        edges: edges
    };

    const options = {
        improvedLayout: true,
        clusterThreshold: 20,
        layout: {
            hierarchical: false
        },
        edges: {
            color: "red"
        },
        height: "100%"
    };

    const events = {
        select: function (event) {
            var { nodes, edges } = event;
            console.log(edges);
            console.log(nodes);
        }
    };
    return (
        <Box>
            <Typography>Relational Graph</Typography>
            <Graph
                graph={graph}
                options={options}
                events={events}
            />
        </Box>

    );
}