export let servicesBaseUrl = "/";
if (!process.env.NODE_ENV || process.env.NODE_ENV === 'development') {
    servicesBaseUrl = "https://localhost:5001/";
}
const endpointList = require('./endpoints.json');
let environment = process.env.REACT_APP_ENVIRONMENT || 'development';
export const endpoints = endpointList[environment];