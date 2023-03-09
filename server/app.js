/*
 from https://www.youtube.com/playlist?list=PL4cUxeGkcC9iK6Qhn-QLcXCXPQUov1U7f
 */

const express = require('express');
const graphqlHTTP = require('express-graphql').graphqlHTTP;
const schema = require('./schema/schema');
const mongoose = require('mongoose');

const app = express();

//  connect to db
mongoose.connect("mongodb+srv://russlance91:UORPQRI0NWb1xhwo@cluster0.drxkg2p.mongodb.net/?retryWrites=true&w=majority");
mongoose.connection.once('open', () => {
    console.log("connected to database");
})

// middleware
//  must pass schema here as well
app.use('/graphql', graphqlHTTP({
    schema,
    graphiql: true
}));

app.listen(4000, () => {
    console.log('now listening on port 4000');
})