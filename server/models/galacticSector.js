const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const galacticRegionSchema = new Schema({
    name: String,
    q: String,
    r: String,
    s: String,
});

module.exports = mongoose.model('GalacticRegion', galacticRegionSchema);