import { createServer } from "miragejs";

export const createServer = () => ({
    routes() {
        this.get("/api/files", () => [
            {
                id: 1,
                fileName: "FILENAME+22+CHARAS1",
                last_seen: "Wed Jan 25 2023 06:48:00",
                file_status: "NOT_ON_FS",
                signal_ids: [
                    "<base>.eqdw",
                    "<base>.eqdw",
                    "<base>.eqdw",
                    "<base>.eqdw",
                ],
                irod_ids: ["IROD1", "IROD2", "IROD3", "IROD4", "IROD5"],
            },

        ]);
    },
});