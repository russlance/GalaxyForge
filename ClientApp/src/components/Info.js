import React, { Component } from "react";
import { Box, Typography } from "@mui/material";

export class Info extends Component {
    static displayName = Info.name;

    render() {
        return (
            <Box >
                <Typography>Info goes here</Typography>
                <Typography>More info goes here</Typography>
            </Box>
        );
    }
}