import { endpoints, servicesBaseUrl } from "../constants/service/ApiConstants";
import { HttpClient } from "./base/HttpClient";
import headers from "../constants/service/header.json";

export const GetLocations = async (data: any): Promise<any> => {
    const url = `${servicesBaseUrl + endpoints.GETLOCATION}`;
    const config = headers.content_type.application_json;
    return HttpClient.post<any>(url, data, config);
};
